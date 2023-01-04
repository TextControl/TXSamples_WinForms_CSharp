/*-------------------------------------------------------------------------------------------------------------
** Form1.cs File
**
** Description:
**      Sample project that is related to the 'Howto: Use Hypertext Links -> Step 2: Adding a Dialog Box for 
**		Inserting Hypertext Links ' article inside the 'Windows Forms User's Guide'.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Windows.Forms;

namespace Step2 {
	public partial class Form1 : Form {
		/*-------------------------------------------------------------------------------------------------------------
		** M E M B E R   V A R I A B L E S
		**-----------------------------------------------------------------------------------------------------------*/
		private TXTextControl.HypertextLink m_hlCurrentHyperlink = null;


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
        ** Hyperlinks_DropDownOpening Handler
        ** When opening the 'Hyperlinks' menu item drop down, check whether there is a hyperlink at the current 
        ** input position and update the enabled state of the 'Insert...' and 'Edit...' items.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Hyperlinks_DropDownOpening(object sender, EventArgs e) {
			// Get the hyperlink at the current input position.
			m_hlCurrentHyperlink = m_txTextControl.HypertextLinks.GetItem();
			// Disable the 'Insert...' item if there is a hyperlink at the
			// current input position.
			m_tmiInsertHyperlink.Enabled = m_hlCurrentHyperlink == null;
			// Disable the 'Edit...' item if there is no hyperlink at the
			// current input position.
			m_tmiEditHyperlink.Enabled = m_hlCurrentHyperlink != null;
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** OpenHyperlinkDialog_Click Handler
        ** Open the custom hyperlink dialog to create or edit a hyperlink.
        **-----------------------------------------------------------------------------------------------------------*/
		private void OpenHyperlinkDialog_Click(object sender, EventArgs e) {
			// Open the custom hyperlink dialog to create or edit a hyperlink.
			CustomHyperlinkDialog dlgInsertHyperlinkDialog = new CustomHyperlinkDialog(m_hlCurrentHyperlink, m_txTextControl);
			dlgInsertHyperlinkDialog.ShowDialog(this);
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** TextControl_TextFieldCreated Handler
        ** Update the underline style and fore color settings when a hyperlink is created.
        **-----------------------------------------------------------------------------------------------------------*/
		private void TextControl_TextFieldCreated(object sender, TXTextControl.TextFieldEventArgs e) {
			// Update the underline style and fore color settings of the created hyperlink.
			if (e.TextField is TXTextControl.HypertextLink) {
				HighlightHyperlink(e.TextField as TXTextControl.HypertextLink, m_tmiShowHyperlinks.Checked);
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** ShowHyperlinks_Click Handler
        ** Step through all hyperlinks to update the underline style and fore color settings.
        **-----------------------------------------------------------------------------------------------------------*/
		private void ShowHyperlinks_Click(object sender, EventArgs e) {
			m_txTextControl.BeginUndoAction("Show Hyperlinks");
			// Step through all hyperlinks to update the underline style and fore color settings.
			TXTextControl.HypertextLinkCollection colHyperlinks = m_txTextControl.HypertextLinks;
			foreach (TXTextControl.HypertextLink link in colHyperlinks) {
				HighlightHyperlink(link, m_tmiShowHyperlinks.Checked);
			}
			m_txTextControl.EndUndoAction();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** TextControl_HypertextLinkClicked Handler
		** Open the clicked link by the system's default application to open a hyperlink.
		**-----------------------------------------------------------------------------------------------------------*/
		private void TextControl_HypertextLinkClicked(object sender, TXTextControl.HypertextLinkEventArgs e) {
			// Get the hyperlink target.
			string strHyperlink = e.HypertextLink.Target;
			// Update target to a correct hyperlink if necessary.
			if (!strHyperlink.StartsWith("http://")) {
				strHyperlink = "http://" + strHyperlink;
			}
			// Create an URI object and try to open the link by the system's default application
			// to open a hyperlink.
			Uri uriTarget;
			if (Uri.TryCreate(strHyperlink, UriKind.RelativeOrAbsolute, out uriTarget) && uriTarget.IsAbsoluteUri) {
				System.Diagnostics.Process.Start(uriTarget.AbsoluteUri);
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
		** M E T H O D S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** HighlightHyperlink Method
        ** Determines for the specified hyperlink whether or not the text should be
        ** formatted with blue fore color and a single underline style.
        **
        ** Parameters:
        **		link		The hyperlink to handle.
        **		highlight	A value that indicates whether or not the hyperlink 
        **					should be highlighted.
        **-----------------------------------------------------------------------------------------------------------*/
		private void HighlightHyperlink(TXTextControl.HypertextLink link, bool highlight) {
			// Create a selection object to determine the color and underline style
			// of the hyperlink text.
			TXTextControl.Selection selLink = new TXTextControl.Selection(link.Start - 1, link.Length);

			// Determine the fore color and underline style settings.
			if (highlight) {
				selLink.ForeColor = System.Drawing.Color.Blue;
				selLink.Underline = TXTextControl.FontUnderlineStyle.Single;
			}
			else {
				selLink.ForeColor = System.Drawing.Color.Black;
				selLink.Underline = TXTextControl.FontUnderlineStyle.None;
			}

			// Apply the settings by adopting the selection.
			m_txTextControl.Selection = selLink;

			// Set the input position inside the hyperlink to prevent adopting the set formatting when
			// typing right behind the hyperlink.
			m_txTextControl.InputPosition = new TXTextControl.InputPosition(selLink.Start + selLink.Length, TXTextControl.TextFieldPosition.InsideTextField);
		}
	}
}
