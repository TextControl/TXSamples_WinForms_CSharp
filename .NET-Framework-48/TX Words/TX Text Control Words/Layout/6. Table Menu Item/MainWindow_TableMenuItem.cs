/*-------------------------------------------------------------------------------------------------------------
** MainWindow_TableMenuItem.cs File
**
** Description: Provides methods to set the layout and behavior of the 'Table' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** SetTableItemsTexts Method
		**
		** Sets the texts of the 'Table' menu items.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SetTableItemsTexts() {
			// 'Table'
			SetItemText(m_tmiTable);

			// 'Insert'
			SetItemText(m_tmiTable_Insert);
			SetItemText(m_tmiTable_Insert_Table);
			SetItemText(m_tmiTable_Insert_ColumnToTheLeft);
			SetItemText(m_tmiTable_Insert_ColumnToTheRight);
			SetItemText(m_tmiTable_Insert_RowAbove);
			SetItemText(m_tmiTable_Insert_RowBelow);

			// 'Delete'
			SetItemText(m_tmiTable_Delete);
			SetItemText(m_tmiTable_Delete_Table);
			SetItemText(m_tmiTable_Delete_Columns);
			SetItemText(m_tmiTable_Delete_Rows);
			SetItemText(m_tmiTable_Delete_Cells);

			// 'Select'
			SetItemText(m_tmiTable_Select);
			SetItemText(m_tmiTable_Select_Table);
			SetItemText(m_tmiTable_Select_Column);
			SetItemText(m_tmiTable_Select_Row);
			SetItemText(m_tmiTable_Select_Cell);

			// 'Merge Cells'
			SetItemText(m_tmiTable_MergeCells);

			// 'Split Cells'
			SetItemText(m_tmiTable_SplitCells);

			// 'Split Table'
			SetItemText(m_tmiTable_SplitTable);
			SetItemText(m_tmiTable_SplitTable_Above);
			SetItemText(m_tmiTable_SplitTable_Below);

			// 'Formulas'
			SetItemText(m_tmiTable_Formulas);
			SetItemText(m_tmiTable_Formulas_A1ReferenceStyle);
			SetItemText(m_tmiTable_Formulas_R1C1ReferenceStyle);
			SetItemText(m_tmiTable_Formulas_EditFormula);
			SetItemText(m_tmiTable_Formulas_AutomaticCalculation);

			// 'Properties...'
			SetItemText(m_tmiTable_Properties);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** SetTableItemsImages Method
		**
		** Sets the images of the 'Table' menu items.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SetTableItemsImages() {
			// 'Insert'
			SetItemImage(m_tmiTable_Insert, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertTable.ToString());
			SetItemImage(m_tmiTable_Insert_Table, Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertTable.ToString());
			SetItemImage(m_tmiTable_Insert_ColumnToTheLeft, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonItem.TXITEM_InsertTableColLeft.ToString());
			SetItemImage(m_tmiTable_Insert_ColumnToTheRight, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonItem.TXITEM_InsertTableColRight.ToString());
			SetItemImage(m_tmiTable_Insert_RowAbove, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonItem.TXITEM_InsertTableRowAbove.ToString());
			SetItemImage(m_tmiTable_Insert_RowBelow, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonItem.TXITEM_InsertTableRowBelow.ToString());

			// 'Delete'
			SetItemImage(m_tmiTable_Delete, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonItem.TXITEM_DeleteTable.ToString());
			SetItemImage(m_tmiTable_Delete_Table, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonItem.TXITEM_DeleteTable.ToString());
			SetItemImage(m_tmiTable_Delete_Columns, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonDropDownItem.TXITEM_DeleteTableCol.ToString());
			SetItemImage(m_tmiTable_Delete_Rows, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonDropDownItem.TXITEM_DeleteTableRow.ToString());
			SetItemImage(m_tmiTable_Delete_Cells, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonDropDownItem.TXITEM_DeleteTableCell.ToString());

			// 'Select'
			SetItemImage(m_tmiTable_Select, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonDropDownItem.TXITEM_SelectTableRow.ToString());
			SetItemImage(m_tmiTable_Select_Table, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonDropDownItem.TXITEM_SelectTableAll.ToString());
			SetItemImage(m_tmiTable_Select_Column, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonDropDownItem.TXITEM_SelectTableCol.ToString());
			SetItemImage(m_tmiTable_Select_Row, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonDropDownItem.TXITEM_SelectTableRow.ToString());
			SetItemImage(m_tmiTable_Select_Cell, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonDropDownItem.TXITEM_SelectTableCell.ToString());

			// 'Merge Cells'
			SetItemImage(m_tmiTable_MergeCells, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonItem.TXITEM_MergeTableCells.ToString());

			// 'Split Cells'
			SetItemImage(m_tmiTable_SplitCells, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonItem.TXITEM_SplitTableCells.ToString());

			// 'Split Table'
			SetItemImage(m_tmiTable_SplitTable, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonItem.TXITEM_SplitTable.ToString());
			SetItemImage(m_tmiTable_SplitTable_Above, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonDropDownItem.TXITEM_SplitTableAbove.ToString());
			SetItemImage(m_tmiTable_SplitTable_Below, Windows.Forms.Ribbon.RibbonTableLayoutTab.RibbonDropDownItem.TXITEM_SplitTableBelow.ToString());

			// 'Formulas'
			SetItemImage(m_tmiTable_Formulas, Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_AddFunction.ToString());
			SetItemImage(m_tmiTable_Formulas_A1ReferenceStyle, Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_EnableA1Style.ToString());
			SetItemImage(m_tmiTable_Formulas_R1C1ReferenceStyle, Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_EnableR1C1Style.ToString());
			SetItemImage(m_tmiTable_Formulas_EditFormula, "TXITEM_FormulaEditing");
			SetItemImage(m_tmiTable_Formulas_AutomaticCalculation, Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_EnableFormulaCalculation.ToString());

			// 'Properties...'
			SetItemImage(m_tmiTable_Properties, Windows.Forms.Ribbon.RibbonInsertTab.RibbonDropDownItem.TXITEM_InsertTableDialog.ToString());
		}

		/*-------------------------------------------------------------------------------------------------------------
		** ConnectTableItemsHandlers Method
		**
		** Connects the 'Table' menu items to Click and DropDownOpening handlers.
		**-----------------------------------------------------------------------------------------------------------*/
		private void ConnectTableItemsHandlers() {
			// Click Handlers

			// 'Insert'
			m_tmiTable_Insert_Table.Click += Table_Insert_Table_Click;
			m_tmiTable_Insert_ColumnToTheLeft.Click += Table_Insert_ColumnToTheLeft_Click;
			m_tmiTable_Insert_ColumnToTheRight.Click += Table_Insert_ColumnToTheRight_Click;
			m_tmiTable_Insert_RowAbove.Click += Table_Insert_RowAbove_Click;
			m_tmiTable_Insert_RowBelow.Click += Table_Insert_RowBelow_Click;

			// 'Delete'
			m_tmiTable_Delete_Cells.Click += Table_Delete_Cells_Click;
			m_tmiTable_Delete_Columns.Click += Table_Delete_Columns_Click;
			m_tmiTable_Delete_Rows.Click += Table_Delete_Rows_Click;
			m_tmiTable_Delete_Table.Click += Table_Delete_Table_Click;

			// 'Select'
			m_tmiTable_Select_Cell.Click += Table_Select_Cell_Click;
			m_tmiTable_Select_Column.Click += Table_Select_Column_Click;
			m_tmiTable_Select_Row.Click += Table_Select_Row_Click;
			m_tmiTable_Select_Table.Click += Table_Select_Table_Click;

			// 'Merge Cells'
			m_tmiTable_MergeCells.Click += Table_MergeCells_Click;

			// 'Split Cells'
			m_tmiTable_SplitCells.Click += Table_SplitCells_Click;

			// 'Split Table'
			m_tmiTable_SplitTable_Above.Click += Table_SplitTable_Above_Click;
			m_tmiTable_SplitTable_Below.Click += Table_SplitTable_Below_Click;

			// 'Formulas'
			m_tmiTable_Formulas_A1ReferenceStyle.Click += Table_Formulas_A1ReferenceStyle_Click;
			m_tmiTable_Formulas_R1C1ReferenceStyle.Click += Table_Formulas_R1C1ReferenceStyle_Click;
			m_tmiTable_Formulas_AutomaticCalculation.Click += Table_Formulas_AutomaticCalculation_Click;
			m_tmiTable_Formulas_EditFormula.Click += Table_Formulas_EditFormula_Click;

			// 'Properties...'
			m_tmiTable_Properties.Click += Table_Properties_Click;


			// DropDownOpening Handlers

			// 'Table'
			m_tmiTable.DropDownOpening += Table_DropDownOpening;

			// 'Formulas'
			m_tmiTable_Formulas.DropDownOpening += Formulas_DropDownOpening;
		}
	}
}
