/*-------------------------------------------------------------------------------------------------------------
** MainWindow_InsertMenuItem_DropDownOpening.cs File
**
** Description: Provides all DropDownOpening handlers associated with 'Insert' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** Insert_DropDownOpening Handler
		**
		** Updates the enabled state of 'Insert' drop down menu items.
		** 
		** Item: 'Insert'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_DropDownOpening(object sender, EventArgs e) {
			bool bCanEdit = m_txTextControl.CanEdit;
			// 'File...'
			m_tmiInsert_File.Enabled = bCanEdit;

			// 'Image...'
			m_tmiInsert_Image.Enabled = bCanEdit;

			// 'Text Frame'
			m_tmiInsert_TextFrame.Enabled = bCanEdit;

			// 'Shape'	
			m_tmiInsert_Shape.Enabled = bCanEdit;

			// 'Barcode'
			m_tmiInsert_Barcode.Enabled = bCanEdit;

			if (m_plTXLicense >= VersionInfo.ProductLevel.Professional) {
				PageCollection colPages = m_txTextControl.GetPages();
				HeaderFooter hfHeaderFooter = m_txTextControl.TextParts.GetItem() as HeaderFooter;
				Page pgPage = colPages != null ? colPages.GetItem() : null;

				// 'Header'
				m_tmiInsert_Header_Insert.Enabled = colPages != null;
				m_tmiInsert_Header_Remove.Enabled = bCanEdit && pgPage != null && pgPage.Header != null;

				// 'Footer'
				m_tmiInsert_Footer_Insert.Enabled = colPages != null;
				m_tmiInsert_Footer_Remove.Enabled = bCanEdit && pgPage != null && pgPage.Footer != null;

				// 'Page Number'
				m_tmiInsert_PageNumber.Enabled = bCanEdit && hfHeaderFooter != null;

				if (hfHeaderFooter != null) {
					PageNumberField pnfPageNumberField = hfHeaderFooter.PageNumberFields.GetItem();
					m_tmiInsert_PageNumber_Insert.Enabled = pnfPageNumberField == null;
					m_tmiInsert_PageNumber_Delete.Enabled = pnfPageNumberField != null;
				}
			}

			if (m_plTXLicense >= VersionInfo.ProductLevel.Enterprise) {
				// 'Form Fields'
				m_tmiInsert_FormField_TextFormField.Enabled =
				m_tmiInsert_FormField_CheckBox.Enabled =
				m_tmiInsert_FormField_ComboBox.Enabled =
				m_tmiInsert_FormField_DropDownList.Enabled =
				m_tmiInsert_FormField_DateFormField.Enabled = bCanEdit && m_txTextControl.FormFields.CanAdd;
				m_tmiInsert_FormField_Delete.Enabled = bCanEdit && m_txTextControl.FormFields.GetItem() != null;
			}

			// 'Symbol'
			m_tmiInsert_Symbol.Enabled = bCanEdit;

			if (m_plTXLicense >= VersionInfo.ProductLevel.Professional) {
				// 'Hyperlink...'
				m_tmiInsert_Hyperlink.Enabled = bCanEdit && (m_txTextControl.HypertextLinks.CanAdd || m_txTextControl.DocumentLinks.CanAdd);

				// 'Bookmark...'
				DocumentTargetCollection colDocumentTargets = m_txTextControl.DocumentTargets;
				m_tmiInsert_Bookmark_Insert.Enabled = bCanEdit && colDocumentTargets.CanAdd;
				m_tmiInsert_Bookmark_Delete.Enabled = bCanEdit && colDocumentTargets.Count != 0;
				m_tmiInsert_Bookmark.Enabled = this.m_tmiInsert_Bookmark_Insert.Enabled || this.m_tmiInsert_Bookmark_Delete.Enabled;
			}

			if (m_plTXLicense >= VersionInfo.ProductLevel.Enterprise) {
				// 'Table of Contents'
				bool bInsideTOC = m_txTextControl.TablesOfContents.GetItem() != null;
				m_tmiInsert_TableOfContents_Insert.Enabled = bCanEdit && !bInsideTOC;
				m_tmiInsert_TableOfContents_Delete.Enabled =
				m_tmiInsert_TableOfContents_Update.Enabled = bCanEdit && bInsideTOC;
				m_tmiInsert_TableOfContents.Enabled = bCanEdit;
			}

			// 'Columns'
			m_tmiInsert_Columns_One.Enabled =
			m_tmiInsert_Columns_Two.Enabled =
			m_tmiInsert_Columns_MoreColumns.Enabled = bCanEdit;

			// 'Page Breaks'
			m_tmiInsert_PageBreaks.Enabled = bCanEdit;

			// 'Section Breaks'
			m_tmiInsert_SectionBreaks.Enabled = bCanEdit;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_Columns_DropDownOpening Handler
		**
		** Updates the checked state of 'Columns' drop down menu items.
		** 
		** Item: 'Columns'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_Columns_DropDownOpening(object sender, EventArgs e) {
			if (m_plTXLicense >= VersionInfo.ProductLevel.Professional) {
				// Get the number of columns
				Section secCurrentSection = m_txTextControl.Sections.GetItem();
				int iColumns = secCurrentSection != null ? secCurrentSection.Format.Columns : -1;
				// Check the items.
				m_tmiInsert_Columns_One.Checked = iColumns == 1;
				m_tmiInsert_Columns_Two.Checked = iColumns == 2;
				m_tmiInsert_Columns_MoreColumns.Checked = iColumns > 2;
			}
		}
	}
}
