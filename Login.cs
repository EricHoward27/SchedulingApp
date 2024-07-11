using SchedulingApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SchedulingApp
{
	public partial class Login : Form
	{
		private Label lblUsername;
		private TextBox txtUsername;
		private Label lblPassword;
		private TextBox txtPassword;
		private Button btnLogin;
		private Label lblError;

		public Login()
		{
			InitializeComponents();
			SetLanguage();
			InitializeControls();
		}

		private void SetLanguage()
		{
			var culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
			if (culture == "fr")
			{
				Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
			} else
			{
				Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
			}
		}

		private void InitializeControls()
		{
			this.Text = Resources.LoginLabel;
			lblUsername.Text = Resources.LoginLabel;
			lblPassword.Text = Resources.PasswordLabel;
			btnLogin.Text = Resources.LoginButton;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			var username = txtUsername.Text;
			var password = txtPassword.Text;
			if (ValidateUser(username, password))
			{
				MessageBox.Show("Login successful");
				// Log the login
				LogLogin(username);

				// Open appointment form
				OpenFormsSideBySide();
				this.Hide();

			} else
			{
				lblError.Text = Resources.LoginError;
			}
		}

		private bool ValidateUser(string username, string password)
		{
			using (var context = new ScheduleDbContext())
			{
				var user = context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
				return user != null;
			}
		}

		private void InitializeComponents()
		{
			this.lblUsername = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblError = new System.Windows.Forms.Label();
			this.SuspendLayout();

			//label username
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(12, 15);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(55, 13);
			this.lblUsername.TabIndex = 0;
			this.lblUsername.Text = "Username";

			// txtUsername
			this.txtUsername.Location = new System.Drawing.Point(80, 12);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(192, 20);
			this.txtUsername.TabIndex = 1;

			// lblPassword
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(12, 41);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(53, 13);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Password";

			// txtPassword
			this.txtPassword.Location = new System.Drawing.Point(80, 38);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(192, 20);
			this.txtPassword.TabIndex = 3;

			// btnLogin
			this.btnLogin.Location = new System.Drawing.Point(197, 64);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

			// lblError
			this.lblError.AutoSize = true;
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.Location = new System.Drawing.Point(12, 95);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(0, 13);
			this.lblError.TabIndex = 5;

			// loginform
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 121);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.lblUsername);
			this.Name = "LoginForm";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void OpenFormsSideBySide()
		{
			CustomerForm customerForm = new CustomerForm();
			AppointmentForm appointmentForm = new AppointmentForm();

			// Open the customer form first
			customerForm.StartPosition = FormStartPosition.Manual;
			customerForm.Location = new Point(100, 100); // Set a desired position
			customerForm.Hide();

			// Open the appointment form next to the customer form
			appointmentForm.StartPosition = FormStartPosition.Manual;
			appointmentForm.Location = new Point(customerForm.Location.X + customerForm.Width + 10, customerForm.Location.Y); // Set position relative to customer form
			appointmentForm.Show();
		}

		private void LogLogin(string username)
		{
			// Set the log file path relative to the application's directory
			string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Login_History.txt");
			string logEntry = $"{DateTime.Now}: {username} logged in";

			// Append the log entry to the file
			File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
		}

	}
}
