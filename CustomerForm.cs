using SchedulingApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
			this.lblCustomerAddress = new Label();
			this.txtCustomerAddress = new TextBox();
			this.lblCustomerPhone = new Label();
			this.txtCustomerPhone = new TextBox();
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
			this.txtCustomerName.Location = new System.Drawing.Point(100, 12);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(192, 20);
			this.txtCustomerName.TabIndex = 1;

			// lblCustomerAddress
			this.lblCustomerAddress.AutoSize = true;
			this.lblCustomerAddress.Location = new System.Drawing.Point(12, 41);
			this.lblCustomerAddress.Name = "lblCustomerAddress";
			this.lblCustomerAddress.Size = new System.Drawing.Size(45, 13);
			this.lblCustomerAddress.TabIndex = 2;
			this.lblCustomerAddress.Text = "Address";

			// txtCustomerAddress
			this.txtCustomerAddress.Location = new System.Drawing.Point(100, 38);
			this.txtCustomerAddress.Name = "txtCustomerAddress";
			this.txtCustomerAddress.Size = new System.Drawing.Size(192, 20);
			this.txtCustomerAddress.TabIndex = 3;

			// lblCustomerPhone
			this.lblCustomerPhone.AutoSize = true;
			this.lblCustomerPhone.Location = new System.Drawing.Point(12, 67);
			this.lblCustomerPhone.Name = "lblCustomerPhone";
			this.lblCustomerPhone.Size = new System.Drawing.Size(78, 13);
			this.lblCustomerPhone.TabIndex = 4;
			this.lblCustomerPhone.Text = "Phone Number";

			// txtCustomerPhone
			this.txtCustomerPhone.Location = new System.Drawing.Point(100, 64);
			this.txtCustomerPhone.Name = "txtCustomerPhone";
			this.txtCustomerPhone.Size = new System.Drawing.Size(192, 20);
			this.txtCustomerPhone.TabIndex = 5;

			//btnAddCustomer
			this.btnAddCustomer.Location = new System.Drawing.Point(15, 90);
			this.btnAddCustomer.Name = "btnAddCustomer";
			this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
			this.btnAddCustomer.TabIndex = 6;
			this.btnAddCustomer.Text = "Add";
			this.btnAddCustomer.UseVisualStyleBackColor = true;
			this.btnAddCustomer.Click += new EventHandler(this.btnAddCustomer_Click);

			//btnUpdateCustomer
			this.btnUpdateCustomer.Location = new System.Drawing.Point(100, 90);
			this.btnUpdateCustomer.Name = "btnUpdateCustomer";
			this.btnUpdateCustomer.Size = new System.Drawing.Size(75, 23);
			this.btnUpdateCustomer.TabIndex = 7;
			this.btnUpdateCustomer.Text = "Update";
			this.btnUpdateCustomer.UseVisualStyleBackColor = true;
			this.btnUpdateCustomer.Click += new EventHandler(this.btnUpdateCustomer_Click);

			//btnDeleteCustomer
			this.btnDeleteCustomer.Location = new System.Drawing.Point(190, 90);
			this.btnDeleteCustomer.Name = "btnDeleteCustomer";
			this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteCustomer.TabIndex = 8;
			this.btnDeleteCustomer.Text = "Delete";
			this.btnDeleteCustomer.UseVisualStyleBackColor = true;
			this.btnDeleteCustomer.Click += new EventHandler(this.btnDeleteCustomer_Click);

			//dataGridViewCustomers
			this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCustomers.Location = new System.Drawing.Point(15, 120);
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
			this.Controls.Add(this.txtCustomerPhone);
			this.Controls.Add(this.lblCustomerPhone);
			this.Controls.Add(this.txtCustomerAddress);
			this.Controls.Add(this.lblCustomerAddress);
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
				txtCustomerName.Text = dataGridViewCustomers.CurrentRow.Cells["CustomerName"].Value.ToString();
				txtCustomerAddress.Text = dataGridViewCustomers.CurrentRow.Cells["Address"].Value.ToString();
				txtCustomerPhone.Text = dataGridViewCustomers.CurrentRow.Cells["Phone"].Value.ToString();
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



		// validation for customer form
		private bool ValidateCustomerFields(out string errorMessage)
		{
			errorMessage = string.Empty;

			if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
			{
				errorMessage = "Customer name cannot be empty";
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtCustomerAddress.Text))
			{
				errorMessage = "Customer address cannot be empty";
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtCustomerPhone.Text))
			{
				errorMessage = "Customer phone cannot be empty";
				return false;
			}
			
			foreach(char c in txtCustomerPhone.Text)
			{
				if(!char.IsDigit(c) && c!= '-')
				{
					errorMessage = "Phone number can only contain digits and dashes";
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
		}
	}
}
