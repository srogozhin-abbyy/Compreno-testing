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
	/// Entity
	/// </summary>
	[DataContract]
	public partial class Entity :  IEquatable<Entity>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Entity" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected Entity() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Entity" /> class.
		/// </summary>
		/// <param name="Name">Name (required).</param>
		/// <param name="DocumentType">DocumentType (required).</param>
		/// <param name="JobIds">JobIds.</param>
		/// <param name="ValidatedDocsCount">ValidatedDocsCount.</param>
		/// <param name="TrainedDocsCount">TrainedDocsCount.</param>
		/// <param name="Id">Id.</param>
		/// <param name="Exceptions">Exceptions.</param>
		/// <param name="CreatedAt">CreatedAt (required).</param>
		/// <param name="UpdatedAt">UpdatedAt (required).</param>
		public Entity(string Name = default(string), string DocumentType = default(string), List<object> JobIds = default(List<object>), double? ValidatedDocsCount = default(double?), double? TrainedDocsCount = default(double?), ObjectID Id = default(ObjectID), List<ObjectID> Exceptions = default(List<ObjectID>), DateTime? CreatedAt = default(DateTime?), DateTime? UpdatedAt = default(DateTime?))
		{
			// to ensure "Name" is required (not null)
			if (Name == null)
			{
				throw new InvalidDataException("Name is a required property for Entity and cannot be null");
			}
			else
			{
				this.Name = Name;
			}
			// to ensure "DocumentType" is required (not null)
			if (DocumentType == null)
			{
				throw new InvalidDataException("DocumentType is a required property for Entity and cannot be null");
			}
			else
			{
				this.DocumentType = DocumentType;
			}
			// to ensure "CreatedAt" is required (not null)
			if (CreatedAt == null)
			{
				throw new InvalidDataException("CreatedAt is a required property for Entity and cannot be null");
			}
			else
			{
				this.CreatedAt = CreatedAt;
			}
			// to ensure "UpdatedAt" is required (not null)
			if (UpdatedAt == null)
			{
				throw new InvalidDataException("UpdatedAt is a required property for Entity and cannot be null");
			}
			else
			{
				this.UpdatedAt = UpdatedAt;
			}
			this.JobIds = JobIds;
			this.ValidatedDocsCount = ValidatedDocsCount;
			this.TrainedDocsCount = TrainedDocsCount;
			this.Id = Id;
			this.Exceptions = Exceptions;
		}
		
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }
		/// <summary>
		/// Gets or Sets DocumentType
		/// </summary>
		[DataMember(Name="documentType", EmitDefaultValue=false)]
		public string DocumentType { get; set; }
		/// <summary>
		/// Gets or Sets JobIds
		/// </summary>
		[DataMember(Name="jobIds", EmitDefaultValue=false)]
		public List<object> JobIds { get; set; }
		/// <summary>
		/// Gets or Sets ValidatedDocsCount
		/// </summary>
		[DataMember(Name="validatedDocsCount", EmitDefaultValue=false)]
		public double? ValidatedDocsCount { get; set; }
		/// <summary>
		/// Gets or Sets TrainedDocsCount
		/// </summary>
		[DataMember(Name="trainedDocsCount", EmitDefaultValue=false)]
		public double? TrainedDocsCount { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public ObjectID Id { get; set; }
		/// <summary>
		/// Gets or Sets Exceptions
		/// </summary>
		[DataMember(Name="exceptions", EmitDefaultValue=false)]
		public List<ObjectID> Exceptions { get; set; }
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
			sb.Append("class Entity {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
			sb.Append("  JobIds: ").Append(JobIds).Append("\n");
			sb.Append("  ValidatedDocsCount: ").Append(ValidatedDocsCount).Append("\n");
			sb.Append("  TrainedDocsCount: ").Append(TrainedDocsCount).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Exceptions: ").Append(Exceptions).Append("\n");
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
			return this.Equals(obj as Entity);
		}

		/// <summary>
		/// Returns true if Entity instances are equal
		/// </summary>
		/// <param name="other">Instance of Entity to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Entity other)
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
					this.DocumentType == other.DocumentType ||
					this.DocumentType != null &&
					this.DocumentType.Equals(other.DocumentType)
				) && 
				(
					this.JobIds == other.JobIds ||
					this.JobIds != null &&
					this.JobIds.SequenceEqual(other.JobIds)
				) && 
				(
					this.ValidatedDocsCount == other.ValidatedDocsCount ||
					this.ValidatedDocsCount != null &&
					this.ValidatedDocsCount.Equals(other.ValidatedDocsCount)
				) && 
				(
					this.TrainedDocsCount == other.TrainedDocsCount ||
					this.TrainedDocsCount != null &&
					this.TrainedDocsCount.Equals(other.TrainedDocsCount)
				) && 
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) && 
				(
					this.Exceptions == other.Exceptions ||
					this.Exceptions != null &&
					this.Exceptions.SequenceEqual(other.Exceptions)
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
				if (this.DocumentType != null)
					hash = hash * 59 + this.DocumentType.GetHashCode();
				if (this.JobIds != null)
					hash = hash * 59 + this.JobIds.GetHashCode();
				if (this.ValidatedDocsCount != null)
					hash = hash * 59 + this.ValidatedDocsCount.GetHashCode();
				if (this.TrainedDocsCount != null)
					hash = hash * 59 + this.TrainedDocsCount.GetHashCode();
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();
				if (this.Exceptions != null)
					hash = hash * 59 + this.Exceptions.GetHashCode();
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
