﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MailMerge_Nested_Blocks {
	internal static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
