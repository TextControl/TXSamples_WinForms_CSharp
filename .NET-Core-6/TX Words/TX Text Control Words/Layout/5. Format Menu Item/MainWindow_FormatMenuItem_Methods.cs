/*-------------------------------------------------------------------------------------------------------------
** MainWindow_FormatMenuItem_Methods.cs File
**
** Description: Provides supporting methods to implement the desired behavior of some 'Format' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
        ** 'Bullets and Numbering' Item
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** SetNumberedList Method
        ** Sets whether there is a numbered or structured list at the current input position. If such a list is set,
        ** the specified list format is set.
        **
        ** Parameters:
        **      isChecked:	Determines whether a numbered or structured list is set at the current input position.
        **		listFormat:	Specifies the list format to set.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SetNumberedList(bool isChecked, NumberFormat listFormat) {
			// Check whether a structured or a numbered list is handled.
			if (m_tmiFormat_BulletsAndNumbering_AsStructuredList.Checked) {
				// Set or remove the structured list.
				if ((m_txTextControl.InputFormat.StructuredList = isChecked).Value) {
					// If a structured list is set, determine its list format.
					m_txTextControl.InputFormat.StructuredListFormat = listFormat;
				}
			}
			else {
				// Set or remove the numbered list.
				if ((m_txTextControl.InputFormat.NumberedList = isChecked).Value) {
					// If a numbered list is set, determine its list format.
					m_txTextControl.InputFormat.NumberedListFormat = listFormat;
				}
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** 'Shape...' Item
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** EnableShapeItem Method
        ** Returns a value indicating whether the specified FrameBase element is a DrawingFrame or there is an
        ** activated DrawingFrame where at least one shape is selected.
        **
        ** Parameters:
        **      frame:		The FrameBase element to check.
        **
        ** Return Value:	True, if the specified FrameBase element is a DrawingFrame or there is an activated 
        **					DrawingFrame where at least one shape is selected. Otherwise false.
        **-----------------------------------------------------------------------------------------------------------*/
		private bool EnableShapeItem(FrameBase frame) {
			// Check whether the specified FrameBase element is a DrawingFrame.
			bool bEnableDrawingItem = frame is DataVisualization.DrawingFrame;
			if (frame == null) {
				// Check whether there is a DrawingFrame that is currently activated.
				DataVisualization.DrawingFrame dfActivatedDrawingFrame = m_txTextControl.Drawings.GetActivatedItem();
				if (dfActivatedDrawingFrame != null) {
					// Check whether the activated DrawingFrame contains at least on selected shape.
					Drawing.TXDrawingControl txdDrawingControl = dfActivatedDrawingFrame.Drawing as Drawing.TXDrawingControl;
					bEnableDrawingItem = txdDrawingControl.Selection.Shapes.Length > 0;
				}
			}
			return bEnableDrawingItem;
		}
	}
}
