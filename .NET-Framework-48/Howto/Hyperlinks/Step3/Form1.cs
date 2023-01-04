/*-------------------------------------------------------------------------------------------------------------
** Form1.cs File
**
** Description:
**      Sample project that is related to the 'Howto: Use Hypertext Links -> Step 3: Adding Document Targets' 
**		article inside the 'Windows Forms User's Guide'.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Windows.Forms;

namespace Step3 {
	public partial class Form1 : Form {

		/*-------------------------------------------------------------------------------------------------------------
		** M E M B E R   V A R I A B L E S
		**-----------------------------------------------------------------------------------------------------------*/
		private TXTextControl.TextField m_tfCurrentLink = null;
		private TXTextControl.DocumentTarget m_dtCurrentDocumentTarget = null;


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
        ** 'File' Drop Down
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** New_Click Handler
        ** Deletes the entire contents of a Text Control.
        **-----------------------------------------------------------------------------------------------------------*/
		private void New_Click(object sender, EventArgs e) {
			m_txTextControl.ResetContents();
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** Open_Click Handler
        ** Opens a built-in dialog to load a document into the TextControl.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Open_Click(object sender, EventArgs e) {
			m_txTextControl.Load();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** SaveAs_Click Handler
		** Opens a built-in dialog to save the document.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SaveAs_Click(object sender, EventArgs e) {
			m_txTextControl.Save();
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** 'Links' Drop Down
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** Links_DropDownOpening Handler
        ** When opening the 'Links' menu item drop down, check whether there is a text field (base class of 
        ** HypertextLink and DocumentLink) at the current input position and update the enabled state of the 
        ** corresponding 'Insert...' and 'Edit...' items.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Links_DropDownOpening(object sender, EventArgs e) {
			// Get the text field at the current input position.
			m_tfCurrentLink = m_txTextControl.TextFields.GetItem();
			// Disable the 'Insert...' item if there is a text field at the
			// current input position.
			m_tmiInsertLink.Enabled = m_tfCurrentLink == null;
			// Disable the 'Edit...' item if there is no hyperlink or 
			// document linkat the current input position.
			m_tmiEditLink.Enabled = m_tfCurrentLink != null && (m_tfCurrentLink is TXTextControl.HypertextLink || m_tfCurrentLink is TXTextControl.DocumentLink);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** OpenCustomLinkDialog_Click Handler
		** Open the custom link dialog to create or edit a link.
		**-----------------------------------------------------------------------------------------------------------*/
		private void OpenCustomLinkDialog_Click(object sender, EventArgs e) {
			// Open the custom link dialog to create or edit a link.
			LinkDialog dlgLinkDialog = new LinkDialog(m_tfCurrentLink, m_txTextControl);
			dlgLinkDialog.ShowDialog(this);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** TextControl_TextFieldCreated Handler
		** Update the underline style and fore color settings when a hyperlink or document link is created.
		**-----------------------------------------------------------------------------------------------------------*/
		private void TextControl_TextFieldCreated(object sender, TXTextControl.TextFieldEventArgs e) {
			// Update the underline style and fore color settings of the created link.
			if (e.TextField is TXTextControl.HypertextLink || e.TextField is TXTextControl.DocumentLink) {
				HighlightLink(e.TextField, m_tmiShowHyperlinks.Checked);
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** ShowHyperlinks_Click Handler
        ** Step through all hyperlinks to update the underline style and fore color settings.
        **-----------------------------------------------------------------------------------------------------------*/
		private void ShowHyperlinks_Click(object sender, EventArgs e) {
			// Step through all hyperlinks to update the underline style and fore color settings.
			TXTextControl.HypertextLinkCollection colHyperlinks = m_txTextControl.HypertextLinks;
			foreach (TXTextControl.HypertextLink link in colHyperlinks) {
				HighlightLink(link, m_tmiShowHyperlinks.Checked);
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** ShowDocumentLinks_Click Handler
		** Step through all document links to update the underline style and fore color settings.
		**-----------------------------------------------------------------------------------------------------------*/
		private void ShowDocumentLinks_Click(object sender, EventArgs e) {
			// Step through all document links to update the underline style and fore color settings.
			TXTextControl.DocumentLinkCollection colDocumentLinks = m_txTextControl.DocumentLinks;
			foreach (TXTextControl.DocumentLink link in colDocumentLinks) {
				HighlightLink(link, m_tmiShowDocumentLinks.Checked);
			}
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
		** TextControl_DocumentLinkClicked Handler
		** Scroll to the target of the clicked document link.
		**-----------------------------------------------------------------------------------------------------------*/
		private void TextControl_DocumentLinkClicked(object sender, TXTextControl.DocumentLinkEventArgs e) {
			TXTextControl.DocumentTarget dtTarget = e.DocumentLink.DocumentTarget;
			if (dtTarget != null) {
				dtTarget.ScrollTo();
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** 'Document Targets' Drop Down
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** DocumentTargets_DropDownOpening Handler
        ** When opening the 'Document Targets' menu item drop down, check whether there is a document target at 
        ** the current input position and update the enabled state of the corresponding 'Insert..' and 'Edit...' items.
        **-----------------------------------------------------------------------------------------------------------*/
		private void DocumentTargets_DropDownOpening(object sender, EventArgs e) {
			m_dtCurrentDocumentTarget = m_txTextControl.DocumentTargets.GetItem();
			m_tmiEditDocumentTarget.Enabled = m_dtCurrentDocumentTarget != null;
			m_tmiShowDocumentTargets.Checked = m_txTextControl.DocumentTargetMarkers;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** InsertDocumentTarget_Click Handler
		** Open the document target dialog to create a document target.
		**-----------------------------------------------------------------------------------------------------------*/
		private void InsertDocumentTarget_Click(object sender, EventArgs e) {
			DocumentTargetDialog dlgDocumentTargetDialog = new DocumentTargetDialog(null, m_txTextControl);
			dlgDocumentTargetDialog.ShowDialog(this);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** EditDocumentTarget_Click Handler
		** Open the document target dialog to edit a document target.
		**-----------------------------------------------------------------------------------------------------------*/
		private void EditDocumentTarget_Click(object sender, EventArgs e) {
			DocumentTargetDialog dlgDocumentTargetDialog = new DocumentTargetDialog(m_dtCurrentDocumentTarget, m_txTextControl);
			dlgDocumentTargetDialog.ShowDialog(this);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** DeleteAndGoToTarget_Click Handler
		** Open the delete and go to target dialog to delete or navigate to a document target.
		**-----------------------------------------------------------------------------------------------------------*/
		private void DeleteAndGoToTarget_Click(object sender, EventArgs e) {
			DeleteAndGoToTargetDialog dlgDeleteAndGoToTargetDialog = new DeleteAndGoToTargetDialog(m_txTextControl);
			dlgDeleteAndGoToTargetDialog.ShowDialog(this);
		}


		/*-------------------------------------------------------------------------------------------------------------
		** ShowDocumentTargets_Click Handler
		** Sets a value indicating that markers for document targets are shown or not.
		**-----------------------------------------------------------------------------------------------------------*/
		private void ShowDocumentTargets_Click(object sender, EventArgs e) {
			m_txTextControl.DocumentTargetMarkers = m_tmiShowDocumentTargets.Checked;
		}


		/*-------------------------------------------------------------------------------------------------------------
		** M E T H O D S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** HighlightLink Method
        ** Determines for the specified link whether or not the text should be formatted with
        ** blue (hyperlink) or green (document link) fore color and a single underline style.
        **
        ** Parameters:
        **		link		The link to handle.
        **		highlight	A value that indicates whether or not the link 
        **					should be highlighted.
        **-----------------------------------------------------------------------------------------------------------*/
		private void HighlightLink(TXTextControl.TextField link, bool highlight) {
			// Create a selection object to determine the color and underline style
			// of the link text.
			TXTextControl.Selection selLink = new TXTextControl.Selection(link.Start - 1, link.Length);

			// Determine the fore color and underline style settings.
			if (highlight) {
				selLink.ForeColor = link is TXTextControl.HypertextLink ? System.Drawing.Color.Blue : System.Drawing.Color.Green;
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

	/*-------------------------------------------------------------------------------------------------------------
	**S U P P O R T I N G   C L A S S E S
	**-----------------------------------------------------------------------------------------------------------*/

	/*-------------------------------------------------------------------------------------------------------------
	** DocumentTargetItem class
	** Used as item inside a combo or list box to display an obejct of type DocumentTarget. 
	**-----------------------------------------------------------------------------------------------------------*/
	internal class DocumentTargetItem {
		// Member Variables
		private TXTextControl.DocumentTarget m_dtDocumentTarget;
		private string m_strDisplayedText;
		private bool m_bIsDocumentTargetDeletable;

		// Constructor
		internal DocumentTargetItem(TXTextControl.DocumentTarget documentTarget) {
			m_dtDocumentTarget = documentTarget;
			m_strDisplayedText = m_dtDocumentTarget.TargetName;
			m_bIsDocumentTargetDeletable = documentTarget.Deleteable;
		}

		// Properties
		internal string DisplayedText { get { return m_strDisplayedText; } set { m_strDisplayedText = value; } }

		internal TXTextControl.DocumentTarget DocumentTarget { get { return m_dtDocumentTarget; } }

		internal bool IsDocumentTargetDeletable { get { return m_bIsDocumentTargetDeletable; } set { m_bIsDocumentTargetDeletable = value; } }

		// Overridden Methods
		public override string ToString() {
			return m_strDisplayedText;
		}
	}
}
