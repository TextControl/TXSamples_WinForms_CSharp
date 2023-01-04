/*-------------------------------------------------------------------------------------------------------------
** MainWindow_RibbonFormFieldsTab_Preview.cs File
**
** Description:
**     Adds and manages a conditional instructions preview button.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System.Drawing;
using TXTextControl.Windows.Forms.Ribbon;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** M E M B E R   V A R I A B L E S
		**-----------------------------------------------------------------------------------------------------------*/

		private RibbonToggleButton m_rtbtnPreviewConditionalInstructions = null;
		private RibbonToggleButton m_rbtnEnableFormValidation = null;
		private bool m_bIsPreviewActivated = false;
		private byte[] m_rbtTextControlContent = null;
		private bool m_bAllowEditinFormFieldsTemp = false;
		private bool m_bReadOnlyTemp = false;


		/*-------------------------------------------------------------------------------------------------------------
        ** H A N D L E R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** PreviewConditionalInstructions_CheckedChanged Handler
        ** Activates or deactivates the conditional instructions preview.
        **-----------------------------------------------------------------------------------------------------------*/
		private void PreviewConditionalInstructions_CheckedChanged(object sender, System.EventArgs e) {
			if (m_rtbtnPreviewConditionalInstructions.Checked) {
				ActivateCIPreview();
			}
			else {
				DeactivateCIPreview(true);
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** TXITEM_EnableFormValidation_CheckedChanged Handler
		** Handles the enabled state of the preview button  if the preview is not activated and the TextControl can be 
		** edited.
		**-----------------------------------------------------------------------------------------------------------*/
		private void TXITEM_EnableFormValidation_CheckedChanged(object sender, System.EventArgs e) {
			// Only handle the enabled state of the preview button if the preview is not activated
			// and the TextControl can be edited.
			if (!m_bIsPreviewActivated && m_txTextControl.EditMode == EditMode.Edit) {
				m_rtbtnPreviewConditionalInstructions.Enabled = m_rbtnEnableFormValidation.Checked;
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** FormFields_TextControl_ContentChanged Handler
		** Deactivates the conditional instructions preview when a new document is loaded or the TextControl content
		** is reset by the TextControl.ResetContents method.
		** In case the preview is not activated, the handler updates the enabled state of the preview button.
		**-----------------------------------------------------------------------------------------------------------*/
		private void FormFields_TextControl_ContentChanged(object sender, System.EventArgs e) {
			if (!m_bIsPreviewActivated) {
				m_rtbtnPreviewConditionalInstructions.Enabled = m_txTextControl.EditMode == EditMode.Edit && m_txTextControl.IsFormFieldValidationEnabled;
			}
			else {
				DeactivateCIPreview(false);
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** EnforceProtection_Click Handler
		** Deactivates the conditional instructions preview when the PermissionsTab's 'Enforce Protection' button was
		** clicked and TextControl.EditMode property value was changed to EditMode.Edit.
		** In case the preview is not activated, the handler updates the enabled state of the preview button.
		**-----------------------------------------------------------------------------------------------------------*/
		private void EnforceProtection_Click(object sender, System.EventArgs e) {
			bool bCanEdit = m_txTextControl.EditMode == EditMode.Edit;
			if (!m_bIsPreviewActivated) {
				m_rtbtnPreviewConditionalInstructions.Enabled = bCanEdit && m_txTextControl.IsFormFieldValidationEnabled;
			}
			else {
				if (bCanEdit) {
					DeactivateCIPreview(true);
				}
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** M E T H O D S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** AddPreviewCondtionalInstructionButton Method
        ** Adds a "Preview Conditional Instructions" button to the TXITEM_FormValidationGroup ribbon group.
        **-----------------------------------------------------------------------------------------------------------*/
		private void AddPreviewCondtionalInstructionsButton() {
			// Get the icons.
			Bitmap bmpSmallIcon = GetSmallIcon("TXTextControl.Words.Images.PreviewFormFields_Small.svg");
			Bitmap bmpLargeIcon = GetLargeIcon("TXTextControl.Words.Images.PreviewFormFields_Large.svg");

			// Create the ribbon button
			m_rtbtnPreviewConditionalInstructions = new RibbonToggleButton() {
				Text = Properties.Resources.RibbonFormFieldsTab_PreviewConditionalInstructions,
				SmallIcon = bmpSmallIcon,
				LargeIcon = bmpLargeIcon,
				KeyTip = Properties.Resources.RibbonFormFieldsTab_PreviewConditionalInstructions_KeyTip,
				Enabled = m_txTextControl.IsFormFieldValidationEnabled
			};

			// Add tool tips
			m_rtbtnPreviewConditionalInstructions.ToolTip.Title = Properties.Resources.RibbonFormFieldsTab_PreviewConditionalInstructions_ToolTip_Title;
			m_rtbtnPreviewConditionalInstructions.ToolTip.Description = Properties.Resources.RibbonFormFieldsTab_PreviewConditionalInstructions_ToolTip_Description;

			// Add the handler that activates or deactivates the conditional instructions preview. 
			m_rtbtnPreviewConditionalInstructions.Click += PreviewConditionalInstructions_CheckedChanged;

			// Add the ribbon button to the TXITEM_FormValidationGroup ribbon group.
			RibbonGroup rgFormValidationGroup = m_rtRibbonFormFieldsTab.FindItem(RibbonFormFieldsTab.RibbonItem.TXITEM_FormValidationGroup) as RibbonGroup;
			rgFormValidationGroup.RibbonItems.Add(m_rtbtnPreviewConditionalInstructions);

			// Add CheckedChanged event handler to the TXITEM_EnableFormValidation ribbon toggle button
			// that handles the enabled state of the preview button when checked or unchecked.
			m_rbtnEnableFormValidation = m_rtRibbonFormFieldsTab.FindItem(RibbonFormFieldsTab.RibbonItem.TXITEM_EnableFormValidation) as RibbonToggleButton;
			m_rbtnEnableFormValidation.CheckedChanged += TXITEM_EnableFormValidation_CheckedChanged;

			// Add a TextControl PropertyChanged handler to update the TextControl and ribbon when the TextControl edit mode changed.
			m_txTextControl.ContentsReset += FormFields_TextControl_ContentChanged;
			m_txTextControl.DocumentLoaded += FormFields_TextControl_ContentChanged;
			RibbonToggleButton rtbtnEnforceProtection = m_rtRibbonPermissionsTab.FindItem(RibbonPermissionsTab.RibbonItem.TXITEM_EnforceProtection) as RibbonToggleButton;
			rtbtnEnforceProtection.Click += EnforceProtection_Click;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** ActivateCIPreview Method
		** Activate the conditional instructions pzreview.
		**-----------------------------------------------------------------------------------------------------------*/
		private void ActivateCIPreview() {
			// Store the current TextControl content.
			m_txTextControl.Save(out m_rbtTextControlContent, BinaryStreamType.InternalUnicodeFormat);

			// Store the current DocumentPermissions.AllowEditingFormFields and .ReadOnly property values.
			m_bAllowEditinFormFieldsTemp = m_txTextControl.DocumentPermissions.AllowEditingFormFields;
			m_bReadOnlyTemp = m_txTextControl.DocumentPermissions.ReadOnly;

			// Set those document permissions that are necessary to show a preview.
			m_txTextControl.DocumentPermissions.AllowEditingFormFields = true;
			m_txTextControl.DocumentPermissions.ReadOnly = true;

			// Hide all ribbon groups behind the TXITEM_FormValidationGroup group
			for (int i = 3; i < m_rtRibbonFormFieldsTab.RibbonGroups.Count; i++) {
				m_rtRibbonFormFieldsTab.RibbonGroups[i].Visible = false;
			}

			// Activate the preview by setting the TextControl.EditMode property value to
			// EditMode.ReadAndSelect.
			m_bIsPreviewActivated = true;
			m_txTextControl.EditMode = EditMode.ReadAndSelect;

			// Disable the TXITEM_EnableFormValidation ribbon toggle button
			m_rbtnEnableFormValidation.Enabled = false;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** DeactivateCIPreview Method
		** Deactivates the conditional instructions preview.
		**
		** Parameters:
		**      reloadContent:		Indicates whether or not the stored TextControl content should be reloaded.
		**-----------------------------------------------------------------------------------------------------------*/
		private void DeactivateCIPreview(bool reloadContent) {
			// Reset the preview button checked state
			m_rtbtnPreviewConditionalInstructions.Checked = false;
			m_bIsPreviewActivated = false;

			//  Enable the "Enable Form Validation" button.
			m_rbtnEnableFormValidation.Enabled = true;

			// Reset the Textcontrol content and permissions.
			if (reloadContent) {
				// Reload the Textcontrol content.
				m_txTextControl.Load(m_rbtTextControlContent, BinaryStreamType.InternalUnicodeFormat);
				m_rbtTextControlContent = null;

				// Reset the DocumentPermissions.AllowEditingFormFields and .ReadOnly property values.
				m_txTextControl.DocumentPermissions.AllowEditingFormFields = m_bAllowEditinFormFieldsTemp;
				m_txTextControl.DocumentPermissions.ReadOnly = m_bReadOnlyTemp;
			}
		}
	}
}
