using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApp.Models
{
	public class Address
	{
		[Column("addressId")]
		public int AddressId { get; set; }
		[Column("address")]
		public string Address1 { get; set; }
		[Column("address2")]
		public string Address2 { get; set; }
		[Column("cityId")]
		public int CityId { get; set; }
		[Column("postalCode")]
		public string PostalCode { get; set; }
		[Column("phone")]
		public string Phone { get; set; }
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
