/*-------------------------------------------------------------------------------------------------------------
** MainWindow_FileMenuItem_Click.cs File
**
** Description: Provides all Click handlers associated with 'File' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** File_New_Click Handler
		**
		** Invokes the TextControl.ResetContents method to create a new document.
		** 
		** Item: 'New'
		**-----------------------------------------------------------------------------------------------------------*/
		private void File_New_Click(object sender, EventArgs e) {
			// Check whether the document is dirty. In this case, the user is suggested to save that document. 
			if (SaveDirtyDocumentOnNew()) {
				// Create a new document.
				m_txTextControl.ResetContents();

				// A new document is created. Now:
				UpdateCurrentDocumentInfo(); // Reset the current document information.
				UpdateMainWindowCaption(); // Update the caption of the application's main window.
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** File_Open_Click Handler
		**
		** Invokes the Open method to load a document by using the internal TextControl 'Open' dialog.
		** 
		** Item: 'Open...'
		**-----------------------------------------------------------------------------------------------------------*/
		private void File_Open_Click(object sender, EventArgs e) {
			Open();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** File_RecentFiles_Item_Click Handler
		**
		** Opens the file that is represented by the clicked item.
		** 
		** Item: Each item of the 'Recent Files' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void File_RecentFiles_Item_Click(object sender, EventArgs e) {
			// Get the file that is represented by the clicked item.
			string strFile = (sender as ToolStripMenuItem).Tag as string;

			// Check whether the file still exists.
			if (!File.Exists(strFile)) {
				// If not, open a Message box that asks the user whether the not
				// existing file should be removed from the recent file list.
				if (MessageBox.Show(this, Properties.Resources.MessageBox_OpenRecentFile_FileDoesNotExist_Text, Properties.Resources.MessageBox_OpenRecentFile_FileDoesNotExist_Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
					// Remove the file from the list and update the items collection.
					m_colRecentFiles.Remove(strFile);
					UpdateRecentFileList();
				}
			}
			else {
				// Open the file.
				Open(strFile);
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** File_Save_Click Handler
		**
		** Invokes the Save method to save a document by saving it at the same location where it was loaded 
        ** before.
		** 
		** Item: 'Save'
		**-----------------------------------------------------------------------------------------------------------*/
		private void File_Save_Click(object sender, EventArgs e) {
			Save(m_strActiveDocumentPath);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** File_SaveAs_Click Handler
		**
		** Invokes the Save method to save a document by using the internal TextControl 'Save' dialog.
		** 
		** Item: 'Save As...'
		**-----------------------------------------------------------------------------------------------------------*/
		private void File_SaveAs_Click(object sender, EventArgs e) {
			Save(null);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** File_PageSetup_Click Handler
		**
		** Invokes the built-in dialog for setting section attributes.
		** 
		** Item: 'Page Setup...'
		**-----------------------------------------------------------------------------------------------------------*/
		private void File_PageSetup_Click(object sender, EventArgs e) {
			m_txTextControl.SectionFormatDialog();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** File_PrintPreview_Click Handler
		**
		** Opens a print preview.
		** 
		** Item: 'Print Preview...'
		**-----------------------------------------------------------------------------------------------------------*/
		private void File_PrintPreview_Click(object sender, EventArgs e) {
			m_txTextControl.PrintPreview(m_strActiveDocumentName);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** File_Print_Click Handler
		**
		** Invokes the TextControl Print method to open the TextControl print dialog.
		** 
		** Item: 'Print...'
		**-----------------------------------------------------------------------------------------------------------*/
		private void File_Print_Click(object sender, EventArgs e) {
			// Use the active document name to open the print dialog.
			m_txTextControl.Print(m_strActiveDocumentName);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** File_PrintQuick_Click Handler
		**
		** Prints the current document without opening the dialog before.
		** 
		** Item: 'Print Quick'
		**-----------------------------------------------------------------------------------------------------------*/
		private void File_PrintQuick_Click(object sender, EventArgs e) {
			m_txTextControl.Print(new PrintDocument() {
				PrinterSettings = new PrinterSettings() {
					FromPage = 1,
					ToPage = m_txTextControl.Pages,
					Copies = 1,
					Collate = true,
					PrintFileName = m_strActiveDocumentName
				},
			});
		}

		/*-------------------------------------------------------------------------------------------------------------
		** File_SignIn_Click Handler
		**
		** Opens a dialog to sign in to the TextControl a user by its account. If no such account is known,
        ** a new account is created. 
		** 
		** Item: 'Sign In...'
		**-----------------------------------------------------------------------------------------------------------*/
		private void File_SignIn_Click(object sender, EventArgs e) {
			// Open the password dialog to sign in or create a user account.
			UserAccessDialog dlgUserAccessDialog = m_uiCurrentUser == null ? new UserAccessDialog(m_strUserName) : new UserAccessDialog(m_uiCurrentUser);

			if (dlgUserAccessDialog.ShowDialog(this) == DialogResult.OK) {
				// Get the UserInfo instance that represents the current signed in user.
				m_uiCurrentUser = dlgUserAccessDialog.UserInfo;

				// Give the user access to the TextControl.
				m_txTextControl.UserNames = new string[] { m_uiCurrentUser.Name };

				// Hide the Sign In item.
				m_tmiFile_SignIn.Enabled =
				m_tmiFile_SignIn.Visible = false;

				// Show the [Current User] item.
				m_tmiFile_CurrentUser.Enabled =
				m_tmiFile_CurrentUser.Visible = true;
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** File_CurrentUser_AccountSettings_Click Handler
		**
		** Opens a dialog to edit the account settings of the current signed in user.
		** 
		** Item: 'Account Settings...' of the '[Current User]' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void File_CurrentUser_AccountSettings_Click(object sender, EventArgs e) {
			UserAccessDialog dlg = new UserAccessDialog(m_uiCurrentUser);
			switch (dlg.ShowDialog()) {
				case DialogResult.OK:
					// Replace the user info object of the current user
					// with a new instance.
					m_uiCurrentUser = dlg.UserInfo;
					m_tmiFile_CurrentUser.Visible = true;
					break;
				case DialogResult.Abort:
					// The UserAccessDialog's Delete Account item was clicked. 
					// Set current user to null...
					m_uiCurrentUser = null;
					// ... and sign out.
					SignOut();
					break;
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** File_CurrentUser_SignOut_Click Handler
		**
		** Signs out the current signed in user.
		** 
		** Item: 'Sign Out' of the '[Current User]' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void File_CurrentUser_SignOut_Click(object sender, EventArgs e) {
			SignOut();
			MessageBox.Show(this, string.Format(Properties.Resources.MessageBox_UserAccess_SignOut_Text, m_strUserName), Properties.Resources.MessageBox_UserAccess_SignOut_Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** File_Exit_Click Handler
		**
		** Closes the application when clicked.
		** 
		** Item: 'Exit'
		**-----------------------------------------------------------------------------------------------------------*/
		private void File_Exit_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
