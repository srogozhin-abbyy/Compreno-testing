/* 
 * ata
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
	/// <summary>
	/// Job
	/// </summary>
	[DataContract]
	public partial class Job :  IEquatable<Job>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Job" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected Job() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Job" /> class.
		/// </summary>
		/// <param name="Name">Name (required).</param>
		/// <param name="ErrorCode">ErrorCode (default to 0.0).</param>
		/// <param name="ErrorMsg">ErrorMsg (default to &quot;&quot;).</param>
		/// <param name="StepORstage">StepORstage (default to &quot;&quot;).</param>
		/// <param name="Step">Step.</param>
		/// <param name="RestartStep">RestartStep.</param>
		/// <param name="Status">Status (required) (default to &quot;Staged&quot;).</param>
		/// <param name="StatusMsg">StatusMsg (default to &quot;&quot;).</param>
		/// <param name="Entries">Entries.</param>
		/// <param name="SchemaVersion">SchemaVersion (default to 1.0).</param>
		/// <param name="Doctype">Doctype.</param>
		/// <param name="Document">Document.</param>
		/// <param name="Validators">Validators.</param>
		/// <param name="IsFake">IsFake.</param>
		/// <param name="OrganizationId">OrganizationId (required).</param>
		/// <param name="WorkflowId">WorkflowId (required).</param>
		/// <param name="Project">Project (required).</param>
		/// <param name="Level">Level (required) (default to 1.0).</param>
		/// <param name="DocumentId">DocumentId.</param>
		/// <param name="Extractions">Extractions.</param>
		/// <param name="Id">Id.</param>
		/// <param name="CreatedAt">CreatedAt (required).</param>
		/// <param name="UpdatedAt">UpdatedAt (required).</param>
		public Job(string Name = default(string), double? ErrorCode = 0.0, string ErrorMsg = "", string StepORstage = "", Object Step = default(Object), string RestartStep = default(string), string Status = "Staged", string StatusMsg = "", List<object> Entries = default(List<object>), double? SchemaVersion = 1.0, Object Doctype = default(Object), Object Document = default(Object), Object Validators = default(Object), bool? IsFake = default(bool?), ObjectID OrganizationId = default(ObjectID), ObjectID WorkflowId = default(ObjectID), Object Project = default(Object), double? Level = 1.0, Object DocumentId = default(Object), Object Extractions = default(Object), ObjectID Id = default(ObjectID), DateTime? CreatedAt = default(DateTime?), DateTime? UpdatedAt = default(DateTime?))
		{
			// to ensure "Name" is required (not null)
			if (Name == null)
			{
				throw new InvalidDataException("Name is a required property for Job and cannot be null");
			}
			else
			{
				this.Name = Name;
			}
			// to ensure "Status" is required (not null)
			if (Status == null)
			{
				throw new InvalidDataException("Status is a required property for Job and cannot be null");
			}
			else
			{
				this.Status = Status;
			}
			// to ensure "OrganizationId" is required (not null)
			if (OrganizationId == null)
			{
				throw new InvalidDataException("OrganizationId is a required property for Job and cannot be null");
			}
			else
			{
				this.OrganizationId = OrganizationId;
			}
			// to ensure "WorkflowId" is required (not null)
			if (WorkflowId == null)
			{
				throw new InvalidDataException("WorkflowId is a required property for Job and cannot be null");
			}
			else
			{
				this.WorkflowId = WorkflowId;
			}
			// to ensure "Project" is required (not null)
			if (Project == null)
			{
				throw new InvalidDataException("Project is a required property for Job and cannot be null");
			}
			else
			{
				this.Project = Project;
			}
			// to ensure "Level" is required (not null)
			if (Level == null)
			{
				throw new InvalidDataException("Level is a required property for Job and cannot be null");
			}
			else
			{
				this.Level = Level;
			}
			// to ensure "CreatedAt" is required (not null)
			if (CreatedAt == null)
			{
				throw new InvalidDataException("CreatedAt is a required property for Job and cannot be null");
			}
			else
			{
				this.CreatedAt = CreatedAt;
			}
			// to ensure "UpdatedAt" is required (not null)
			if (UpdatedAt == null)
			{
				throw new InvalidDataException("UpdatedAt is a required property for Job and cannot be null");
			}
			else
			{
				this.UpdatedAt = UpdatedAt;
			}
			// use default value if no "ErrorCode" provided
			if (ErrorCode == null)
			{
				this.ErrorCode = 0.0;
			}
			else
			{
				this.ErrorCode = ErrorCode;
			}
			// use default value if no "ErrorMsg" provided
			if (ErrorMsg == null)
			{
				this.ErrorMsg = "";
			}
			else
			{
				this.ErrorMsg = ErrorMsg;
			}
			// use default value if no "StepORstage" provided
			if (StepORstage == null)
			{
				this.StepORstage = "";
			}
			else
			{
				this.StepORstage = StepORstage;
			}
			this.Step = Step;
			this.RestartStep = RestartStep;
			// use default value if no "StatusMsg" provided
			if (StatusMsg == null)
			{
				this.StatusMsg = "";
			}
			else
			{
				this.StatusMsg = StatusMsg;
			}
			this.Entries = Entries;
			// use default value if no "SchemaVersion" provided
			if (SchemaVersion == null)
			{
				this.SchemaVersion = 1.0;
			}
			else
			{
				this.SchemaVersion = SchemaVersion;
			}
			this.Doctype = Doctype;
			this.Document = Document;
			this.Validators = Validators;
			this.IsFake = IsFake;
			this.DocumentId = DocumentId;
			this.Extractions = Extractions;
			this.Id = Id;
		}
		
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }
		/// <summary>
		/// Gets or Sets ErrorCode
		/// </summary>
		[DataMember(Name="errorCode", EmitDefaultValue=false)]
		public double? ErrorCode { get; set; }
		/// <summary>
		/// Gets or Sets ErrorMsg
		/// </summary>
		[DataMember(Name="errorMsg", EmitDefaultValue=false)]
		public string ErrorMsg { get; set; }
		/// <summary>
		/// Gets or Sets StepORstage
		/// </summary>
		[DataMember(Name="stepORstage", EmitDefaultValue=false)]
		public string StepORstage { get; set; }
		/// <summary>
		/// Gets or Sets Step
		/// </summary>
		[DataMember(Name="step", EmitDefaultValue=false)]
		public Object Step { get; set; }
		/// <summary>
		/// Gets or Sets RestartStep
		/// </summary>
		[DataMember(Name="restartStep", EmitDefaultValue=false)]
		public string RestartStep { get; set; }
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name="status", EmitDefaultValue=false)]
		public string Status { get; set; }
		/// <summary>
		/// Gets or Sets StatusMsg
		/// </summary>
		[DataMember(Name="statusMsg", EmitDefaultValue=false)]
		public string StatusMsg { get; set; }
		/// <summary>
		/// Gets or Sets Entries
		/// </summary>
		[DataMember(Name="entries", EmitDefaultValue=false)]
		public List<object> Entries { get; set; }
		/// <summary>
		/// Gets or Sets SchemaVersion
		/// </summary>
		[DataMember(Name="schemaVersion", EmitDefaultValue=false)]
		public double? SchemaVersion { get; set; }
		/// <summary>
		/// Gets or Sets Doctype
		/// </summary>
		[DataMember(Name="doctype", EmitDefaultValue=false)]
		public Object Doctype { get; set; }
		/// <summary>
		/// Gets or Sets Document
		/// </summary>
		[DataMember(Name="document", EmitDefaultValue=false)]
		public Object Document { get; set; }
		/// <summary>
		/// Gets or Sets Validators
		/// </summary>
		[DataMember(Name="validators", EmitDefaultValue=false)]
		public Object Validators { get; set; }
		/// <summary>
		/// Gets or Sets IsFake
		/// </summary>
		[DataMember(Name="isFake", EmitDefaultValue=false)]
		public bool? IsFake { get; set; }
		/// <summary>
		/// Gets or Sets OrganizationId
		/// </summary>
		[DataMember(Name="organizationId", EmitDefaultValue=false)]
		public ObjectID OrganizationId { get; set; }
		/// <summary>
		/// Gets or Sets WorkflowId
		/// </summary>
		[DataMember(Name="workflowId", EmitDefaultValue=false)]
		public ObjectID WorkflowId { get; set; }
		/// <summary>
		/// Gets or Sets Project
		/// </summary>
		[DataMember(Name="project", EmitDefaultValue=false)]
		public Object Project { get; set; }
		/// <summary>
		/// Gets or Sets Level
		/// </summary>
		[DataMember(Name="level", EmitDefaultValue=false)]
		public double? Level { get; set; }
		/// <summary>
		/// Gets or Sets DocumentId
		/// </summary>
		[DataMember(Name="documentId", EmitDefaultValue=false)]
		public Object DocumentId { get; set; }
		/// <summary>
		/// Gets or Sets Extractions
		/// </summary>
		[DataMember(Name="extractions", EmitDefaultValue=false)]
		public Object Extractions { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public ObjectID Id { get; set; }
		/// <summary>
		/// Gets or Sets CreatedAt
		/// </summary>
		[DataMember(Name="createdAt", EmitDefaultValue=false)]
		public DateTime? CreatedAt { get; set; }
		/// <summary>
		/// Gets or Sets UpdatedAt
		/// </summary>
		[DataMember(Name="updatedAt", EmitDefaultValue=false)]
		public DateTime? UpdatedAt { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Job {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
			sb.Append("  ErrorMsg: ").Append(ErrorMsg).Append("\n");
			sb.Append("  StepORstage: ").Append(StepORstage).Append("\n");
			sb.Append("  Step: ").Append(Step).Append("\n");
			sb.Append("  RestartStep: ").Append(RestartStep).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  StatusMsg: ").Append(StatusMsg).Append("\n");
			sb.Append("  Entries: ").Append(Entries).Append("\n");
			sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
			sb.Append("  Doctype: ").Append(Doctype).Append("\n");
			sb.Append("  Document: ").Append(Document).Append("\n");
			sb.Append("  Validators: ").Append(Validators).Append("\n");
			sb.Append("  IsFake: ").Append(IsFake).Append("\n");
			sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
			sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
			sb.Append("  Project: ").Append(Project).Append("\n");
			sb.Append("  Level: ").Append(Level).Append("\n");
			sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
			sb.Append("  Extractions: ").Append(Extractions).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
			sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
  
		/// <summary>
		/// Returns the JSON string presentation of the object
		/// </summary>
		/// <returns>JSON string presentation of the object</returns>
		public string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}

		/// <summary>
		/// Returns true if objects are equal
		/// </summary>
		/// <param name="obj">Object to be compared</param>
		/// <returns>Boolean</returns>
		public override bool Equals(object obj)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			return this.Equals(obj as Job);
		}

		/// <summary>
		/// Returns true if Job instances are equal
		/// </summary>
		/// <param name="other">Instance of Job to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Job other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return 
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) && 
				(
					this.ErrorCode == other.ErrorCode ||
					this.ErrorCode != null &&
					this.ErrorCode.Equals(other.ErrorCode)
				) && 
				(
					this.ErrorMsg == other.ErrorMsg ||
					this.ErrorMsg != null &&
					this.ErrorMsg.Equals(other.ErrorMsg)
				) && 
				(
					this.StepORstage == other.StepORstage ||
					this.StepORstage != null &&
					this.StepORstage.Equals(other.StepORstage)
				) && 
				(
					this.Step == other.Step ||
					this.Step != null &&
					this.Step.Equals(other.Step)
				) && 
				(
					this.RestartStep == other.RestartStep ||
					this.RestartStep != null &&
					this.RestartStep.Equals(other.RestartStep)
				) && 
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) && 
				(
					this.StatusMsg == other.StatusMsg ||
					this.StatusMsg != null &&
					this.StatusMsg.Equals(other.StatusMsg)
				) && 
				(
					this.Entries == other.Entries ||
					this.Entries != null &&
					this.Entries.SequenceEqual(other.Entries)
				) && 
				(
					this.SchemaVersion == other.SchemaVersion ||
					this.SchemaVersion != null &&
					this.SchemaVersion.Equals(other.SchemaVersion)
				) && 
				(
					this.Doctype == other.Doctype ||
					this.Doctype != null &&
					this.Doctype.Equals(other.Doctype)
				) && 
				(
					this.Document == other.Document ||
					this.Document != null &&
					this.Document.Equals(other.Document)
				) && 
				(
					this.Validators == other.Validators ||
					this.Validators != null &&
					this.Validators.Equals(other.Validators)
				) && 
				(
					this.IsFake == other.IsFake ||
					this.IsFake != null &&
					this.IsFake.Equals(other.IsFake)
				) && 
				(
					this.OrganizationId == other.OrganizationId ||
					this.OrganizationId != null &&
					this.OrganizationId.Equals(other.OrganizationId)
				) && 
				(
					this.WorkflowId == other.WorkflowId ||
					this.WorkflowId != null &&
					this.WorkflowId.Equals(other.WorkflowId)
				) && 
				(
					this.Project == other.Project ||
					this.Project != null &&
					this.Project.Equals(other.Project)
				) && 
				(
					this.Level == other.Level ||
					this.Level != null &&
					this.Level.Equals(other.Level)
				) && 
				(
					this.DocumentId == other.DocumentId ||
					this.DocumentId != null &&
					this.DocumentId.Equals(other.DocumentId)
				) && 
				(
					this.Extractions == other.Extractions ||
					this.Extractions != null &&
					this.Extractions.Equals(other.Extractions)
				) && 
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) && 
				(
					this.CreatedAt == other.CreatedAt ||
					this.CreatedAt != null &&
					this.CreatedAt.Equals(other.CreatedAt)
				) && 
				(
					this.UpdatedAt == other.UpdatedAt ||
					this.UpdatedAt != null &&
					this.UpdatedAt.Equals(other.UpdatedAt)
				);
		}

		/// <summary>
		/// Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode()
		{
			// credit: http://stackoverflow.com/a/263416/677735
			unchecked // Overflow is fine, just wrap
			{
				int hash = 41;
				// Suitable nullity checks etc, of course :)
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();
				if (this.ErrorCode != null)
					hash = hash * 59 + this.ErrorCode.GetHashCode();
				if (this.ErrorMsg != null)
					hash = hash * 59 + this.ErrorMsg.GetHashCode();
				if (this.StepORstage != null)
					hash = hash * 59 + this.StepORstage.GetHashCode();
				if (this.Step != null)
					hash = hash * 59 + this.Step.GetHashCode();
				if (this.RestartStep != null)
					hash = hash * 59 + this.RestartStep.GetHashCode();
				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();
				if (this.StatusMsg != null)
					hash = hash * 59 + this.StatusMsg.GetHashCode();
				if (this.Entries != null)
					hash = hash * 59 + this.Entries.GetHashCode();
				if (this.SchemaVersion != null)
					hash = hash * 59 + this.SchemaVersion.GetHashCode();
				if (this.Doctype != null)
					hash = hash * 59 + this.Doctype.GetHashCode();
				if (this.Document != null)
					hash = hash * 59 + this.Document.GetHashCode();
				if (this.Validators != null)
					hash = hash * 59 + this.Validators.GetHashCode();
				if (this.IsFake != null)
					hash = hash * 59 + this.IsFake.GetHashCode();
				if (this.OrganizationId != null)
					hash = hash * 59 + this.OrganizationId.GetHashCode();
				if (this.WorkflowId != null)
					hash = hash * 59 + this.WorkflowId.GetHashCode();
				if (this.Project != null)
					hash = hash * 59 + this.Project.GetHashCode();
				if (this.Level != null)
					hash = hash * 59 + this.Level.GetHashCode();
				if (this.DocumentId != null)
					hash = hash * 59 + this.DocumentId.GetHashCode();
				if (this.Extractions != null)
					hash = hash * 59 + this.Extractions.GetHashCode();
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();
				if (this.CreatedAt != null)
					hash = hash * 59 + this.CreatedAt.GetHashCode();
				if (this.UpdatedAt != null)
					hash = hash * 59 + this.UpdatedAt.GetHashCode();
				return hash;
			}
		}

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{ 
			yield break;
		}
	}

}
