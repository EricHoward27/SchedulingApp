using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApp.Models
{
	public class ScheduleDbContext : DbContext
	{
		public ScheduleDbContext() : base("name=ScheduleDbContext")
		{
		}

		public DbSet<User> Users { get; set; }
		public DbSet<City> Cities { get; set; }
		public DbSet<Country> Countries { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Appointment> Appointments { get; set; }

	}
}
