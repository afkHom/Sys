namespace WindowsFormsApp1
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
			this.btn_Open1 = new System.Windows.Forms.Button();
			this.lbl_openbuttontext = new System.Windows.Forms.Label();
			this.cb_Test1 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btn_Open1
			// 
			this.btn_Open1.Location = new System.Drawing.Point(43, 52);
			this.btn_Open1.Name = "btn_Open1";
			this.btn_Open1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Open1.Size = new System.Drawing.Size(75, 23);
			this.btn_Open1.TabIndex = 0;
			this.btn_Open1.Text = "Open";
			this.btn_Open1.UseVisualStyleBackColor = true;
			this.btn_Open1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lbl_openbuttontext
			// 
			this.lbl_openbuttontext.AutoSize = true;
			this.lbl_openbuttontext.Location = new System.Drawing.Point(12, 36);
			this.lbl_openbuttontext.Name = "lbl_openbuttontext";
			this.lbl_openbuttontext.Size = new System.Drawing.Size(129, 13);
			this.lbl_openbuttontext.TabIndex = 1;
			this.lbl_openbuttontext.Text = "This Button Does Nothing";
			// 
			// cb_Test1
			// 
			this.cb_Test1.AutoSize = true;
			this.cb_Test1.Location = new System.Drawing.Point(925, 56);
			this.cb_Test1.Name = "cb_Test1";
			this.cb_Test1.Size = new System.Drawing.Size(78, 17);
			this.cb_Test1.TabIndex = 2;
			this.cb_Test1.Text = "TestCheck";
			this.cb_Test1.UseVisualStyleBackColor = true;
			this.cb_Test1.CheckedChanged += new System.EventHandler(this.cb_Test1_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1017, 582);
			this.Controls.Add(this.cb_Test1);
			this.Controls.Add(this.lbl_openbuttontext);
			this.Controls.Add(this.btn_Open1);
			this.Name = "Form1";
			this.Text = "Test(Github:AfkHom)";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Open1;
		private System.Windows.Forms.Label lbl_openbuttontext;
		private System.Windows.Forms.CheckBox cb_Test1;
	}
}

