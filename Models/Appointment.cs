using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApp.Models
{
	public class Appointment
	{
		[Column("appointmentId")]
		public int AppointmentId { get; set; }
		[Column("customerId")]
		public int CustomerId { get; set; }

        [ForeignKey("User")]
        [Column("userId")]
		public int UserId { get; set; }
	
		public virtual User User { get; set; }
		[Column("title")]
		public string Title { get; set; }
		[Column("description")]
		public string Description { get; set; }
		[Column("location")]
		public string Location { get; set; }
		[Column("contact")]
		public string Contact { get; set; }
		[Column("type")]
		public string Type { get; set; }
		[Column("url")]
		public string Url { get; set; }
		[Column("start")]
		public DateTime Start { get; set; }
		[Column("end")]
		public DateTime End { get; set; }
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
