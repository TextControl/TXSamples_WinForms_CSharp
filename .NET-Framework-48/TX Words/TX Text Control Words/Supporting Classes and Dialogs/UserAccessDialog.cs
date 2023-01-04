/*-------------------------------------------------------------------------------------------------------------
** UserAccessDialog.cs File
**
** Description:
**     Provides a dialog to create a new user account, sign in a user or edit a user account.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System.Windows.Forms;

namespace TXTextControl.Words {
	/*-------------------------------------------------------------------------------------------------------------
    ** UserAccessDialog Class
    ** A dialog to create a new user account, sign in a user or edit a user account.
    **-----------------------------------------------------------------------------------------------------------*/
	internal partial class UserAccessDialog : Form {

		/*-------------------------------------------------------------------------------------------------------------
		** E N U M S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** DialogBehaviors Enum
        ** Represents three kinds of behavior how the dialog might act.
        **-----------------------------------------------------------------------------------------------------------*/
		internal enum DialogBehaviors {
			CreateAccount,      // The dialog is opened to create a new user account.
			SignIn,             // The dialog is opened to sign in a user.
			AccountSettings     // The dialog is opened to edit the signed in user's account.
		}


		/*-------------------------------------------------------------------------------------------------------------
		** M E M B E R   V A R I A B L E S
		**-----------------------------------------------------------------------------------------------------------*/

		private readonly UserInfo m_uiUserInfo = null;
		private readonly string m_strUserName = null;
		private readonly DialogBehaviors m_dbDialogBehavior = DialogBehaviors.CreateAccount;


		/*-------------------------------------------------------------------------------------------------------------
        ** C O N S T R U C T O R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** UserAccessDialog Constructor
        ** Opens the dialog to sign in a user or to edit the signed in user's account settings.
        **
        ** Parameters:
        **      userInfo:   The UserInfo instance of the user to be handled.
        **-----------------------------------------------------------------------------------------------------------*/
		internal UserAccessDialog(UserInfo userInfo) {
			InitializeComponent();
			m_uiUserInfo = userInfo;

			// Set the user name
			m_lblUserName.Text = m_strUserName = m_uiUserInfo.Name;

			// Check whether to sign in the user or edit its account settings.
			if (m_uiUserInfo.IsSignedIn) {
				// Edit user account settings.
				m_dbDialogBehavior = DialogBehaviors.AccountSettings;

				// Update controls texts
				this.Text = Properties.Resources.UserAccessDialog_AccountSettings_Caption;

				m_lblPassword.Text = Properties.Resources.UserAccessDialog_AccountSettings_OldPassword;
				m_lblNewPassword.Text = Properties.Resources.UserAccessDialog_AccountSettings_NewPassword;
				m_lblConfirmPassword.Text = Properties.Resources.UserAccessDialog_AccountSettings_ConfirmPassword;

				// Buttons
				m_btnDelete.Visible = true;
				m_btnDelete.Text = Properties.Resources.UserAccessDialog_AccountSettings_Delete;
			}
			else {
				// Otherwise the user is known but not signed in.
				m_dbDialogBehavior = DialogBehaviors.SignIn;

				// Hide 'New password' and 'Confirm password' controls
				m_lblNewPassword.Visible =
				m_tbxNewPassword.Visible =
				m_lblConfirmPassword.Visible =
				m_tbxConfirmPassword.Visible = false;

				// Update controls texts
				this.Text = Properties.Resources.UserAccessDialog_SignIn_Caption;
				m_lblPassword.Text = Properties.Resources.UserAccessDialog_SignIn_Password;
			}
			m_btnOK.Text = Properties.Resources.UserAccessDialog_OK;
			m_btnCancel.Text = Properties.Resources.UserAccessDialog_Cancel;
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** UserAccessDialog Constructor
        ** Opens the dialog to create a user account.
        **
        ** Parameters:
        **      userName:   The name of the user to create an account for.
        **-----------------------------------------------------------------------------------------------------------*/
		public UserAccessDialog(string userName) {
			InitializeComponent();

			// Set the user name
			m_lblUserName.Text = m_strUserName = userName;

			// A new account should be created.
			m_dbDialogBehavior = DialogBehaviors.CreateAccount;

			// Hide password controls
			m_lblPassword.Visible =
			m_tbxPassword.Visible = false;

			// Update control texts
			this.Text = Properties.Resources.UserAccessDialog_CreateAccount_Caption;
			m_lblNewPassword.Text = Properties.Resources.UserAccessDialog_CreateAccount_NewPassword;
			m_lblConfirmPassword.Text = Properties.Resources.UserAccessDialog_CreateAccount_ConfirmPassword;

			// Buttons
			m_btnOK.Text = Properties.Resources.UserAccessDialog_OK;
			m_btnCancel.Text = Properties.Resources.UserAccessDialog_Cancel;
		}


		/*-------------------------------------------------------------------------------------------------------------
		** P R O P E R T I E S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** UserInfo Property
        ** Returns an instance of a UserInfo class that represents the signed in user.
        **-----------------------------------------------------------------------------------------------------------*/
		internal UserInfo UserInfo {
			get
			{
				switch (m_dbDialogBehavior) {
					case DialogBehaviors.SignIn:
						m_uiUserInfo.IsSignedIn = true;
						return m_uiUserInfo;
					default:
						return new UserInfo(m_strUserName, m_tbxConfirmPassword.Text);
				}
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
		** H A N D L E R S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** Password_TextChanged Handler
        ** Updates the enabled states of the dialog controls when the text of a text box changed.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Password_TextChanged(object sender, System.EventArgs e) {
			EnableControls();
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** Delete_Click Handler
        ** Asks the user whether his user account should be deleted. In that case and if the 
        ** password is correct, the dialog is closed.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Delete_Click(object sender, System.EventArgs e) {
			// Ask the user whether the current user account should be deleted.
			if (MessageBox.Show(this, Properties.Resources.MessageBox_UserAccessDialogDeleteAccount_Text, this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
				// Validate the password of the current signed in user.
				if (!m_uiUserInfo.ValidatePassword(m_tbxPassword.Text)) {
					MessageBox.Show(this, Properties.Resources.MessageBox_UserAccessDialogIncorrectPassword_Text, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				// Close the dialog
				this.DialogResult = DialogResult.Abort;
				this.Close();
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** OK_Click Handler
        ** Validates the password when the OK button is clicked.
        **-----------------------------------------------------------------------------------------------------------*/
		private void OK_Click(object sender, System.EventArgs e) {
			// Validate the password of the current signed in user or the user to sign in.
			if (m_uiUserInfo != null && !m_uiUserInfo.ValidatePassword(m_tbxPassword.Text)) {
				// The password is not correct.
				MessageBox.Show(this, Properties.Resources.MessageBox_UserAccessDialogIncorrectPassword_Text, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			this.DialogResult = DialogResult.OK;
		}


		/*-------------------------------------------------------------------------------------------------------------
		** M E T H O D S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** EnableControls Method
        ** Updates the enabled states of the dialog controls when the text of a text box changed.
        **-----------------------------------------------------------------------------------------------------------*/
		private void EnableControls() {
			switch (m_dbDialogBehavior) {
				case DialogBehaviors.CreateAccount:
					// Enable/Disable the confirm password text 
					if (!(m_tbxConfirmPassword.Enabled = m_tbxNewPassword.Text.Length > 0)) {
						m_tbxConfirmPassword.Text = ""; // Reset the confirm password text box if it is disabled.
					}
					// Enable/Disable the OK button.
					m_btnOK.Enabled = m_tbxConfirmPassword.Enabled && m_tbxNewPassword.Text == m_tbxConfirmPassword.Text;
					break;
				case DialogBehaviors.SignIn:
					// Enable/Disable the OK button.
					m_btnOK.Enabled = m_tbxPassword.Text.Length > 0;
					break;
				case DialogBehaviors.AccountSettings:
					// Enable/Disable the confirm password text 
					if (!(m_tbxConfirmPassword.Enabled = m_tbxNewPassword.Text.Length > 0)) {
						m_tbxConfirmPassword.Text = "";  // Reset the confirm password text box if it is disabled.
					}
					// Enable/Disable the OK and Delete button.
					m_btnOK.Enabled = (m_btnDelete.Enabled = m_tbxPassword.Text.Length > 0) && m_tbxConfirmPassword.Enabled && m_tbxNewPassword.Text == m_tbxConfirmPassword.Text;

					break;
			}
		}
	}
}