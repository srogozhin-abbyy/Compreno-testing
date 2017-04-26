using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions;

using Abbyy.ComprenoTesting.ComprenoClient.Models;

namespace Abbyy.ComprenoTesting.ComprenoClient
{
	public class Client
	{
		private Uri Uri;
		private string token;


		public Client()
		{
			Uri = new Uri(ConfigurationManager.AppSettings["url"]);
		}

		public Credentials Login(string email, string password)
		{
			var credentials = new Dictionary<string, string>
			{
				{"username", email},
				{"password", password}
			};

			var response = Post(credentials, "nextapi/users/login");
			return (Credentials)Deserialize(response, typeof(Models.Credentials));
		}

		private string Post(Dictionary<string, string> values, string path = "")
		{
			using (var client = new HttpClient())
			{
				var content = new FormUrlEncodedContent(values);
				return client.PostAsync(new Uri(Uri, path), content).Result.Content.ReadAsStringAsync().Result;
			}
		}

		private object Deserialize(string content, Type type, IList<Parameter> headers = null)
		{
			if (type == typeof(Object)) // return an object
			{
				return content;
			}

			if (type == typeof(Stream))
			{
				var filePath = Path.GetTempPath();

				var fileName = filePath + Guid.NewGuid();
				if (headers != null)
				{
					var regex = new Regex(@"Content-Disposition:.*filename=['""]?([^'""\s]+)['""]?$");
					var match = regex.Match(headers.ToString());
					if (match.Success)
						fileName = filePath + match.Value.Replace("\"", "").Replace("'", "");
				}
				File.WriteAllText(fileName, content);
				return new FileStream(fileName, FileMode.Open);
			}

			if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
			{
				return DateTime.Parse(content, null, System.Globalization.DateTimeStyles.RoundtripKind);
			}

			if (type == typeof(String) || type.Name.StartsWith("System.Nullable")) // return primitive type
			{
				return ConvertType(content, type);
			}

			// at this point, it must be a model (json)
			try
			{
				return JsonConvert.DeserializeObject(content, type);
			}
			catch (IOException e)
			{
				//throw new ApiException(500, e.Message);
				throw new Exception();
			}
		}
		/// <summary>
		/// Dynamically cast the object into target type.
		/// Ref: http://stackoverflow.com/questions/4925718/c-dynamic-runtime-cast
		/// </summary>
		/// <param name="source">Object to be casted</param>
		/// <param name="dest">Target type</param>
		/// <returns>Casted object</returns>
		private static Object ConvertType(Object source, Type dest)
		{
			return Convert.ChangeType(source, dest);
		}
	}
}