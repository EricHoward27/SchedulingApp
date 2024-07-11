using SchedulingApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApp
{
	public partial class AppointmentForm : Form
	{
		private Label lblTitle;
		private TextBox txtTitle;
		private Label lblDescription;
		private TextBox txtDescription;
		private Label lblLocation;
		private TextBox txtLocation;
		private Label lblContact;
		private TextBox txtContact;
		private Label lblUrl;
		private TextBox txtUrl;
		private Label lblAppointmentType;
		private ComboBox cmbAppointmentType;
		private Label lblAppointmentDate;
		private DateTimePicker dtpAppointmentDate;
		private Label lblStartTime;
		private DateTimePicker dtpStartTime;
		private Label lblEndTime;
		private DateTimePicker dtpEndTime;
		private Label lblCustomer;
		private ComboBox cmbCustomer;
		private Button btnAddAppointment;
		private Button btnUpdateAppointment;
		private Button btnDeleteAppointment;
		private MonthCalendar monthCalendar;
		private DataGridView dataGridViewAppointments;
		private RichTextBox richTextBoxLog;
		private Label lblTimeZone;
		private ComboBox cmbTimeZone;

		public AppointmentForm()
		{
			InitializeComponents();
			this.Load += new System.EventHandler(this.Form_Load);
		}

		private void InitializeComponents()
		{
			// Enlarge the form
			this.ClientSize = new System.Drawing.Size(1000, 800);

			// Appointment Title
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(50, 75);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(90, 13);
			this.lblTitle.Text = "Title";

			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtTitle.Location = new System.Drawing.Point(150, 75);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(200, 20);

			// Appointment Description
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(50, 125);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 13);
			this.lblDescription.Text = "Description";

			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtDescription.Location = new System.Drawing.Point(150, 125);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(200, 20);

			// Appointment Location
			this.lblLocation = new System.Windows.Forms.Label();
			this.lblLocation.AutoSize = true;
			this.lblLocation.Location = new System.Drawing.Point(50, 175);
			this.lblLocation.Name = "lblLocation";
			this.lblLocation.Size = new System.Drawing.Size(55, 13);
			this.lblLocation.Text = "Location";

			this.txtLocation = new System.Windows.Forms.TextBox();
			this.txtLocation.Location = new System.Drawing.Point(150, 175);
			this.txtLocation.Name = "txtLocation";
			this.txtLocation.Size = new System.Drawing.Size(200, 20);

			// Appointment Contact
			this.lblContact = new System.Windows.Forms.Label();
			this.lblContact.AutoSize = true;
			this.lblContact.Location = new System.Drawing.Point(50, 225);
			this.lblContact.Name = "lblContact";
			this.lblContact.Size = new System.Drawing.Size(55, 13);
			this.lblContact.Text = "Contact";

			this.txtContact = new System.Windows.Forms.TextBox();
			this.txtContact.Location = new System.Drawing.Point(150, 225);
			this.txtContact.Name = "txtContact";
			this.txtContact.Size = new System.Drawing.Size(200, 20);

			// Appointment URL
			this.lblUrl = new System.Windows.Forms.Label();
			this.lblUrl.AutoSize = true;
			this.lblUrl.Location = new System.Drawing.Point(50, 275);
			this.lblUrl.Name = "lblUrl";
			this.lblUrl.Size = new System.Drawing.Size(55, 13);
			this.lblUrl.Text = "URL";

			this.txtUrl = new System.Windows.Forms.TextBox();
			this.txtUrl.Location = new System.Drawing.Point(150, 275);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(200, 20);

			// Appointment Type
			this.lblAppointmentType = new System.Windows.Forms.Label();
			this.lblAppointmentType.AutoSize = true;
			this.lblAppointmentType.Location = new System.Drawing.Point(50, 325);
			this.lblAppointmentType.Name = "lblAppointmentType";
			this.lblAppointmentType.Size = new System.Drawing.Size(90, 13);
			this.lblAppointmentType.Text = "Appointment Type";

			this.cmbAppointmentType = new System.Windows.Forms.ComboBox();
			this.cmbAppointmentType.Location = new System.Drawing.Point(150, 325);
			this.cmbAppointmentType.Name = "cmbAppointmentType";
			this.cmbAppointmentType.Size = new System.Drawing.Size(200, 20);

			// Appointment Date
			this.lblAppointmentDate = new System.Windows.Forms.Label();
			this.lblAppointmentDate.AutoSize = true;
			this.lblAppointmentDate.Location = new System.Drawing.Point(50, 375);
			this.lblAppointmentDate.Name = "lblAppointmentDate";
			this.lblAppointmentDate.Size = new System.Drawing.Size(93, 13);
			this.lblAppointmentDate.Text = "Appointment Date";

			this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
			this.dtpAppointmentDate.Location = new System.Drawing.Point(150, 375);
			this.dtpAppointmentDate.Name = "dtpAppointmentDate";
			this.dtpAppointmentDate.Size = new System.Drawing.Size(200, 20);

			// Start Time
			this.lblStartTime = new System.Windows.Forms.Label();
			this.lblStartTime.AutoSize = true;
			this.lblStartTime.Location = new System.Drawing.Point(50, 425);
			this.lblStartTime.Name = "lblStartTime";
			this.lblStartTime.Size = new System.Drawing.Size(55, 13);
			this.lblStartTime.Text = "Start Time";

			this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
			this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpStartTime.ShowUpDown = true;
			this.dtpStartTime.Location = new System.Drawing.Point(150, 425);
			this.dtpStartTime.Name = "dtpStartTime";
			this.dtpStartTime.Size = new System.Drawing.Size(200, 20);

			// End Time
			this.lblEndTime = new System.Windows.Forms.Label();
			this.lblEndTime.AutoSize = true;
			this.lblEndTime.Location = new System.Drawing.Point(50, 475);
			this.lblEndTime.Name = "lblEndTime";
			this.lblEndTime.Size = new System.Drawing.Size(52, 13);
			this.lblEndTime.Text = "End Time";

			this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
			this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpEndTime.ShowUpDown = true;
			this.dtpEndTime.Location = new System.Drawing.Point(150, 475);
			this.dtpEndTime.Name = "dtpEndTime";
			this.dtpEndTime.Size = new System.Drawing.Size(200, 20);

			// Customer
			this.lblCustomer = new System.Windows.Forms.Label();
			this.lblCustomer.AutoSize = true;
			this.lblCustomer.Location = new System.Drawing.Point(50, 525);
			this.lblCustomer.Name = "lblCustomer";
			this.lblCustomer.Size = new System.Drawing.Size(51, 13);
			this.lblCustomer.Text = "Customer";

			this.cmbCustomer = new System.Windows.Forms.ComboBox();
			this.cmbCustomer.Location = new System.Drawing.Point(150, 525);
			this.cmbCustomer.Name = "cmbCustomer";
			this.cmbCustomer.Size = new System.Drawing.Size(200, 20);

			// Add Appointment Button
			this.btnAddAppointment = new System.Windows.Forms.Button();
			this.btnAddAppointment.Location = new System.Drawing.Point(150, 600);
			this.btnAddAppointment.Name = "btnAddAppointment";
			this.btnAddAppointment.Size = new System.Drawing.Size(100, 30);
			this.btnAddAppointment.Text = "Add";
			this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);

			// Update Appointment Button
			this.btnUpdateAppointment = new System.Windows.Forms.Button();
			this.btnUpdateAppointment.Location = new System.Drawing.Point(260, 600);
			this.btnUpdateAppointment.Name = "btnUpdateAppointment";
			this.btnUpdateAppointment.Size = new System.Drawing.Size(100, 30);
			this.btnUpdateAppointment.Text = "Update";
			this.btnUpdateAppointment.Click += new System.EventHandler(this.btnUpdateAppointment_Click);

			// Delete Appointment Button
			this.btnDeleteAppointment = new System.Windows.Forms.Button();
			this.btnDeleteAppointment.Location = new System.Drawing.Point(370, 600);
			this.btnDeleteAppointment.Name = "btnDeleteAppointment";
			this.btnDeleteAppointment.Size = new System.Drawing.Size(100, 30);
			this.btnDeleteAppointment.Text = "Delete";
			this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);

			// Calendar View
			this.monthCalendar = new System.Windows.Forms.MonthCalendar();
			this.monthCalendar.Location = new System.Drawing.Point(400,75);
			this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);

			// Appointments DataGridView
			this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
			this.dataGridViewAppointments.Location = new System.Drawing.Point(400, 270);
			this.dataGridViewAppointments.Size = new System.Drawing.Size(550, 300);
			this.dataGridViewAppointments.SelectionChanged += new System.EventHandler(this.dataGridViewAppointments_SelectionChanged);

			// Initialize the RichTextBox for logging
			this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
			this.richTextBoxLog.Location = new System.Drawing.Point(50, 700);
			this.richTextBoxLog.Size = new System.Drawing.Size(900, 100);
			this.richTextBoxLog.ReadOnly = true;



			// Add controls to form
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.lblLocation);
			this.Controls.Add(this.txtLocation);
			this.Controls.Add(this.lblContact);
			this.Controls.Add(this.txtContact);
			this.Controls.Add(this.lblUrl);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.lblAppointmentType);
			this.Controls.Add(this.cmbAppointmentType);
			this.Controls.Add(this.lblAppointmentDate);
			this.Controls.Add(this.dtpAppointmentDate);
			this.Controls.Add(this.lblStartTime);
			this.Controls.Add(this.dtpStartTime);
			this.Controls.Add(this.lblEndTime);
			this.Controls.Add(this.dtpEndTime);
			this.Controls.Add(this.lblCustomer);
			this.Controls.Add(this.cmbCustomer);
			this.Controls.Add(this.btnAddAppointment);
			this.Controls.Add(this.btnUpdateAppointment);
			this.Controls.Add(this.btnDeleteAppointment);
			this.Controls.Add(this.monthCalendar);
			this.Controls.Add(this.dataGridViewAppointments);
			this.Controls.Add(this.richTextBoxLog);
		}
		// Load Appointments
		private void LoadAppointments()
		{
			try
			{
				using (var context = new ScheduleDbContext())
				{
					var appointments = context.Appointments.ToList();
					dataGridViewAppointments.DataSource = appointments;
					dataGridViewAppointments.ClearSelection();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while loading appointments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		// Form Load Event
		private void Form_Load(object sender, EventArgs e)
		{
			LoadCustomersAndAppointmentTypes();
			ShowUpcomingAppointmentAlert();
			LoadAppointments();
			OpenCustomerForm();
			ClearAppointmentFormData();
			dataGridViewAppointments.ClearSelection();
			
		}
		private void dataGridViewAppointments_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewAppointments.CurrentRow != null)
			{
				int appointmentId = Convert.ToInt32(dataGridViewAppointments.CurrentRow.Cells["AppointmentId"].Value);
				using (var context = new ScheduleDbContext())
				{
					var appointment = context.Appointments.FirstOrDefault(a => a.AppointmentId == appointmentId);
					if (appointment != null)
					{
						var customer = context.Customers.FirstOrDefault(c => c.CustomerId == appointment.CustomerId);

						var timeZone = GetLocalTimeZone();

						var start = appointment.Start;

						var end = appointment.End;

						if (timeZone != null)
						{
							start = TimeZoneInfo.ConvertTimeFromUtc(start, timeZone);
							end = TimeZoneInfo.ConvertTimeFromUtc(end, timeZone);
						}

						txtTitle.Text = appointment.Title;
						txtDescription.Text = appointment.Description;
						txtLocation.Text = appointment.Location;
						txtContact.Text = appointment.Contact;
						txtUrl.Text = appointment.Url;
						cmbAppointmentType.SelectedItem = appointment.Type;
						dtpAppointmentDate.Value = appointment.Start.Date;
						dtpStartTime.Value = start;
						dtpEndTime.Value = end;
						cmbCustomer.SelectedValue = appointment.CustomerId;
					}
				}
			}
			else
			{
				ClearAppointmentFormData();
			}
		}

		private void OpenCustomerForm()
		{
			CustomerForm customerForm = new CustomerForm();
			customerForm.CustomerAdded += LoadCustomersAndAppointmentTypes; // Subscribe to the event
			customerForm.Show();
		}


		// Load Customers and Appointment Types
		private void LoadCustomersAndAppointmentTypes()
		{
			try
			{
				using (var context = new ScheduleDbContext())
				{
					var customers = context.Customers.ToList();
					cmbCustomer.DataSource = customers;
					cmbCustomer.DisplayMember = "CustomerName";
					cmbCustomer.ValueMember = "CustomerId";
					cmbCustomer.SelectedIndex = -1;

					var appointmentTypes = new List<string> { "Consultation", "Follow-up", "Routine Check", "Emergency" };
					cmbAppointmentType.DataSource = appointmentTypes;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private TimeZoneInfo GetLocalTimeZone()
		{
			return TimeZoneInfo.Local;
		}

		// Add Appointment Button Click Event
		private void btnAddAppointment_Click(object sender, EventArgs e)
		{
			try
			{
				if (ValidateAppointmentFields(out string errorMessage))
				{
					using (var context = new ScheduleDbContext())
					{
						var startDateTime = dtpAppointmentDate.Value.Date.Add(dtpStartTime.Value.TimeOfDay);
						var endDateTime = dtpAppointmentDate.Value.Date.Add(dtpEndTime.Value.TimeOfDay);
						var timeZone = TimeZoneInfo.Local;

						// Convert to UTC for storage
						var startUtc = TimeZoneInfo.ConvertTimeToUtc(startDateTime, timeZone);
						var endUtc = TimeZoneInfo.ConvertTimeToUtc(endDateTime, timeZone);

						// Debug start and end time
						Debug.WriteLine($"Local Start Time: {startDateTime} | UTC Start Time: {startUtc}");
						Debug.WriteLine($"Local End Time: {endDateTime} | UTC End Time: {endUtc}");

						if (IsWithinBusinessHours(startUtc, endUtc) && !HasOverlappingAppointment(startUtc, endUtc))
						{
							var appointment = new Appointment
							{
								CustomerId = (int)cmbCustomer.SelectedValue,
								Title = txtTitle.Text.Trim(),
								Description = txtDescription.Text.Trim(),
								Location = txtLocation.Text.Trim(),
								Contact = txtContact.Text.Trim(),
								Type = cmbAppointmentType.SelectedItem.ToString(),
								Url = txtUrl.Text.Trim(),
								Start = startUtc,
								End = endUtc,
								CreateDate = DateTime.UtcNow,
								CreatedBy = "Admin",
								LastUpdate = DateTime.UtcNow,
								LastUpdateBy = "Admin"
							};

							context.Appointments.Add(appointment);
							context.SaveChanges();
							LoadAppointments();
							ClearAppointmentFormData(); // Clear form fields after adding appointment
						}
						else
						{
							MessageBox.Show("Appointment time is outside business hours or overlaps with an existing appointment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				else
				{
					MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while adding the appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Update Appointment Button Click Event
		private void btnUpdateAppointment_Click(object sender, EventArgs e)
		{
			try
			{
				if (ValidateAppointmentFields(out string errorMessage))
				{
					using (var context = new ScheduleDbContext())
					{
						int appointmentId = Convert.ToInt32(dataGridViewAppointments.CurrentRow.Cells["AppointmentId"].Value);
						var appointment = context.Appointments.FirstOrDefault(a => a.AppointmentId == appointmentId);

						if (appointment != null)
						{
							var startDateTime = dtpAppointmentDate.Value.Date.Add(dtpStartTime.Value.TimeOfDay);
							var endDateTime = dtpAppointmentDate.Value.Date.Add(dtpEndTime.Value.TimeOfDay);
							var timeZone = TimeZoneInfo.Local;

							// Convert to UTC for storage
							var startUtc = TimeZoneInfo.ConvertTimeToUtc(startDateTime, timeZone);
							var endUtc = TimeZoneInfo.ConvertTimeToUtc(endDateTime, timeZone);

							// Debug start and end time
							Debug.WriteLine($"Local Start Time: {startDateTime} | UTC Start Time: {startUtc}");
							Debug.WriteLine($"Local End Time: {endDateTime} | UTC End Time: {endUtc}");

							if (IsWithinBusinessHours(startUtc, endUtc) && !HasOverlappingAppointment(startUtc, endUtc, appointmentId))
							{
								appointment.CustomerId = (int)cmbCustomer.SelectedValue;
								appointment.Title = txtTitle.Text.Trim();
								appointment.Description = txtDescription.Text.Trim();
								appointment.Location = txtLocation.Text.Trim();
								appointment.Contact = txtContact.Text.Trim();
								appointment.Type = cmbAppointmentType.SelectedItem.ToString();
								appointment.Url = txtUrl.Text.Trim();
								appointment.Start = startUtc;
								appointment.End = endUtc;
								appointment.LastUpdate = DateTime.UtcNow;
								appointment.LastUpdateBy = "Admin";
								context.SaveChanges();
								LoadAppointments();
							}
							else
							{
								MessageBox.Show("Appointment time is outside business hours or overlaps with an existing appointment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}
				}
				else
				{
					MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while updating the appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Validate Appointment Fields
		private bool ValidateAppointmentFields(out string errorMessage)
		{
			errorMessage = string.Empty;

			// Validate appointment time within business hours
			var startDateTime = dtpAppointmentDate.Value.Date.Add(dtpStartTime.Value.TimeOfDay);
			var endDateTime = dtpAppointmentDate.Value.Date.Add(dtpEndTime.Value.TimeOfDay);
			var timeZone = TimeZoneInfo.Local;

			// Convert to UTC for validation
			var startUtc = TimeZoneInfo.ConvertTimeToUtc(startDateTime, timeZone);
			var endUtc = TimeZoneInfo.ConvertTimeToUtc(endDateTime, timeZone);

			if (!IsWithinBusinessHours(startUtc, endUtc))
			{
				errorMessage = "Appointments must be scheduled during business hours (9:00 AM to 5:00 PM, Monday to Friday).";
				return false;
			}

			return true;
		}

		// Check Business Hours in UTC
		private bool IsWithinBusinessHours(DateTime startUtc, DateTime endUtc)
		{
			// Business hours: 9:00 AM to 5:00 PM, Monday to Friday (Eastern Standard Time)
			var est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
			var businessStart = new DateTime(startUtc.Year, startUtc.Month, startUtc.Day, 9, 0, 0, DateTimeKind.Unspecified);
			var businessEnd = new DateTime(startUtc.Year, startUtc.Month, startUtc.Day, 17, 0, 0, DateTimeKind.Unspecified);

			var businessStartUtc = TimeZoneInfo.ConvertTimeToUtc(businessStart, est);
			var businessEndUtc = TimeZoneInfo.ConvertTimeToUtc(businessEnd, est);

			if (startUtc < businessStartUtc || endUtc > businessEndUtc)
			{
				return false;
			}

			// Check if the date is a weekday
			if (startUtc.DayOfWeek == DayOfWeek.Saturday || startUtc.DayOfWeek == DayOfWeek.Sunday)
			{
				return false;
			}

			return true;
		}

		// Overlapping Appointment Check
		private bool HasOverlappingAppointment(DateTime start, DateTime end, int? appointmentId = null)
		{
			using (var context = new ScheduleDbContext())
			{
				var overlappingAppointments = context.Appointments
					.Where(a => a.Start < end && start < a.End);

				if (appointmentId.HasValue)
				{
					overlappingAppointments = overlappingAppointments.Where(a => a.AppointmentId != appointmentId.Value);
				}

				return overlappingAppointments.Any();
			}
		}

		// Delete Appointment Button Click Event
		private void btnDeleteAppointment_Click(object sender, EventArgs e)
		{
			try
			{
				using (var context = new ScheduleDbContext())
				{
					int appointmentId = Convert.ToInt32(dataGridViewAppointments.CurrentRow.Cells["AppointmentId"].Value);
					var appointment = context.Appointments.FirstOrDefault(a => a.AppointmentId == appointmentId);

					if (appointment != null)
					{
						context.Appointments.Remove(appointment);
						context.SaveChanges();
						LoadAppointments();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while deleting the appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
		{
			try
			{
				using (var context = new ScheduleDbContext())
				{
					var selectedDate = e.Start.Date;
					var nextDate = selectedDate.AddDays(1);
					LogMessage($"Selected Date: {selectedDate}");

					var appointments = context.Appointments
						.Where(a => a.Start >= selectedDate && a.Start < nextDate)
						.ToList();

					LogMessage($"Appointments Count: {appointments.Count}");
					dataGridViewAppointments.DataSource = appointments;
				}
			}
			catch (Exception ex)
			{
				var innerExceptionMessage = ex.InnerException != null ? ex.InnerException.Message : string.Empty;
				LogMessage($"Error: {ex.Message}\n{innerExceptionMessage}");
				MessageBox.Show($"An error occurred while loading appointments for the selected date: {ex.Message}\n{innerExceptionMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Clear Appointment Fields
		private void ClearAppointmentFormData()
		{
			txtTitle.Text = string.Empty;
			txtDescription.Text = string.Empty;
			txtLocation.Text = string.Empty;
			txtContact.Text = string.Empty;
			txtUrl.Text = string.Empty;
			cmbAppointmentType.SelectedIndex = -1;
			dtpAppointmentDate.Value = DateTime.Today;
			dtpStartTime.Value = DateTime.Now;
			dtpEndTime.Value = DateTime.Now;
			cmbCustomer.SelectedIndex = -1;
		}

		private void LogMessage(string message)
		{
			richTextBoxLog.AppendText(message + Environment.NewLine);
		}

		// Method to check for upcoming appointments and alert the user
		private void ShowUpcomingAppointmentAlert()
		{
			try
			{
				using (var context = new ScheduleDbContext())
				{
					var currentTimeUtc = DateTime.UtcNow;
					var upcomingTimeLocal = currentTimeUtc.AddMinutes(15);

					var upcomingAppointments = context.Appointments
						.Where(a => a.Start >= currentTimeUtc && a.Start <= upcomingTimeLocal)
						.ToList();

					if (upcomingAppointments.Any())
					{
						MessageBox.Show("You have an appointment within the next 15 minutes.", "Upcoming Appointment Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				LogMessage($"Error in ShowUpcomingAppointmentAlert: {ex.Message}");
				MessageBox.Show($"An error occurred while checking for upcoming appointments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}
