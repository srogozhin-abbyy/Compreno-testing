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
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
	/// <summary>
	/// DocumentTypeProcessingDefaults
	/// </summary>
	[DataContract]
	public partial class DocumentTypeProcessingDefaults :  IEquatable<DocumentTypeProcessingDefaults>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentTypeProcessingDefaults" /> class.
		/// </summary>
		/// <param name="Recognition">Recognition.</param>
		/// <param name="Classification">Classification.</param>
		/// <param name="Identification">Identification.</param>
		/// <param name="Extraction">Extraction.</param>
		public DocumentTypeProcessingDefaults(string Recognition = default(string), string Classification = default(string), string Identification = default(string), string Extraction = default(string))
		{
			this.Recognition = Recognition;
			this.Classification = Classification;
			this.Identification = Identification;
			this.Extraction = Extraction;
		}
		
		/// <summary>
		/// Gets or Sets Recognition
		/// </summary>
		[DataMember(Name="recognition", EmitDefaultValue=false)]
		public string Recognition { get; set; }
		/// <summary>
		/// Gets or Sets Classification
		/// </summary>
		[DataMember(Name="classification", EmitDefaultValue=false)]
		public string Classification { get; set; }
		/// <summary>
		/// Gets or Sets Identification
		/// </summary>
		[DataMember(Name="identification", EmitDefaultValue=false)]
		public string Identification { get; set; }
		/// <summary>
		/// Gets or Sets Extraction
		/// </summary>
		[DataMember(Name="extraction", EmitDefaultValue=false)]
		public string Extraction { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DocumentTypeProcessingDefaults {\n");
			sb.Append("  Recognition: ").Append(Recognition).Append("\n");
			sb.Append("  Classification: ").Append(Classification).Append("\n");
			sb.Append("  Identification: ").Append(Identification).Append("\n");
			sb.Append("  Extraction: ").Append(Extraction).Append("\n");
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
			return this.Equals(obj as DocumentTypeProcessingDefaults);
		}

		/// <summary>
		/// Returns true if DocumentTypeProcessingDefaults instances are equal
		/// </summary>
		/// <param name="other">Instance of DocumentTypeProcessingDefaults to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DocumentTypeProcessingDefaults other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return 
				(
					this.Recognition == other.Recognition ||
					this.Recognition != null &&
					this.Recognition.Equals(other.Recognition)
				) && 
				(
					this.Classification == other.Classification ||
					this.Classification != null &&
					this.Classification.Equals(other.Classification)
				) && 
				(
					this.Identification == other.Identification ||
					this.Identification != null &&
					this.Identification.Equals(other.Identification)
				) && 
				(
					this.Extraction == other.Extraction ||
					this.Extraction != null &&
					this.Extraction.Equals(other.Extraction)
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
				if (this.Recognition != null)
					hash = hash * 59 + this.Recognition.GetHashCode();
				if (this.Classification != null)
					hash = hash * 59 + this.Classification.GetHashCode();
				if (this.Identification != null)
					hash = hash * 59 + this.Identification.GetHashCode();
				if (this.Extraction != null)
					hash = hash * 59 + this.Extraction.GetHashCode();
				return hash;
			}
		}

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{ 
			yield break;
		}
	}

}
