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
			this.Configuration.LazyLoadingEnabled = false;
		}

		public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
		public DbSet<Country> Countries { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Appointment>().HasRequired(a => a.User).WithMany().HasForeignKey(a => a.UserId).WillCascadeOnDelete(false);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("user");
			modelBuilder.Entity<City>().ToTable("city");
			modelBuilder.Entity<Country>().ToTable("country");
			modelBuilder.Entity<Address>().ToTable("address");
            modelBuilder.Entity<Customer>().ToTable("customer");
            modelBuilder.Entity<Appointment>().ToTable("appointment");

			modelBuilder.Entity<Address>().Property(a => a.AddressId).HasColumnName("addressId");
			modelBuilder.Entity<Address>().Property(a => a.Address1).HasColumnName("address");
			modelBuilder.Entity<Address>().Property(a => a.Address2).HasColumnName("address2");
			modelBuilder.Entity<Address>().Property(a => a.CityId).HasColumnName("cityId");
			modelBuilder.Entity<Address>().Property(a => a.PostalCode).HasColumnName("postalCode");
			modelBuilder.Entity<Address>().Property(a => a.Phone).HasColumnName("phone");
			modelBuilder.Entity<Address>().Property(a => a.CreateDate).HasColumnName("createDate");
			modelBuilder.Entity<Address>().Property(a => a.CreatedBy).HasColumnName("createdBy");
			modelBuilder.Entity<Address>().Property(a => a.LastUpdate).HasColumnName("lastUpdate");
			modelBuilder.Entity<Address>().Property(a => a.LastUpdateBy).HasColumnName("lastUpdateBy");

			// customer
			modelBuilder.Entity<Customer>().Property(c => c.CustomerId).HasColumnName("customerId");
			modelBuilder.Entity<Customer>().Property(c => c.CustomerName).HasColumnName("customerName");
			modelBuilder.Entity<Customer>().Property(c => c.AddressId).HasColumnName("addressId");
			modelBuilder.Entity<Customer>().Property(c => c.Active).HasColumnName("active");
			modelBuilder.Entity<Customer>().Property(c => c.CreateDate).HasColumnName("createDate");
			modelBuilder.Entity<Customer>().Property(c => c.CreatedBy).HasColumnName("createdBy");
			modelBuilder.Entity<Customer>().Property(c => c.LastUpdate).HasColumnName("lastUpdate");

		
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
