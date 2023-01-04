/*-------------------------------------------------------------------------------------------------------------
** MainWindow_AppMenu_FileInfo.cs File
**
** Description:
**     Manages updating information about the current loaded/shown document.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;

namespace TXTextControl.Words {
	partial class MainWindow {

		/*-------------------------------------------------------------------------------------------------------------
        ** M E M B E R   V A R I A B L E S
        **-----------------------------------------------------------------------------------------------------------*/

		// Values that are updated when opening, creating or saving a document.
		private string m_strActiveDocumentName = Properties.Resources.MainWindow_Caption_Untitled; // The document's name is '[Untitled]' on default.
		private string m_strActiveDocumentPath = null; // The path of the active document.
		private StreamType m_stActiveDocumentType = StreamType.RichTextFormat; // The StreamType that was last used to load or save the current document.
		private string m_strUserPasswordPDF = string.Empty; // Tthe password for the user when the document is reopened.
		private string m_strCssFileName = null; //The path and filename of a CSS file belonging to a HTML document.
		private CssSaveMode m_svCssSaveMode = CssSaveMode.None; // Specifies how to save stylesheet data with a HTML document.
		private bool m_bIsUnknownDocument = true; // A flag that indicates whether or not the active document is loaded/saved or created (unknown).

		// A flag that indicates whether or not the document is 'dirty'.
		private bool m_bIsDirtyDocument = false;


		/*-------------------------------------------------------------------------------------------------------------
        ** H A N D L E R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** TextControl_Changed Handler
        ** Updates the 'Is Dirty Document' flag to true if the document changed.
        **-----------------------------------------------------------------------------------------------------------*/
		private void TextControl_Changed(object sender, EventArgs e) {
			if (m_bIsDirtyDocument != (m_bIsDirtyDocument = true)) {
				// Update caption and save button enabled state.
				UpdateMainWindowCaption();
				UpdateSaveEnabledState();
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** M E T H O D S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** UpdateMainWindowCaption Method
        ** Updates the application caption with the name of the active document and the product name.
        **-----------------------------------------------------------------------------------------------------------*/
		private void UpdateMainWindowCaption() {
			this.Text = m_strActiveDocumentName + (m_bIsDirtyDocument ? "*" : "") + " - " + Properties.Resources.MainWindow_Caption_Product;
			this.Refresh();
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** UpdateSaveEnabledState Method
        ** Enables the Save button in case the loaded document is dirty. Otherwise the button is disabled.
        **-----------------------------------------------------------------------------------------------------------*/
		private void UpdateSaveEnabledState() {
			m_rbtnSave.Enabled = m_bIsDirtyDocument && !m_bIsUnknownDocument;
		}
	}
}
