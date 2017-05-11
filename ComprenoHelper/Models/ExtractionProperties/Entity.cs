using System.Collections.Generic;

namespace ComprenoTesting.ComprenoHelper.Models.Extractions
{
	public class Entity
	{
		public bool selected { get; set; }
		public string id { get; set; }
		public string value { get; set; }
		public List<Instance> instances { get; set; }
		public List<Segment> segments { get; set; }
	}
}