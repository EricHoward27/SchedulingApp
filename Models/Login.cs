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

namespace SchedulingApp.Models
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
			} else
			{
				lblError.Text = Resources.LoginError;
			}
		}

		private bool ValidateUser(string username, string password)
		{
			// mock validation for demostration purposes
			return username == "admin" && password == "password";
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
		}
	}
}
