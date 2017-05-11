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
	/// Markup
	/// </summary>
	[DataContract]
	public partial class Markup :  IEquatable<Markup>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Markup" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected Markup() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Markup" /> class.
		/// </summary>
		/// <param name="Text">Text (required).</param>
		/// <param name="Extractions">Extractions (required).</param>
		/// <param name="Id">Id.</param>
		/// <param name="JobId">JobId.</param>
		/// <param name="DocumentId">DocumentId.</param>
		/// <param name="CreatedAt">CreatedAt (required).</param>
		/// <param name="UpdatedAt">UpdatedAt (required).</param>
		public Markup(string Text = default(string), List<Object> Extractions = default(List<Object>), ObjectID Id = default(ObjectID), ObjectID JobId = default(ObjectID), ObjectID DocumentId = default(ObjectID), DateTime? CreatedAt = default(DateTime?), DateTime? UpdatedAt = default(DateTime?))
		{
			// to ensure "Text" is required (not null)
			if (Text == null)
			{
				throw new InvalidDataException("Text is a required property for Markup and cannot be null");
			}
			else
			{
				this.Text = Text;
			}
			// to ensure "Extractions" is required (not null)
			if (Extractions == null)
			{
				throw new InvalidDataException("Extractions is a required property for Markup and cannot be null");
			}
			else
			{
				this.Extractions = Extractions;
			}
			// to ensure "CreatedAt" is required (not null)
			if (CreatedAt == null)
			{
				throw new InvalidDataException("CreatedAt is a required property for Markup and cannot be null");
			}
			else
			{
				this.CreatedAt = CreatedAt;
			}
			// to ensure "UpdatedAt" is required (not null)
			if (UpdatedAt == null)
			{
				throw new InvalidDataException("UpdatedAt is a required property for Markup and cannot be null");
			}
			else
			{
				this.UpdatedAt = UpdatedAt;
			}
			this.Id = Id;
			this.JobId = JobId;
			this.DocumentId = DocumentId;
		}
		
		/// <summary>
		/// Gets or Sets Text
		/// </summary>
		[DataMember(Name="text", EmitDefaultValue=false)]
		public string Text { get; set; }
		/// <summary>
		/// Gets or Sets Extractions
		/// </summary>
		[DataMember(Name="extractions", EmitDefaultValue=false)]
		public List<Object> Extractions { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public ObjectID Id { get; set; }
		/// <summary>
		/// Gets or Sets JobId
		/// </summary>
		[DataMember(Name="jobId", EmitDefaultValue=false)]
		public ObjectID JobId { get; set; }
		/// <summary>
		/// Gets or Sets DocumentId
		/// </summary>
		[DataMember(Name="documentId", EmitDefaultValue=false)]
		public ObjectID DocumentId { get; set; }
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
			sb.Append("class Markup {\n");
			sb.Append("  Text: ").Append(Text).Append("\n");
			sb.Append("  Extractions: ").Append(Extractions).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  JobId: ").Append(JobId).Append("\n");
			sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
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
			return this.Equals(obj as Markup);
		}

		/// <summary>
		/// Returns true if Markup instances are equal
		/// </summary>
		/// <param name="other">Instance of Markup to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Markup other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return 
				(
					this.Text == other.Text ||
					this.Text != null &&
					this.Text.Equals(other.Text)
				) && 
				(
					this.Extractions == other.Extractions ||
					this.Extractions != null &&
					this.Extractions.SequenceEqual(other.Extractions)
				) && 
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) && 
				(
					this.JobId == other.JobId ||
					this.JobId != null &&
					this.JobId.Equals(other.JobId)
				) && 
				(
					this.DocumentId == other.DocumentId ||
					this.DocumentId != null &&
					this.DocumentId.Equals(other.DocumentId)
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
				if (this.Text != null)
					hash = hash * 59 + this.Text.GetHashCode();
				if (this.Extractions != null)
					hash = hash * 59 + this.Extractions.GetHashCode();
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();
				if (this.JobId != null)
					hash = hash * 59 + this.JobId.GetHashCode();
				if (this.DocumentId != null)
					hash = hash * 59 + this.DocumentId.GetHashCode();
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
