/*-------------------------------------------------------------------------------------------------------------
** MainWindow_AppMenu_UserAccess.cs File
**
** Description:
**      Handles the user access to the document.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Windows.Forms;


namespace TXTextControl.Words {
	partial class MainWindow {

		/*-------------------------------------------------------------------------------------------------------------
		** M E M B E R   V A R I A B L E S
		**-----------------------------------------------------------------------------------------------------------*/

		private UserInfo m_uiCurrentUser = null; // Info about the current user.
		private string m_strUserName = ""; // Environment.UserName


		/*-------------------------------------------------------------------------------------------------------------
        ** H A N D L E R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** SignIn_Click Handler
        ** Opens a dialog to sign in to the TextControl a user by its account. If no such account is known,
        ** a new account is created. 
        **-----------------------------------------------------------------------------------------------------------*/
		private void SignIn_Click(object sender, EventArgs e) {
			// Open the password dialog to sign in or create a user account.
			UserAccessDialog dlgUserAccessDialog = m_uiCurrentUser == null ? new UserAccessDialog(m_strUserName) : new UserAccessDialog(m_uiCurrentUser);

			if (dlgUserAccessDialog.ShowDialog(this) == DialogResult.OK) {
				// Get the UserInfo instance that represents the current signed in user.
				m_uiCurrentUser = dlgUserAccessDialog.UserInfo;

				// Give the user access to the TextControl.
				m_txTextControl.UserNames = new string[] { m_uiCurrentUser.Name };

				// Hide the Sign In button.
				m_rbtnSignIn.Enabled =
				m_rbtnSignIn.Visible = false;

				// Show the [Current User] button.
				m_rmbtnCurrentUser.Enabled =
				m_rmbtnCurrentUser.Visible = true;

				// Save the settings of the current user.
				SaveKnownUserSettings();
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** AccountSettings_Click Handler
        ** Opens a dialog to edit the account settings of the current signed in user.
        **----------------------------------------------------------------------------------------------------------*/
		private void AccountSettings_Click(object sender, EventArgs e) {
			UserAccessDialog dlgUserAccessDialog = new UserAccessDialog(m_uiCurrentUser);
			switch (dlgUserAccessDialog.ShowDialog()) {
				case DialogResult.OK:
					// Replace the user info object of the current user
					// with a new instance.
					m_uiCurrentUser = dlgUserAccessDialog.UserInfo;
					m_rmbtnCurrentUser.Visible = true;
					break;
				case DialogResult.Abort:
					// The UserAccessDialog's Delete Account button was clicked. 
					// Set current user to null...
					m_uiCurrentUser = null;
					// ... and sign out.
					SignOut();
					break;
				default:
					return;
			}

			// Save the settings of the current user.
			SaveKnownUserSettings();
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** SignOut_Click Handler
        ** Signs out the current signed in user.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SignOut_Click(object sender, EventArgs e) {
			SignOut();
			MessageBox.Show(this, string.Format(Properties.Resources.MessageBox_UserAccess_SignOut_Text, m_strUserName), Properties.Resources.MessageBox_UserAccess_SignOut_Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** M E T H O D S
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
			// Save the known user to the Properties.Settings.Default.KnownUsers property
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

			// Show the Sign In button.
			m_rbtnSignIn.Enabled =
			m_rbtnSignIn.Visible = true;

			// Hide the [Current User] button.
			m_rmbtnCurrentUser.Enabled =
			m_rmbtnCurrentUser.Visible = false;
		}
	}
}
