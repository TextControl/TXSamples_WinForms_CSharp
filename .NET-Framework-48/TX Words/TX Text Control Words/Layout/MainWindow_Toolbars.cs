/*-------------------------------------------------------------------------------------------------------------
** MainWindow_Toolbars.cs File
**
** Description:
**      Customizes the style of the status bar and the ruler bars.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System.Drawing;

namespace TXTextControl.Words {
	partial class MainWindow {

		/*-------------------------------------------------------------------------------------------------------------
        ** M E T H O D S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** SetButtonBar Method
        ** Customize the ButtonBar' style by colors.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SetButtonBar() {
			// ButtonBar 
			m_bbButtonBar.BackColor = Color.FromArgb(255, 245, 246, 247);
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** SetRulerBarsDesign Method
        ** Customize the RulerBars' style by colors.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SetRulerBarsDesign() {
			// Horizontal ruler bar
			m_rbHorizontalRulerBar.DisplayColors.GradientBackColor =
			m_rbHorizontalRulerBar.DisplayColors.BackColor =

			// Vertical ruler bar
			m_rbVerticalRulerBar.DisplayColors.GradientBackColor =
			m_rbVerticalRulerBar.DisplayColors.BackColor = Color.FromArgb(255, 245, 246, 247);
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** SetStatusBarDesign Method
        ** Customize the StatusBar's style by setting texts and colors.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SetStatusBarDesign() {
			// Status bar texts
			m_sbStatusBar.LineText = Properties.Resources.StatusBar_Line;
			m_sbStatusBar.PageText = Properties.Resources.StatusBar_Page;
			m_sbStatusBar.ColumnText = Properties.Resources.StatusBar_Column;
			m_sbStatusBar.SectionText = Properties.Resources.StatusBar_Section;

			// Status bar colors
			m_sbStatusBar.DisplayColors.BackColorBottom =
			m_sbStatusBar.DisplayColors.BackColorMiddle =
			m_sbStatusBar.DisplayColors.BackColorTop =
			m_sbStatusBar.DisplayColors.FrameColor =
			m_sbStatusBar.DisplayColors.SeparatorColorLight = Color.FromArgb(255, 43, 86, 154);
			m_sbStatusBar.DisplayColors.ForeColor = Color.White;
			m_sbStatusBar.DisplayColors.SeparatorColorDark = Color.White;
		}
	}
}
