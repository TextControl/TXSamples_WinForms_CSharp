/*-------------------------------------------------------------------------------------------------------------
** MainWindow_FileMenuItem_DropDownOpening.cs File
**
** Description: Provides all DropDownOpening handlers associated with 'File' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** File_DropDownOpening Handler
		**
		** Updates the enabled state of 'File' drop down menu items.
		** 
		** Item: 'File'
		**-----------------------------------------------------------------------------------------------------------*/
		private void File_DropDownOpening(object sender, EventArgs e) {
			// 'Recent Files'
			m_tmiFile_RecentFiles.Enabled = m_colRecentFiles.Count > 0;

			// 'Save'
			m_tmiFile_Save.Enabled = m_bIsDirtyDocument && !m_bIsUnknownDocument;

			// 'Print'
			m_tmiFile_Print.Enabled =
			m_tmiFile_PrintPreview.Enabled = m_txTextControl.CanPrint;
		}
	}
}
