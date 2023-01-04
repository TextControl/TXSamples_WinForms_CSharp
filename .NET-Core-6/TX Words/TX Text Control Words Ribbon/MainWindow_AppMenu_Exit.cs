/*-------------------------------------------------------------------------------------------------------------
** MainWindow_AppMenu_Exit.cs File
**
** Description:
**     Manages closing the application.
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
        ** Exit_Click Handler
        ** Closes the application when clicked.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Exit_Click(object sender, EventArgs e) {
			this.Close();
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** MainWindow_FormClosing Handler
        ** Invokes the SaveDirtyDocumentOnExit method to handle dirty documents. If the method returns false, the 
        ** closing of the application will be canceled. If the form closing is not canceled, the recent files
        ** are saved to the Properties.Settings.Default.RecentFiles property.
        **-----------------------------------------------------------------------------------------------------------*/
		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
			if (!(e.Cancel = !SaveDirtyDocumentOnExit())) {
				// Save the recent files to the Properties.Settings.Default.RecentFiles property
				SaveRecentFiles();
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** M E T H O D S
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
