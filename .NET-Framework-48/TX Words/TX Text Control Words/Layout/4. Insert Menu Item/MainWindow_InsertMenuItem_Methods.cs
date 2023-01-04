/*-------------------------------------------------------------------------------------------------------------
** MainWindow_InsertMenuItem_Methods.cs File
**
** Description: Provides supporting methods to implement the desired behavior of some 'Insert' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Drawing;
using System.Windows.Forms;
using TXTextControl.DataVisualization;
using TXTextControl.Windows.Forms;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
        ** 'Shape' Item
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** AddShape method
		** Inserts a shape as a DrawingFrame into the TextControl or, if a drawing frame is activated, into it. If the
		** shape is inserted as a DrawingFrame, it is anchored to a paragraph and moves with the text. The text flows 
		** around the drawing frame and empty areas at the left and right side are filled.
        **
        ** Parameters:
        **      shapeType:  The type of the shape to add.
		**-----------------------------------------------------------------------------------------------------------*/
		private void AddShape(Drawing.ShapeType shapeType) {
			DrawingFrame dfDrawingFrame = m_txTextControl.Drawings.GetActivatedItem();
			if (dfDrawingFrame == null) {
				// Create a new drawing canvas/TXDrawingControl.
				Drawing.TXDrawingControl txdDrawingControl = new Drawing.TXDrawingControl(7000, 4000);

				// Add a shape with the specified shape type into the drawing canvas.
				Drawing.Shape shape = new Drawing.Shape(shapeType) { AutoSize = true, Movable = false, Sizable = false };
				txdDrawingControl.Shapes.Add(shape, Drawing.ShapeCollection.AddStyle.Fill);

				// Finally the new created drawing canvas/TXDrawingControl is added to the TextControl
				dfDrawingFrame = new DrawingFrame(txdDrawingControl);
				m_txTextControl.Drawings.Add(dfDrawingFrame, FrameInsertionMode.DisplaceText | FrameInsertionMode.MoveWithText);
			}
			else {
				// Add a new Shape into the drawing canvas
				Drawing.TXDrawingControl drawing = dfDrawingFrame.Drawing as Drawing.TXDrawingControl;
				if (drawing != null && drawing.IsCanvasVisible) {
					drawing.Shapes.Add(new Drawing.Shape(shapeType), Drawing.ShapeCollection.AddStyle.MouseCreation);
				}
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** AddShapeItem method
		** Creates a new MenuItem that represents a specific shape type and adds it to the specified items collection. 
		**
		** Parameters:
        **      items:			The items collection where to add the created item.
        **		shapeType:		The shape type that is represented by the created item.
		**-----------------------------------------------------------------------------------------------------------*/
		private void AddShapeItem(ToolStripItemCollection items, Drawing.ShapeType shapeType) {
			// Get text and icon by using the ResourceProvider
			string strResourceID = "TXITEM_SHAPE_" + shapeType;
			string strText = ResourceProvider.GetToolTipDescription(strResourceID);
			Bitmap bmpImage = ResourceProvider.GetSmallIcon(strResourceID, this);

			// Create a ToolStripMenuItem with the corresponding text and icon. Additionally the shape type is stored
			// as Tag value.
			ToolStripMenuItem tmiShapeItem = new ToolStripMenuItem(strText, bmpImage) { Tag = shapeType };
			// Add the Click handler to the item.
			tmiShapeItem.Click += Insert_Shape_ShapeCategory_MenuItem_Click;
			// Add the item to the specified items collection.
			items.Add(tmiShapeItem);
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** 'Barcode' Item
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** AddBarcodeItem method
		** Creates a new MenuItem that represents a specific barcode type and adds it to the specified items 
		** collection. 
		**
		** Parameters:
		**      items:			The items collection where to add the created item.
		**		barcodeType:	The barcode type that is represented by the created item.
		**-----------------------------------------------------------------------------------------------------------*/
		private void AddBarcodeItem(ToolStripItemCollection items, Barcode.BarcodeType barcodeType) {
			// Get text and icon by using the ResourceProvider
			string strResourceID = "TXITEM_BARCODE_" + barcodeType;
			string strText = ResourceProvider.GetToolTipTitle(strResourceID);
			Bitmap bmpImage = ResourceProvider.GetSmallIcon(strResourceID, this);

			// Create a ToolStripMenuItem with the corresponding text and icon. Additionally the barcode type is stored
			// as Tag value.
			ToolStripMenuItem tmiBarcodeItem = new ToolStripMenuItem(strText, bmpImage) { Tag = barcodeType };
			// Add the Click handler to the item.
			tmiBarcodeItem.Click += Insert_Barcode_MenuItem_Click;
			// Add the item to the specified items collection.
			items.Add(tmiBarcodeItem);
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** 'Header' and 'Footer' Item
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** InsertHeaderFooter method
		** Insert a header or footer to the TextControl (or activates the header/footer if it already exists).
		**
		** Parameters:
		**      type:			The header/footer type to insert/activate.
		**-----------------------------------------------------------------------------------------------------------*/
		private void InsertHeaderFooter(HeaderFooterType type) {

			// Get the HeaderFooter of the current page if it already exists.
			Page pgPage = m_txTextControl.GetPages().GetItem();
			HeaderFooter hfHeaderFooter = type == HeaderFooterType.Header ? pgPage.Header : pgPage.Footer;

			// If there is no header or footer, insert it:
			if (hfHeaderFooter == null) {
				Section section = m_txTextControl.Sections[pgPage.Section];
				if (section != null) {
					HeaderFooterCollection colHeaderFooters = section.HeadersAndFooters;
					if (colHeaderFooters != null) {
						colHeaderFooters.Add(type);
						hfHeaderFooter = type == HeaderFooterType.Header ? pgPage.Header : pgPage.Footer;
					}
				}
			}

			// Finally activate the header or footer:
			if (hfHeaderFooter != null) {
				hfHeaderFooter.Activate();
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** RemoveHeaderFooter method
		** Removes the header/footer from the TextControl.
		**
		** Parameters:
		**      headerFooter:		The header/footer to remove.
		**-----------------------------------------------------------------------------------------------------------*/
		private void RemoveHeaderFooter(HeaderFooter headerFooter) {
			Section secSection = m_txTextControl.Sections[headerFooter.Section];
			if (secSection != null) {
				HeaderFooterCollection colHeaderFooters = secSection.HeadersAndFooters;
				if (colHeaderFooters != null) colHeaderFooters.Remove(headerFooter.Type);
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
		** 'Form Fields' Item
		**-----------------------------------------------------------------------------------------------------------*/

		/*------------------------------------------------------------------------------------------------
		** GetWidthFromEnvironment Method
		** Calculates and returns the width to set for a TextFormField or a SelectionFormField that
		** will be created and inserted into the TextControl. The width depends on whether the FormField
		** is inserted inside a table cell or a text frame. In this case, the corresponding width is
		** returned. Otherwise the default empty width is returnd.
		**
		** Return value:        The calculated width to set.
		**----------------------------------------------------------------------------------------------*/
		private int GetWidthFromEnvironment() {

			int iHorizontalPadding = 114;// ~2mm horizontal padding
			Table tblTable = m_txTextControl.Tables.GetItem();
			if (tblTable != null) {
				TableCell tcCell = tblTable.Cells.GetItem();
				if (tcCell != null) {
					return tcCell.Width - iHorizontalPadding;
				}
			}
			else {
				TextFrame tfTextFrame = m_txTextControl.TextParts.GetItem() as TextFrame;
				if (tfTextFrame != null) {
					return Math.Min(m_iDefaultEmptyWidth, tfTextFrame.Size.Width - iHorizontalPadding);
				}
			}
			return 0;
		}


		/*-------------------------------------------------------------------------------------------------------------
		** 'Columns' Item
		**-----------------------------------------------------------------------------------------------------------*/

		/*------------------------------------------------------------------------------------------------
		** SetColumnCount
		** Set a specific number of columns for the current section.
		**
		** Parameters:
		**      columns:		The number of columns to set.
		**----------------------------------------------------------------------------------------------*/
		private void SetColumnCount(int columns) {
			m_txTextControl.Select(m_txTextControl.Selection.Start, 0);
			Section secCurrentSection = m_txTextControl.Sections.GetItem();

			if (secCurrentSection != null) {
				secCurrentSection.Format.EqualColumnWidth = true;
				secCurrentSection.Format.Columns = columns;
			}

		}


		/*-------------------------------------------------------------------------------------------------------------
		** 'Page Breaks' and 'Section Breaks' Items
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------
		** ScrollToTextPosition
		** Scrolls to a specific text position. Based on:
		** https://docs.textcontrol.com/textcontrol/windows-forms/article.techarticle.howtosscrolltotextposition.htm
		**
		** Parameters:
		**      textPosition:		The specified text position where to scroll.
		**-----------------------------------------------------------------------------------------------------*/
		private void ScrollToTextPosition(int textPosition) {
			Point pntNewScrollLocation; ;
			if (textPosition + 1 <= m_txTextControl.TextChars.Count) {
				pntNewScrollLocation = new Point(0, m_txTextControl.TextChars[textPosition + 1].Bounds.Y);
			}
			else {
				pntNewScrollLocation = new Point(0, m_txTextControl.Lines[m_txTextControl.Lines.Count].TextBounds.Y);
			}
			m_txTextControl.ScrollLocation = pntNewScrollLocation;
		}
	}
}
