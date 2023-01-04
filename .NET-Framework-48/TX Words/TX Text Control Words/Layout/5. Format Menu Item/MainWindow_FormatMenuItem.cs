/*-------------------------------------------------------------------------------------------------------------
** MainWindow_FormatMenuItem.cs File
**
** Description: Provides methods to set the layout and behavior of the 'Format' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System.Windows.Forms;

namespace TXTextControl.Words {
	partial class MainWindow {

		/*-------------------------------------------------------------------------------------------------------------
		** M E T H O D S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** SetFormatItemsTexts Method
		**
		** Sets the texts of the 'Format' menu items.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SetFormatItemsTexts() {
			// 'Format'
			SetItemText(m_tmiFormat);

			// 'Character...'
			SetItemText(m_tmiFormat_Character);

			// 'Paragraph...'
			SetItemText(m_tmiFormat_Paragraph);

			// 'Styles...'
			SetItemText(m_tmiFormat_Styles);

			// 'Paragraph Structure Levels'
			SetItemText(m_tmiFormat_ParagraphStructureLevels);
			SetItemText(m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle_BodyText);
			SetItemText(m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle);

			// Set texts of the 'Paragraph Style: [Current Paragraph Style]' item's 'Level' drop down items.
			for (int i = 1; i < m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.DropDownItems.Count; i++) {
				// Get item.
				ToolStripItem tmiLevel = m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.DropDownItems[i];
				// Create accelerator string.
				string strLevel = i < 10 ? "&" + i : "1&0";
				// Set text.
				SetItemText(tmiLevel, Properties.Resources.Item_Format_ParagraphStructureLevels_CurrentParagraphStyle_Level_Text, strLevel);
			}

			SetItemText(m_tmiFormat_ParagraphStructureLevels_AddToParagraph);
			SetItemText(m_tmiFormat_ParagraphStructureLevels_AddToParagraph_BodyText);

			// Set texts of the 'Add to Paragraph' item's 'Level' drop down items.
			for (int i = 1; i < m_tmiFormat_ParagraphStructureLevels_AddToParagraph.DropDownItems.Count; i++) {
				// Get item.
				ToolStripItem tmiLevel = m_tmiFormat_ParagraphStructureLevels_AddToParagraph.DropDownItems[i];
				// Create accelerator string.
				string strLevel = i < 10 ? "&" + i : "1&0";
				// Set text.
				SetItemText(tmiLevel, Properties.Resources.Item_Format_ParagraphStructureLevels_AddToParagraph_Level_Text, strLevel);
			}

			// 'Bullets and Numbering'
			SetItemText(m_tmiFormat_BulletsAndNumbering);
			SetItemText(m_tmiFormat_BulletsAndNumbering_ArabicNumbers);
			SetItemText(m_tmiFormat_BulletsAndNumbering_CapitalLetters);
			SetItemText(m_tmiFormat_BulletsAndNumbering_Letters);
			SetItemText(m_tmiFormat_BulletsAndNumbering_RomanNumbers);
			SetItemText(m_tmiFormat_BulletsAndNumbering_SmallRomanNumbers);
			SetItemText(m_tmiFormat_BulletsAndNumbering_AsStructuredList);
			SetItemText(m_tmiFormat_BulletsAndNumbering_Bullets);
			SetItemText(m_tmiFormat_BulletsAndNumbering_IncreaseLevel);
			SetItemText(m_tmiFormat_BulletsAndNumbering_DecreaseLevel);
			SetItemText(m_tmiFormat_BulletsAndNumbering_Properties);

			// 'Image...'
			SetItemText(m_tmiFormat_Image);

			// 'Text Frame...'
			SetItemText(m_tmiFormat_TextFrame);

			// 'Shape...'
			SetItemText(m_tmiFormat_Shape);

			// 'Barcode...'
			SetItemText(m_tmiFormat_Barcode);

			// 'Headers and Footers...'
			SetItemText(m_tmiFormat_HeadersAndFooters);

			// 'Page Number...'
			SetItemText(m_tmiFormat_PageNumberField);

			// 'Form Fields'
			SetItemText(m_tmiFormat_FormFields);
			SetItemText(m_tmiFormat_FormFields_Edit);
			SetItemText(m_tmiFormat_FormFields_EnableFormValidation);
			SetItemText(m_tmiFormat_FormFields_ManageConditionalInstructions);

			// 'Hyperlink...'
			SetItemText(m_tmiFormat_Hyperlink);

			// 'Bookmark...'
			SetItemText(m_tmiFormat_Bookmark);

			// 'Table of Contents...'
			SetItemText(m_tmiFormat_TableOfContents);

			// 'Columns...'
			SetItemText(m_tmiFormat_Columns);

			// 'Page Borders...'
			SetItemText(m_tmiFormat_PageBorders);

			// 'Page Color...'
			SetItemText(m_tmiFormat_PageColor);

			// 'Tabs...'
			SetItemText(m_tmiFormat_Tabs);

			// 'Language...'
			SetItemText(m_tmiFormat_Language);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** SetFormatItemsImages Method
		**
		** Sets the images of the 'Format' menu items.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SetFormatItemsImages() {
			// 'Character...'
			SetItemImage(m_tmiFormat_Character, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_ChangeCase.ToString());

			// 'Paragraph...'
			SetItemImage(m_tmiFormat_Paragraph, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_ControlChars.ToString());

			// 'Styles...'
			SetItemImage(m_tmiFormat_Styles, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_StyleName.ToString());

			// 'Paragraph Structure Levels'
			SetItemImage(m_tmiFormat_ParagraphStructureLevels, Windows.Forms.Ribbon.RibbonReferencesTab.RibbonItem.TXITEM_TOCMinimumStructureLevel.ToString());
			SetItemImage(m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_StyleName.ToString());
			SetItemImage(m_tmiFormat_ParagraphStructureLevels_AddToParagraph, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_ControlChars.ToString());

			// 'Bullets and Numbering'
			SetItemImage(m_tmiFormat_BulletsAndNumbering, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_NumberedList.ToString());
			SetItemImage(m_tmiFormat_BulletsAndNumbering_AsStructuredList, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_StructuredList.ToString());
			SetItemImage(m_tmiFormat_BulletsAndNumbering_Bullets, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_BulletedList.ToString());
			SetItemImage(m_tmiFormat_BulletsAndNumbering_IncreaseLevel, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_IncreaseIndent.ToString());
			SetItemImage(m_tmiFormat_BulletsAndNumbering_DecreaseLevel, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_DecreaseIndent.ToString());
			SetItemImage(m_tmiFormat_BulletsAndNumbering_Properties, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_NumberedList.ToString());

			// 'Image...'
			SetItemImage(m_tmiFormat_Image, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertImage.ToString());

			// 'Text Frame...'
			SetItemImage(m_tmiFormat_TextFrame, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertTextFrame.ToString());

			// 'Shape...'
			SetItemImage(m_tmiFormat_Shape, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertShape.ToString());

			// 'Barcode...'
			SetItemImage(m_tmiFormat_Barcode, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertBarcode.ToString());

			// 'Headers and Footers...'
			SetItemImage(m_tmiFormat_HeadersAndFooters, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertHeader.ToString());

			// 'Page Number...'
			SetItemImage(m_tmiFormat_PageNumberField, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertPageNumber.ToString());

			// 'Form Fields'
			SetItemImage(m_tmiFormat_FormFields, Windows.Forms.Ribbon.RibbonFormFieldsTab.RibbonItem.TXITEM_InsertComboBoxField.ToString());
			SetItemImage(m_tmiFormat_FormFields_Edit, Windows.Forms.Ribbon.RibbonFormFieldsTab.RibbonItem.TXITEM_InsertComboBoxField.ToString());
			SetItemImage(m_tmiFormat_FormFields_EnableFormValidation, Windows.Forms.Ribbon.RibbonFormFieldsTab.RibbonItem.TXITEM_EnableFormValidation.ToString());
			SetItemImage(m_tmiFormat_FormFields_ManageConditionalInstructions, Windows.Forms.Ribbon.RibbonFormFieldsTab.RibbonItem.TXITEM_ManageConditionalInstructions.ToString());

			// 'Hyperlink...'
			SetItemImage(m_tmiFormat_Hyperlink, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertHyperlink.ToString());

			// 'Bookmark...'
			SetItemImage(m_tmiFormat_Bookmark, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertBookmark.ToString());

			// 'Table of Contents...'
			SetItemImage(m_tmiFormat_TableOfContents, Windows.Forms.Ribbon.RibbonReferencesTab.RibbonItem.TXITEM_ModifyTableOfContents.ToString());

			// 'Columns...'
			SetItemImage(m_tmiFormat_Columns, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonItem.TXITEM_Columns.ToString());

			// 'Page Borders...'
			SetItemImage(m_tmiFormat_PageBorders, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonItem.TXITEM_PageBorders.ToString());

			// 'Page Color...'
			SetItemImage(m_tmiFormat_PageColor, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonItem.TXITEM_PageColor.ToString());

			// 'Tabs...'
			SetItemImage(m_tmiFormat_Tabs, Windows.Forms.Ribbon.RibbonFormattingTab.RibbonItem.TXITEM_EditTabs.ToString());

			// 'Language...'
			SetItemImage(m_tmiFormat_Language, Windows.Forms.Ribbon.RibbonProofingTab.RibbonItem.TXITEM_SetLanguage.ToString());
		}

		/*-------------------------------------------------------------------------------------------------------------
		** ConnectFormatItemsHandlers Method
		**
		** Connects the 'Format' menu items to Click and DropDownOpening handlers.
		**-----------------------------------------------------------------------------------------------------------*/
		private void ConnectFormatItemsHandlers() {
			// Click Handlers

			// 'Character...'
			m_tmiFormat_Character.Click += Format_Character_Click;

			// 'Paragraph...'
			m_tmiFormat_Paragraph.Click += Format_Paragraph_Click;

			// 'Styles...'
			m_tmiFormat_Styles.Click += Format_Styles_Click;

			// 'Paragraph Structure Levels'
			foreach (ToolStripMenuItem item in m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.DropDownItems) {
				item.Click += Format_ParagraphStructureLevels_CurrentParagraphStyle_Level_Click;
			}

			foreach (ToolStripMenuItem item in m_tmiFormat_ParagraphStructureLevels_AddToParagraph.DropDownItems) {
				item.Click += Format_ParagraphStructureLevels_AddToParagraph_Level_Click;
			}

			// 'Bullets and Numbering'
			m_tmiFormat_BulletsAndNumbering_ArabicNumbers.Click += Format_BulletsAndNumbering_ArabicNumbers_Click;
			m_tmiFormat_BulletsAndNumbering_Letters.Click += Format_BulletsAndNumbering_Letters_Click;
			m_tmiFormat_BulletsAndNumbering_CapitalLetters.Click += Format_BulletsAndNumbering_CapitalLetters_Click;
			m_tmiFormat_BulletsAndNumbering_RomanNumbers.Click += Format_BulletsAndNumbering_RomanNumbers_Click;
			m_tmiFormat_BulletsAndNumbering_SmallRomanNumbers.Click += Format_BulletsAndNumbering_SmallRomanNumbers_Click;
			m_tmiFormat_BulletsAndNumbering_AsStructuredList.Click += Format_BulletsAndNumbering_AsStructuredList_Click;
			m_tmiFormat_BulletsAndNumbering_Bullets.Click += Format_BulletsAndNumbering_Bullets_Click;
			m_tmiFormat_BulletsAndNumbering_IncreaseLevel.Click += Format_BulletsAndNumbering_IncreaseLevel_Click;
			m_tmiFormat_BulletsAndNumbering_DecreaseLevel.Click += Format_BulletsAndNumbering_DecreaseLevel_Click;
			m_tmiFormat_BulletsAndNumbering_Properties.Click += Format_BulletsAndNumbering_Properties_Click;

			// 'Image...'
			m_tmiFormat_Image.Click += Format_Image_Click;

			// 'Text Frame...'
			m_tmiFormat_TextFrame.Click += Format_TextFrame_Click;

			// 'Shape...'
			m_tmiFormat_Shape.Click += Format_Shape_Click;

			// 'Barcode...'
			m_tmiFormat_Barcode.Click += Frame_Barcode_Click;

			// 'Headers and Footers...'
			m_tmiFormat_HeadersAndFooters.Click += Frame_HeadersAndFooters_Click;

			// 'Page Number...'
			m_tmiFormat_PageNumberField.Click += Format_PageNumberField_Click;

			// 'Form Fields'
			m_tmiFormat_FormFields_Edit.Click += Format_FormFields_Edit_Click;
			m_tmiFormat_FormFields_EnableFormValidation.Click += Format_FormFields_EnableFormValidation_Click;
			m_tmiFormat_FormFields_ManageConditionalInstructions.Click += Format_FormFields_ManageConditionalInstructions_Click;

			// 'Hyperlink...'
			m_tmiFormat_Hyperlink.Click += Format_Hyperlink_Click;

			// 'Bookmark...'
			m_tmiFormat_Bookmark.Click += Format_Bookmark_Click;

			// 'Table of Contents...'
			m_tmiFormat_TableOfContents.Click += Format_TableOfContents_Click;

			// 'Columns...'
			m_tmiFormat_Columns.Click += Format_Columns_Click;

			// 'Page Borders...'
			m_tmiFormat_PageBorders.Click += Format_PageBorders_Click;

			// 'Page Color...'
			m_tmiFormat_PageColor.Click += Format_PageColor_Click;

			// 'Tabs...'
			m_tmiFormat_Tabs.Click += Format_Tabs_Click;

			// 'Language...'
			m_tmiFormat_Language.Click += Format_Language_Click;


			// DropDownOpening Handlers

			// 'Format'
			m_tmiFormat.DropDownOpening += Format_DropDownOpening;

			// 'Paragraph Structure Levels'
			m_tmiFormat_ParagraphStructureLevels.DropDownOpening += Format_ParagraphStructureLevels_DropDownOpening;
			m_tmiFormat_ParagraphStructureLevels_CurrentParagraphStyle.DropDownOpening += Format_ParagraphStructureLevels_CurrentParagraphStyle_DropDownOpening;
			m_tmiFormat_ParagraphStructureLevels_AddToParagraph.DropDownOpening += Format_ParagraphStructureLevels_AddToParagraph_DropDownOpening;

			// 'Bullets and Numbering'
			m_tmiFormat_BulletsAndNumbering.DropDownOpening += Format_BulletsAndNumbering_DropDownOpening;

			// 'Form Fields'
			m_tmiFormat_FormFields.DropDownOpening += Format_FormFields_DropDownOpening;
		}
	}
}
