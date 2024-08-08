using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApp.Models
{
	public class City
	{
		[Column("cityId")]
		public int CityId { get; set; }
		[Column("city")]
		public string CityName { get; set; }
		[Column("countryId")]
		public int CountryId { get; set; }
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
