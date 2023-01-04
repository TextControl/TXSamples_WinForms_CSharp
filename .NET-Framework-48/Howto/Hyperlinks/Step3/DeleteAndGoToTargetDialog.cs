/*-------------------------------------------------------------------------------------------------------------
** DeleteAndGoToTargetDialog.cs File
**
** Description:
**      A custom dialog to delete or navigate to document targets.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Step3 {
	public partial class DeleteAndGoToTargetDialog : Form {
		/*-------------------------------------------------------------------------------------------------------------
		** M E M B E R   V A R I A B L E S
		**-----------------------------------------------------------------------------------------------------------*/
		private TXTextControl.TextControl m_txTextControl;
		private List<TXTextControl.DocumentTarget> m_lstTagetsToDelete = new List<TXTextControl.DocumentTarget>();


		/*-------------------------------------------------------------------------------------------------------------
		** C O N S T R U C T O R
		**-----------------------------------------------------------------------------------------------------------*/
		public DeleteAndGoToTargetDialog(TXTextControl.TextControl textControl) {
			m_txTextControl = textControl;
			InitializeComponent();
		}


		/*-------------------------------------------------------------------------------------------------------------
		** H A N D L E R S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** DeleteAndGoToTargetDialog_Load Handler
        ** Updates the dialog layout.
        **-----------------------------------------------------------------------------------------------------------*/
		private void DeleteAndGoToTargetDialog_Load(object sender, EventArgs e) {
			// Fill the 'Document Targets' list box with all document targets of the document.
			TXTextControl.DocumentTargetCollection colDocumentTargets = m_txTextControl.DocumentTargets;
			foreach (TXTextControl.DocumentTarget documentTarget in colDocumentTargets) {
				m_lbxDocumentTargets.Items.Add(new DocumentTargetItem(documentTarget));
			}

			// Select the first item.
			if (m_lbxDocumentTargets.Items.Count > 0) {
				m_lbxDocumentTargets.SelectedIndex = 0;
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** DocumentTargets_SelectedIndexChanged Handler
        ** Update the enabled state of the 'Delete' and 'Go To' buttons when the selected index of the 
        ** 'Document Targets' list box changed.
        **-----------------------------------------------------------------------------------------------------------*/
		private void DocumentTargets_SelectedIndexChanged(object sender, EventArgs e) {
			m_btnDelete.Enabled =
			m_btnGoTo.Enabled = m_lbxDocumentTargets.SelectedIndex != -1;
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** Delete_Click Handler
        ** Remove the selected item from the 'Document Targets' list box.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Delete_Click(object sender, EventArgs e) {
			// Remember the current index.
			int iSelectedIndex = m_lbxDocumentTargets.SelectedIndex;

			// Get the current selected item.
			DocumentTargetItem dtiItemToDelete = m_lbxDocumentTargets.SelectedItem as DocumentTargetItem;
			m_lstTagetsToDelete.Add(dtiItemToDelete.DocumentTarget); // Remember that item.
			m_lbxDocumentTargets.Items.Remove(dtiItemToDelete); // Remove that item from the 'Document Targets' list box.

			// Select a new item.
			if (m_lbxDocumentTargets.Items.Count > 0) {
				m_lbxDocumentTargets.SelectedIndex = Math.Max(0, Math.Min(iSelectedIndex, m_lbxDocumentTargets.Items.Count - 1));
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** GoTo_Click Handler
        ** Scroll to the document target that is represented by the selected item inside the 
        ** 'Document Targets' list box.
        **-----------------------------------------------------------------------------------------------------------*/
		private void GoTo_Click(object sender, EventArgs e) {
			(m_lbxDocumentTargets.SelectedItem as DocumentTargetItem).DocumentTarget.ScrollTo();
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** OK_Click Handler
        ** Delete all corresponding document targets that were removed from the 'Document Targets' list box.
        **-----------------------------------------------------------------------------------------------------------*/
		private void OK_Click(object sender, EventArgs e) {
			if (m_lstTagetsToDelete.Count > 0) {
				TXTextControl.DocumentTargetCollection colDocumentTargets = m_txTextControl.DocumentTargets;
				foreach (TXTextControl.DocumentTarget documentTarget in m_lstTagetsToDelete) {
					colDocumentTargets.Remove(documentTarget);
				}
			}
		}
	}
}
