namespace UserLogin
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textUser = new System.Windows.Forms.TextBox();
			this.textPassword = new System.Windows.Forms.TextBox();
			this.BtnLogin = new System.Windows.Forms.Button();
			this.labelClose = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Location = new System.Drawing.Point(-2, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(254, 397);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.label1.Location = new System.Drawing.Point(309, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "User  login";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(279, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Username";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(280, 198);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Password";
			// 
			// textUser
			// 
			this.textUser.Location = new System.Drawing.Point(283, 158);
			this.textUser.Name = "textUser";
			this.textUser.Size = new System.Drawing.Size(198, 20);
			this.textUser.TabIndex = 4;
			// 
			// textPassword
			// 
			this.textPassword.Location = new System.Drawing.Point(283, 221);
			this.textPassword.Name = "textPassword";
			this.textPassword.Size = new System.Drawing.Size(198, 20);
			this.textPassword.TabIndex = 5;
			// 
			// BtnLogin
			// 
			this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.BtnLogin.Location = new System.Drawing.Point(332, 264);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(99, 40);
			this.BtnLogin.TabIndex = 6;
			this.BtnLogin.Text = "Login";
			this.BtnLogin.UseVisualStyleBackColor = true;
			this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			// 
			// labelClose
			// 
			this.labelClose.AutoSize = true;
			this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelClose.Image = global::UserLogin.Properties.Resources.Close_Window_35px;
			this.labelClose.Location = new System.Drawing.Point(474, 9);
			this.labelClose.Name = "labelClose";
			this.labelClose.Size = new System.Drawing.Size(30, 25);
			this.labelClose.TabIndex = 7;
			this.labelClose.Text = "   ";
			this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 358);
			this.Controls.Add(this.labelClose);
			this.Controls.Add(this.BtnLogin);
			this.Controls.Add(this.textPassword);
			this.Controls.Add(this.textUser);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(523, 397);
			this.MinimumSize = new System.Drawing.Size(523, 397);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textUser;
		private System.Windows.Forms.TextBox textPassword;
		private System.Windows.Forms.Button BtnLogin;
		private System.Windows.Forms.Label labelClose;
	}
}

