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
	public partial class CreateUserForm : Form
	{
		private Label lblUsername;
		private TextBox txtUsername;
		private Label lblPassword;
		private TextBox txtPassword;
		private Button btnCreate;
		private Label lblMessage;

		public CreateUserForm()
		{
			InitializeComponents();
		}
		private void InitializeComponents()
		{
			this.lblUsername = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.lblMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(12, 15);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(55, 13);
			this.lblUsername.TabIndex = 0;
			this.lblUsername.Text = "Username";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(80, 12);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(192, 20);
			this.txtUsername.TabIndex = 1;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(12, 41);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(53, 13);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Password";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(80, 38);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(192, 20);
			this.txtPassword.TabIndex = 3;
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(197, 64);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 4;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.ForeColor = System.Drawing.Color.Red;
			this.lblMessage.Location = new System.Drawing.Point(12, 100);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(0, 13);
			this.lblMessage.TabIndex = 5;
			// 
			// CreateUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 121);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.lblUsername);
			this.Name = "CreateUserForm";
			this.Text = "Create User";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			var username = txtUsername.Text;
			var password = txtPassword.Text;

			using (var context = new ScheduleDbContext())
			{
				if (context.Users.Any(u => u.UserName == username))
				{
					lblMessage.Text = "Username already exists.";
				}
				else
				{
					var user = new User
					{
						UserName = username,
						Password = password,
						Active = true,
						CreateDate = DateTime.Now,
						CreatedBy = "system",
						LastUpdate = DateTime.Now,
						LastUpdateBy = "system"
					};

					context.Users.Add(user);
					context.SaveChanges();

					MessageBox.Show("User created successfully.");
					this.Close();
				}
			}
		}

	}
}
