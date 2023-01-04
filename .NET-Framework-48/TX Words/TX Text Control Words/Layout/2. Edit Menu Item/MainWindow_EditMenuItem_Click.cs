/*-------------------------------------------------------------------------------------------------------------
** MainWindow_EditMenuItem_Click.cs File
**
** Description: Provides all Click handlers associated with 'Edit' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** Edit_Undo_Click Handler
		**
		** Undoes the last edit operation in the TextControl.
		** 
		** Item: 'Undo'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_Undo_Click(object sender, EventArgs e) {
			m_txTextControl.Undo();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_Redo_Click Handler
		**
		** Redoes the last TextControl operation.
		** 
		** Item: 'Redo'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_Redo_Click(object sender, EventArgs e) {
			m_txTextControl.Redo();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_Cut_Click Handler
		**
		** Moves the current selection in the TextControl to the Clipboard.
		** 
		** Item: 'Cut'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_Cut_Click(object sender, EventArgs e) {
			m_txTextControl.Cut();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_Copy_Click Handler
		**
		** Copies the current selection in the TextControl to the Clipboard.
		** 
		** Item: 'Copy'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_Copy_Click(object sender, EventArgs e) {
			m_txTextControl.Copy();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_Paste_Click Handler
		**
		** Replaces the current selection in the TextControl with the contents of the Clipboard.
		** 
		** Item: 'Paste'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_Paste_Click(object sender, EventArgs e) {
			m_txTextControl.Paste();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_SelectAll_Click Handler
		**
		** Selects all text in the TextControl.
		** 
		** Item: 'Select All'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_SelectAll_Click(object sender, EventArgs e) {
			m_txTextControl.SelectAll();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_Find_Click Handler
		**
		** Opens the built-in Find dialog box.
		** 
		** Item: 'Find...'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_Find_Click(object sender, System.EventArgs e) {
			m_txTextControl.Find();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_Replace_Click Handler
		**
		** Opens the built-in Replace dialog box.
		** 
		** Item: 'Replace...'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_Replace_Click(object sender, System.EventArgs e) {
			m_txTextControl.Replace();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_Permissions_AllowFormatting_Click Handler
		**
		** Sets a value specifying whether the document can be formatted. 
		** 
		** Item: 'Allow Formatting' of the 'Permissions' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_Permissions_AllowFormatting_Click(object sender, EventArgs e) {
			m_txTextControl.DocumentPermissions.AllowFormatting = m_tmiEdit_Permissions_AllowFormatting.Checked;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_Permissions_AllowFormattingStyles_Click Handler
		**
		** Sets a value specifying whether formatting styles can be used to format the document. 
		** 
		** Item: 'Allow Formatting Styles' of the 'Permissions' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_Permissions_AllowFormattingStyles_Click(object sender, EventArgs e) {
			m_txTextControl.DocumentPermissions.AllowFormattingStyles = m_tmiEdit_Permissions_AllowFormattingStyles.Checked;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_Permissions_AllowPrinting_Click Handler
		**
		** Sets a value specifying whether the document can be printed.
		** 
		** Item: 'Allow Printing' of the 'Permissions' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_Permissions_AllowPrinting_Click(object sender, EventArgs e) {
			m_txTextControl.DocumentPermissions.AllowPrinting = m_tmiEdit_Permissions_AllowPrinting.Checked;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_Permissions_AllowCopy_Click Handler
		**
		** Sets a value specifying whether document content can be copied to the clipboard.
		** 
		** Item: 'Allow Copy' of the 'Permissions' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_Permissions_AllowCopy_Click(object sender, EventArgs e) {
			m_txTextControl.DocumentPermissions.AllowCopy = m_tmiEdit_Permissions_AllowCopy.Checked;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_Permissions_AllowEditingFormFields_Click Handler
		**
		** Sets a value specifying whether form fields can be edited. 
		** 
		** Item: 'Allow Editing Form Fields' of the 'Permissions' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_Permissions_AllowEditingFormFields_Click(object sender, EventArgs e) {
			m_txTextControl.DocumentPermissions.AllowEditingFormFields = m_tmiEdit_Permissions_AllowEditingFormFields.Checked;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_Permissions_ReadOnly_Click Handler
		**
		** Opens the built-in Replace dialog box.
		** 
		** Item: 'Read Only' of the 'Permissions' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_Permissions_ReadOnly_Click(object sender, EventArgs e) {
			m_txTextControl.DocumentPermissions.ReadOnly = m_tmiEdit_Permissions_ReadOnly.Checked;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_EditableRegions_Add_ForCurrentUser_Click Handler
		**
		** Adds an editable region for the current signed in user to the document.
		** 
		** Item: 'For [Current User]' of the 'Add' drop down menu ('Add' is an item of the 'Editable Regions'  
		**		 drop down menu)
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_EditableRegions_Add_ForCurrentUser_Click(object sender, EventArgs e) {
			EditableRegionCollection.AddResult arAddResult = m_txTextControl.EditableRegions.Add(new EditableRegion(m_strUserName, 0));
			HandleAddEditableRegionFailure(arAddResult);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_EditableRegions_Add_ForEveryone_Click Handler
		**
		** Adds an editable region for every user to the document.
		** 
		** Item: 'For Everyone' of the 'Add' drop down menu ('Add' is an item of the 'Editable Regions'  
		**		 drop down menu)
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_EditableRegions_Add_ForEveryone_Click(object sender, EventArgs e) {
			EditableRegionCollection.AddResult arAddResult = m_txTextControl.EditableRegions.Add(new EditableRegion("", 0));
			HandleAddEditableRegionFailure(arAddResult);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_EditableRegions_Remove_ForCurrentUser_Click Handler
		**
		** Removes the editable region for the current signed in user from the document.
		** 
		** Item: 'For [Current User]' of the 'Remove' drop down menu ('Remove' is an item of the 'Editable Regions'  
		**		 drop down menu)
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_EditableRegions_Remove_ForCurrentUser_Click(object sender, EventArgs e) {
			RemoveUser(m_strUserName);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_EditableRegions_Remove_ForEveryone_Click Handler
		**
		** Removes the editable region for every user from the document.
		** 
		** Item: 'For Everyone' of the 'Remove' drop down menu ('Remove' is an item of the 'Editable Regions'  
		**		 drop down menu)
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_EditableRegions_Remove_ForEveryone_Click(object sender, EventArgs e) {
			RemoveUser("");
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_ProtectDocument_Click Handler
		**
		** Sets a value indicating whether the document's text is protected, or can be freely edited and formatted.
		** 
		** Item: 'Protect Document'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_ProtectDocument_Click(object sender, EventArgs e) {
			m_txTextControl.EditMode = m_tmiEdit_ProtectDocument.Checked ? EditMode.ReadAndSelect | EditMode.UsePassword : EditMode.Edit;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_TrackedChanges_TrackChanges_Click Handler
		**
		** Sets a value indicating whether track changes is active or not. When this property is true, new changes 
		** made to the document are marked up. 
		** 
		** Item: 'Track Changes' of the 'Tracked Changes' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_TrackedChanges_TrackChanges_Click(object sender, EventArgs e) {
			m_txTextControl.IsTrackChangesEnabled = m_tmiEdit_TrackedChanges_TrackChanges.Checked;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_TrackedChanges_ReviewTrackedChanges_Click Handler
		**
		** Opens a modeless dialog that reviews the tracked changes of the document.
		** 
		** Item: 'Review Tracked Changes...' of the 'Tracked Changes' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_TrackedChanges_ReviewTrackedChanges_Click(object sender, EventArgs e) {
			TrackedChangesDialog dlgTrackedChanges = new TrackedChangesDialog(m_txTextControl) { Owner = this };
			dlgTrackedChanges.Show();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_Comments_AddComment_Click Handler
		**
		** Opens the comment input control to add a new comment to the document.
		** 
		** Item: 'Add Comment...' of the 'Comments' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_Comments_AddComment_Click(object sender, EventArgs e) {
			CommentCollection.AddResult arAddResult = m_txTextControl.Comments.Add();
			HandleAddCommentFailure(arAddResult);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_Comments_ReviewComments_Click Handler
		**
		** Opens a modeless dialog that reviews the comments of the document.
		** 
		** Item: 'Review Comments...' of the 'Comments' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_Comments_ReviewComments_Click(object sender, EventArgs e) {
			CommentsDialog dlgComments = new CommentsDialog(m_txTextControl) { Owner = this };
			dlgComments.Show();
		}
	}
}
