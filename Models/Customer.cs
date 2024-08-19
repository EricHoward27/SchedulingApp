using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApp.Models
{
	public class Customer
	{
		[Column("customerId")]
		public int CustomerId { get; set; }
		[Column("customerName")]
		public string CustomerName { get; set; }
		[Column("addressId")]
		public int AddressId { get; set; }
		[ForeignKey("AddressId")]
		public virtual Address Address { get; set; }
		[Column("active")]
		public bool Active { get; set; }
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
