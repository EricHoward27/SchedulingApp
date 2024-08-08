using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApp.Models
{
	public class Country
	{
		[Column("countryId")]
		public int CountryId { get; set; }
		[Column("country")]
		public string CountryName { get; set; }
		[Column("createDate")]
		public DateTime CreateDate { get; set; }
		[Column("createdBy")]
		public string CreatedBy { get; set; }
		[Column("lastUpdate")]
		public DateTime LastUpdate { get; set; }
		[Column("lastUpdateBy")]
		public string LastUpdateBy { get; set; }
	}
}
