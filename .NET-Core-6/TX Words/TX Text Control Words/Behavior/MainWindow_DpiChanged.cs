/*-------------------------------------------------------------------------------------------------------------
** MainWindow_DpiChanged.cs File
**
** Description:
**     Handles custom image updating when the application resolution changed.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System.Drawing;
using System.Windows.Forms;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** M E M B E R   V A R I A B L E S
		**-----------------------------------------------------------------------------------------------------------*/
		private float m_fDPI = 0;


		/*-------------------------------------------------------------------------------------------------------------
        ** O V E R R I D D E N   M E T H O D S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** WndProc Method (overridden)
		** Overridden to get the DPI value when the window is created and to update the icons of the custom 
		** ribbon buttons and groups when the dpi value changed.
		**
		** Parameters:
		**      message:   The Windows Message to process.
		**-----------------------------------------------------------------------------------------------------------*/
		protected override void WndProc(ref Message message) {
			switch (message.Msg) {
				case 0x0001: // WM_CREATE
							 // Get the DPI value from the created handle.
					using (Graphics g = Graphics.FromHwnd(this.Handle)) {
						m_fDPI = g.DpiX;
					}
					break;
				case 0x02E0: // WM_DPICHANGED
							 // Get the new DPI value when the dpi value changed.
					int iNewDPI = (int)message.WParam & 0xFFFF;
					if (m_fDPI != (m_fDPI = iNewDPI)) {
						SetFileItemsImages();
						SetEditItemsImages();
						SetViewItemsImages();
						SetInsertItemsImages();
						SetFormatItemsImages();
						SetTableItemsImages();
					}
					break;
			}
			base.WndProc(ref message);
		}
	}
}
