using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApp.Models
{
	public class Report
	{
		public class AppointmentReport
		{
			public string AppointmentType { get; set; }
			public int Month { get; set; }
			public int Count { get; set; }

		}

		public class UserScheduleReport
		{
			public int UserId { get; set; }
			public string UserName { get; set; }
			public List<Appointment> Appointments { get; set; }

		}

		public class CustomerReport
		{
			public int CustomerId { get; set; }
			public string CustomerName { get; set; }
			public int AppointmentCount { get; set; }
		}
	}
}