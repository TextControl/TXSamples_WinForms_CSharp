/*-------------------------------------------------------------------------------------------------------------
** MainWindow_InsertMenuItem_Click.cs File
**
** Description: Provides all Click handlers associated with 'Insert' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Drawing;
using System.Windows.Forms;
using TXTextControl.DataVisualization;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** Insert_File_Click Handler
		**
		** Opens a dialog to exchange the currently selected text with a specified file.
		** 
		** Item: 'File...'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_File_Click(object sender, EventArgs e) {
			// Create load settings.
			LoadSettings lsLoadSettings = new LoadSettings {
				ApplicationFieldFormat = ApplicationFieldFormat.MSWordTXFormFields,
				LoadSubTextParts = true,
				DocumentPartName = string.Empty
			};
			// Open the dialog to chose a file that exchanges the currently selected text.
			m_txTextControl.Selection.Load(StreamType.All, lsLoadSettings);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_Image_Click Handler
		**
		** Opens a dialog to insert an image where the text flows around that image and empty areas at the left and 
		** right side are filled.
		** 
		** Item: 'Image...'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_Image_Click(object sender, EventArgs e) {
			m_txTextControl.Images.Add(new Image(), HorizontalAlignment.Left, -1, ImageInsertionMode.DisplaceText);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_TextFrame_Click Handler
		**
		** Inserts a text frame by sizing its bounds with the mouse. The text frame is anchored to a paragraph and 
		** moves with the text. The text flows around the text frame and empty areas at the left and right side are 
		** filled.
		** 
		** Item: 'Text Frame'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_TextFrame_Click(object sender, EventArgs e) {
			m_txTextControl.TextFrames.Add(new TextFrame(new Size(2880, 2880)), TextFrameInsertionMode.DisplaceText | TextFrameInsertionMode.MoveWithText);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_Shape_ShapeCategory_MenuItem_Click Handler
		**
		** Inserts a shape as a DrawingFrame into the TextControl or, if a drawing frame is activated, into it. If the
		** shape is inserted as a DrawingFrame, it is anchored to a paragraph and moves with the text. The text flows 
		** around the drawing frame and empty areas at the left and right side are filled.
		**  
		** Item: Each item of the 'Shape' drop down menu's category items.
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_Shape_ShapeCategory_MenuItem_Click(object sender, EventArgs e) {
			AddShape((Drawing.ShapeType)(sender as ToolStripMenuItem).Tag);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_Shape_DrawingCanvas_Click Handler
		**
		** Inserts an activated DrawingFrame that represents a drawing canvas into the TextControl. The text flows  
		** around that image and empty areas at the left and right side are filled.
		**  
		** Item: 'Drawing Canvas' of the 'Shape' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_Shape_DrawingCanvas_Click(object sender, EventArgs e) {
			// Add a DrawingFrame that represents a drawing canvas into the TextControl.
			Drawing.TXDrawingControl drawing = new Drawing.TXDrawingControl(7000, 4000);
			DrawingFrame dfDrawingFrame = new DrawingFrame(drawing);
			m_txTextControl.Drawings.Add(dfDrawingFrame, HorizontalAlignment.Left, -1, FrameInsertionMode.DisplaceText);

			// Activate the DrawingFrame.
			dfDrawingFrame.Activate();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_Barcode_MenuItem_Click Handler
		**
		** Inserts a BarcodeFrame that represents the barcode type that is represented by the clicked item into the 
		** TextControl. It is anchored to a paragraph and moves with the text. The text flows around the barcode 
		** frame and empty areas at the left and right side are filled.
		**  
		** Item: Each item of the 'Barcode' drop down items.
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_Barcode_MenuItem_Click(object sender, EventArgs e) {
			Barcode.TXBarcodeControl txbBarcodeControl = new Barcode.TXBarcodeControl {
				Size = new Size(240, 180),
				BarcodeType = (Barcode.BarcodeType)(sender as ToolStripMenuItem).Tag
			};
			BarcodeFrame bfBarcodeFrame = new BarcodeFrame(txbBarcodeControl);
			m_txTextControl.Barcodes.Add(bfBarcodeFrame, HorizontalAlignment.Left, -1, FrameInsertionMode.DisplaceText | FrameInsertionMode.MoveWithText);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_Header_Insert_Click Handler
		**
		** Insert a header to the TextControl (or activates the header if it already exists).
		**  
		** Item: 'Insert' of the 'Header' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_Header_Insert_Click(object sender, EventArgs e) {
			InsertHeaderFooter(HeaderFooterType.Header);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_Header_Remove_Click Handler
		**
		** Removes the header from the TextControl.
		**  
		** Item: 'Remove' of the 'Header' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_Header_Remove_Click(object sender, EventArgs e) {
			HeaderFooter hfHeader = m_txTextControl.GetPages().GetItem().Header;
			RemoveHeaderFooter(hfHeader);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_Footer_Insert_Click Handler
		**
		** Insert a footer to the TextControl (or activates the footer if it already exists).
		**  
		** Item: 'Insert' of the 'Footer' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_Footer_Insert_Click(object sender, EventArgs e) {
			InsertHeaderFooter(HeaderFooterType.Footer);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_Footer_Remove_Click Handler
		**
		** Removes the footer from the TextControl.
		**  
		** Item: 'Remove' of the 'Footer' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_Footer_Remove_Click(object sender, EventArgs e) {
			HeaderFooter hfFooter = m_txTextControl.GetPages().GetItem().Footer;
			RemoveHeaderFooter(hfFooter);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_PageNumber_Insert_Click Handler
		**
		** Inserts a new page number field at the current input position of the header or footer.
		**  
		** Item: 'Insert' of the 'Page Number' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_PageNumber_Insert_Click(object sender, EventArgs e) {
			HeaderFooter hfHeaderFooter = m_txTextControl.TextParts.GetItem() as HeaderFooter;
			hfHeaderFooter.PageNumberFields.Add(new PageNumberField());
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_PageNumber_Remove_Click Handler
		**
		** Removes a page number from the header or footer.
		**  
		** Item: 'Remove' of the 'Page Number' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_PageNumber_Remove_Click(object sender, EventArgs e) {
			HeaderFooter hfHeaderFooter = m_txTextControl.TextParts.GetItem() as HeaderFooter;
			PageNumberField pnfPageNumberField = hfHeaderFooter.PageNumberFields.GetItem();
			hfHeaderFooter.PageNumberFields.Remove(pnfPageNumberField);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_FormFields_TextFormField_Click Handler
		**
		** Inserts a text form field at the current input position.
		**  
		** Item: 'Text Form Field' of the 'Form Fields' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_FormFields_TextFormField_Click(object sender, EventArgs e) {
			TextFormField tffTextFormField = new TextFormField(GetWidthFromEnvironment());
			m_txTextControl.FormFields.Add(tffTextFormField);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_FormFields_CheckBox_Click Handler
		**
		** Inserts a check form field at the current input position.
		**  
		** Item: 'Check Box' of the 'Form Fields' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_FormFields_CheckBox_Click(object sender, EventArgs e) {
			CheckFormField cffCheckFormField = new CheckFormField(true);
			m_txTextControl.FormFields.Add(cffCheckFormField);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_FormFields_ComboBox_Click Handler
		**
		** Inserts a selection form field (with combo box behavior) at the current input position.
		**  
		** Item: 'Combo Box' of the 'Form Fields' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_FormFields_ComboBox_Click(object sender, EventArgs e) {
			SelectionFormField sffComboBoxField = new SelectionFormField(GetWidthFromEnvironment()) { IsDropDownArrowVisible = true };
			m_txTextControl.FormFields.Add(sffComboBoxField);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_FormFields_DropDownList_Click Handler
		**
		** Inserts a selection form field (with drop down list behavior) at the current input position.
		**  
		** Item: 'Drop-Down List' of the 'Form Fields' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_FormFields_DropDownList_Click(object sender, EventArgs e) {
			SelectionFormField sffDropDownListField = new SelectionFormField(GetWidthFromEnvironment()) { Editable = false, IsDropDownArrowVisible = true };
			m_txTextControl.FormFields.Add(sffDropDownListField);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_FormFields_DateFormField_Click Handler
		**
		** Inserts a date form field at the current input position.
		**  
		** Item: 'Date Form Field' of the 'Form Fields' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_FormFields_DateFormField_Click(object sender, EventArgs e) {
			DateFormField dffDateFormField = new DateFormField(0) { IsDateControlVisible = true };
			m_txTextControl.FormFields.Add(dffDateFormField);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_FormFields_Delete_Click Handler
		**
		** Removes the current form field from the TextControl document.
		**  
		** Item: 'Delete' of the 'Form Fields' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_FormFields_Delete_Click(object sender, EventArgs e) {
			m_txTextControl.FormFields.Remove(m_txTextControl.FormFields.GetItem());
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_Symbol_Click Handler
		**
		** Invokes a built-in dialog box for inserting symbol characters.
		**  
		** Item: 'Symbol...'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_Symbol_Click(object sender, EventArgs e) {
			m_txTextControl.AddSymbolDialog();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_Hyperlink_Insert_Click Handler
		**
		** Opens an instance of the HyperlinkDialog to insert a hyperlink (HypertextLink or DocumentLink) at the 
		** current input position.
		**  
		** Item: 'Hyperlink...'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_Hyperlink_Click(object sender, EventArgs e) {
			HyperlinkDialog dlgHyperlink = new HyperlinkDialog(m_txTextControl) { Owner = this };
			dlgHyperlink.ShowDialog(this);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_Bookmark_Insert_Click Handler
		**
		** Opens an instance of the BookmarkDialog to insert a DocumentTarget at the current input position.
		**  
		** Item: 'Insert...' of the 'Bookmark' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_Bookmark_Insert_Click(object sender, EventArgs e) {
			BookmarkDialog dlgInsertBookmark = new BookmarkDialog(m_txTextControl) { Owner = this };
			dlgInsertBookmark.ShowDialog(this);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_Bookmark_Delete_Click Handler
		**
		** Opens an instance of the DeleteBookmarksDialog to delete document targets from the TextControl document.
		**  
		** Item: 'Delete...' of the 'Bookmark' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_Bookmark_Delete_Click(object sender, EventArgs e) {
			DeleteBookmarksDialog dlgDeleteBookmark = new DeleteBookmarksDialog(m_txTextControl) { Owner = this };
			dlgDeleteBookmark.ShowDialog(this);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_TableOfContents_Insert_Click Handler
		**
		** Invokes the built-in dialog box to insert a table of contents. 
		**  
		** Item: 'Insert...' of the 'Table of Contents' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_TableOfContents_Insert_Click(object sender, EventArgs e) {
			m_txTextControl.TableOfContentsDialog();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_TableOfContents_Delete_Click Handler
		**
		** Removes the table of contents from the collection including all its text and including all DocumentTargets 
		** to where the table's links point.
		**  
		** Item: 'Delete' of the 'Table of Contents' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_TableOfContents_Delete_Click(object sender, EventArgs e) {
			TableOfContents tocTableOfContens = m_txTextControl.TablesOfContents.GetItem();
			if (tocTableOfContens != null) {
				m_txTextControl.TablesOfContents.Remove(tocTableOfContens);
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_TableOfContents_Update_Click Handler
		**
		** Updates the content and the page numbers of the table of contents.
		**  
		** Item: 'Update' of the 'Table of Contents' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_TableOfContents_Update_Click(object sender, EventArgs e) {
			TableOfContents tocTableOfContens = m_txTextControl.TablesOfContents.GetItem();
			if (tocTableOfContens != null) {
				if (tocTableOfContens.Update() == TableOfContentsCollection.AddResult.ContentNotFound) {
					MessageBox.Show(this, Properties.Resources.MessageBox_UpdateTableOfContents_NoContents_Text, Properties.Resources.MessageBox_UpdateTableOfContents_NoContents_Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_Columns_One_Click Handler
		**
		** Set the number of colums for the current section to one.
		**  
		** Item: 'One' of the 'Columns' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_Columns_One_Click(object sender, EventArgs e) {
			SetColumnCount(1);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_Columns_Two_Click Handler
		**
		** Set the number of colums for the current section to two.
		**  
		** Item: 'Two' of the 'Columns' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_Columns_Two_Click(object sender, EventArgs e) {
			SetColumnCount(2);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_Columns_MoreColumns_Click Handler
		**
		** Opens the third tab of the built-in tabbed dialog box for setting the number of page columns and its 
		** attributes.
		**  
		** Item: 'More Columns...' of the 'Columns' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_Columns_MoreColumns_Click(object sender, EventArgs e) {
			m_txTextControl.SectionFormatDialog(2);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_PageBreaks_Page_Click Handler
		**
		** Add a page break at the current text position and scrolls to input position on the next page.
		**  
		** Item: 'Page' of the 'Page Breaks' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_PageBreaks_Page_Click(object sender, EventArgs e) {
			m_txTextControl.TextChars.Add(ControlChars.PageBreak);
			m_txTextControl.ScrollLocation = new Point(m_txTextControl.InputPosition.Location.X, m_txTextControl.InputPosition.Location.Y - 1440);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_PageBreaks_Column_Click Handler
		**
		** Add a column break at the current text position and scrolls to the new input position.
		**  
		** Item: 'Column' of the 'Page Breaks' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_PageBreaks_Column_Click(object sender, EventArgs e) {
			m_txTextControl.TextChars.Add(ControlChars.ColumnBreak);
			ScrollToTextPosition(m_txTextControl.InputPosition.TextPosition);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_PageBreaks_TextWrapping_Click Handler
		**
		** Add a line break at the current text position and scrolls to the new input position.
		**  
		** Item: 'Text Wrapping' of the 'Page Breaks' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_PageBreaks_TextWrapping_Click(object sender, EventArgs e) {
			m_txTextControl.TextChars.Add(ControlChars.LineBreak);
			ScrollToTextPosition(m_txTextControl.InputPosition.TextPosition);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_SectionBreaks_NextPage_Click Handler
		**
		** Adds a new section on the next page with a new paragraph.
		**  
		** Item: 'Next Page' of the 'Section Breaks' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_SectionBreaks_NextPage_Click(object sender, EventArgs e) {
			m_txTextControl.Sections.Add(SectionBreakKind.BeginAtNewPage);
			ScrollToTextPosition(m_txTextControl.InputPosition.TextPosition);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Insert_SectionBreaks_Continuous_Click Handler
		**
		** Adds a new section on the next line with a new paragraph.
		**  
		** Item: 'Continuous' of the 'Section Breaks' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Insert_SectionBreaks_Continuous_Click(object sender, EventArgs e) {
			m_txTextControl.Sections.Add(SectionBreakKind.BeginAtNewLine);
			ScrollToTextPosition(m_txTextControl.InputPosition.TextPosition);
		}
	}
}
