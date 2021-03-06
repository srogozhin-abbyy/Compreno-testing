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
	/// Segment
	/// </summary>
	[DataContract]
	public partial class Segment :  IEquatable<Segment>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Segment" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected Segment() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Segment" /> class.
		/// </summary>
		/// <param name="OrganizationId">OrganizationId (required).</param>
		/// <param name="Doctype">Doctype (required).</param>
		/// <param name="ExtractionTemplateId">ExtractionTemplateId (required).</param>
		/// <param name="Type">Type (required).</param>
		/// <param name="DisplayName">DisplayName (required).</param>
		/// <param name="Extractions">Extractions.</param>
		/// <param name="Id">Id.</param>
		/// <param name="CreatedAt">CreatedAt (required).</param>
		/// <param name="UpdatedAt">UpdatedAt (required).</param>
		public Segment(ObjectID OrganizationId = default(ObjectID), Object Doctype = default(Object), ObjectID ExtractionTemplateId = default(ObjectID), string Type = default(string), string DisplayName = default(string), List<Object> Extractions = default(List<Object>), ObjectID Id = default(ObjectID), DateTime? CreatedAt = default(DateTime?), DateTime? UpdatedAt = default(DateTime?))
		{
			// to ensure "OrganizationId" is required (not null)
			if (OrganizationId == null)
			{
				throw new InvalidDataException("OrganizationId is a required property for Segment and cannot be null");
			}
			else
			{
				this.OrganizationId = OrganizationId;
			}
			// to ensure "Doctype" is required (not null)
			if (Doctype == null)
			{
				throw new InvalidDataException("Doctype is a required property for Segment and cannot be null");
			}
			else
			{
				this.Doctype = Doctype;
			}
			// to ensure "ExtractionTemplateId" is required (not null)
			if (ExtractionTemplateId == null)
			{
				throw new InvalidDataException("ExtractionTemplateId is a required property for Segment and cannot be null");
			}
			else
			{
				this.ExtractionTemplateId = ExtractionTemplateId;
			}
			// to ensure "Type" is required (not null)
			if (Type == null)
			{
				throw new InvalidDataException("Type is a required property for Segment and cannot be null");
			}
			else
			{
				this.Type = Type;
			}
			// to ensure "DisplayName" is required (not null)
			if (DisplayName == null)
			{
				throw new InvalidDataException("DisplayName is a required property for Segment and cannot be null");
			}
			else
			{
				this.DisplayName = DisplayName;
			}
			// to ensure "CreatedAt" is required (not null)
			if (CreatedAt == null)
			{
				throw new InvalidDataException("CreatedAt is a required property for Segment and cannot be null");
			}
			else
			{
				this.CreatedAt = CreatedAt;
			}
			// to ensure "UpdatedAt" is required (not null)
			if (UpdatedAt == null)
			{
				throw new InvalidDataException("UpdatedAt is a required property for Segment and cannot be null");
			}
			else
			{
				this.UpdatedAt = UpdatedAt;
			}
			this.Extractions = Extractions;
			this.Id = Id;
		}
		
		/// <summary>
		/// Gets or Sets OrganizationId
		/// </summary>
		[DataMember(Name="organizationId", EmitDefaultValue=false)]
		public ObjectID OrganizationId { get; set; }
		/// <summary>
		/// Gets or Sets Doctype
		/// </summary>
		[DataMember(Name="doctype", EmitDefaultValue=false)]
		public Object Doctype { get; set; }
		/// <summary>
		/// Gets or Sets ExtractionTemplateId
		/// </summary>
		[DataMember(Name="extractionTemplateId", EmitDefaultValue=false)]
		public ObjectID ExtractionTemplateId { get; set; }
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name="type", EmitDefaultValue=false)]
		public string Type { get; set; }
		/// <summary>
		/// Gets or Sets DisplayName
		/// </summary>
		[DataMember(Name="displayName", EmitDefaultValue=false)]
		public string DisplayName { get; set; }
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
			sb.Append("class Segment {\n");
			sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
			sb.Append("  Doctype: ").Append(Doctype).Append("\n");
			sb.Append("  ExtractionTemplateId: ").Append(ExtractionTemplateId).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
			return this.Equals(obj as Segment);
		}

		/// <summary>
		/// Returns true if Segment instances are equal
		/// </summary>
		/// <param name="other">Instance of Segment to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Segment other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return 
				(
					this.OrganizationId == other.OrganizationId ||
					this.OrganizationId != null &&
					this.OrganizationId.Equals(other.OrganizationId)
				) && 
				(
					this.Doctype == other.Doctype ||
					this.Doctype != null &&
					this.Doctype.Equals(other.Doctype)
				) && 
				(
					this.ExtractionTemplateId == other.ExtractionTemplateId ||
					this.ExtractionTemplateId != null &&
					this.ExtractionTemplateId.Equals(other.ExtractionTemplateId)
				) && 
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) && 
				(
					this.DisplayName == other.DisplayName ||
					this.DisplayName != null &&
					this.DisplayName.Equals(other.DisplayName)
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
				if (this.OrganizationId != null)
					hash = hash * 59 + this.OrganizationId.GetHashCode();
				if (this.Doctype != null)
					hash = hash * 59 + this.Doctype.GetHashCode();
				if (this.ExtractionTemplateId != null)
					hash = hash * 59 + this.ExtractionTemplateId.GetHashCode();
				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();
				if (this.DisplayName != null)
					hash = hash * 59 + this.DisplayName.GetHashCode();
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
