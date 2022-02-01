using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ResourceResolver
{
	public class ErrorHandlingService : ICustomService
	{
		#region Methods
		public void Register()
		{
			Application.ThreadException += new ThreadExceptionEventHandler(
				ApplicationThreadExceptionOccurs);
			AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(
				DomainUnhandledException);
		}

		public void ApplicationThreadExceptionOccurs(object sender, ThreadExceptionEventArgs e)
		{
			OnErrorOccured(e.Exception.Message, GetMessage(e.Exception));
		}

		private void OnErrorOccured(string message, string detail)
		{
			using (frmErrorHandlingWindow dialog = new frmErrorHandlingWindow(message, detail))
			{
				dialog.ShowDialog();
			}
		}

		public void DomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			Exception exp = e.ExceptionObject as Exception;
			OnErrorOccured(exp.Message, GetMessage(exp));
		}

		private string GetMessage(Exception exp)
		{
			string message = string.Empty;
			if (exp != null)
			{
				while (true)
				{
					message += "$" + exp.Message;
					message += "#" + exp.StackTrace;
					if (exp.InnerException != null)
						exp = exp.InnerException;
					else
						break;
				}
			}

			return message;
		}

		public void DeRegister()
		{
			Application.ThreadException -= new ThreadExceptionEventHandler(
				ApplicationThreadExceptionOccurs);
			AppDomain.CurrentDomain.UnhandledException -= new UnhandledExceptionEventHandler(
				DomainUnhandledException);

			GC.SuppressFinalize(this);
		}
		#endregion
	}
}
