using System;
using System.Windows.Forms;

namespace TXTextControl.Words {
	internal static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
			Application.ThreadException += MainWindow.Application_ThreadException;
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow());
		}
	}
}
