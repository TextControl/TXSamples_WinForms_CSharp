/*-------------------------------------------------------------------------------------------------------------
** MainWindow_AppMenu_About.cs File
**
** Description:
**      Handles displaying the 'About' sidebar and manages its content.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using TXTextControl.Windows.Forms;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** M E T H O D S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** UpdateAboutSidebar Method
        ** Loads the About.xml into the about viewer.
        **-----------------------------------------------------------------------------------------------------------*/
		private void UpdateAboutSidebar() {
			TextControl txAboutViewer = m_sbSidebarLeft.FindItem(Sidebar.AboutItem.TXITEM_AboutViewer) as TextControl;
			txAboutViewer.Tables.GridLines = false; // Disable table grid lines.
			txAboutViewer.PageSize = new PageSize(17010, 17010); // Set a size of 30x30cm
			txAboutViewer.Load(m_strFilesDirectory + "About.xml", StreamType.XMLFormat);
			txAboutViewer.XmlEditMode = XmlEditMode.NoValidate;
		}


		/*-------------------------------------------------------------------------------------------------------------
		** H A N D L E R S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** About_Click Handler
        ** Shows or hides the 'About' sidebar
        **-----------------------------------------------------------------------------------------------------------*/
		private void About_CheckedChanged(object sender, EventArgs e) {
			if (m_rtbtnAbout.Checked) {
				m_sbSidebarLeft.ContentLayout = Sidebar.SidebarContentLayout.About;
				m_sbSidebarLeft.IsShown = true;
				UpdateAboutSidebar();
			}
			else {
				m_sbSidebarLeft.IsShown = false;
			}
		}
	}
}
