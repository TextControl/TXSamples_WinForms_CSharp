/*-------------------------------------------------------------------------------------------------------------
** MainWindow_ContextMenu.cs File
**
** Description:
**      Adds an item to the TextControl context menu when a frame is selected. Clicking that item opens
**      a dialog to edit the name of the selected frame.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Windows.Forms;
using TXTextControl.DataVisualization;
using TXTextControl.Windows.Forms;
using TXTextControl.Windows.Forms.Ribbon;

namespace TXTextControl.Words {
	partial class MainWindow {

		/*-------------------------------------------------------------------------------------------------------------
        ** H A N D L E R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** TextControl_TextContextMenuOpening Handler
		** Customize the context menu by adding additional items if a frame is selected.
		**-----------------------------------------------------------------------------------------------------------*/
		private void TextControl_TextContextMenuOpening(object sender, TextContextMenuEventArgs e) {
			if ((e.ContextMenuLocation & ContextMenuLocation.SelectedFrame) != 0) {
				// A frame is selected
				AddFrameContextMenuItems(e.TextContextMenu);
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** SetFrameName_Click Handler
		** Show a dialog on click for setting the FrameBase object's name.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SetFrameName_Click(object sender, EventArgs e) {
			// Get the current frame base object
			FrameBase fbFrame;
			if ((fbFrame = m_txTextControl.Frames.GetItem()) == null) {
				return;
			}

			// Initialize a UserPromptDialog to edit the frame base name 
			string strName = fbFrame.Name;
			FrameNameDialog dlgFrameNameDialog = new FrameNameDialog(strName);

			// Open the dialog.
			if (dlgFrameNameDialog.ShowDialog(this) == DialogResult.OK) {
				// Set the new name.
				fbFrame.Name = dlgFrameNameDialog.FrameName;

				// Update the ribbon frame layout's Name text box.           
				RibbonTextBox rtbxObjectName = m_rtRibbonFrameLayoutTab.FindItem(RibbonFrameLayoutTab.RibbonItem.TXITEM_ObjectName) as RibbonTextBox;
				rtbxObjectName.Text = fbFrame.Name;
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** M E T H O D S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** SetContextMenuBehavior Method
        ** Adds all necessary handlers to show a customized context menu.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SetContextMenuBehavior() {
			// Adds context specific items to the TextControl 'Text Context Menu' 
			m_txTextControl.TextContextMenuOpening += TextControl_TextContextMenuOpening; 
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** AddFrameContextMenuItems Method
        ** Adds the new context menu items, to ContextMenuStrip, for setting the framebase's name.
        **
        ** Parameters:
        **		contextMenu:    The context menu where to add the new items.	
        **-----------------------------------------------------------------------------------------------------------*/
		private void AddFrameContextMenuItems(ContextMenuStrip contextMenu) {
			FrameBase frame = m_txTextControl.Frames.GetItem();
			if (frame != null && !(frame is ChartFrame) && m_txTextControl.CanEdit) {
				contextMenu.Items.Add(new ToolStripSeparator()); // Add separator.
				contextMenu.Items.Add(
					Properties.Resources.ContextMenu_FameName, // Get item text.
					ResourceProvider.GetSmallIcon(RibbonFrameLayoutTab.RibbonItem.TXITEM_ObjectName.ToString(), this), // Get item icon.
					SetFrameName_Click); // Add Click event to open a dialog to edit the frame base name.
			}
		}
	}
}
