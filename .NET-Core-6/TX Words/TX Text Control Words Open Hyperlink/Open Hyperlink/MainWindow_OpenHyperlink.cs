/*-------------------------------------------------------------------------------------------------------------
** MainWindow_OpenHyperlink.cs File
**
** Description:
**     Handles opening a hyperlink
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace TXTextControl.Words {
	partial class MainWindow {

		/*-------------------------------------------------------------------------------------------------------------
        ** H A N D L E R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** TextControl_HypertextLinkClicked Handler
		** Open the hypertext link.
		**-----------------------------------------------------------------------------------------------------------*/
		private void TextControl_HypertextLinkClicked(object sender, HypertextLinkEventArgs e) {
			OpenHyperlink(e.HypertextLink.Target);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** MainWindow_OpenHyperlink_Load Handler
		** If the clicked link is a document file, the file path is added as Process.StartInfo argument of a new 
		** instance. When the new instance is loaded, the corresponding file is opened.
		**-----------------------------------------------------------------------------------------------------------*/
		private void MainWindow_OpenHyperlink_Load(object sender, EventArgs e) {
			// Load file provided as a command line argument
			string[] rstrArgs = Environment.GetCommandLineArgs();
			if (rstrArgs.Length > 1) {
				string strFile = rstrArgs[1];
				if (File.Exists(strFile)) {
					Open(strFile);
				}
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** TextControl_DocumentLinkClicked Handler
		** Scroll to the linked document target.
		**-----------------------------------------------------------------------------------------------------------*/
		private void TextControl_DocumentLinkClicked(object sender, DocumentLinkEventArgs e) {
			DocumentTarget dtTarget = e.DocumentLink.DocumentTarget;
			if (dtTarget != null &&
				// TextControl scrolls automatically to TOC targets
				// when pressing the Ctrl key and clicking the link.
				dtTarget.AutoGenerationType!=AutoGenerationType.TableOfContents) { 
				dtTarget.ScrollTo();
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** M E T H O D S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** SetOpenHyperlinkBehavior Method
        ** Adds all necessary handlers to implement an open hyperlink behavior.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SetOpenHyperlinkBehavior() {
			// Open Hyperlink on click:
			m_txTextControl.HypertextLinkClicked += TextControl_HypertextLinkClicked; // Opens the hyperlink when clicked.
			m_txTextControl.DocumentLinkClicked += TextControl_DocumentLinkClicked; // Scroll to the document target when clicked.
			this.Load += MainWindow_OpenHyperlink_Load; // Loads a linked file.
		}


		/*-------------------------------------------------------------------------------------------------------------
		** OpenHyperlink Method
		** Open a new application instance if the hyperlink links a document. Open an internet browser if the hyperlink
		** links to an http address.
		**
		** Parameters:
		**		hypertextLinkTarget:	The link to the http address or document that should be opened.
		**-----------------------------------------------------------------------------------------------------------*/
		private void OpenHyperlink(string hypertextLinkTarget) {
			if (!string.IsNullOrEmpty(hypertextLinkTarget)) {
				try {
					// Create a Uri to determine the type of the linked target. 
					Uri uriTarget;
					if ((Uri.TryCreate(hypertextLinkTarget, UriKind.RelativeOrAbsolute, out uriTarget) && uriTarget.IsAbsoluteUri) ||
						Uri.TryCreate(Path.GetFullPath(hypertextLinkTarget), UriKind.RelativeOrAbsolute, out uriTarget) // Handle relative file paths
						) {
						// Check whether the specified Uri is a file
						if (uriTarget.IsFile) {
							// Open the file by a type-corresponding application.
							OpenFile(uriTarget);
						}
						else {
							// If it is not a file, the local system decides how to open the linked target. 
							Process.Start(new ProcessStartInfo(uriTarget.AbsoluteUri) { UseShellExecute = true });
						}
					}
					return;
				} catch { }
			}
			// Inform the user if something went wrong.
			MessageBox.Show(this, 
				string.Format(Properties.Resources.MessageBox_OpenHyperlink_CouldNotOpenLink_Text, hypertextLinkTarget), 
				Properties.Resources.MessageBox_OpenHyperlink_CouldNotOpenLink_Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** OpenFile Method
        ** Open the file that is linked by the specified uri.
        **
        ** Parameters:
        **		fileTarget: The uri that specifies the file to open.
        **-----------------------------------------------------------------------------------------------------------*/
		private void OpenFile(Uri fileTarget) {
			string strFileToOpen = fileTarget.LocalPath;

			// Remove internal links inside the target document.
			int iPos = strFileToOpen.IndexOf("#");
			if (iPos != -1) {
				strFileToOpen = strFileToOpen.Substring(0, iPos);
			}

			// Check whether the specified file exists.
			if (!File.Exists(strFileToOpen)) {
				MessageBox.Show(this, string.Format(Properties.Resources.MessageBox_OpenHyperlink_FileDoesNotExist_Text, strFileToOpen), 
					Properties.Resources.MessageBox_OpenHyperlink_FileDoesNotExist_Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else {
				// If the file format is supported by TX Text Control...
				if (IsSupportedDocumentFormat(strFileToOpen)) {
					// ... open the file with a new instance of this application.
					OpenFileInNewInstance(strFileToOpen);
				}
				else {
					// Otherwise open the file with the default application that 
					// is determined for the corresponding format.
					Process.Start(strFileToOpen);
				}
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** OpenFileInNewInstance
		** Open the file by passed filepath in a new instance of this application.
		**
		** Parameters:
		**      filePath:   The path to the file that should be opened in a new instance of this application
		**-----------------------------------------------------------------------------------------------------------*/
		private void OpenFileInNewInstance(string filePath) {
			// Get running demo's exe path
			string strExePath = Assembly.GetEntryAssembly().Location;

			// Start new demo instance
			Process pcPocess = new Process();
			pcPocess.StartInfo.FileName = strExePath;
			pcPocess.StartInfo.Arguments = "\"" + filePath + "\"";
			pcPocess.Start();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** IsSupportedDocumentFormat Method
		** Checks whether the file format of the specified file is supported by TX Text Control.
		**
		** Parameters:
		**		filePath:	The file to check.
		**
		** Returns:	True if the specified file format is supported by TX Text Control. Otherwise false.
		**-----------------------------------------------------------------------------------------------------------*/
		private bool IsSupportedDocumentFormat(string filePath) {
			// Check the extension of the file path.
			switch (Path.GetExtension(filePath).ToLower()) {
				case ".rtf":
				case ".doc":
				case ".docx":
				case ".tx":
				case ".xml":
				case ".pdf":
				case ".xlsx":
				case ".txt":
					return true;
			}
			return false;
		}
	}
}
