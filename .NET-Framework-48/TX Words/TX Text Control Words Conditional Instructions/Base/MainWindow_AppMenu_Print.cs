/*-------------------------------------------------------------------------------------------------------------
** MainWindow_AppMenu_Print.cs File
**
** Description:
**     Manages printing a document
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.ComponentModel;
using System.Drawing.Printing;

namespace TXTextControl.Words {
	partial class MainWindow {

		/*-------------------------------------------------------------------------------------------------------------
        ** H A N D L E R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** Print_Click Handler
        ** Invokes the TextControl Print method to open the TextControl print dialog.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Print_Click(object sender, EventArgs e) {
			// Use the active document name to open the print dialog.
			m_txTextControl.Print(m_strActiveDocumentName);
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** PrintQuick_Click Handler
        ** Prints the current document without opening the dialog before.
        **-----------------------------------------------------------------------------------------------------------*/
		private void PrintQuick_Click(object sender, EventArgs e) {
			m_txTextControl.Print(new PrintDocument() {
				PrinterSettings = new PrinterSettings() {
					FromPage = 1,
					ToPage = m_txTextControl.Pages,
					Copies = 1,
					Collate = true,
					PrintFileName = m_strActiveDocumentName
				},
			});
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** PrintPreview_Click Handler
        ** Opens a print preview.
        **-----------------------------------------------------------------------------------------------------------*/
		private void PrintPreview_Click(object sender, EventArgs e) {
			m_txTextControl.PrintPreview(m_strActiveDocumentName);
		}

		/*--------------------------------------------------------------------------------------------------------------
        ** TextControl_PropertyChanged_Print Handler
        ** Update the print button's enabled states.
        **------------------------------------------------------------------------------------------------------------*/
		private void TextControl_PropertyChanged_Print(object sender, PropertyChangedEventArgs e) {
			switch (e.PropertyName) {
				case "CanPrint":
					m_rsbtnPrint.Enabled =
					m_rbtnPrint.Enabled =
					m_rbtnPrintQuick.Enabled =
					m_rbtnPrintPreview.Enabled = m_txTextControl.CanPrint;
					break;
			}
		}
	}
}
