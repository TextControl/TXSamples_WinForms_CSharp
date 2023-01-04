/*-------------------------------------------------------------------------------------------------------------
** PasswordDialog.xaml.cs File
**
** Description:
**     Provides a dialog that sets the password that is used to load a password protected document.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.IO;
using System.Windows.Forms;

namespace TXTextControl.Words {
	/// <summary>
	/// Interaction logic for PasswordDialog.xaml
	/// </summary>
	public partial class PasswordDialog : Form {
		/*-------------------------------------------------------------------------------------------------------------
		** M E M B E R   V A R I A B L E S
		**-----------------------------------------------------------------------------------------------------------*/
		private TextControl m_txTextControl;
		private LoadSettings m_lsLoadSettings;


		/*-------------------------------------------------------------------------------------------------------------
        ** C O N S T R U C T O R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** PasswordDialog Constructor
        ** Opens the password dialog to set the password that is used to load a password protected document.
        **
        ** Parameters:
        **      textControl:    The TextControl where to load the password protected document.
        **		loadSettings:	The LoadSettings that are used to load the password protected document.
        **-----------------------------------------------------------------------------------------------------------*/
		public PasswordDialog(TextControl textControl, LoadSettings loadSettings) {
			m_txTextControl = textControl;
			m_lsLoadSettings = loadSettings;

			InitializeComponent();

			// Set the texts of the dialog
			this.Text = Properties.Resources.PasswordDialog_Caption;
			m_lbProtectedDocument.Text = String.Format(Properties.Resources.PasswordDialog_ProtectedDocument, Path.GetFileName(m_lsLoadSettings.LoadedFile));
			m_lblEnterPassword.Text = Properties.Resources.PasswordDialog_EnterPassword;
			m_lblPassword.Text = Properties.Resources.PasswordDialog_Password;
			m_btnOK.Text = Properties.Resources.PasswordDialog_OK;
			m_btnCancel.Text = Properties.Resources.PasswordDialog_Cancel;
		}


		/*-------------------------------------------------------------------------------------------------------------
		** H A N D L E R S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** OK_Click Handler
        ** When clicking the OK button the set password from the text box is used to open the password protected 
        ** document.
        **-----------------------------------------------------------------------------------------------------------*/
		private void OK_Click(object sender, EventArgs e) {
			if (LoadDocument()) {
				this.DialogResult = DialogResult.OK;
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** Password_TextChanged Handler
        ** Updates the enabled state of the OK button.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Password_TextChanged(object sender, EventArgs e) {
			m_btnOK.Enabled = m_tbxPassword.Text.Length > 0;
		}


		/*-------------------------------------------------------------------------------------------------------------
		** M E T H O D S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** LoadDocument Method
        ** Uses the set password from the text box to load the password protected document.
        **
       	** Return value:		True if the password protected document could be loaded.
        **						Otherwise false.
        **-----------------------------------------------------------------------------------------------------------*/
		private bool LoadDocument() {
			try {
				// Set the password from the text box and...
				m_lsLoadSettings.UserPassword = m_tbxPassword.Text;
				// ... try to load the document.
				m_txTextControl.Load(m_lsLoadSettings.LoadedFile, m_lsLoadSettings.LoadedStreamType, m_lsLoadSettings);
				return true;
			} catch (FilterException ex) {
				if (ex is FilterException) {
					switch ((ex as FilterException).Reason) {
						case FilterException.FilterError.InvalidPassword:
							// The set password is incorrect.
							// Inform the user, reset the password and return false.
							MessageBox.Show(this, Properties.Resources.MessageBox_PasswordDialog_IncorrectPassword_Text, Properties.Resources.MessageBox_PasswordDialog_IncorrectPassword_Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
							m_lsLoadSettings.UserPassword = string.Empty;
							return false;
					}
				}
				throw ex;
			}
		}
	}
}
