/*-------------------------------------------------------------------------------------------------------------
** MainWindow_AppMenu_Open.cs File
**
** Description:
**     Manages opening a file.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.IO;
using System.Windows.Forms;

namespace TXTextControl.Words {
	partial class MainWindow {

		/*-------------------------------------------------------------------------------------------------------------
        ** M E M B E R   V A R I A B L E S
        **-----------------------------------------------------------------------------------------------------------*/
		private StreamType m_stLastLoadedType = StreamType.RichTextFormat;
		private readonly PDFImportSettings m_isPDFImportSettings = PDFImportSettings.GenerateTextFrames | PDFImportSettings.LoadEmbeddedFiles;


		/*-------------------------------------------------------------------------------------------------------------
        ** H A N D L E R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** Open_Click Handler
        ** Invokes the Open method to load a document by using the internal TextControl 'Open' dialog.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Open_Click(object sender, EventArgs e) {
			Open();
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** M E T H O D S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** Open Method
        ** Opens a file.
        **
        ** Parameters:
        **      fileName:   If not specified, the TextControl Load-Dialog is opened to select the file to open. 
        **                  Otherwise the specified file is loaded.
        **      streamType: If set, the TXTextControl.StreamType value is used to load the file that is specified
        **                  by the fileName parameter. Otherwise, the corresponding StreamType is determined by
        **                  the file's format.
        **-----------------------------------------------------------------------------------------------------------*/
		internal void Open(string fileName = null, StreamType streamType = (StreamType)(-1)) {
			// Check whether the document is dirty. In this case, the user is suggested to save that document. 
			if (SaveDirtyDocumentOnOpen()) {
				// Create settings to determine some load parameters and get information about the document
				// when it is opened.
				LoadSettings lsLoadSettings = CreateLoadSettings();
				try {
					// Check whether a file to load is specified.
					if (string.IsNullOrEmpty(fileName)) {
						// If not, the TextControl Load dialog is opened. In that dialog all loadable file 
						// formats can be chosen that are provided by the TXTextControl.StreamType enumeration.
						if (m_txTextControl.Load(StreamType.All, lsLoadSettings) == DialogResult.Cancel) {
							return;
						}
					}
					else {
						// Determine the stream type if necessary
						if (streamType == (StreamType)(-1)) {
							streamType = GetStreamType(fileName);
						}
						// Open the file directly by using its path.
						m_txTextControl.Load(fileName, streamType, lsLoadSettings);
					}
				} catch (Exception ex) {
					// Set the password if the document is password protected.
					if (!HandlePasswordProtectedDocument(ex, lsLoadSettings)) {
						return;
					}
				}
				// The document is loaded. Now:
				UpdateCurrentDocumentInfo(lsLoadSettings);  // Set information about the loaded document.              
				AddRecentFile(m_strActiveDocumentPath);  // Add the document to the recent files list.
				UpdateMainWindowCaption(); // Update the caption of the application's main window.
				UpdateSaveEnabledState(); // Update the enabled state of the Save button.
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** HandlePasswordProtectedDocument Method
		** Handles password protect documents by opening a password dialog.
		**
		** Parameters:
		**      exception:		The exception that is thrown when opening the document.
		**      loadSettings:	The load settings that are used when opening the doucment.
		**
		** Return value:		True if the password protected document could be loaded.
        **						Otherwise false.
		**-----------------------------------------------------------------------------------------------------------*/
		private bool HandlePasswordProtectedDocument(Exception exception, LoadSettings loadSettings) {
			// Check whether the thrown exception is an exception of type FilterException.
			if (exception is FilterException) {
				switch ((exception as FilterException).Reason) {
					case FilterException.FilterError.InvalidPassword:
						// Open the password dialog if the document is write protected.
						PasswordDialog dlgPassword = new PasswordDialog(m_txTextControl, loadSettings);
						return dlgPassword.ShowDialog(this) == DialogResult.OK;
				}
			}
			throw exception;
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** SaveDirtyDocumentOnOpen Method
        ** If the document is dirty (unsaved changes were made), a MessageBox is shown where the user can
        ** decide whether loading the new file should be canceled or the changed document should (or should not) 
        ** be saved before opening the new document.
        **
        ** Return value:    If loading the new document should be canceled, the method returns false. 
        **                  Otherwise true.
        **-----------------------------------------------------------------------------------------------------------*/
		private bool SaveDirtyDocumentOnOpen() {
			bool bKeepGoing = true;
			if (m_bIsDirtyDocument) {
				// If the document is dirty, show a message box where the user can decide how to handle it.

				// The message box' text depends on whether the dirty document is an unsaved file or not.
				string strMessageBoxTExt = m_bIsUnknownDocument ?
				   Properties.Resources.MessageBox_SaveDirtyDocumentOnOpen_Untitled :
				   string.Format(Properties.Resources.MessageBox_SaveDirtyDocumentOnOpen_ToFile, m_strActiveDocumentPath);

				// Show message box.
				DialogResult drSaveFile = MessageBox.Show(this, strMessageBoxTExt, Properties.Resources.MessageBox_SaveDirtyDocumentOnOpen_Caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

				switch (drSaveFile) {
					case DialogResult.Yes:
						// The dirty document should be saved.
						bKeepGoing = Save(m_strActiveDocumentPath);
						break;
					case DialogResult.Cancel:
						// Opening a new document is canceled.
						bKeepGoing = false;
						break;
				}
			}
			return bKeepGoing;
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** GetStreamType Method
        ** Checks whether the format of the specified file is supported by TX Text Control and returns the
        ** corresponding StreamType.
        **
        ** Parameters:
        **      filePath:   The file to determine whether or not its format is supported by TX Text Control.
        **
        ** Return value:    The corresponding StreamType if the file format is supported. Otherwise 
        **                  (StreamType)(-1)
        **-----------------------------------------------------------------------------------------------------------*/
		private StreamType GetStreamType(string filePath) {
			string strFileExtension = Path.GetExtension(filePath);
			switch (strFileExtension) {
				case ".rtf":
					return StreamType.RichTextFormat;

				case ".htm":
				case ".html":
					return StreamType.HTMLFormat;

				case ".tx":
					return StreamType.InternalUnicodeFormat;

				case ".doc":
					return StreamType.MSWord;

				case ".docx":
					return StreamType.WordprocessingML;

				case ".pdf":
					return StreamType.AdobePDF;

				case ".txt":
					return StreamType.PlainText;

				case ".xlsx":
					return StreamType.SpreadsheetML;
			}
			return (StreamType)(-1);
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** CreateLoadSettings Method
        ** Creates and returns an object of type TXTextControl.LoadSettings that is used to open a document and
        ** provide information about the document after it was loaded.
        **
        ** Return value:    The created LoadSettings object.
        **-----------------------------------------------------------------------------------------------------------*/
		private LoadSettings CreateLoadSettings() {
			LoadSettings lsLoadSettings = new LoadSettings {
				ApplicationFieldFormat = ApplicationFieldFormat.MSWordTXFormFields,
				LoadSubTextParts = true,
				ReportingMergeBlockFormat = ReportingMergeBlockFormat.SubTextParts,
				PDFImportSettings = m_isPDFImportSettings,
				DocumentPartName = string.Empty,
				DefaultStreamType = m_stLastLoadedType
			};			
			return lsLoadSettings;
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** UpdateCurrentDocumentInfo Method
        ** Updates some variables that provide information about the current active document. In this case 
        ** these information are updated by the load settings of the opened document.
        **
        ** Parameters:
        **              loadSettings:   The load settings that provide the information about the opened 
        **                              document.
        **-----------------------------------------------------------------------------------------------------------*/
		private void UpdateCurrentDocumentInfo(LoadSettings loadSettings) {
			m_strActiveDocumentPath = loadSettings.LoadedFile;
			m_stActiveDocumentType = m_stLastLoadedType = loadSettings.LoadedStreamType;
			m_strUserPasswordPDF = loadSettings.UserPassword;
			m_strCssFileName = loadSettings.CssFileName;
			m_svCssSaveMode = CssSaveMode.None;
			m_bIsDirtyDocument = false;
			m_bIsUnknownDocument = false;
			m_strActiveDocumentName = Path.GetFileName(m_strActiveDocumentPath);
		}
	}
}
