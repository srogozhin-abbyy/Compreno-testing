using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

using IO.Swagger.Model;
using IO.Swagger.Api;

using APITesting;
using ComprenoHelper.Models;
using ComprenoTesting.ComprenoHelper.Models.Extractions;

namespace ComprenoTesting.APITesting
{
	[TestFixture]
	public class JobTest: TestBase
	{	
		private JobApi jobApi { get; }
		private DocumentApi documentApi { get; }


		public JobTest() : base(UserRole.Admin)
		{
			jobApi = new JobApi(Configuration);
			documentApi = new DocumentApi(Configuration);

		}

		[Test]
		public void Job_FindOne_Ok()
		{
			Job job = jobApi.JobFindOne("");
			Console.WriteLine(job.OrganizationId);
		}

		[Category("APIBasic")]
		[Test]
		public void Job_Post_Ok()
		{
			//var basePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
			var basePath = TestContext.CurrentContext.TestDirectory;
			Job job = Helper.PostDocument(Path.Combine(basePath, DocumentPaths.SLA_PDF), TestProjectId);
			Assert.IsNotNull(job);
		}

		[Test]
		[Category("APIBasic")]
		public void Jobs_GetByFilter_Ok()
		{
			int count = 10;
			string filter = $"{{\"skip\":0,\"limit\":{count},\"all\":false,\"include\":[],\"exclude\":[],\"docType\":\"All\",\"sort\":{{}},\"stage\":\"All\",\"levels\":[2,1],\"projectIds\":[\"{TestProjectId}\"]}}";
			JObject response = (JObject)jobApi.JobReport(filter);
			response.SelectToken("totalCount");

			List<Document> documents = response.SelectToken("documents").ToObject<List<Document>>();
			Assert.AreEqual(count, documents.Count, "Wrong number of documents");
		}

		[Test, TestCaseSource(nameof(PrepareJobFilters))]
		public void Jobs_GetByFilters_Ok(string filter)
		{
			JObject response = (JObject)jobApi.JobReport(filter);
		}

		private static IEnumerable<TestCaseData> PrepareJobFilters()
		{
			var limits = new List<int> {50, 1000};
			var sorts = new List<string>
			{
				"name",
				"doctype.displayName",
			};
			var sortOrders = new List<string>
			{
				"1",
				"-1"
			};
			var levels = new List<string>
			{
				"[1]",
				"[1,2]"
			};

			IEnumerable<Tuple<int, string, string, string, string, string>> filters = 
			from limit in limits
			from doctype in EntityNames.Doctypes
			from sort in sorts
			from sortOrder in sortOrders
			from stage in EntityNames.ProcessingStages
			from level in levels
			select Tuple.Create(limit, doctype, sort, sortOrder, stage, level);
			foreach (var filter in filters)
			{
				yield return new TestCaseData(getFilterString(filter));
			}
		}

		/// <summary>
		/// Get filter string for job request
		/// </summary>
		/// <param name="filter"></param>
		/// <returns></returns>
		public static string getFilterString(Tuple<int, string, string, string, string, string> filter)
		{
			int limit = filter.Item1;
			string doctype = filter.Item2;
			string sort = filter.Item3;
			string sortOrder = filter.Item4;
			string stage = filter.Item5;
			string level = filter.Item6;

			return
				$"{{\"skip\":0,\"limit\":{limit},\"all\":false,\"include\":[],\"exclude\":[],\"docType\":\"{doctype}\",\"sort\":{{\"{sort}\":{sortOrder}}},\"stage\":\"{stage}\",\"levels\":{level},\"projectIds\":null}}";
		}

		[Ignore("Not finished")]
		[Test]
		[Category("APIBasic")]
		public void Jobs_SaveEntry_Ok()
		{
			jobApi.JobSaveEntry();
		}

