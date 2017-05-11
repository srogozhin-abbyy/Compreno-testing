using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprenoHelper.Models
{
	public class EntityNames
	{
		public static readonly List<string> Doctypes = new List<string>()
		{
			"All",
			"MSA_Standard_ST",
			"NDA_Mututal_MU",
			"NDA_OneWayRec_OWR",
			"NDA_OneWayDIs_OWD",
			"NDA_Multiparty_MP"
		};

		public static readonly List<string> ProcessingStages = new List<string>()
		{
			"All",
			"Processing Errors",
			"Processing",
			"Ready to Validate",
			"Exceptions",
			"Ready to Export",
			"Exported",
			"Removed"
		};
	}
}
