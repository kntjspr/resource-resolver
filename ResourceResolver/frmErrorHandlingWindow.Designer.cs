namespace ResourceResolver
{
	partial class frmErrorHandlingWindow
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.txtDetail = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnOkay = new System.Windows.Forms.Button();
			this.btnCloseApplication = new System.Windows.Forms.Button();
			this.btnRestartApplication = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(514, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Unhandled Exception Occured";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(5, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Error";
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(82, 43);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(420, 20);
			this.txtMessage.TabIndex = 2;
			// 
			// txtDetail
			// 
			this.txtDetail.Location = new System.Drawing.Point(82, 69);
			this.txtDetail.Multiline = true;
			this.txtDetail.Name = "txtDetail";
			this.txtDetail.Size = new System.Drawing.Size(420, 256);
			this.txtDetail.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(5, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Error Detail";
			// 
			// btnOkay
			// 
			this.btnOkay.Location = new System.Drawing.Point(179, 329);
			this.btnOkay.Name = "btnOkay";
			this.btnOkay.Size = new System.Drawing.Size(105, 23);
			this.btnOkay.TabIndex = 5;
			this.btnOkay.Text = "OK";
			this.btnOkay.UseVisualStyleBackColor = true;
			this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
			// 
			// btnCloseApplication
			// 
			this.btnCloseApplication.Location = new System.Drawing.Point(290, 329);
			this.btnCloseApplication.Name = "btnCloseApplication";
			this.btnCloseApplication.Size = new System.Drawing.Size(105, 23);
			this.btnCloseApplication.TabIndex = 6;
			this.btnCloseApplication.Text = "Close Application";
			this.btnCloseApplication.UseVisualStyleBackColor = true;
			this.btnCloseApplication.Click += new System.EventHandler(this.btnCloseApplication_Click);
			// 
			// btnRestartApplication
			// 
			this.btnRestartApplication.Location = new System.Drawing.Point(397, 329);
			this.btnRestartApplication.Name = "btnRestartApplication";
			this.btnRestartApplication.Size = new System.Drawing.Size(105, 23);
			this.btnRestartApplication.TabIndex = 7;
			this.btnRestartApplication.Text = "Restart Application";
			this.btnRestartApplication.UseVisualStyleBackColor = true;
			this.btnRestartApplication.Click += new System.EventHandler(this.btnRestartApplication_Click);
			// 
			// frmErrorHandlingWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 353);
			this.ControlBox = false;
			this.Controls.Add(this.btnRestartApplication);
			this.Controls.Add(this.btnCloseApplication);
			this.Controls.Add(this.btnOkay);
			this.Controls.Add(this.txtDetail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frmErrorHandlingWindow";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Unhandled Exception";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.TextBox txtDetail;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnOkay;
		private System.Windows.Forms.Button btnCloseApplication;
		private System.Windows.Forms.Button btnRestartApplication;
	}
}