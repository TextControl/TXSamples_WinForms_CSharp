/*-------------------------------------------------------------------------------------------------------------
** MainWindow_FormatMenuItem_DropDownOpening.cs File
**
** Description: Provides all DropDownOpening handlers associated with 'Format' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Windows.Forms;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** Format_DropDownOpening Handler
		**
		** Updates the enabled state of 'Format' drop down menu items.
		** 
		** Item: 'Format'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Format_DropDownOpening(object sender, EventArgs e) {
			bool bCanEdit = m_txTextControl.CanEdit;
			FrameBase fbFrame = bCanEdit ? m_txTextControl.Frames.GetItem() : null;

			// 'Character...', 
			m_tmiFormat_Character.Enabled = m_txTextControl.CanCharacterFormat;

			// 'Paragraph...'
			m_tmiFormat_Paragraph.Enabled = m_txTextControl.CanParagraphFormat;

			// 'Styles...'
			m_tmiFormat_Styles.Enabled = m_txTextControl.CanStyleFormat;

			// 'Image...'
			m_tmiFormat_Image.Enabled = fbFrame is Image;

			// 'Text Frame...'
			m_tmiFormat_TextFrame.Enabled = fbFrame is TextFrame;

			if (m_plTXLicense >= VersionInfo.ProductLevel.Professional) {
				// 'Shape...'
				m_tmiFormat_Shape.Enabled = EnableShapeItem(fbFrame);
			}

			// 'Barcode...'
			m_tmiFormat_Barcode.Enabled = fbFrame is DataVisualization.BarcodeFrame;

			// 'Headers and Footers...'
			m_tmiFormat_HeadersAndFooters.Enabled = bCanEdit;

			if (m_plTXLicense >= VersionInfo.ProductLevel.Professional) {
				// 'Page Number...'
				HeaderFooter hfHeaderFooter = m_txTextControl.TextParts.GetItem() as HeaderFooter;
				m_tmiFormat_PageNumberField.Enabled = bCanEdit && hfHeaderFooter != null && hfHeaderFooter.PageNumberFields.GetItem() != null;
			}

			if (m_plTXLicense >= VersionInfo.ProductLevel.Professional) {
				// 'Hyperlink...'
				HypertextLinkCollection colHyperTextLinks = m_txTextControl.HypertextLinks;
				m_tmiFormat_Hyperlink.Enabled = bCanEdit && (colHyperTextLinks.GetItem() != null || m_txTextControl.DocumentLinks.GetItem() != null);

				// 'Bookmark...'
				DocumentTargetCollection colDocumentTargets = m_txTextControl.DocumentTargets;
				m_tmiFormat_Bookmark.Enabled = bCanEdit && colDocumentTargets.GetItem() != null;
			}

			if (m_plTXLicense >= VersionInfo.ProductLevel.Enterprise) {
				// 'Table of Contents...'
				bool bInsideTOC = m_txTextControl.TablesOfContents.GetItem() != null;
				m_tmiFormat_TableOfContents.Enabled = bCanEdit && bInsideTOC;
			}

			// 'Columns...'
			m_tmiFormat_Columns.Enabled = bCanEdit;

			// 'Page Borders...'
			m_tmiFormat_PageBorders.Enabled = bCanEdit;

			// 'Page Color...'
			m_tmiFormat_PageColor.Enabled = bCanEdit;

			// 'Tabs...'
			m_tmiFormat_Tabs.Enabled = bCanEdit;

			// 'Language...'
			m_tmiFormat_Language.Enabled = bCanEdit;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Format_ParagraphStructureLevels_DropDownOpening Handler
		**
		** Updates the text of the '[Current Paragraph Style]' item.
		** 
		** Item: 'Paragraph Structure Levels'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Format_ParagraphStructureLevels_DropDownOpening(object sender, EventArgs e) {
			if (m_plTXLicense >= VersionInfo.ProductLevel.Enterprise) {
				// Get the current style name
				string strStyleName = m_txTextControl.InputFormat.StyleName;

				// Determine current paragraph style
				ParagraphStyle psCurrentStyle = m_txTextControl.ParagraphStyles.GetItem(strStyleName);

				// If no paragraph style could be determined, use the default "[Normal]" style.
				if (psCurrentStyle == null) {
					strStyleName = "[Normal]";
					psCurrentStyle = m_txTextControl.ParagraphStyles.GetItem(strStyleName);
				}

				// Provide the paragraph style by using the item's Tag property.
				m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.Tag = psCurrentStyle;

				// Display the paragraph style name as item text.
				m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.Text = string.Format(Properties.Resources.Item_Format_ParagraphStructureLevels_CurrentParagraphStyle_Text, strStyleName);
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Format_ParagraphStructureLevels_CurrentParagraphStyle_DropDownOpening Handler
		**
		** Updates the checked and enabled state of the '[Current Paragraph Style]' drop down menu items.
		** 
		** Item: '[Current Paragraph Style]' of the 'Paragraph Structure Levels' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Format_ParagraphStructureLevels_CurrentParagraphStyle_DropDownOpening(object sender, EventArgs e) {
			// Get the corresponding paragraph style.
			ParagraphStyle psParagraphStyle = m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.Tag as ParagraphStyle;
			if (psParagraphStyle != null) {
				// Get name and structure level of that style.
				string strStyleName = psParagraphStyle.Name;
				int iStructureLevel = psParagraphStyle.ParagraphFormat.StructureLevel;

				// The strucure levels of the table of contents styles ("TOC_Title" and "TOC_Level") cannot be edited.
				bool bCanEdit = m_txTextControl.CanEdit && !(strStyleName == "TOC_Title" || strStyleName.StartsWith("TOC_Level"));

				// Step through all structure level drop down items and handle their Enabled and Check properties.
				foreach (ToolStripMenuItem item in m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.DropDownItems) {
					item.Enabled = bCanEdit;
					item.Checked = int.Parse(item.Tag.ToString()) == iStructureLevel;
				}
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Format_ParagraphStructureLevels_AddToParagraph_DropDownOpening Handler
		**
		** Updates the checked and enabled state of the 'Add to Paragaph' drop down menu items.
		** 
		** Item: 'Add to Paragaph' of the 'Paragraph Structure Levels' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Format_ParagraphStructureLevels_AddToParagraph_DropDownOpening(object sender, EventArgs e) {
			// Check whether the items should be enabled.
			bool bCanEdit = m_txTextControl.CanEdit;

			// Get the current paragraph's structure level.
			int? iStructureLevel = m_txTextControl.InputFormat.StructureLevel;
			iStructureLevel = iStructureLevel.HasValue ? iStructureLevel.Value : -1;

			// Step through all structure level drop down items and handle their Enabled and Check properties.
			foreach (ToolStripMenuItem item in m_tmiFormat_ParagraphStructureLevels_AddToParagraph.DropDownItems) {
				item.Enabled = bCanEdit;
				item.Checked = int.Parse(item.Tag.ToString()) == iStructureLevel;
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Format_BulletsAndNumbering_DropDownOpening Handler
		**
		** Updates the enabled and checked state of 'Bullets and Numbering' drop down menu items.
		** 
		** Item: 'Bullets and Numbering'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Format_BulletsAndNumbering_DropDownOpening(object sender, EventArgs e) {
			// Get list format
			ListFormat lfListFormat = m_txTextControl.Selection.ListFormat;

			// Check list format type
			bool bIsList = lfListFormat.Type != ListType.None;
			bool bIsBulleted = lfListFormat.Type == ListType.Bulleted;
			bool bIsStructured = lfListFormat.Type == ListType.Structured;

			// Get number format
			NumberFormat fnNumberFormat = lfListFormat.NumberFormat;
			bool bCanCharacterFormat = m_txTextControl.CanCharacterFormat;

			// Set items Enabled states
			m_tmiFormat_BulletsAndNumbering_ArabicNumbers.Enabled =                     // '1, 2, 3'		
			m_tmiFormat_BulletsAndNumbering_CapitalLetters.Enabled =                    // 'A, B, C'
			m_tmiFormat_BulletsAndNumbering_Letters.Enabled =                           // 'a, b, c'
			m_tmiFormat_BulletsAndNumbering_RomanNumbers.Enabled =                      // 'I, II, III, IV'
			m_tmiFormat_BulletsAndNumbering_SmallRomanNumbers.Enabled =                 // 'i, ii, iii, iv'
			m_tmiFormat_BulletsAndNumbering_AsStructuredList.Enabled =                  // 'As structured List'
			m_tmiFormat_BulletsAndNumbering_Bullets.Enabled = bCanCharacterFormat;      // 'Bullets'

			// 'Increase Level'
			m_tmiFormat_BulletsAndNumbering_IncreaseLevel.Enabled = bIsList && bCanCharacterFormat;

			// 'Decrease Level'
			m_tmiFormat_BulletsAndNumbering_DecreaseLevel.Enabled = bIsList && bCanCharacterFormat && m_txTextControl.Selection.ListFormat.Level >= 2;

			// 'Properties...'
			m_tmiFormat_BulletsAndNumbering_Properties.Enabled = bCanCharacterFormat;

			// Set items Checked states
			m_tmiFormat_BulletsAndNumbering_ArabicNumbers.Checked = bIsList && !bIsBulleted && fnNumberFormat == NumberFormat.ArabicNumbers;            // '1, 2, 3'
			m_tmiFormat_BulletsAndNumbering_CapitalLetters.Checked = bIsList && !bIsBulleted && fnNumberFormat == NumberFormat.CapitalLetters;          // 'A, B, C'
			m_tmiFormat_BulletsAndNumbering_Letters.Checked = bIsList && !bIsBulleted && fnNumberFormat == NumberFormat.Letters;                        // 'a, b, c'
			m_tmiFormat_BulletsAndNumbering_RomanNumbers.Checked = bIsList && !bIsBulleted && fnNumberFormat == NumberFormat.RomanNumbers;              // 'I, II, III, IV'
			m_tmiFormat_BulletsAndNumbering_SmallRomanNumbers.Checked = bIsList && !bIsBulleted && fnNumberFormat == NumberFormat.SmallRomanNumbers;    // 'i, ii, iii, iv'
			m_tmiFormat_BulletsAndNumbering_AsStructuredList.Checked = bIsStructured;   // 'As structured List'
			m_tmiFormat_BulletsAndNumbering_Bullets.Checked = bIsBulleted;              // 'Bullets'
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Format_FormFields_DropDownOpening Handler
		**
		** Updates the enabled and checked state of 'Form Fields' drop down menu items.
		** 
		** Item: 'Form Fields'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Format_FormFields_DropDownOpening(object sender, System.EventArgs e) {
			if (m_plTXLicense >= VersionInfo.ProductLevel.Enterprise) {
				bool bCanEdit = m_txTextControl.CanEdit;
				// 'Form Fields...'
				FormFieldCollection colFormFields = m_txTextControl.FormFields;
				m_tmiFormat_FormFields_Edit.Enabled = bCanEdit && colFormFields.GetItem() != null;

				// 'Form Validation'
				m_tmiFormat_FormFields_EnableFormValidation.Enabled = bCanEdit && colFormFields.Count > 0;
				m_tmiFormat_FormFields_EnableFormValidation.Checked =
				m_tmiFormat_FormFields_ManageConditionalInstructions.Enabled = m_txTextControl.IsFormFieldValidationEnabled;
			}
		}
	}
}
