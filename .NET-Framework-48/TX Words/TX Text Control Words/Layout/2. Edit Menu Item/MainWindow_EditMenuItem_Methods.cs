/*-------------------------------------------------------------------------------------------------------------
** MainWindow_EditMenuItem_Methods.cs File
**
** Description: Provides supporting methods to implement the desired behavior of some 'Edit' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System.Windows.Forms;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** 'Undo' Item
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** UpdateUndoText Method
        ** Sets the Undo item text by combining the default 'Undo' text with the corresponding undo action.
        **-----------------------------------------------------------------------------------------------------------*/
		private void UpdateUndoText() {
			// Update Undo item text.
			m_tmiEdit_Undo.Text = Properties.Resources.Item_Edit_Undo_Text;

			// Add undo action text that is performed when the Undo item is clicked.
			string strUndoActionName = m_txTextControl.UndoActionName;
			if (!string.IsNullOrEmpty(strUndoActionName)) {
				m_tmiEdit_Undo.Text += " " + strUndoActionName;
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** 'Redo' Item
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** UpdateRedoText Method
        ** Sets the Redo item text by combining the default 'Redo' text with the corresponding redo action.
        **-----------------------------------------------------------------------------------------------------------*/
		private void UpdateRedoText() {
			// Update Redo item text.
			m_tmiEdit_Redo.Text = Properties.Resources.Item_Edit_Redo_Text;

			// Add redo action text that is performed when the Redo item is clicked.
			string strRedoActionName = m_txTextControl.RedoActionName;
			if (!string.IsNullOrEmpty(strRedoActionName)) {
				m_tmiEdit_Redo.Text += " " + strRedoActionName;
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
		** 'Editable Regions' Items
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** HandleAddEditableRegionFailure Method
        ** Handles the returned AddResult when adding a new editable region to the document. If the result is not
        ** AddResult.Successful, a corresponding message box with a detailed description of the failure is shown.
        **
        ** Parameters:
        **      addResult:		The EditableRegionCollection.AddResult value to check.
        **-----------------------------------------------------------------------------------------------------------*/
		private void HandleAddEditableRegionFailure(EditableRegionCollection.AddResult addResult) {
			if (addResult != EditableRegionCollection.AddResult.Successful) {
				string strMessageBoxCaption = null;
				string strMessageBoxText = null;
				switch (addResult) {
					case EditableRegionCollection.AddResult.Error:
						strMessageBoxCaption = Properties.Resources.MessageBox_AddEditableRegion_Error_Caption;
						strMessageBoxText = Properties.Resources.MessageBox_AddEditableRegion_Error_Text;
						break;
					case EditableRegionCollection.AddResult.NoSelection:
						strMessageBoxCaption = Properties.Resources.MessageBox_AddEditableRegion_NoSelection_Caption;
						strMessageBoxText = Properties.Resources.MessageBox_AddEditableRegion_NoSelection_Text;
						break;
					case EditableRegionCollection.AddResult.PositionInvalid:
						strMessageBoxCaption = Properties.Resources.MessageBox_AddEditableRegion_PositionInvalid_Caption;
						strMessageBoxText = Properties.Resources.MessageBox_AddEditableRegion_PositionInvalid_Text;
						break;
					case EditableRegionCollection.AddResult.SelectionTooComplex:
						strMessageBoxCaption = Properties.Resources.MessageBox_AddEditableRegion_SelectionTooComplex_Caption;
						strMessageBoxText = Properties.Resources.MessageBox_AddEditableRegion_SelectionTooComplex_Text;
						break;
				}
				if (strMessageBoxText != null) {
					MessageBox.Show(this, strMessageBoxText, strMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** RemoveUser Method
        ** Removes the editable region that is related to the specified user name from the current text position.
        **
        ** Parameters:
        **      userName:		The name of the user that is related to the editable region that should be removed. 
        **						If the parameter is an empty string, the editable region is related to 'Everyone'.
        **-----------------------------------------------------------------------------------------------------------*/
		private void RemoveUser(string userName) {
			EditableRegionCollection colEditableRegions = m_txTextControl.EditableRegions;
			EditableRegion[] rrrCurrentEditableRegions = colEditableRegions.GetItems();
			EditableRegion erEditableRegionToRemove = GetEditableRegion(userName, rrrCurrentEditableRegions);
			colEditableRegions.Remove(erEditableRegionToRemove, m_txTextControl.Selection.Length > 0);
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** GetEditableRegion Method
        ** Searches in an array of EditableRegion objects for an editable region that corresponds to the name of a 
        ** specific user.
        **
        ** Parameters:
        **      userName:			The name of the specified user.
        **      editableRegions:	An array of EditableRegion objects that are checked.
        **
        ** Return Value:			If found, the editable Region that corresponds to the name of the specified user. 
        **							Otherwise null.
        **-----------------------------------------------------------------------------------------------------------*/
		private EditableRegion GetEditableRegion(string userName, EditableRegion[] editableRegions) {
			for (int i = 0; i < editableRegions.Length; i++) {
				if (editableRegions[i].UserName == userName) {
					return editableRegions[i];
				}
			}
			return null;
		}


		/*-------------------------------------------------------------------------------------------------------------
		** 'Comments' Items
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** HandleAddCommentFailure Method
        ** Handles the returned AddResult when adding a new comment to the document. If the result is not
        ** AddResult.Successful, a corresponding message box with a detailed description of the failure is shown.
        **
        ** Parameters:
        **      addResult:		The CommentCollection.AddResult value to check.
        **-----------------------------------------------------------------------------------------------------------*/
		private void HandleAddCommentFailure(CommentCollection.AddResult addResult) {
			if (addResult != CommentCollection.AddResult.Successful) {

				string strMessageBoxCaption = null;
				string strMessageBoxText = null;
				switch (addResult) {
					case CommentCollection.AddResult.Error:
						strMessageBoxCaption = Properties.Resources.MessageBox_AddComment_Error_Caption;
						strMessageBoxText = Properties.Resources.MessageBox_AddComment_Error_Text;
						break;
					case CommentCollection.AddResult.NoSelection:
						strMessageBoxCaption = Properties.Resources.MessageBox_AddComment_NoSelection_Caption;
						strMessageBoxText = Properties.Resources.MessageBox_AddComment_NoSelection_Text;
						break;
					case CommentCollection.AddResult.PositionInvalid:
						strMessageBoxCaption = Properties.Resources.MessageBox_AddComment_PositionInvalid_Caption;
						strMessageBoxText = Properties.Resources.MessageBox_AddComment_PositionInvalid_Text;
						break;
					case CommentCollection.AddResult.SelectionTooComplex:
						strMessageBoxCaption = Properties.Resources.MessageBox_AddComment_SelectionTooComplex_Caption;
						strMessageBoxText = Properties.Resources.MessageBox_AddComment_SelectionTooComplex_Text;
						break;
				}
				if (strMessageBoxText != null) {
					MessageBox.Show(this, strMessageBoxText, strMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
