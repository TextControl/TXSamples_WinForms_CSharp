/*-------------------------------------------------------------------------------------------------------------
** MainWindow_AppMenu_DocumentSettings.cs File
**
** Description:
**     Manages showing/hiding the document settings sidebar.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using TXTextControl.Windows.Forms;
using TXTextControl.Windows.Forms.Ribbon;

namespace TXTextControl.Words {
	partial class MainWindow {

		/*-------------------------------------------------------------------------------------------------------------
        ** H A N D L E R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** DocumentSettings_Handler Handler
        ** Shows and hides the Document Settings sidebar when the checked state of the corresponding button
        ** changed.
        **-----------------------------------------------------------------------------------------------------------*/
		private void DocumentSettings_CheckedChanged(object sender, EventArgs e) {
			if ((sender as RibbonToggleButton).Checked) {
				// Set the content layout of the sidebar to DocumentSettings when the button is checked.
				m_sbSidebarLeft.ContentLayout = Sidebar.SidebarContentLayout.DocumentSettings;
			}
			// Show/hide the sidebar.
			m_sbSidebarLeft.IsShown = (sender as RibbonToggleButton).Checked;
		}
	}
}
