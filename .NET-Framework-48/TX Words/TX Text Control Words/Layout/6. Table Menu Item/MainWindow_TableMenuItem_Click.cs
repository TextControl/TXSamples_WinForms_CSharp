/*-------------------------------------------------------------------------------------------------------------
** MainWindow_TableMenuItem_Click.cs File
**
** Description: Provides all Click handlers associated with 'Table' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** Table_Insert_Table_Click Handler
		**
		** Opens a dialog to add a new table at the current text input position.
		** 
		** Item: 'Table' of the 'Insert' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Insert_Table_Click(object sender, EventArgs e) {
			m_txTextControl.Tables.Add();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_Insert_ColumnToTheLeft_Click Handler
		**
		** Adds a new table column left of the column with the current input position.
		** 
		** Item: 'Column to the Left' of the 'Insert' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Insert_ColumnToTheLeft_Click(object sender, EventArgs e) {
			Table tblTable = m_txTextControl.Tables.GetItem();
			tblTable.Columns.Add(TableAddPosition.Before);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_Insert_ColumnToTheRight_Click Handler
		**
		** Adds a new table column right of the column with the current input position.
		** 
		** Item: 'Column to the Right' of the 'Insert' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Insert_ColumnToTheRight_Click(object sender, EventArgs e) {
			Table tblTable = m_txTextControl.Tables.GetItem();
			tblTable.Columns.Add(TableAddPosition.After);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_Insert_RowAbove_Click Handler
		**
		** Adds a new table row in front of the row with the current input position.
		** 
		** Item: 'Row Above' of the 'Insert' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Insert_RowAbove_Click(object sender, EventArgs e) {
			Table tblTable = m_txTextControl.Tables.GetItem();
			tblTable.Rows.Add(TableAddPosition.Before, 1);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_Insert_RowBelow_Click Handler
		**
		** Adds a new table row behind the row with the current input position.
		** 
		** Item: 'Row Below' of the 'Insert' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Insert_RowBelow_Click(object sender, EventArgs e) {
			Table tblTable = m_txTextControl.Tables.GetItem();
			tblTable.Rows.Add(TableAddPosition.After, 1);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_Delete_Cells_Click Handler
		**
		** Removes the table cell at the current text input position or all selected table cells when a text 
		** selection exists.
		** 
		** Item: 'Cells' of the 'Delete' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Delete_Cells_Click(object sender, EventArgs e) {
			Table tblTable = m_txTextControl.Tables.GetItem();
			tblTable.Cells.Remove();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_Delete_Columns_Click Handler
		**
		** Removes the table column at the current text input position or all selected table columns when a text 
		** selection exists.
		** 
		** Item: 'Columns' of the 'Delete' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Delete_Columns_Click(object sender, EventArgs e) {
			Table tblTable = m_txTextControl.Tables.GetItem();
			tblTable.Columns.Remove();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_Delete_Rows_Click Handler
		**
		** Removes the selected table rows or the row at the current text input position.
		** 
		** Item: 'Rows' of the 'Delete' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Delete_Rows_Click(object sender, EventArgs e) {
			Table tblTable = m_txTextControl.Tables.GetItem();
			tblTable.Rows.Remove();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_Delete_Table_Click Handler
		**
		** Removes the table at the current text input position.
		** 
		** Item: 'Table' of the 'Delete' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Delete_Table_Click(object sender, EventArgs e) {
			m_txTextControl.Tables.Remove();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_Select_Cell_Click Handler
		**
		** Selects the table cell.
		** 
		** Item: 'Cell' of the 'Select' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Select_Cell_Click(object sender, EventArgs e) {
			Table tblTable = m_txTextControl.Tables.GetItem();
			tblTable.Cells.GetItem().Select();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_Select_Column_Click Handler
		**
		** Selects the table column.
		** 
		** Item: 'Column' of the 'Select' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Select_Column_Click(object sender, EventArgs e) {
			Table tblTable = m_txTextControl.Tables.GetItem();
			tblTable.Columns.GetItem().Select();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_Select_Row_Click Handler
		**
		** Selects the table row.
		** 
		** Item: 'Row' of the 'Select' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Select_Row_Click(object sender, EventArgs e) {
			Table tblTable = m_txTextControl.Tables.GetItem();
			tblTable.Rows.GetItem().Select();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_Select_Table_Click Handler
		**
		** Selects the table.
		** 
		** Item: 'Table' of the 'Select' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Select_Table_Click(object sender, EventArgs e) {
			Table tblTable = m_txTextControl.Tables.GetItem();
			tblTable.Select();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_MergeCells_Click Handler
		**
		** Merges all selected table cells in this table.
		** 
		** Item: 'Merge Cells'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_MergeCells_Click(object sender, EventArgs e) {
			Table tblTable = m_txTextControl.Tables.GetItem();
			tblTable.MergeCells();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_SplitCells_Click Handler
		**
		** Splits all selected table cells in this table. Only previously merged cells can be split.
		** 
		** Item: 'Split Cells'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_SplitCells_Click(object sender, EventArgs e) {
			Table tblTable = m_txTextControl.Tables.GetItem();
			tblTable.SplitCells();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_SplitTable_Above_Click Handler
		**
		** Splits a table in front of the row with the current input position.
		** 
		** Item: 'Above' of the 'Split Table' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_SplitTable_Above_Click(object sender, EventArgs e) {
			Table tblTable = m_txTextControl.Tables.GetItem();
			tblTable.Split(TableAddPosition.Before);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_SplitTable_Below_Click Handler
		**
		** Splits a table behind the row with the current input position.
		** 
		** Item: 'Below' of the 'Split Table' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_SplitTable_Below_Click(object sender, EventArgs e) {
			Table tblTable = m_txTextControl.Tables.GetItem();
			tblTable.Split(TableAddPosition.After);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_Formulas_A1ReferenceStyle_Click Handler
		**
		** Determines that a table cell in formulas is addressed with a column letter and a row number.
		** 
		** Item: 'A1 Reference Style' of the 'Formulas' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Formulas_A1ReferenceStyle_Click(object sender, EventArgs e) {
			m_txTextControl.FormulaReferenceStyle = FormulaReferenceStyle.A1;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_Formulas_R1C1ReferenceStyle_Click Handler
		**
		** Determines that a table cell in formulas is addressed with a column number and a row number.
		** 
		** Item: 'R1C1 Reference Style' of the 'Formulas' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Formulas_R1C1ReferenceStyle_Click(object sender, EventArgs e) {
			m_txTextControl.FormulaReferenceStyle = FormulaReferenceStyle.R1C1;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_Formulas_EditFormula_Click Handler
		**
		** Opens the third tab of the built-in table dialog for setting formulas and numberformats.
		** 
		** Item: 'Edit Formula...' of the 'Formulas' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Formulas_EditFormula_Click(object sender, EventArgs e) {
			m_txTextControl.TableFormatDialog(2);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_Formulas_AutomaticCalculation_Click Handler
		**
		** Set a value whether formulas in tables are automatically calculated when the text of an input cell is 
		** changed.
		** 
		** Item: 'Automatic Calculation' of the 'Formulas' drop down menu
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Formulas_AutomaticCalculation_Click(object sender, EventArgs e) {
			m_txTextControl.IsFormulaCalculationEnabled = m_tmiTable_Formulas_AutomaticCalculation.Checked;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Table_Properties_Click Handler
		**
		** Invokes the built-in dialog for setting formatting attributes of tables. 
		** 
		** Item: 'Properties...'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_Properties_Click(object sender, EventArgs e) {
			m_txTextControl.TableFormatDialog();
		}
	}
}
