using System.Collections.Generic;

namespace Abbyy.ComprenoTesting.ComprenoClient.Models
{
	public class User
	{
		public string roleId { get; set; }
		public string roleName { get; set; }
		public List<int> levels { get; set; }
		public string username { get; set; }
		public string email { get; set; }
		public string id { get; set; }
		public string createdAt { get; set; }
		public string updatedAt { get; set; }
		public string organizationId { get; set; }
		public Permission permission { get; set; }
		public Organization organization { get; set; }
	}
}