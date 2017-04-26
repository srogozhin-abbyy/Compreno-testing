namespace Abbyy.ComprenoTesting.ComprenoClient.Models
{
	public class Organization
	{
		public string name { get; set; }
		public string id { get; set; }
		public string createdAt { get; set; }
		public string updatedAt { get; set; }
		public Settings settings { get; set; }
	}
}