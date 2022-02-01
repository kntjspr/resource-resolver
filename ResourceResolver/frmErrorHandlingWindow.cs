using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResourceResolver
{
	public partial class frmErrorHandlingWindow : Form
	{
		public frmErrorHandlingWindow(string message, string detail)
		{
			InitializeComponent();
			txtMessage.Text = message;
			txtDetail.Text = detail;
		}

		private void btnOkay_Click(object sender, EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.OK;
		}

		private void btnCloseApplication_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnRestartApplication_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}
	}
}
