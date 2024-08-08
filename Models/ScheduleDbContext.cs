using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchedulingApp.Models.Report;

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("user");
			modelBuilder.Entity<City>().ToTable("city");
			modelBuilder.Entity<Country>().ToTable("country");
            modelBuilder.Entity<Address>().ToTable("address");
            modelBuilder.Entity<Customer>().ToTable("customer");
            modelBuilder.Entity<Appointment>().ToTable("appointment");
        }
        //report for the num of appointments types by month
        public List<AppointmentReport> GetAppointmentTypesByMonth()
		{
			var appointments = Appointments.ToList(); // Fetch all appointments to memory

			var query = appointments
				.GroupBy(a => new { a.Type, Month = a.Start.Month })
				.Select(g => new AppointmentReport
				{
					AppointmentType = g.Key.Type,
					Month = g.Key.Month,
					Count = g.Count()
				})
				.ToList();

			return query;
		}
		// report for the schedule of each user
		public List<UserScheduleReport> GetUserSchedules()
		{
			return Users
				.Select(u => new UserScheduleReport
				{
					UserId = u.UserId,
					UserName = u.UserName,
					Appointments = Appointments.Where(a => a.UserId == u.UserId).ToList()
				})
				.ToList();
		}

		// report for num of appointments per customer
		public List<CustomerReport> GetCustomerAppointments()
		{
			return Customers
				.Select(c => new CustomerReport
				{
					CustomerId = c.CustomerId,
					CustomerName = c.CustomerName,
					AppointmentCount = Appointments.Count(a => a.CustomerId == c.CustomerId)
				})
				.ToList();
		}

	}
}
