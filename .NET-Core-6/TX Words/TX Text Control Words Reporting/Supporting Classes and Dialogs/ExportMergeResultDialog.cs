/*-------------------------------------------------------------------------------------------------------------
** ExportMergeResultDialog.cs File
**
** Description:
**     Provides a dialog to export the results of the merge process.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Windows.Forms;

namespace TXTextControl.Words {
	public partial class ExportMergeResultDialog : Form {
		/*------------------------------------------------------------------------------------------------
		** Class FormatItem
		** Represents the 'Format' combo box item. It provides the displayed text, the format extension
		** and the TXTextControl.StreamType to use.
		**----------------------------------------------------------------------------------------------*/
		internal class FormatItem {
			// Member Variables
			private string m_strFormat;
			private string m_strExtension;
			private StreamType m_stStreamType;

			// Constructor
			internal FormatItem(string displayedText, string extension, StreamType streamType) {
				m_strFormat = displayedText;
				m_strExtension = extension;
				m_stStreamType = streamType;
			}

			// Properties
			internal string Extension { get { return m_strExtension; } }

			internal StreamType StreamType { get { return m_stStreamType; } }

			// Overridden Methods.
			public override string ToString() {
				return string.Format(m_strFormat, m_strExtension);
			}
		}


		/*------------------------------------------------------------------------------------------------
		** C O N S T R U C T O R
		**----------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** ExportMergeResultDialog Constructor
		** Creates a dialog to export the results of the merge process.
		**-----------------------------------------------------------------------------------------------------------*/
		public ExportMergeResultDialog() {
			InitializeComponent();

			// Set caption and label texts.
			this.Text = Properties.Resources.ExportMergeResultDialog_Caption;
			m_lblFilePrefix.Text = Properties.Resources.ExportMergeResultDialog_FilePrefix;
			m_lblDirectory.Text = Properties.Resources.ExportMergeResultDialog_Directory;
			m_lblFormat.Text = Properties.Resources.ExportMergeResultDialog_Format;
			m_btnOK.Text = Properties.Resources.ExportMergeResultDialog_OK;
			m_btnCancel.Text = Properties.Resources.ExportMergeResultDialog_Cancel;
			m_chbxopenDirectory.Text = Properties.Resources.ExportMergeResultDialog_openDirectory;

			// Add format items.
			m_cmbxFormat.Items.AddRange(new FormatItem[] {
			new FormatItem(Properties.Resources.ExportMergeResultDialog_Format_RTF,".rtf", StreamType.RichTextFormat),
			new FormatItem(Properties.Resources.ExportMergeResultDialog_Format_HTML,".html", StreamType.HTMLFormat),
			new FormatItem(Properties.Resources.ExportMergeResultDialog_Format_DOCX,".docx", StreamType.SpreadsheetML),
			new FormatItem(Properties.Resources.ExportMergeResultDialog_Format_DOC,".doc", StreamType.MSWord),
			new FormatItem(Properties.Resources.ExportMergeResultDialog_Format_PDF,".pdf", StreamType.AdobePDFA),
			new FormatItem(Properties.Resources.ExportMergeResultDialog_Format_TXT,".txt", StreamType.PlainText),
			new FormatItem(Properties.Resources.ExportMergeResultDialog_Format_TX,".tx", StreamType.InternalFormat)});

			// Select the PDF item.
			m_cmbxFormat.SelectedIndex = 4;
		}


		/*------------------------------------------------------------------------------------------------
		** P R O P E R T I E S
		**----------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** Directory Property
		** Gets or sets the directoy where to export the created files of the merge process. 
		**-----------------------------------------------------------------------------------------------------------*/
		internal string Directory { get { return m_tbxDirectory.Text.Trim(); } set { m_tbxDirectory.Text = value; } }

		/*-------------------------------------------------------------------------------------------------------------
		** FilePrefix Property
		** Gets or sets the prefix string that is used when exporting the created files of the merge process.
		**-----------------------------------------------------------------------------------------------------------*/
		internal string FilePrefix { get { return m_tbxFilePrefix.Text.Trim(); } set { m_tbxFilePrefix.Text = System.IO.Path.GetFileNameWithoutExtension(value); } }

		/*-------------------------------------------------------------------------------------------------------------
		** Format Property
		** Gets the document format that is used when exporting the created files of the merge process.
		**-----------------------------------------------------------------------------------------------------------*/
		internal FormatItem Format { get { return m_cmbxFormat.SelectedItem as FormatItem; } }

		/*-------------------------------------------------------------------------------------------------------------
		** openDirectory Property
		** Gets a value indicating whether the directory where the merged files are exported should be openeded.
		**-----------------------------------------------------------------------------------------------------------*/
		internal bool openDirectory { get { return m_chbxopenDirectory.Checked; } }


		/*------------------------------------------------------------------------------------------------
		** H A N D L E R S
		**----------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** OpenFolderBrowser_Click Handler
		** Opens the folder browser dialog to determine the directory where to export the created files of the merge 
		** process. 
		**-----------------------------------------------------------------------------------------------------------*/
		private void OpenFolderBrowser_Click(object sender, EventArgs e) {
			FolderBrowserDialog dlgFolderBrowser = new FolderBrowserDialog();
			// Sets the current directory path as selected path.
			if (System.IO.Directory.Exists(this.Directory)) {
				dlgFolderBrowser.SelectedPath = this.Directory;
			}

			// Update the directory text box if a path is selected by the folder browser dialog.
			if (dlgFolderBrowser.ShowDialog() == DialogResult.OK) {
				m_tbxDirectory.Text = dlgFolderBrowser.SelectedPath;
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Directory_TextChanged Handler
		** Handles the enabled state of the OK button.
		**-----------------------------------------------------------------------------------------------------------*/
		private void Directory_TextChanged(object sender, EventArgs e) {
			m_btnOK.Enabled = this.Directory.Length > 0;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** OK_Click Handler
		** If the specified directory path exists, close the dialog.
		**-----------------------------------------------------------------------------------------------------------*/
		private void OK_Click(object sender, EventArgs e) {
			if (!System.IO.Directory.Exists(this.Directory)) {
				MessageBox.Show(Properties.Resources.MessageBox_ExportMergeResultDialog_DirectoryDoesNotExist_Text, Properties.Resources.MessageBox_ExportMergeResultDialog_DirectoryDoesNotExist_Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else {
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}
	}
}