		[Ignore("Not finished")]
		[Test]
		[Category("APIBasic")]
		public void Jobs_PutStatus_Ok()
		{
			int limit = 1;
			string status = "Ready to Export";
			string stepName = "Validation";
			string stepType = "validation";

			string filter = $"{{\"skip\":0,\"limit\":{limit},\"all\":false,\"include\":[],\"exclude\":[],\"docType\":\"MSA_Standard_ST\",\"sort\":{{\"createdAt\":-1}},\"stage\":\"Ready to Validate\",\"levels\":[2,1],\"projectIds\":[\"{TestProjectId}\"]}}";
			List<Document> documents = ((JObject)jobApi.JobReport(filter)).SelectToken("documents").ToObject<List<Document>>();
			var document = documents[0];
			var jobId = document.Id.ToString();

			var job = Helper.PutJobStatus(jobId, status, stepName, stepType);
			Assert.AreEqual(jobId, job.Id.ToString());
			Assert.AreEqual(status, job.Status);
		}

		[Test]
		[Category("APIBasic")]
		public void Jobs_PostUpdateExtractions_Ok()
		{
			//Get document from Ready to Validate queue
			int limit = 1;
			string filter =
				$"{{\"skip\":0,\"limit\":{limit},\"all\":false,\"include\":[],\"exclude\":[],\"docType\":\"MSA_Standard_ST\",\"sort\":{{\"createdAt\":-1}},\"stage\":\"Ready to Validate\",\"levels\":[2,1],\"projectIds\":[\"{TestProjectId}\"]}}";
			List<Document> documents = ((JObject) jobApi.JobReport(filter)).SelectToken("documents").ToObject<List<Document>>();
			var document = documents[0];
			var jobId = document.Id.ToString();

			Job job = ((JObject) jobApi.JobValidation(jobId)).ToObject<Job>();

			JObject extractions = (JObject) job.Extractions;
			MSA_Standard_ST contract =
				(MSA_Standard_ST) JsonConvert.DeserializeObject(extractions.ToString(), typeof(MSA_Standard_ST));
			var properties = typeof(MSA_Standard_ST).GetRuntimeProperties();

			// Fill extraction fields
			foreach (var property in properties.Where(p => p.PropertyType == typeof(ExtractionProperty)))
			{
				ExtractionProperty extractionProperty = (ExtractionProperty) property.GetValue(contract);

				// Resolve duplicate values
				if (extractionProperty.entities.Count > 1)
				{
					extractionProperty.entities[0].selected = true;
					extractionProperty.entities[0].value = "test" + DateTime.Now.ToString();
				}
				else
				{
					// Fill missing values
					if (extractionProperty.entities[0].value == "")
					{
						extractionProperty.entities[0].value = "test" + DateTime.Now.ToString();
						property.SetValue(contract, extractionProperty);
					}
				}
			}

			JObject postDocuments = new JObject(
				new JProperty(
					"documents",
					new JArray
					{
						new JObject
						(
							new JProperty("extractions", JObject.FromObject(contract)),
							new JProperty("id", jobId)
						)
					}
				));

			Helper.PostJobUpdateExtractions(postDocuments);

			// Check updated and selected fields

			Job updatedJob = ((JObject) jobApi.JobValidation(jobId)).ToObject<Job>();
			JObject updatedExtractions = (JObject) updatedJob.Extractions;
			MSA_Standard_ST updatedContract =
				(MSA_Standard_ST) JsonConvert.DeserializeObject(updatedExtractions.ToString(), typeof(MSA_Standard_ST));

			foreach (var property in properties.Where(p => p.PropertyType == typeof(ExtractionProperty)))
			{
				ExtractionProperty oldProperty = (ExtractionProperty) property.GetValue(contract);
				ExtractionProperty updatedProperty = (ExtractionProperty) property.GetValue(updatedContract);
				Assert.AreEqual(oldProperty.entities[0].value, updatedProperty.entities[0].value);
				if(updatedProperty.entities.Count > 1) Assert.IsTrue(updatedProperty.entities[0].selected);
			}
		}

		[Test]
		[Category("APIBasic")]
		public void Jobs_ValidationGetById_Ok()
		{
			string id = "5909ad66baf2a14f2c0420b3";
			Job job = ((JObject)jobApi.JobValidation(id)).ToObject<Job>();
			Assert.AreEqual(id, job.Id.ToString(), "Wrong job id");
		}
	}
}
