/*-------------------------------------------------------------------------------------------------------------
** MainWindow_FileMenuItem_Methods.cs File
**
** Description: Provides supporting methods to implement the desired behavior of some 'File' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/

using System;
using System.IO;
using System.Windows.Forms;

namespace TXTextControl.Words {
	partial class MainWindow {


		/*-------------------------------------------------------------------------------------------------------------
        ** 'New' item
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** SaveDirtyDocumentOnNew Method
        ** If the document is dirty (unsaved changes were made), a MessageBox is shown where the user can
        ** decide whether resetting the content should be canceled or the changed document should (or should not) 
        ** be saved before creating a new document.
        **
        ** Return value:    If creating the new document should be canceled, the method returns false. 
        **                  Otherwise true.
        **-----------------------------------------------------------------------------------------------------------*/
		private bool SaveDirtyDocumentOnNew() {
			bool bKeepGoing = true;
			if (m_bIsDirtyDocument) {
				// If the document is dirty, show a message box where the user can decide how to handle it.

				// The message box' text depends on whether the dirty document is an unsaved file or not.
				string strMessageBoxText = m_bIsUnknownDocument ?
				   Properties.Resources.MessageBox_SaveDirtyDocumentOnNew_Untitled :
				   string.Format(Properties.Resources.MessageBox_SaveDirtyDocumentOnNew_ToFile, m_strActiveDocumentPath);

				// Show message box.
				DialogResult drSaveFile = MessageBox.Show(this, strMessageBoxText, Properties.Resources.MessageBox_SaveDirtyDocumentOnNew_Caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
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
        ** UpdateCurrentDocumentInfo Method
        ** Updates some variables that provide information about the current active document. In this case 
        ** these information are reset to the values of a newly created document.
        **-----------------------------------------------------------------------------------------------------------*/
		private void UpdateCurrentDocumentInfo() {
			m_strActiveDocumentPath = null;
			m_strUserPasswordPDF = string.Empty;
			m_strCssFileName = null;
			m_svCssSaveMode = CssSaveMode.None;
			m_bIsDirtyDocument = false;
			m_bIsUnknownDocument = true;
			m_strActiveDocumentName = Properties.Resources.MainWindow_Caption_Untitled;
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** 'Open...' item
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
		private void Open(string fileName = null, StreamType streamType = (StreamType)(-1)) {
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


		/*-------------------------------------------------------------------------------------------------------------
        ** 'Recent Files' item
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** LoadRecentFiles Method
        ** Gets the recent files from the application settings.
        **-----------------------------------------------------------------------------------------------------------*/
		private void LoadRecentFiles() {
			m_colRecentFiles = Properties.Settings.Default.RecentFiles;
			if (m_colRecentFiles == null) {
				m_colRecentFiles = new System.Collections.Specialized.StringCollection();
			}
			// Remove empty entries.
			for (int i = m_colRecentFiles.Count - 1; i >= 0; i--) {
				if (string.IsNullOrEmpty(m_colRecentFiles[i])) {
					m_colRecentFiles.RemoveAt(i);
				}
			}
			UpdateRecentFileList();
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** SaveRecentFiles Method
        ** Saves the recent files list to the Properties.Settings.Default.RecentFiles property when the 
        ** application is closing (see MainWindow_FormClosing Handler).
        **-----------------------------------------------------------------------------------------------------------*/
		private void SaveRecentFiles() {

			Properties.Settings.Default.RecentFiles = m_colRecentFiles;
			Properties.Settings.Default.Save();
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** AddRecentFile Method
        ** Inserts the specified file path as first entry inside the recent files list. 
        **
        ** Parameters:
        **      filePath:   The file path to add.
        **-----------------------------------------------------------------------------------------------------------*/
		private void AddRecentFile(string filePath) {
			if (!string.IsNullOrEmpty(filePath)) {
				// Check whether the list already contains that file.
				if (m_colRecentFiles.Contains(filePath)) {
					// In that case remove that file.
					m_colRecentFiles.Remove(filePath);
				}
				else {
					// Remove last entry if the current number of entries equals to the
					// maximum number of recent files.
					if (m_colRecentFiles.Count == m_iMaxRecentFiles) {
						m_colRecentFiles.RemoveAt(m_iMaxRecentFiles - 1);
					}
				}
				// Insert the file path at the top of the list.
				m_colRecentFiles.Insert(0, filePath);

				// Update the recent file drop down items.
				UpdateRecentFileList();
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** UpdateRecentFileList Method
        ** Updates the recent file drop down items.
        **-----------------------------------------------------------------------------------------------------------*/
		private void UpdateRecentFileList() {
			m_tmiFile_RecentFiles.DropDownItems.Clear();

			// Create and insert for each recent file path entry an item that represents a recent file.
			for (int i = 0; i < m_colRecentFiles.Count && i < m_iMaxRecentFiles; i++) {
				m_tmiFile_RecentFiles.DropDownItems.Add(CreateRecentFileItem(i));
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** CreateRecentFileItem Method
        ** Creates and returns an item that represents a recent file.
        **
        ** Parameters:
        **      index:   The index of the recent file inside the recent files collection.
        **
        ** Return value:    A ToolStripMenuItem that represents a recent file.
        **-----------------------------------------------------------------------------------------------------------*/
		private ToolStripMenuItem CreateRecentFileItem(int index) {
			// Create an item
			ToolStripMenuItem tmiRecentFile = new ToolStripMenuItem();

			// Get the path and name of the file.
			string strFilePath = m_colRecentFiles[index];
			string strFileName = Path.GetFileName(strFilePath);

			// Determine the displayed text of the item (index plus file name) 
			// and store the file path as Tag value.
			tmiRecentFile.Text = "&" + (index + 1) + ". " + strFileName;
			tmiRecentFile.Tag = strFilePath;

			// Provide file path by setting the tool tip.
			tmiRecentFile.ToolTipText = strFilePath;

			// Add a handler to the Click event to open the corresponding file when the item is clicked.
			tmiRecentFile.Click += File_RecentFiles_Item_Click;

			return tmiRecentFile;
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** 'Save' and 'Save as...' items
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** Save Method
        ** Saves the current document as a file by using the TextControl Save dialog or using the path where the
        ** the active document was loaded from.
        **
        ** Parameters:
        **              savePath: The path where to save the active document. If that parameter is null  
        **                        or an empty string, the TextControl Save dialog is opened to save the 
        **                        document.
        **
        ** Return value:    False if the document was not saved. Otherwise true.
        **-----------------------------------------------------------------------------------------------------------*/
		private bool Save(string savePath) {
			// Create settings to determine some save parameters and get information about the document
			// when it is saved.
			SaveSettings svsSaveSettings = CreateSaveSettings();

			// Check whether a file path is specified where the document should be loaded.
			if (string.IsNullOrEmpty(savePath)) {
				// If no such path is determined, the TextControl Save dialog is opened. In that dialog 
				// all file formats can be chosen that are provided by the TXTextControl.StreamType enumeration.
				// Furthermore the DialogSettings EnterPassword, StylesheetOptions and SaveSelection are set.
				if (m_txTextControl.Save(StreamType.All, svsSaveSettings,
					SaveSettings.DialogSettings.EnterPassword |
					SaveSettings.DialogSettings.StylesheetOptions |
					SaveSettings.DialogSettings.SaveSelection) == DialogResult.Cancel) {
					return false;
				}
			}
			else {
				// Save the document at the same location (and with the same format) where it was loaded
				// before.
				svsSaveSettings.CssSaveMode = m_svCssSaveMode; // Set the stored css save mode.
				svsSaveSettings.CssFileName = m_strCssFileName;  // Set the stored css file name.
				svsSaveSettings.UserPassword = m_strUserPasswordPDF; // Set the stored user password.
				m_txTextControl.Save(m_strActiveDocumentPath, m_stActiveDocumentType, svsSaveSettings);
			}

			// The document is saved. Now:
			UpdateCurrentDocumentInfo(svsSaveSettings);  // Set information about the saved document.       
			AddRecentFile(m_strActiveDocumentPath); // Add the document to the recent files list.
			UpdateMainWindowCaption();  // Update the caption of the application's main window.
			return true;
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** CreateSaveSettings Method
        ** Creates and returns an object of type TXTextControl.SaveSettings that is used to save a document and
        ** provide information about the document after it was saved.
        **
        ** Return value:    The created SaveSettings object.
        **-----------------------------------------------------------------------------------------------------------*/
		private SaveSettings CreateSaveSettings() {
			SaveSettings svsSaveSettings = new SaveSettings {
				LastModificationDate = DateTime.Now,
				ReportingMergeBlockFormat = ReportingMergeBlockFormat.SubTextParts,
				DefaultStreamType = m_stLastSavedType
			};
			return svsSaveSettings;
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** UpdateCurrentDocumentInfo Method
        ** Updates some variables that provide information about the current active document. In this case 
        ** these information are updated by the save settings of the saved document.
        **
        ** Parameters:
        **              saveSettings:   The save settings that provide the information about the saved 
        **                              document.
        **-----------------------------------------------------------------------------------------------------------*/
		private void UpdateCurrentDocumentInfo(SaveSettings saveSettings) {
			m_strActiveDocumentPath = saveSettings.SavedFile;
			m_stActiveDocumentType = m_stLastSavedType = saveSettings.SavedStreamType;
			m_strUserPasswordPDF = saveSettings.UserPassword;
			m_strCssFileName = saveSettings.CssFileName;
			m_svCssSaveMode = saveSettings.CssSaveMode;
			m_bIsDirtyDocument = false;
			m_bIsUnknownDocument = false;
			m_strActiveDocumentName = Path.GetFileName(m_strActiveDocumentPath);
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** 'Sign In...' and '[Current user]' items
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** LoadKnownUserSettings Method
        ** Gets the known user from the application settings.
        **-----------------------------------------------------------------------------------------------------------*/
		private void LoadKnownUserSettings() {
			m_strUserName = Environment.UserName;  // Get the user name of the person who is currently logged on the operation system
			m_uiCurrentUser = Properties.Settings.Default.KnownUser;
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** SaveKnownUserSettings Method
        ** Save the known user to the application settings.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SaveKnownUserSettings() {

			// Save the know users to the Properties.Settings.Default.KnownUsers property
			Properties.Settings.Default.KnownUser = m_uiCurrentUser;
			Properties.Settings.Default.Save();
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** SignOut Method
        ** Signs out the current user.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SignOut() {
			//Signs out the current user.
			if (m_uiCurrentUser != null) {
				m_uiCurrentUser.IsSignedIn = false;
			}
			// Reset the TextControl user access.
			m_txTextControl.UserNames = null;

			// Show the Sign In item.
			m_tmiFile_SignIn.Enabled =
			m_tmiFile_SignIn.Visible = true;

			// Hide the [Current User] item.
			m_tmiFile_CurrentUser.Enabled =
			m_tmiFile_CurrentUser.Visible = false;
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** 'Exit' item
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** SaveDirtyDocumentOnExit Method
        ** If the document is dirty (unsaved changes were made), a MessageBox is shown where the user can
        ** decide whether closing the application should be canceled or the changed document should (or should 
        ** not) be saved before closing the program.
        **
        ** Return value:    If closing the application should be canceled, the method returns false. 
        **                  Otherwise true.
        **-----------------------------------------------------------------------------------------------------------*/
		private bool SaveDirtyDocumentOnExit() {
			bool bKeepGoing = true;
			if (m_bIsDirtyDocument) {
				string strMessageBoxTExt = m_bIsUnknownDocument ?
					Properties.Resources.MessageBox_SaveDirtyDocumentOnExit_Untitled :
					string.Format(Properties.Resources.MessageBox_SaveDirtyDocumentOnExit_ToFile, m_strActiveDocumentPath);
				DialogResult drSaveFile = MessageBox.Show(this, strMessageBoxTExt, Properties.Resources.MessageBox_SaveDirtyDocumentOnExit_Caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
				switch (drSaveFile) {
					case DialogResult.Yes:
						bKeepGoing = Save(m_strActiveDocumentPath);
						break;
					case DialogResult.Cancel:
						bKeepGoing = false;
						break;
				}
			}
			return bKeepGoing;
		}
	}
}
