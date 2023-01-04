/*-------------------------------------------------------------------------------------------------------------
** MainWindow_AppMenu_New.cs File
**
** Description:
**     Manages resetting the content of the document.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Windows.Forms;

namespace TXTextControl.Words {
	partial class MainWindow {

		/*-------------------------------------------------------------------------------------------------------------
        ** H A N D L E R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** New_Click Handler
        ** Invokes the TextControl.ResetContents method to create a new document.
        **-----------------------------------------------------------------------------------------------------------*/
		private void New_Click(object sender, EventArgs e) {
			// Check whether the document is dirty. In this case, the user is suggested to save that document. 
			if (SaveDirtyDocumentOnNew()) {
				// Create a new document.
				m_txTextControl.ResetContents();

				// A new document is created. Now:
				UpdateCurrentDocumentInfo(); // Reset the current document information.
				UpdateMainWindowCaption(); // Update the caption of the application's main window.
				UpdateSaveEnabledState(); // Update the enabled state of the Save button.
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** M E T H O D S
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
	}
}
