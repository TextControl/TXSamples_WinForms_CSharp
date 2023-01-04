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
        ** Manages the layout of the left sidebar if its ContentLayout is set to TrackedChanges, DocumentSettings or 
        ** About. 
        **-----------------------------------------------------------------------------------------------------------*/
		private void SidebarLeft_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
			switch (e.PropertyName) {
				case "ContentLayout":
					switch (m_sbSidebarLeft.ContentLayout) {
						case Sidebar.SidebarContentLayout.TrackedChanges:
							m_sbSidebarLeft.ShowPinButton = true;
							m_rtbtnDocumentSettings.Checked = false;
							m_rtbtnAbout.Checked = false;
							break;
						case Sidebar.SidebarContentLayout.DocumentSettings:
							m_sbSidebarLeft.ShowPinButton = false;
							m_sbSidebarLeft.IsPinned = true;
							m_rtbtnDocumentSettings.Checked = true;
							m_rtbtnAbout.Checked = false;
							break;
						case Sidebar.SidebarContentLayout.About:
							m_sbSidebarLeft.ShowPinButton = false;
							m_sbSidebarLeft.IsPinned = true;
							m_rtbtnDocumentSettings.Checked = false;
							break;
					}
					break;
				case "IsShown":
					m_rtbtnDocumentSettings.Checked = m_sbSidebarLeft.ContentLayout == Sidebar.SidebarContentLayout.DocumentSettings && m_sbSidebarLeft.IsShown;
					m_rtbtnAbout.Checked = m_sbSidebarLeft.ContentLayout == Sidebar.SidebarContentLayout.About && m_sbSidebarLeft.IsShown;
					break;
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** SidebarRight_PropertyChanged Handler
        ** Manages the layout of the right sidebar if its ContentLayout is set to ConditionalInstructions,
        ** FieldNavigator, Styles, Comments, Find or Replace.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SidebarRight_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
			if (e.PropertyName == "ContentLayout")
				switch (m_sbSidebarRight.ContentLayout) {
					case Sidebar.SidebarContentLayout.ConditionalInstructions:
						m_sbSidebarRight.ShowPinButton = true;
						m_sbSidebarRight.DialogStyle = Sidebar.SidebarDialogStyle.Standard;
						break;
					case Sidebar.SidebarContentLayout.FieldNavigator:
					case Sidebar.SidebarContentLayout.Styles:
						m_sbSidebarRight.ShowPinButton = false;
						m_sbSidebarRight.IsPinned = true;
						m_sbSidebarRight.DialogStyle = Sidebar.SidebarDialogStyle.Standard;
						break;
					case Sidebar.SidebarContentLayout.Comments:
						m_sbSidebarRight.ShowPinButton = true;
						m_sbSidebarRight.DialogStyle = Sidebar.SidebarDialogStyle.StandardSizable;
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
        ** Manages the layout of the bottom sidebar if its ContentLayout is set to TrackedChanges, Comments, Find,
        ** Replace and GoTo.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SidebarBottom_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
			if (e.PropertyName == "ContentLayout") {
				switch (m_sbSidebarBottom.ContentLayout) {
					case Sidebar.SidebarContentLayout.TrackedChanges:
					case Sidebar.SidebarContentLayout.Comments:
						m_sbSidebarBottom.ShowTitle = true;
						m_sbSidebarBottom.DialogStyle = Sidebar.SidebarDialogStyle.StandardSizable;
						break;
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
