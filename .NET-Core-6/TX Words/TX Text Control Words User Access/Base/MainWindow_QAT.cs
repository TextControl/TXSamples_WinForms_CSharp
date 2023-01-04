/*-------------------------------------------------------------------------------------------------------------
** MainWindow_QAT.cs File
**
** Description:
**      Creates an undo and a redo button and adds these button plus references to the [current user], Save,  
**      Open, New and Print buttons to the Quick Access Toolbar.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using TXTextControl.Windows.Forms;
using TXTextControl.Windows.Forms.Ribbon;

namespace TXTextControl.Words {
	partial class MainWindow {

		/*-------------------------------------------------------------------------------------------------------------
		** M E M B E R   V A R I A B L E S
		**-----------------------------------------------------------------------------------------------------------*/

		RibbonButton m_rbtnUndo, m_rbtnRedo;


		/*-------------------------------------------------------------------------------------------------------------
        ** M E T H O D S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** SetQATItemsDesign Method
        ** Creates an undo and a redo button and adds these button plus references to the [current user], Save, Open, 
        ** New and Print buttons to the Quick Access Toolbar.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SetQATItemsDesign() {
			SetRibbonButtonDesign(ResourceProvider.GeneralItem.TXITEM_Undo.ToString(), m_rbtnUndo = new RibbonButton());
			SetRibbonButtonDesign(ResourceProvider.GeneralItem.TXITEM_Redo.ToString(), m_rbtnRedo = new RibbonButton());
			this.SetQuickAccessToolbarStandardItems(new RibbonButton[] { m_rmbtnCurrentUser, m_rbtnSave, m_rbtnOpen, m_rbtnUndo, m_rbtnRedo, m_rbtnNew, m_rsbtnPrint });
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** SetUndoRedoButtonsBehavior Method
        ** Manages the RibbonButtons that should act like an 'Undo' and a 'Redo' button.
        **-----------------------------------------------------------------------------------------------------------*/
		internal void SetUndoRedoButtonsBehavior() {
			// Undo
			m_rbtnUndo.Enabled = false;
			m_rbtnUndo.Click += Undo_Click;
			m_rbtnUndo.ToolTip.Opening += Undo_ToolTip_Opening;

			// Redo
			m_rbtnRedo.Enabled = false;
			m_rbtnRedo.Click += Redo_Click;
			m_rbtnRedo.ToolTip.Opening += Redo_ToolTip_Opening;

			// Add handler for button Enable state handling
			m_txTextControl.PropertyChanged += TextControl_PropertyChanged_UndoRedo;
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** H A N D L E R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** Undo_Click Handler
        ** Invokes the TextControl Undo method to undo the last action.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Undo_Click(object sender, EventArgs e) {
			m_txTextControl.Undo();
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** Undo_ToolTip_Opening Handler
        ** Sets the tool tip of the Undo button when the tool tip is opening. The tool tip shows the undo action
        ** that is performed when the Undo button is clicked.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Undo_ToolTip_Opening(object sender, EventArgs e) {
			string strUndoActionName = m_txTextControl.UndoActionName;
			m_rbtnUndo.ToolTip.Description = !string.IsNullOrEmpty(strUndoActionName) ?
				strUndoActionName :
				ResourceProvider.GetToolTipDescription(ResourceProvider.GeneralItem.TXITEM_Undo.ToString());
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** Redo_Click Handler
        ** Invokes the TextControl Redo method to redo the last action.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Redo_Click(object sender, EventArgs e) {
			m_txTextControl.Redo();
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** Redo_ToolTip_Opening Handler
        ** Sets the tool tip of the Redo button when the tool tip is opening. The tool tip shows the redo action
        ** that is performed when the Redo button is clicked.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Redo_ToolTip_Opening(object sender, EventArgs e) {
			string strRedoActionName = m_txTextControl.RedoActionName;
			m_rbtnRedo.ToolTip.Description = !string.IsNullOrEmpty(strRedoActionName) ?
				strRedoActionName :
				ResourceProvider.GetToolTipDescription(ResourceProvider.GeneralItem.TXITEM_Redo.ToString());
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** TextControl_PropertyChanged_UndoRedo Handler
        ** Updates the enabled state of the Undo or Redo button when the TextControl CanUndo or CanRedo 
        ** property value changed.
        **-----------------------------------------------------------------------------------------------------------*/
		private void TextControl_PropertyChanged_UndoRedo(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
			switch (e.PropertyName) {
				case "CanUndo":
					m_rbtnUndo.Enabled = m_txTextControl.CanUndo;
					break;
				case "CanRedo":
					m_rbtnRedo.Enabled = m_txTextControl.CanRedo;
					break;
			}
		}
	}
}
