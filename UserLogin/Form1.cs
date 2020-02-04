using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLogin
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			textPassword.PasswordChar = '*';


		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			string username = textUser.Text;
		string password = textPassword.Text;
			if ((username == "Madhushanka") && (password == "madda"))
			{
				MessageBox.Show("Login Successfully");
				Form2 f2 = new Form2();
				f2.Show();
				this.Hide();

			}
			else
			{
				MessageBox.Show("Enter Correct Username and Password");
			}
		}

		private void labelClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
