/*-------------------------------------------------------------------------------------------------------------
** MainWindow_TableMenuItem_DropDownOpening.cs File
**
** Description: Provides all DropDownOpening handlers associated with 'Table' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** Table_DropDownOpening Handler
		**
		** Updates the enabled state of 'Table' drop down menu items.
		** 
		** Item: 'Table'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Table_DropDownOpening(object sender, EventArgs e) {
			// Get current table states
			Table tblCurrentTable = m_txTextControl.Tables.GetItem();
			bool bIsTable = tblCurrentTable != null;
			bool bCanTableFormat = m_txTextControl.CanTableFormat;
			TableCellCollection colTableCells = bIsTable ? tblCurrentTable.Cells : null;
			TableColumnCollection colTableColumns = bIsTable ? tblCurrentTable.Columns : null;
			TableRowCollection colTableRows = bIsTable ? tblCurrentTable.Rows : null;


			// 'Insert'
			m_tmiTable_Insert.Enabled = bCanTableFormat;
			m_tmiTable_Insert_ColumnToTheLeft.Enabled =
			m_tmiTable_Insert_ColumnToTheRight.Enabled = bCanTableFormat && bIsTable && colTableColumns.CanAdd;
			m_tmiTable_Insert_RowAbove.Enabled =
			m_tmiTable_Insert_RowBelow.Enabled = bCanTableFormat && bIsTable && colTableRows.CanAdd;

			// 'Delete'
			m_tmiTable_Delete.Enabled =
			m_tmiTable_Delete_Table.Enabled = bCanTableFormat && bIsTable;
			m_tmiTable_Delete_Cells.Enabled = bCanTableFormat && bIsTable && colTableCells.CanRemove;
			m_tmiTable_Delete_Columns.Enabled = bCanTableFormat && bIsTable && colTableColumns.CanRemove;
			m_tmiTable_Delete_Rows.Enabled = bCanTableFormat && bIsTable && colTableRows.CanRemove;

			// 'Select'
			m_tmiTable_Select.Enabled =
			m_tmiTable_Select_Table.Enabled = bCanTableFormat && bIsTable;
			m_tmiTable_Select_Cell.Enabled = bCanTableFormat && bIsTable && colTableCells.GetItem() != null;
			m_tmiTable_Select_Column.Enabled = bCanTableFormat && bIsTable && colTableColumns.GetItem() != null;
			m_tmiTable_Select_Row.Enabled = bCanTableFormat && bIsTable && colTableRows.GetItem() != null;

			// 'Merge Cells'
			m_tmiTable_MergeCells.Enabled = bCanTableFormat && bIsTable && tblCurrentTable.CanMergeCells;

			// 'Split Cells'
			m_tmiTable_SplitCells.Enabled = bCanTableFormat && bIsTable && tblCurrentTable.CanSplitCells;

			// 'Split Table'
			m_tmiTable_SplitTable.Enabled = bCanTableFormat && bIsTable && tblCurrentTable.CanSplit;

			// 'Formulas'
			m_tmiTable_Formulas_A1ReferenceStyle.Enabled =
			m_tmiTable_Formulas_R1C1ReferenceStyle.Enabled =
			m_tmiTable_Formulas_AutomaticCalculation.Enabled = bCanTableFormat;
			m_tmiTable_Formulas_EditFormula.Enabled = bCanTableFormat && bIsTable;

			// 'Properties...'
			m_tmiTable_Properties.Enabled = bCanTableFormat && bIsTable;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Formulas_DropDownOpening Handler
		**
		** Updates the checked state of 'Formulas' drop down menu items.
		** 
		** Item: 'Formulas'
		**-----------------------------------------------------------------------------------------------------------*/
		private void Formulas_DropDownOpening(object sender, EventArgs e) {
			// Set the check states of the 'Formulas' drop down items.
			FormulaReferenceStyle frsReferenceStyle = m_txTextControl.FormulaReferenceStyle;
			m_tmiTable_Formulas_A1ReferenceStyle.Checked = frsReferenceStyle == FormulaReferenceStyle.A1;
			m_tmiTable_Formulas_R1C1ReferenceStyle.Checked = frsReferenceStyle == FormulaReferenceStyle.R1C1;
			m_tmiTable_Formulas_AutomaticCalculation.Checked = m_txTextControl.IsFormulaCalculationEnabled;
		}
	}
}
