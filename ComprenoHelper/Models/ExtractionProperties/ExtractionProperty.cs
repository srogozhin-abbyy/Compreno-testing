using System.Collections.Generic;

namespace ComprenoTesting.ComprenoHelper.Models.Extractions
{
	public class ExtractionProperty
	{
		public string displayName { get; set; }
		public string type { get; set; }
		public List<Entity> entities { get; set; }
	}
}