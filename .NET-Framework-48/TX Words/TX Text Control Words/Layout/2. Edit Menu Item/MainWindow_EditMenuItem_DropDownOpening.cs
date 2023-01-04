/*-------------------------------------------------------------------------------------------------------------
** MainWindow_EditMenuItem_DropDownOpening.cs File
**
** Description: Provides all DropDownOpening handlers associated with 'Edit' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** Edit_DropDownOpening Handler
		**
		** Updates the enabled state and texts of 'Edit' drop down menu items.
		** 
		** Item: 'Edit'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_DropDownOpening(object sender, EventArgs e) {
			// Get some current TextControl states
			bool bCanCopy = m_txTextControl.CanCopy;
			bool bCanEdit = m_txTextControl.CanEdit;
			EditMode emEditMode = m_txTextControl.EditMode;

			// 'Undo'
			UpdateUndoText();
			m_tmiEdit_Undo.Enabled = m_txTextControl.CanUndo;

			// 'Redo'
			UpdateRedoText();
			m_tmiEdit_Redo.Enabled = m_txTextControl.CanRedo;

			// 'Cut'
			m_tmiEdit_Cut.Enabled = bCanCopy && bCanEdit;

			// 'Copy'
			m_tmiEdit_Copy.Enabled = bCanCopy;

			// 'Paste'
			m_tmiEdit_Paste.Enabled = m_txTextControl.CanPaste;

			// 'Select All'
			m_tmiEdit_SelectAll.Enabled = bCanEdit || emEditMode == EditMode.ReadAndSelect;

			// 'Replace...'
			m_tmiEdit_Replace.Enabled = bCanEdit;

			// 'Protect Document'
			m_tmiEdit_ProtectDocument.Checked = emEditMode == EditMode.ReadAndSelect || emEditMode == EditMode.ReadOnly;

			// 'Tracked Changes'
			m_tmiEdit_TrackedChanges.Enabled = bCanEdit;

			// 'Comments'
			m_tmiEdit_Comments.Enabled = bCanEdit;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_Permissions_DropDownOpening Handler
		**
		** Updates the enabled and checked state of 'Permissions' drop down menu items.
		** 
		** Item: 'Permissions'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_Permissions_DropDownOpening(object sender, EventArgs e) {
			// Get current document permissions
			DocumentPermissions dpDocumentPermissions = m_txTextControl.DocumentPermissions;

			// Check the 'Permissions' drop down items

			// Because formatting is not allowed in a read only document even if the corresponding document
			// permissions are set, the corresponding items are unchecked when the DocumentPermissions.ReadOnly
			// is set to true.
			bool bIsReadOnly = dpDocumentPermissions.ReadOnly;
			m_tmiEdit_Permissions_AllowFormatting.Checked = !bIsReadOnly && dpDocumentPermissions.AllowFormatting;
			m_tmiEdit_Permissions_AllowFormattingStyles.Checked = !bIsReadOnly && dpDocumentPermissions.AllowFormattingStyles;
			m_tmiEdit_Permissions_AllowPrinting.Checked = dpDocumentPermissions.AllowPrinting;
			m_tmiEdit_Permissions_AllowCopy.Checked = dpDocumentPermissions.AllowCopy;
			m_tmiEdit_Permissions_AllowEditingFormFields.Checked = dpDocumentPermissions.AllowEditingFormFields;
			m_tmiEdit_Permissions_ReadOnly.Checked = bIsReadOnly;

			// Set the enable states of the 'Permissions' drop down items
			bool bIsProtectedDocument = m_tmiEdit_ProtectDocument.Checked;
			m_tmiEdit_Permissions_AllowFormatting.Enabled =
			m_tmiEdit_Permissions_AllowFormattingStyles.Enabled = !bIsReadOnly && !bIsProtectedDocument;
			m_tmiEdit_Permissions_AllowPrinting.Enabled =
			m_tmiEdit_Permissions_AllowCopy.Enabled =
			m_tmiEdit_Permissions_AllowEditingFormFields.Enabled =
			m_tmiEdit_Permissions_ReadOnly.Enabled = !bIsProtectedDocument;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_EditableRegions_Add_DropDownOpening Handler
		**
		** Updates the enabled state of 'Add' drop down menu items.
		** 
		** Item: 'Add' of the 'Editable Regions' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_EditableRegions_Add_DropDownOpening(object sender, EventArgs e) {
			if (m_plTXLicense >= VersionInfo.ProductLevel.Professional) {
				// Set the enabled states of the 'Add' drop down items
				EditableRegionCollection colEditableRegions = m_txTextControl.EditableRegions;
				EditableRegion[] rerCurrentEditableRegions = colEditableRegions.GetItems();
				// The 'For [Current User]' item is enabled if the current user is signed in and 
				// no editable region was defined for the current user at the input position.
				m_tmiEdit_EditableRegions_Add_ForCurrentUser.Enabled = m_uiCurrentUser!=null && m_uiCurrentUser.IsSignedIn && (rerCurrentEditableRegions == null || GetEditableRegion(m_strUserName, rerCurrentEditableRegions) == null);
				// The 'For Everyone' item is enabled if no corresponding editable region was
				// at the current input position.
				m_tmiEdit_EditableRegions_Add_ForEveryone.Enabled = rerCurrentEditableRegions == null || GetEditableRegion("", rerCurrentEditableRegions) == null;
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Edit_EditableRegions_Remove_DropDownOpening Handler
		**
		** Updates the enabled state of 'Remove' drop down menu items.
		** 
		** Item: 'Remove' of the 'Editable Regions' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Edit_EditableRegions_Remove_DropDownOpening(object sender, EventArgs e) {
			if (m_plTXLicense >= VersionInfo.ProductLevel.Professional) {
				// Set the enabled states of the 'Remove' drop down items
				EditableRegionCollection colEditableRegions = m_txTextControl.EditableRegions;
				EditableRegion[] rerCurrentEditableRegions = colEditableRegions.GetItems();
				// The 'For [Current User]' item is enabled if the current user is signed in and 
				// an editable region was defined for the current user at the input position.
				m_tmiEdit_EditableRegions_Remove_ForCurrentUser.Enabled = m_uiCurrentUser != null && m_uiCurrentUser.IsSignedIn && rerCurrentEditableRegions != null && GetEditableRegion(m_strUserName, rerCurrentEditableRegions) != null;
				// The 'For Everyone' item is enabled if a corresponding editable region was
				// at the current input position.
				m_tmiEdit_EditableRegions_Remove_ForEveryone.Enabled = rerCurrentEditableRegions != null && GetEditableRegion("", rerCurrentEditableRegions) != null;
			}
		}
	}
}
