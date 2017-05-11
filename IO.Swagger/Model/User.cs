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
	/// User
	/// </summary>
	[DataContract]
	public partial class User :  IEquatable<User>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="User" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected User() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="User" /> class.
		/// </summary>
		/// <param name="FirstName">FirstName.</param>
		/// <param name="LastName">LastName.</param>
		/// <param name="RoleId">RoleId (required).</param>
		/// <param name="RoleName">RoleName.</param>
		/// <param name="Levels">Levels (required).</param>
		/// <param name="Realm">Realm.</param>
		/// <param name="Username">Username.</param>
		/// <param name="Credentials">Credentials.</param>
		/// <param name="Challenges">Challenges.</param>
		/// <param name="Email">Email (required).</param>
		/// <param name="EmailVerified">EmailVerified.</param>
		/// <param name="Status">Status.</param>
		/// <param name="Created">Created.</param>
		/// <param name="LastUpdated">LastUpdated.</param>
		/// <param name="Id">Id.</param>
		/// <param name="CreatedAt">CreatedAt (required).</param>
		/// <param name="UpdatedAt">UpdatedAt (required).</param>
		/// <param name="OrganizationId">OrganizationId.</param>
		public User(string FirstName = default(string), string LastName = default(string), ObjectID RoleId = default(ObjectID), string RoleName = default(string), List<double?> Levels = default(List<double?>), string Realm = default(string), string Username = default(string), Object Credentials = default(Object), Object Challenges = default(Object), string Email = default(string), bool? EmailVerified = default(bool?), string Status = default(string), DateTime? Created = default(DateTime?), DateTime? LastUpdated = default(DateTime?), ObjectID Id = default(ObjectID), DateTime? CreatedAt = default(DateTime?), DateTime? UpdatedAt = default(DateTime?), ObjectID OrganizationId = default(ObjectID))
		{
			// to ensure "RoleId" is required (not null)
			if (RoleId == null)
			{
				throw new InvalidDataException("RoleId is a required property for User and cannot be null");
			}
			else
			{
				this.RoleId = RoleId;
			}
			// to ensure "Levels" is required (not null)
			if (Levels == null)
			{
				throw new InvalidDataException("Levels is a required property for User and cannot be null");
			}
			else
			{
				this.Levels = Levels;
			}
			// to ensure "Email" is required (not null)
			if (Email == null)
			{
				throw new InvalidDataException("Email is a required property for User and cannot be null");
			}
			else
			{
				this.Email = Email;
			}
			// to ensure "CreatedAt" is required (not null)
			if (CreatedAt == null)
			{
				throw new InvalidDataException("CreatedAt is a required property for User and cannot be null");
			}
			else
			{
				this.CreatedAt = CreatedAt;
			}
			// to ensure "UpdatedAt" is required (not null)
			if (UpdatedAt == null)
			{
				throw new InvalidDataException("UpdatedAt is a required property for User and cannot be null");
			}
			else
			{
				this.UpdatedAt = UpdatedAt;
			}
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.RoleName = RoleName;
			this.Realm = Realm;
			this.Username = Username;
			this.Credentials = Credentials;
			this.Challenges = Challenges;
			this.EmailVerified = EmailVerified;
			this.Status = Status;
			this.Created = Created;
			this.LastUpdated = LastUpdated;
			this.Id = Id;
			this.OrganizationId = OrganizationId;
		}
		
		/// <summary>
		/// Gets or Sets FirstName
		/// </summary>
		[DataMember(Name="firstName", EmitDefaultValue=false)]
		public string FirstName { get; set; }
		/// <summary>
		/// Gets or Sets LastName
		/// </summary>
		[DataMember(Name="lastName", EmitDefaultValue=false)]
		public string LastName { get; set; }
		/// <summary>
		/// Gets or Sets RoleId
		/// </summary>
		[DataMember(Name="roleId", EmitDefaultValue=false)]
		public ObjectID RoleId { get; set; }
		/// <summary>
		/// Gets or Sets RoleName
		/// </summary>
		[DataMember(Name="roleName", EmitDefaultValue=false)]
		public string RoleName { get; set; }
		/// <summary>
		/// Gets or Sets Levels
		/// </summary>
		[DataMember(Name="levels", EmitDefaultValue=false)]
		public List<double?> Levels { get; set; }
		/// <summary>
		/// Gets or Sets Realm
		/// </summary>
		[DataMember(Name="realm", EmitDefaultValue=false)]
		public string Realm { get; set; }
		/// <summary>
		/// Gets or Sets Username
		/// </summary>
		[DataMember(Name="username", EmitDefaultValue=false)]
		public string Username { get; set; }
		/// <summary>
		/// Gets or Sets Credentials
		/// </summary>
		[DataMember(Name="credentials", EmitDefaultValue=false)]
		public Object Credentials { get; set; }
		/// <summary>
		/// Gets or Sets Challenges
		/// </summary>
		[DataMember(Name="challenges", EmitDefaultValue=false)]
		public Object Challenges { get; set; }
		/// <summary>
		/// Gets or Sets Email
		/// </summary>
		[DataMember(Name="email", EmitDefaultValue=false)]
		public string Email { get; set; }
		/// <summary>
		/// Gets or Sets EmailVerified
		/// </summary>
		[DataMember(Name="emailVerified", EmitDefaultValue=false)]
		public bool? EmailVerified { get; set; }
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name="status", EmitDefaultValue=false)]
		public string Status { get; set; }
		/// <summary>
		/// Gets or Sets Created
		/// </summary>
		[DataMember(Name="created", EmitDefaultValue=false)]
		public DateTime? Created { get; set; }
		/// <summary>
		/// Gets or Sets LastUpdated
		/// </summary>
		[DataMember(Name="lastUpdated", EmitDefaultValue=false)]
		public DateTime? LastUpdated { get; set; }
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
		/// Gets or Sets OrganizationId
		/// </summary>
		[DataMember(Name="organizationId", EmitDefaultValue=false)]
		public ObjectID OrganizationId { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class User {\n");
			sb.Append("  FirstName: ").Append(FirstName).Append("\n");
			sb.Append("  LastName: ").Append(LastName).Append("\n");
			sb.Append("  RoleId: ").Append(RoleId).Append("\n");
			sb.Append("  RoleName: ").Append(RoleName).Append("\n");
			sb.Append("  Levels: ").Append(Levels).Append("\n");
			sb.Append("  Realm: ").Append(Realm).Append("\n");
			sb.Append("  Username: ").Append(Username).Append("\n");
			sb.Append("  Credentials: ").Append(Credentials).Append("\n");
			sb.Append("  Challenges: ").Append(Challenges).Append("\n");
			sb.Append("  Email: ").Append(Email).Append("\n");
			sb.Append("  EmailVerified: ").Append(EmailVerified).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Created: ").Append(Created).Append("\n");
			sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
			sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
			sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
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
			return this.Equals(obj as User);
		}

		/// <summary>
		/// Returns true if User instances are equal
		/// </summary>
		/// <param name="other">Instance of User to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(User other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return 
				(
					this.FirstName == other.FirstName ||
					this.FirstName != null &&
					this.FirstName.Equals(other.FirstName)
				) && 
				(
					this.LastName == other.LastName ||
					this.LastName != null &&
					this.LastName.Equals(other.LastName)
				) && 
				(
					this.RoleId == other.RoleId ||
					this.RoleId != null &&
					this.RoleId.Equals(other.RoleId)
				) && 
				(
					this.RoleName == other.RoleName ||
					this.RoleName != null &&
					this.RoleName.Equals(other.RoleName)
				) && 
				(
					this.Levels == other.Levels ||
					this.Levels != null &&
					this.Levels.SequenceEqual(other.Levels)
				) && 
				(
					this.Realm == other.Realm ||
					this.Realm != null &&
					this.Realm.Equals(other.Realm)
				) && 
				(
					this.Username == other.Username ||
					this.Username != null &&
					this.Username.Equals(other.Username)
				) && 
				(
					this.Credentials == other.Credentials ||
					this.Credentials != null &&
					this.Credentials.Equals(other.Credentials)
				) && 
				(
					this.Challenges == other.Challenges ||
					this.Challenges != null &&
					this.Challenges.Equals(other.Challenges)
				) && 
				(
					this.Email == other.Email ||
					this.Email != null &&
					this.Email.Equals(other.Email)
				) && 
				(
					this.EmailVerified == other.EmailVerified ||
					this.EmailVerified != null &&
					this.EmailVerified.Equals(other.EmailVerified)
				) && 
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) && 
				(
					this.Created == other.Created ||
					this.Created != null &&
					this.Created.Equals(other.Created)
				) && 
				(
					this.LastUpdated == other.LastUpdated ||
					this.LastUpdated != null &&
					this.LastUpdated.Equals(other.LastUpdated)
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
				) && 
				(
					this.OrganizationId == other.OrganizationId ||
					this.OrganizationId != null &&
					this.OrganizationId.Equals(other.OrganizationId)
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
				if (this.FirstName != null)
					hash = hash * 59 + this.FirstName.GetHashCode();
				if (this.LastName != null)
					hash = hash * 59 + this.LastName.GetHashCode();
				if (this.RoleId != null)
					hash = hash * 59 + this.RoleId.GetHashCode();
				if (this.RoleName != null)
					hash = hash * 59 + this.RoleName.GetHashCode();
				if (this.Levels != null)
					hash = hash * 59 + this.Levels.GetHashCode();
				if (this.Realm != null)
					hash = hash * 59 + this.Realm.GetHashCode();
				if (this.Username != null)
					hash = hash * 59 + this.Username.GetHashCode();
				if (this.Credentials != null)
					hash = hash * 59 + this.Credentials.GetHashCode();
				if (this.Challenges != null)
					hash = hash * 59 + this.Challenges.GetHashCode();
				if (this.Email != null)
					hash = hash * 59 + this.Email.GetHashCode();
				if (this.EmailVerified != null)
					hash = hash * 59 + this.EmailVerified.GetHashCode();
				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();
				if (this.Created != null)
					hash = hash * 59 + this.Created.GetHashCode();
				if (this.LastUpdated != null)
					hash = hash * 59 + this.LastUpdated.GetHashCode();
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();
				if (this.CreatedAt != null)
					hash = hash * 59 + this.CreatedAt.GetHashCode();
				if (this.UpdatedAt != null)
					hash = hash * 59 + this.UpdatedAt.GetHashCode();
				if (this.OrganizationId != null)
					hash = hash * 59 + this.OrganizationId.GetHashCode();
				return hash;
			}
		}

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{ 
			yield break;
		}
	}

}
