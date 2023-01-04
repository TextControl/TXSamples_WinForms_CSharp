/*-------------------------------------------------------------------------------------------------------------
** MainWindow_Shortcuts.cs File
**
** Description:
**     Handles shortcuts.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System.Windows.Forms;

namespace TXTextControl.Words {
	partial class MainWindow {

		/*-------------------------------------------------------------------------------------------------------------
        ** H A N D L E R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
	    ** TextControl_KeyDown Handler
	    ** Implement Shortcuts for the TextControl.
	    **-----------------------------------------------------------------------------------------------------------*/
		private void TextControl_KeyDown(object sender, KeyEventArgs e) {
			switch (e.KeyCode) {
				case Keys.Insert:   // Toggle insertion mode					
					if (e.Control || e.Alt || e.Shift) { break; }
					ToggleInsertionMode();
					break;

				case Keys.A:        // Ctrl + A: Select all
					if (!e.Control || e.Alt || e.Shift) { break; }
					m_txTextControl.SelectAll();
					break;

				case Keys.S:        // Ctrl + S: Save
					if (!e.Control || e.Alt || e.Shift) { break; }
					Save(m_strActiveDocumentPath);
					break;

				case Keys.O:        // Ctrl + O: Open
					if (!e.Control || e.Alt || e.Shift) { break; }
					Open();
					break;

				case Keys.F:        // Ctrl + F: Search
					if (!e.Control || e.Alt || e.Shift) { break; }
					m_txTextControl.Find();
					break;

				case Keys.P:        // Ctrl + P: Print
					if (!e.Control || e.Alt || e.Shift) { break; }
					if (m_txTextControl.CanPrint) {
						m_txTextControl.Print(m_strActiveDocumentName);
					}
					break;
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** M E T H O D S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** SetShortcutBehavior Method
		** Adds all necessary handlers to implement shortcut behavior.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SetShortcutBehavior() {
			m_txTextControl.KeyDown += TextControl_KeyDown; // Handles shortcuts
		}

		/*-------------------------------------------------------------------------------------------------------------
		** ToggleInsertionMode Method
		** Switch the TextControl's insertion mode between overwrite and insert.
		**-----------------------------------------------------------------------------------------------------------*/
		private void ToggleInsertionMode() {
			m_txTextControl.InsertionMode
				= m_txTextControl.InsertionMode == TXTextControl.InsertionMode.Insert
				? TXTextControl.InsertionMode.Overwrite
				: TXTextControl.InsertionMode.Insert;
		}
	}
}
