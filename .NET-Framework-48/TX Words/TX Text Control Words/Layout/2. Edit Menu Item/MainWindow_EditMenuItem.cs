/*-------------------------------------------------------------------------------------------------------------
** MainWindow_EditMenuItem.cs File
**
** Description: Provides methods to set the layout and behavior of the 'Edit' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using TXTextControl.Windows.Forms;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** SetEditItemsTexts Method
		**
		** Sets the texts of the 'Edit' menu items.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SetEditItemsTexts() {
			// 'Edit'
			SetItemText(m_tmiEdit);

			// 'Undo'
			SetItemText(m_tmiEdit_Undo);

			// 'Redo'
			SetItemText(m_tmiEdit_Redo);

			// 'Cut'
			SetItemText(m_tmiEdit_Cut);

			// 'Copy'
			SetItemText(m_tmiEdit_Copy);

			// 'Paste'
			SetItemText(m_tmiEdit_Paste);

			// 'Select All'
			SetItemText(m_tmiEdit_SelectAll);

			// 'Find...'
			SetItemText(m_tmiEdit_Find);

			// 'Replace...'
			SetItemText(m_tmiEdit_Replace);

			// 'Permissions'
			SetItemText(m_tmiEdit_Permissions);
			SetItemText(m_tmiEdit_Permissions_AllowFormatting);
			SetItemText(m_tmiEdit_Permissions_AllowFormattingStyles);
			SetItemText(m_tmiEdit_Permissions_AllowPrinting);
			SetItemText(m_tmiEdit_Permissions_AllowCopy);
			SetItemText(m_tmiEdit_Permissions_AllowEditingFormFields);
			SetItemText(m_tmiEdit_Permissions_ReadOnly);

			// 'Editable Regions'
			SetItemText(m_tmiEdit_EditableRegions);
			SetItemText(m_tmiEdit_EditableRegions_Add);
			SetItemText(m_tmiEdit_EditableRegions_Add_ForCurrentUser, m_strUserName);
			SetItemText(m_tmiEdit_EditableRegions_Add_ForEveryone);
			SetItemText(m_tmiEdit_EditableRegions_Remove);
			SetItemText(m_tmiEdit_EditableRegions_Remove_ForCurrentUser, m_strUserName);
			SetItemText(m_tmiEdit_EditableRegions_Remove_ForEveryone);

			// 'Protect Document'
			SetItemText(m_tmiEdit_ProtectDocument);

			// 'Tracked Changes'
			SetItemText(m_tmiEdit_TrackedChanges);
			SetItemText(m_tmiEdit_TrackedChanges_TrackChanges);
			SetItemText(m_tmiEdit_TrackedChanges_ReviewTrackedChanges);

			// 'Comments'
			SetItemText(m_tmiEdit_Comments);
			SetItemText(m_tmiEdit_Comments_AddComment);
			SetItemText(m_tmiEdit_Comments_ReviewComments);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** SetEditItemsImages Method
		**
		** Sets the images of the 'Edit' menu items.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SetEditItemsImages() {
			// 'Undo'
			SetItemImage(m_tmiEdit_Undo, ResourceProvider.GeneralItem.TXITEM_Undo.ToString());

			// 'Redo'
			SetItemImage(m_tmiEdit_Redo, ResourceProvider.GeneralItem.TXITEM_Redo.ToString());

			// 'Cut'
			SetItemImage(m_tmiEdit_Cut, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_Cut.ToString());

			// 'Copy'
			SetItemImage(m_tmiEdit_Copy, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_Copy.ToString());

			// 'Paste'
			SetItemImage(m_tmiEdit_Paste, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_Paste.ToString());

			// 'Select All'
			SetItemImage(m_tmiEdit_SelectAll, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_SelectAll.ToString());

			// 'Find...'
			SetItemImage(m_tmiEdit_Find, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_Find.ToString());

			// 'Replace...'
			SetItemImage(m_tmiEdit_Replace, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_Replace.ToString());

			// 'Permissions'
			SetItemImage(m_tmiEdit_Permissions, Windows.Forms.Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_ReadOnly.ToString());
			SetItemImage(m_tmiEdit_Permissions_AllowFormatting, Windows.Forms.Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_AllowFormatting.ToString());
			SetItemImage(m_tmiEdit_Permissions_AllowFormattingStyles, Windows.Forms.Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_AllowFormattingStyles.ToString());
			SetItemImage(m_tmiEdit_Permissions_AllowPrinting, Windows.Forms.Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_AllowPrinting.ToString());
			SetItemImage(m_tmiEdit_Permissions_AllowCopy, Windows.Forms.Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_AllowCopy.ToString());
			SetItemImage(m_tmiEdit_Permissions_AllowEditingFormFields, Windows.Forms.Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_FillInFormFields.ToString());
			SetItemImage(m_tmiEdit_Permissions_ReadOnly, Windows.Forms.Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_ReadOnly.ToString());

			// 'Editable Regions'
			SetItemImage(m_tmiEdit_EditableRegions, Windows.Forms.Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_HighlightEditableRegions.ToString());

			// 'Protect Document'
			SetItemImage(m_tmiEdit_ProtectDocument, Windows.Forms.Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_EnforceProtection.ToString());

			// 'Tracked Changes'
			SetItemImage(m_tmiEdit_TrackedChanges, Windows.Forms.Ribbon.RibbonProofingTab.RibbonItem.TXITEM_TrackChanges.ToString());
			SetItemImage(m_tmiEdit_TrackedChanges_TrackChanges, Windows.Forms.Ribbon.RibbonProofingTab.RibbonItem.TXITEM_TrackChanges.ToString());
			SetItemImage(m_tmiEdit_TrackedChanges_ReviewTrackedChanges, Windows.Forms.Ribbon.RibbonProofingTab.RibbonItem.TXITEM_TrackedChanges.ToString());

			// 'Comments'
			SetItemImage(m_tmiEdit_Comments, Windows.Forms.Ribbon.RibbonProofingTab.RibbonItem.TXITEM_EditComment.ToString());
			SetItemImage(m_tmiEdit_Comments_AddComment, Windows.Forms.Ribbon.RibbonProofingTab.RibbonItem.TXITEM_AddComment.ToString());
			SetItemImage(m_tmiEdit_Comments_ReviewComments, Windows.Forms.Ribbon.RibbonProofingTab.RibbonItem.TXITEM_Comments_Sidebars.ToString());
		}

		/*-------------------------------------------------------------------------------------------------------------
		** ConnectEditItemsHandlers Method
		**
		** Connects the 'Edit' menu items to Click and DropDownOpening handlers.
		**-----------------------------------------------------------------------------------------------------------*/
		private void ConnectEditItemsHandlers() {
			// Click Handlers:

			// 'Undo'
			m_tmiEdit_Undo.Click += Edit_Undo_Click;

			// 'Redo'
			m_tmiEdit_Redo.Click += Edit_Redo_Click;

			// 'Cut'
			m_tmiEdit_Cut.Click += Edit_Cut_Click;

			// 'Copy'
			m_tmiEdit_Copy.Click += Edit_Copy_Click;

			// 'Paste'
			m_tmiEdit_Paste.Click += Edit_Paste_Click;

			// 'Select All'
			m_tmiEdit_SelectAll.Click += Edit_SelectAll_Click;

			// 'Find...'
			m_tmiEdit_Find.Click += Edit_Find_Click;

			// 'Replace...'
			m_tmiEdit_Replace.Click += Edit_Replace_Click;

			// 'Permissions'
			m_tmiEdit_Permissions_AllowFormatting.Click += Edit_Permissions_AllowFormatting_Click;
			m_tmiEdit_Permissions_AllowFormattingStyles.Click += Edit_Permissions_AllowFormattingStyles_Click;
			m_tmiEdit_Permissions_AllowPrinting.Click += Edit_Permissions_AllowPrinting_Click;
			m_tmiEdit_Permissions_AllowCopy.Click += Edit_Permissions_AllowCopy_Click;
			m_tmiEdit_Permissions_AllowEditingFormFields.Click += Edit_Permissions_AllowEditingFormFields_Click;
			m_tmiEdit_Permissions_ReadOnly.Click += Edit_Permissions_ReadOnly_Click;

			// 'Editable Regions'
			m_tmiEdit_EditableRegions_Add_ForCurrentUser.Click += Edit_EditableRegions_Add_ForCurrentUser_Click;
			m_tmiEdit_EditableRegions_Add_ForEveryone.Click += Edit_EditableRegions_Add_ForEveryone_Click;

			m_tmiEdit_EditableRegions_Remove_ForCurrentUser.Click += Edit_EditableRegions_Remove_ForCurrentUser_Click;
			m_tmiEdit_EditableRegions_Remove_ForEveryone.Click += Edit_EditableRegions_Remove_ForEveryone_Click;

			// 'Protect Document'
			m_tmiEdit_ProtectDocument.Click += Edit_ProtectDocument_Click;

			// 'Tracked Changes'
			m_tmiEdit_TrackedChanges_TrackChanges.Click += Edit_TrackedChanges_TrackChanges_Click;
			m_tmiEdit_TrackedChanges_ReviewTrackedChanges.Click += Edit_TrackedChanges_ReviewTrackedChanges_Click;

			// 'Comments'
			m_tmiEdit_Comments_AddComment.Click += Edit_Comments_AddComment_Click;
			m_tmiEdit_Comments_ReviewComments.Click += Edit_Comments_ReviewComments_Click;


			// DropDownOpening Handlers

			// 'Edit'
			m_tmiEdit.DropDownOpening += Edit_DropDownOpening;

			// 'Permissions'
			m_tmiEdit_Permissions.DropDownOpening += Edit_Permissions_DropDownOpening;

			// 'Editable Regions'
			m_tmiEdit_EditableRegions_Add.DropDownOpening += Edit_EditableRegions_Add_DropDownOpening;
			m_tmiEdit_EditableRegions_Remove.DropDownOpening += Edit_EditableRegions_Remove_DropDownOpening;
		}
	}
}
