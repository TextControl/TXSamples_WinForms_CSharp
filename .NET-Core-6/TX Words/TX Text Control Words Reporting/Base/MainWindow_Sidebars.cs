/*-------------------------------------------------------------------------------------------------------------
** MainWindow_Sidebars.cs File
**
** Description:
**     Manages the layout of the sidebars when the content layout changed.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using TXTextControl.Windows.Forms;

namespace TXTextControl.Words {
	partial class MainWindow {

		/*-------------------------------------------------------------------------------------------------------------
        ** M E T H O D S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** SetSidebarBehavior Method
        ** Connects the sidebars with the corresponding PropertyChanged handlers.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SetSidebarBehavior() {
			// Left sidebar:
			m_sbSidebarLeft.PropertyChanged += SidebarLeft_PropertyChanged;

			// Right sidebar:
			m_sbSidebarRight.PropertyChanged += SidebarRight_PropertyChanged;

			// Bottom sidebar:
			m_sbSidebarBottom.PropertyChanged += SidebarBottom_PropertyChanged;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** H A N D L E R S
		**-----------------------------------------------------------------------------------------------------------*/
		
		/*-------------------------------------------------------------------------------------------------------------
		** SidebarLeft_PropertyChanged Handler
		** Manages the layout of the left sidebar if its ContentLayout is set to About. 
		**-----------------------------------------------------------------------------------------------------------*/
		private void SidebarLeft_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
			switch (e.PropertyName) {
				case "ContentLayout":
					switch (m_sbSidebarLeft.ContentLayout) {
						case Sidebar.SidebarContentLayout.About:
							m_sbSidebarLeft.ShowPinButton = false;
							m_sbSidebarLeft.IsPinned = true;
							break;
					}
					break;
				case "IsShown":
					m_rtbtnAbout.Checked = m_sbSidebarLeft.ContentLayout == Sidebar.SidebarContentLayout.About && m_sbSidebarLeft.IsShown;
					break;
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** SidebarRight_PropertyChanged Handler
        ** Manages the layout of the right sidebar if its ContentLayout is set to FieldNavigator, Styles, Find or 
        ** Replace.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SidebarRight_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
			if (e.PropertyName == "ContentLayout")
				switch (m_sbSidebarRight.ContentLayout) {
					case Sidebar.SidebarContentLayout.FieldNavigator:
					case Sidebar.SidebarContentLayout.Styles:
						m_sbSidebarRight.ShowPinButton = false;
						m_sbSidebarRight.IsPinned = true;
						m_sbSidebarRight.DialogStyle = Sidebar.SidebarDialogStyle.Standard;
						break;
					default:
						// Find or Replace
						m_sbSidebarRight.ShowPinButton = true;
						m_sbSidebarRight.DialogStyle = Sidebar.SidebarDialogStyle.Standard;
						break;
				}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** SidebarBottom_PropertyChanged Handler
        ** Manages the layout of the bottom sidebar if its ContentLayout is set to Find, Replace and GoTo.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SidebarBottom_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
			if (e.PropertyName == "ContentLayout") {
				switch (m_sbSidebarBottom.ContentLayout) {
					default:
						// Find, Replace and GoTo
						m_sbSidebarBottom.ShowTitle = false;
						m_sbSidebarBottom.DialogStyle = Sidebar.SidebarDialogStyle.Standard;
						break;
				}
			}
		}
	}
}
