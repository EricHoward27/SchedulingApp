﻿using SchedulingApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApp
{
	public partial class CustomerForm : Form
	{
		private Label lblCustomerName;
		private TextBox txtCustomerName;
		private Label lblCustomerAddress;
		private TextBox txtCustomerAddress;
		private Label lblAddressLine1;
		private TextBox txtAddressLine1;
		private Label lblAddressLine2;
		private TextBox txtAddressLine2;
		private Label lblCity;
		private ComboBox cmbCity;
		private Label lblPostalCode;
		private TextBox txtPostalCode;
		private Label lblPhone;
		private TextBox txtPhone;
		private Label lblCustomerPhone;
		private TextBox txtCustomerPhone;
		private Button btnAddCustomer;
		private Button btnUpdateCustomer;
		private Button btnDeleteCustomer;
		private DataGridView dataGridViewCustomers;
		private Label lblError;
		public CustomerForm()
		{
			InitializeComponents();
			LoadCustomers();
		}

		private void InitializeComponents()
		{
			this.lblCustomerName = new Label();
			this.txtCustomerName = new TextBox();
			this.lblAddressLine1 = new Label();
			this.txtAddressLine1 = new TextBox();
			this.lblAddressLine2 = new Label();
			this.txtAddressLine2 = new TextBox();
			this.lblCity = new Label();
			this.cmbCity = new ComboBox();
			this.lblPostalCode = new Label();
			this.txtPostalCode = new TextBox();
			this.lblPhone = new Label();
			this.txtPhone = new TextBox();
			this.btnAddCustomer = new Button();
			this.btnUpdateCustomer = new Button();
			this.btnDeleteCustomer = new Button();
			this.dataGridViewCustomers = new DataGridView();
			this.lblError = new Label();

			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
			this.SuspendLayout();

			// lblCustomerName
			this.lblCustomerName.AutoSize = true;
			this.lblCustomerName.Location = new System.Drawing.Point(12, 15);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
			this.lblCustomerName.TabIndex = 0;
			this.lblCustomerName.Text = "Customer Name";

			// txtCustomerName
			this.txtCustomerName.Location = new System.Drawing.Point(80, 12);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(192, 20);
			this.txtCustomerName.TabIndex = 1;

			// lblCustomerAddress and txtCustomerAddress
			this.lblAddressLine1.AutoSize = true;
			this.lblAddressLine1.Location = new System.Drawing.Point(12, 42);
			this.lblAddressLine1.Name = "lblAddressLine1";
			this.lblAddressLine1.Size = new System.Drawing.Size(45, 13);
			this.lblAddressLine1.TabIndex = 2;
			this.lblAddressLine1.Text = "Address Line 1";

			this.txtAddressLine1.Location = new System.Drawing.Point(80, 39);
			this.txtAddressLine1.Name = "txtAddressLine1";
			this.txtAddressLine1.Size = new System.Drawing.Size(192, 20);
			this.txtAddressLine1.TabIndex = 3;

			this.lblAddressLine2.AutoSize = true;
			this.lblAddressLine2.Location = new System.Drawing.Point(12, 68);
			this.lblAddressLine2.Name = "lblAddressLine2";
			this.lblAddressLine2.Size = new System.Drawing.Size(45, 13);
			this.lblAddressLine2.TabIndex = 4;
			this.lblAddressLine2.Text = "Address Line 2";

			this.txtAddressLine2.Location = new System.Drawing.Point(80, 65);
			this.txtAddressLine2.Name = "txtAddressLine2";
			this.txtAddressLine2.Size = new System.Drawing.Size(192, 20);
			this.txtAddressLine2.TabIndex = 5;

			this.lblCity.AutoSize = true;
			this.lblCity.Location = new System.Drawing.Point(12, 94);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(26, 13);
			this.lblCity.TabIndex = 6;
			this.lblCity.Text = "City";

			this.cmbCity.Location = new System.Drawing.Point(80, 91);
			this.cmbCity.Name = "cmbCity";
			this.cmbCity.Size = new System.Drawing.Size(192, 20);
			this.cmbCity.TabIndex = 7;

			this.lblPostalCode.AutoSize = true;
			this.lblPostalCode.Location = new System.Drawing.Point(12, 120);
			this.lblPostalCode.Name = "lblPostalCode";
			this.lblPostalCode.Size = new System.Drawing.Size(67, 13);
			this.lblPostalCode.TabIndex = 8;
			this.lblPostalCode.Text = "Postal Code";

			this.txtPostalCode.Location = new System.Drawing.Point(80, 117);
			this.txtPostalCode.Name = "txtPostalCode";
			this.txtPostalCode.Size = new System.Drawing.Size(192, 20);
			this.txtPostalCode.TabIndex = 9;

			this.lblPhone.AutoSize = true;
			this.lblPhone.Location = new System.Drawing.Point(12, 146);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(38, 13);
			this.lblPhone.TabIndex = 10;
			this.lblPhone.Text = "Phone";

			this.txtPhone.Location = new System.Drawing.Point(80, 143);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(192, 20);
			this.txtPhone.TabIndex = 11;

			//btnAddCustomer
			this.btnAddCustomer.Location = new System.Drawing.Point(15, 170);
			this.btnAddCustomer.Name = "btnAddCustomer";
			this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
			this.btnAddCustomer.TabIndex = 6;
			this.btnAddCustomer.Text = "Add";
			this.btnAddCustomer.UseVisualStyleBackColor = true;
			this.btnAddCustomer.Click += new EventHandler(this.btnAddCustomer_Click);

			//btnUpdateCustomer
			this.btnUpdateCustomer.Location = new System.Drawing.Point(100, 170);
			this.btnUpdateCustomer.Name = "btnUpdateCustomer";
			this.btnUpdateCustomer.Size = new System.Drawing.Size(75, 23);
			this.btnUpdateCustomer.TabIndex = 7;
			this.btnUpdateCustomer.Text = "Update";
			this.btnUpdateCustomer.UseVisualStyleBackColor = true;
			this.btnUpdateCustomer.Click += new EventHandler(this.btnUpdateCustomer_Click);

			//btnDeleteCustomer
			this.btnDeleteCustomer.Location = new System.Drawing.Point(190, 170);
			this.btnDeleteCustomer.Name = "btnDeleteCustomer";
			this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteCustomer.TabIndex = 8;
			this.btnDeleteCustomer.Text = "Delete";
			this.btnDeleteCustomer.UseVisualStyleBackColor = true;
			this.btnDeleteCustomer.Click += new EventHandler(this.btnDeleteCustomer_Click);

			//dataGridViewCustomers
			this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCustomers.Location = new System.Drawing.Point(15, 200);
			this.dataGridViewCustomers.Name = "dataGridViewCustomers";
			this.dataGridViewCustomers.Size = new System.Drawing.Size(400, 200);
			this.dataGridViewCustomers.TabIndex = 9;
			this.dataGridViewCustomers.SelectionChanged += new EventHandler(this.dataGridViewCustomers_SelectionChanged);

			// lblError
			this.lblError.AutoSize = true;
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.Location = new System.Drawing.Point(12, 330);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(0, 13);
			this.lblError.TabIndex = 10;

			// CustomerForm
			this.ClientSize = new System.Drawing.Size(450, 360);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.dataGridViewCustomers);
			this.Controls.Add(this.btnDeleteCustomer);
			this.Controls.Add(this.btnUpdateCustomer);
			this.Controls.Add(this.btnAddCustomer);
			this.Controls.Add(this.lblAddressLine1);
			this.Controls.Add(this.txtAddressLine1);
			this.Controls.Add(this.lblAddressLine2);
			this.Controls.Add(this.txtAddressLine2);
			this.Controls.Add(this.lblCity);
			this.Controls.Add(this.cmbCity);
			this.Controls.Add(this.lblPostalCode);
			this.Controls.Add(this.txtPostalCode);
			this.Controls.Add(this.lblPhone);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.lblCustomerName);
			this.Name = "CustomerForm";
			this.Text = "Customer Management";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		// bind data grid view to text boxes
		private void dataGridViewCustomers_SelectionChanged(object sender, EventArgs e)
		{
			if(dataGridViewCustomers.CurrentRow != null)
			{
				int customerId = Convert.ToInt32(dataGridViewCustomers.CurrentRow.Cells["CustomerId"].Value);
				using (var context = new ScheduleDbContext())
				{
					var customer = context.Customers.Include("Address").FirstOrDefault(c => c.CustomerId == customerId);
					if (customer != null)
					{
						txtCustomerName.Text = customer.CustomerName;
						txtAddressLine1.Text = customer.Address.Address1;
						txtAddressLine2.Text = customer.Address.Address2;
						cmbCity.SelectedValue = customer.Address.CityId;
						txtPostalCode.Text = customer.Address.PostalCode;
						txtPhone.Text = customer.Address.Phone;
					}
				}
			}
		}

		// load customers into the data grid view
		private void LoadCustomers()
		{
			try
			{
				using (var context = new ScheduleDbContext())
				{
					dataGridViewCustomers.DataSource = context.Customers.ToList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while loading customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// load cities into the combo box
		private void LoadCities()
		{
			try
			{
				using(var context = new ScheduleDbContext())
				{
					var cities = context.Cities.ToList();
					cmbCity.DataSource = cities;
					cmbCity.DisplayMember = "City";
					cmbCity.ValueMember = "CityId";
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show($"An error occurred while loading cities: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		// validation for customer form
		private bool ValidateCustomerFields(out string errorMessage)
		{
			errorMessage = string.Empty;

			if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
			{
				errorMessage = "Customer name cannot be empty.";
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtAddressLine1.Text))
			{
				errorMessage = "Address Line 1 cannot be empty.";
				return false;
			}

			if (cmbCity.SelectedValue == null)
			{
				errorMessage = "City must be selected.";
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtPostalCode.Text))
			{
				errorMessage = "Postal code cannot be empty.";
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtPhone.Text))
			{
				errorMessage = "Phone number cannot be empty.";
				return false;
			}

			foreach (char c in txtPhone.Text)
			{
				if (!char.IsDigit(c) && c != '-')
				{
					errorMessage = "Phone number can only contain digits and dashes.";
					return false;
				}
			}

			return true;
		}

		// add customer button click event
		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			try
			{
				if(ValidateCustomerFields(out string errorMessage))
				{
					using (var context = new ScheduleDbContext())
					{
						var address = new Address
						{
							Address1 = txtAddressLine1.Text.Trim(),
							Address2 = txtAddressLine2.Text.Trim(),
							CityId = (int)cmbCity.SelectedValue,
							PostalCode = txtPostalCode.Text.Trim(),
							Phone = txtPhone.Text.Trim(),
							CreateDate = DateTime.Now,
							CreatedBy = "Admin",
							LastUpdate = DateTime.Now,
							LastUpdateBy = "Admin"
						};
						context.Addresses.Add(address);
						context.SaveChanges();


						var customer = new Customer
						{
							CustomerName = txtCustomerName.Text.Trim(),
							AddressId = 1,
							Active = true,
							CreateDate = DateTime.Now,
							CreatedBy = "Admin",
							LastUpdate = DateTime.Now,
							LastUpdateBy = "Admin"
						};
						context.Customers.Add(customer);
						context.SaveChanges();
						LoadCustomers();
					}
				}
				else
				{
					MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show($"An error occurred while adding the customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// update customer button click event
		private void btnUpdateCustomer_Click(object sender, EventArgs e)
		{
			try
			{
				if(ValidateCustomerFields(out string errorMessage))
				{
					using (var context = new ScheduleDbContext())
					{
						int customerId = Convert.ToInt32(dataGridViewCustomers.CurrentRow.Cells["CustomerId"].Value);
						var customer = context.Customers.FirstOrDefault(c => c.CustomerId == customerId);

						if(customer != null)
						{
							customer.CustomerName = txtCustomerName.Text.Trim();
							customer.LastUpdate = DateTime.Now;
							customer.LastUpdateBy = "Admin";
							context.SaveChanges();
							LoadCustomers();
						}
					}
				}
				else
				{
					MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show($"An error occurred while updating the customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// delete customer button click event
		private void btnDeleteCustomer_Click(object sender, EventArgs e)
		{
			try
			{
				using (var context = new ScheduleDbContext())
				{
					int customerId = Convert.ToInt32(dataGridViewCustomers.CurrentRow.Cells["CustomerId"].Value);
					var customer = context.Customers.FirstOrDefault(c => c.CustomerId == customerId);

					if(customer != null)
					{
						context.Customers.Remove(customer);
						context.SaveChanges();
						LoadCustomers();
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show($"An error occurred while deleting the customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// form load event
		private void CustomerForm_Load(object sender, EventArgs e)
		{
			LoadCustomers();
			LoadCities();
		}
	}
}
