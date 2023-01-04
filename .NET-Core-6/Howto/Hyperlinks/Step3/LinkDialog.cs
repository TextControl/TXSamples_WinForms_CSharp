/*-------------------------------------------------------------------------------------------------------------
** LinkDialog.cs File
**
** Description:
**      A custom dialog to create or edit a link.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Windows.Forms;

namespace Step3 {
	public partial class LinkDialog : Form {
		/*-------------------------------------------------------------------------------------------------------------
		** E N U M S
		**-----------------------------------------------------------------------------------------------------------*/
		internal enum DialogMode {
			InsertLink,
			EditHyperlink,
			EditDocumentLink
		}


		/*-------------------------------------------------------------------------------------------------------------
		** M E M B E R   V A R I A B L E S
		**-----------------------------------------------------------------------------------------------------------*/
		private DialogMode m_dmDialogMode;
		private TXTextControl.TextField m_tfLink;
		private TXTextControl.TextControl m_txTextControl;


		/*-------------------------------------------------------------------------------------------------------------
		** C O N S T R U C T O R
		**-----------------------------------------------------------------------------------------------------------*/
		public LinkDialog(TXTextControl.TextField link, TXTextControl.TextControl textControl) {
			m_tfLink = link;
			m_txTextControl = textControl;
			InitializeComponent();

			// Determine the dialog mode.
			m_dmDialogMode = m_tfLink == null ?
				DialogMode.InsertLink : m_tfLink is TXTextControl.HypertextLink ?
				DialogMode.EditHyperlink : DialogMode.EditDocumentLink;
		}


		/*-------------------------------------------------------------------------------------------------------------
		** H A N D L E R S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** CustomLinkDialog_Load Handler
        ** Updates the dialog layout according to the handled link.
        **-----------------------------------------------------------------------------------------------------------*/
		private void CustomLinkDialog_Load(object sender, EventArgs e) {
			// Update the dialog layout considering the set dialog mode.
			switch (m_dmDialogMode) {
				case DialogMode.InsertLink:
					m_cmbxDocumentTargets.Visible = false;
					this.Text = "Insert Link";
					break;
				case DialogMode.EditHyperlink:
					this.Text = "Edit Hyperlink";
					m_tlpLinkType.Visible = false;
					m_cmbxDocumentTargets.Visible = false;
					break;
				case DialogMode.EditDocumentLink:
					this.Text = "Edit Document Link";
					m_tlpLinkType.Visible = false;
					m_tbxHyperlink.Visible = false;
					break;
			}

			// Fill the document targets combo box with references to the document targets
			// of the document.
			if (m_dmDialogMode != DialogMode.EditHyperlink) {
				TXTextControl.DocumentTargetCollection colDocumentTargets = m_txTextControl.DocumentTargets;
				foreach (TXTextControl.DocumentTarget target in colDocumentTargets) {
					m_cmbxDocumentTargets.Items.Add(new DocumentTargetItem(target));
				}
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** Type_CheckedChanged Handler
        ** Update the visibility of the corresponding control when the type radio button checked state changed.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Type_CheckedChanged(object sender, EventArgs e) {
			if (!m_rbtnTypeHyperlink.Checked) {
				// The document targets combo box is displayed when the 'Document Link' radio button is toggled.
				m_tbxHyperlink.Visible = false;
				m_cmbxDocumentTargets.Visible = true;
			}
			else {
				// The text box is displayed to enter a hyperlink when the 'Hyperlink' radio button is toggled.
				m_cmbxDocumentTargets.Visible = false;
				m_tbxHyperlink.Visible = true;
			}

			// Update the enabled state of the OK button.
			m_btnOK.Enabled = IsValidLink();
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** LinkParameter_Changed Handler
        ** Update the enabled state of the 'OK' button when the text of any text boxes or the selected item of the 
        ** document targets combo box changed.
        **-----------------------------------------------------------------------------------------------------------*/
		private void LinkParameter_Changed(object sender, EventArgs e) {
			m_btnOK.Enabled = IsValidLink();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** OK_Click Handler
		** Create or edit a link when clicking the 'OK' button.
		**-----------------------------------------------------------------------------------------------------------*/
		private void OK_Click(object sender, EventArgs e) {
			// Consider the current mode.
			switch (m_dmDialogMode) {
				case DialogMode.InsertLink: {
						// The dialog is opened to create a link:
						if (m_rbtnTypeHyperlink.Checked) {
							// Create a new hyperlink and insert it into the TextControl.
							TXTextControl.HypertextLink hlHypertextLink = new TXTextControl.HypertextLink(m_tbxDisplayedText.Text, m_tbxHyperlink.Text);
							hlHypertextLink.DoubledInputPosition = true;
							m_txTextControl.HypertextLinks.Add(hlHypertextLink);
						}
						else {
							// Create a new document link and insert it into the TextControl.
							TXTextControl.DocumentLink dlDocumentLink = new TXTextControl.DocumentLink(m_tbxDisplayedText.Text, (m_cmbxDocumentTargets.SelectedItem as DocumentTargetItem).DocumentTarget);
							dlDocumentLink.DoubledInputPosition = true;
							m_txTextControl.DocumentLinks.Add(dlDocumentLink);
						}
					}
					break;
				case DialogMode.EditHyperlink: {
						// The dialog is opened to edit a hyperlink:
						// Update the text of the hyperlink.
						TXTextControl.HypertextLink hlHypertextLink = m_tfLink as TXTextControl.HypertextLink;
						hlHypertextLink.Text = m_tbxDisplayedText.Text;
						hlHypertextLink.Target = m_tbxHyperlink.Text;
					}
					break;
				case DialogMode.EditDocumentLink: {
						// The dialog is opened to edit a document link:
						// Update the text and the document target of the document link.
						TXTextControl.DocumentLink dlDocumentLink = m_tfLink as TXTextControl.DocumentLink;
						dlDocumentLink.Text = m_tbxDisplayedText.Text;
						dlDocumentLink.DocumentTarget = (m_cmbxDocumentTargets.SelectedItem as DocumentTargetItem).DocumentTarget;
					}
					break;
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
		** M E T H O D S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** IsValidLink Method
        ** Returns a value indicating whether both the 'Displayed Text' text box contains text and the link specific
        ** control (hyperlink text box or document link combo box) contains a valid value.
        **
        ** Returns:		True, if both the 'Displayed Text' text box contains text and the link specific control 
        **				(hyperlink text box or document link combo box) contains a valid value.
        **				Otherwise false.
        **-----------------------------------------------------------------------------------------------------------*/
		private bool IsValidLink() {
			return m_tbxDisplayedText.Text.Trim().Length > 0 && (m_cmbxDocumentTargets.Visible ? m_cmbxDocumentTargets.SelectedIndex != -1 : m_tbxHyperlink.Text.Trim().Length > 0); ;
		}
	}
}
