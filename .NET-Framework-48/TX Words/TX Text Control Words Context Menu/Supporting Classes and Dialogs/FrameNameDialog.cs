/*-------------------------------------------------------------------------------------------------------------
** FrameNameDialog.cs File
**
** Description:
**     Provides a dialog to to edit the name of a frame.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System.Windows.Forms;

namespace TXTextControl.Words {
	/*-------------------------------------------------------------------------------------------------------------
    ** FrameNameDialog Class
    ** A dialog to to edit the name of a frame.
    **-----------------------------------------------------------------------------------------------------------*/
	internal partial class FrameNameDialog : Form {

		/*-------------------------------------------------------------------------------------------------------------
        ** C O N S T R U C T O R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** FrameNameDialog Constructor
        ** Opens the dialog to edit the name of a frame.
        **
        ** Parameters:
        **      frameName:   The current name of the frame.
        **-----------------------------------------------------------------------------------------------------------*/
		internal FrameNameDialog(string frameName) {
			InitializeComponent();
			m_tbxFrameName.Text = frameName; // Set the text box text.

			// Update the texts of the controls.
			this.Text = Properties.Resources.ContextMenu_FrameNameDialog_Caption;
			m_lblFrameName.Text = Properties.Resources.ContextMenu_FrameNameDialog_Label;
			m_btnOK.Text = Properties.Resources.ContextMenu_FrameNameDialog_OK;
			m_btnCancel.Text = Properties.Resources.ContextMenu_FrameNameDialog_Cancel;
		}


		/*-------------------------------------------------------------------------------------------------------------
		** P R O P E R T I E S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** FrameName Property
        ** Returns the text of the frame name text box.
        **-----------------------------------------------------------------------------------------------------------*/
		internal string FrameName { get { return m_tbxFrameName.Text; } }
	}
}
