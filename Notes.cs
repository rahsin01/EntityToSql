using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityToSQL
{
	[Table(Name = "dbo.Notes")]
	public class Notes
    {
		[Column(IsPrimaryKey = true)]
		public string CATEGORY { get; set; }
		[Column]
		public string SUBJECT { get; set; }
		[Column]
		public string NODETEXT { get; set; }
	}
}
