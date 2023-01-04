/*-------------------------------------------------------------------------------------------------------------
** Form1.cs File
**
** Description:
**      Sample project that is related to the 'Howto: User XML Files -> Editing in XML Mode' article inside
**		the 'Windows Forms User's Guide'.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Windows.Forms;

namespace XMLEditing {
	public partial class Form1 : Form {
		/*-------------------------------------------------------------------------------------------------------------
		** C O N S T R U C T O R
		**-----------------------------------------------------------------------------------------------------------*/
		public Form1() {
			InitializeComponent();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** H A N D L E R S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** Open_Click Handler
        ** Load an XML file by using the TextControl built-in load dialog.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Open_Click(object sender, EventArgs e) {
			m_txTextControl.Load(TXTextControl.StreamType.XMLFormat);
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** LoadSample_Click Handler
        ** Load the XML 'address_list.xml' file.
        **-----------------------------------------------------------------------------------------------------------*/
		private void LoadSample_Click(object sender, EventArgs e) {
			m_txTextControl.Load(@"Files\address_list.xml", TXTextControl.StreamType.XMLFormat);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** TextControl_XmlInvalid Handler
		** Shows a message box with the corresponding information when a loaded or changed XML document cannot be 
		** validated with the document type definition (DTD) referenced in the document.
		**-----------------------------------------------------------------------------------------------------------*/
		private void TextControl_XmlInvalid(object sender, TXTextControl.XmlErrorEventArgs e) {
			MessageBox.Show(this, e.Reason, String.Format("Invalid XML (Line {0})", e.LineNumber), MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
