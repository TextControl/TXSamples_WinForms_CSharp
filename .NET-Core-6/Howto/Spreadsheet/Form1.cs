/*-------------------------------------------------------------------------------------------------------------
** Form1.cs File
**
** Description:
**		Sample project that is related to the 'Howto: Use Spreadsheet Formulas in Tables' article inside
**		the 'Windows Forms User's Guide'.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Windows.Forms;

namespace Spreadsheet {
	public partial class Form1 : Form {
		/*-------------------------------------------------------------------------------------------------------------
		** C O N S T R U C T O R
		**-----------------------------------------------------------------------------------------------------------*/
		public Form1() {
			InitializeComponent();
		}


		/*-------------------------------------------------------------------------------------------------------------
		** H A N D L E R S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** Form1_Load Handler
        ** Set the images of the buttons, loads the sample document and updates the states of some controls that are 
        ** related to the TextControl.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Form1_Load(object sender, EventArgs e) {
			// Set the images of the buttons.
			SetImages();

			// Load a sample document.
			m_txTextControl.Load(@"Files\Cashflow.tx", TXTextControl.StreamType.InternalUnicodeFormat);

			// Add the supported functions and number formats to the UI dropdowns.
			m_cmbxFunctions.Items.AddRange(m_txTextControl.Tables.SupportedFormulaFunctions);
			m_cmbxFormats.Items.AddRange(m_txTextControl.Tables.SupportedNumberFormats);
			m_cmbxFunctions.Text = "SUM";

			// Set default reference style and enable calculation.
			m_btnEnableCalculation.Checked = m_txTextControl.IsFormulaCalculationEnabled;
			m_txTextControl.FormulaReferenceStyle = TXTextControl.FormulaReferenceStyle.A1;

			// Check the A1 or R1C1 button.
			if (m_txTextControl.FormulaReferenceStyle == TXTextControl.FormulaReferenceStyle.A1) {
				m_btnA1.Checked = true;
			}
			else {
				m_btnR1C1.Checked = true;
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** R1C1_Click Handler
		** Determines R1C1 as formula reference style and update the UI.
		**-----------------------------------------------------------------------------------------------------------*/
		private void R1C1_Click(object sender, EventArgs e) {
			// Determines R1C1 as formula reference style.
			m_txTextControl.FormulaReferenceStyle = TXTextControl.FormulaReferenceStyle.R1C1;

			// Get the current table cell.
			TXTextControl.Table tblCurrentTable = m_txTextControl.Tables.GetItem();
			if (tblCurrentTable != null) {
				TXTextControl.TableCell tclCurrentTableCell = tblCurrentTable.Cells.GetItem();
				if (tclCurrentTableCell != null) {
					// Update the UI.
					UpdateTableCellSettings(tclCurrentTableCell);
				}
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** A1_Click Handler
		** Determines A1 as formula reference style and update the UI.
		**-----------------------------------------------------------------------------------------------------------*/
		private void A1_Click(object sender, EventArgs e) {
			// Determines A1 as formula reference style.
			m_txTextControl.FormulaReferenceStyle = TXTextControl.FormulaReferenceStyle.A1;

			// Get the current table cell.
			TXTextControl.Table tblCurrentTable = m_txTextControl.Tables.GetItem();
			if (tblCurrentTable != null) {
				TXTextControl.TableCell tclCurrentTableCell = tblCurrentTable.Cells.GetItem();
				if (tclCurrentTableCell != null) {
					// Update the UI.
					UpdateTableCellSettings(tclCurrentTableCell);
				}
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** EnableCalculation_Click Handler
		** Set a value indicating whether formulas in tables are automatically calculated when the text of an input 
		** cell is changed.
		**-----------------------------------------------------------------------------------------------------------*/
		private void EnableCalculation_Click(object sender, EventArgs e) {
			m_txTextControl.IsFormulaCalculationEnabled = m_btnEnableCalculation.Checked;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** AddFunction_Click Handler
		** Add a function to the text box and show a tooltip.
		**-----------------------------------------------------------------------------------------------------------*/
		private void AddFunction_Click(object sender, EventArgs e) {
			AddFunction(m_cmbxFunctions.Text);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Formula_KeyPress Handler
		** Apply the text of the formula text box as new formula to the current table cell when the Return key is 
		** pressed.
		**-----------------------------------------------------------------------------------------------------------*/
		private void Formula_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == 13) { // Check whether the Return key is pressed.
				ApplyFormula();
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Formula_TextChanged Handler
		** Hide the tool tip when the text of the formula text box is changed.
		**-----------------------------------------------------------------------------------------------------------*/
		private void Formula_TextChanged(object sender, EventArgs e) {
			m_ttInfo.Hide(this);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Accept_Click Handler
		** Apply a formula to the cell.
		**-----------------------------------------------------------------------------------------------------------*/
		private void Accept_Click(object sender, EventArgs e) {
			ApplyFormula();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Remove_Click Handler
		** Remove the formula from the current table cell and update the UI.
		**-----------------------------------------------------------------------------------------------------------*/
		private void Remove_Click(object sender, EventArgs e) {
			// Get the current table cell.
			TXTextControl.Table tblCurrentTable = m_txTextControl.Tables.GetItem();
			if (tblCurrentTable != null) {
				TXTextControl.TableCell tclCurrentTableCell = tblCurrentTable.Cells.GetItem();
				if (tclCurrentTableCell != null) {
					// Remove the formula from the table cell.
					tclCurrentTableCell.Formula = "";
					// Update the UI.
					UpdateTableCellSettings(tclCurrentTableCell);
				}
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** TextFormat_Click Handler
		** Determine that the cell's text is interpreted as text.
		**-----------------------------------------------------------------------------------------------------------*/
		private void TextFormat_Click(object sender, EventArgs e) {
			SetCellFormat(TXTextControl.TextType.Standard);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** NumberFormat_Click Handler
		** Determine that the cell's text is interpreted as a number.
		**-----------------------------------------------------------------------------------------------------------*/
		private void NumberFormat_Click(object sender, EventArgs e) {
			SetCellFormat(TXTextControl.TextType.Number);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** ApplyNumberFormat_Click Handler
		** Set the number format for the table cell.
		**-----------------------------------------------------------------------------------------------------------*/
		private void ApplyNumberFormat_Click(object sender, EventArgs e) {
			// Get the current table cell.
			TXTextControl.Table tblCurrentTable = m_txTextControl.Tables.GetItem();
			if (tblCurrentTable != null) {
				TXTextControl.TableCell tclCurrentTableCell = tblCurrentTable.Cells.GetItem();
				if (tclCurrentTableCell != null) {
					// Set the number format for the table cell.
					tclCurrentTableCell.CellFormat.NumberFormat = m_cmbxFormats.Text;
				}
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** TextControl_InputPositionChanged Handler
		** Enable formula UI when input position is inside a table and a single cell is selected or active
		**-----------------------------------------------------------------------------------------------------------*/
		private void TextControl_InputPositionChanged(object sender, EventArgs e) {
			// Check whether the current input position is located inside a table.
			TXTextControl.Table tblCurrentTable = m_txTextControl.Tables.GetItem();
			if (tblCurrentTable == null) {
				m_tsFormula.Enabled = false;
				return;
			}
			else {
				// Get the current table cell.
				TXTextControl.TableCell tclCurrenTableCell;
				if ((tclCurrenTableCell = tblCurrentTable.Cells.GetItem()) != null) {
					m_tsFormula.Enabled = true;
					UpdateTableCellSettings(tclCurrenTableCell);
				}
				else {
					m_tsFormula.Enabled = false;
				}
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
		** M E T H O D S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** SetImages Method
        ** Sets the images of the buttons.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SetImages() {
			// m_m_tsFormulaSettings:
			m_btnR1C1.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_EnableR1C1Style.ToString(), this);
			m_btnA1.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_EnableA1Style.ToString(), this);
			m_btnEnableCalculation.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_EnableFormulaCalculation.ToString(), this);

			// m_m_tsFormula:
			m_btnAddFunction.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_AddFunction.ToString(), this);
			m_btnAccept.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_AcceptFormula.ToString(), this);
			m_btnRemove.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_CancelFormulaEditing.ToString(), this);
			m_btnTextFormat.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_TableCellTextTypeText.ToString(), this);
			m_btnNumberFormat.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_TableCellTextTypeNumber.ToString(), this);
			m_btnApplyNumberFormat.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab.RibbonItem.TXITEM_AcceptFormula.ToString(), this);
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** AddFunction Method
        ** Add a function to the text box and show a tooltip.
        ** Parameters:
        *		function	The function to add.
        **-----------------------------------------------------------------------------------------------------------*/
		private void AddFunction(string function) {
			// Add the specified function to the text box.
			m_tbxFormula.Text = function + "()";
			m_tbxFormula.Select(function.Length + 1, 0);
			m_tbxFormula.Focus();

			// Show the tooltip.
			m_ttInfo.Show("Specify the cell range for the formula calculation."
				+ Environment.NewLine + Environment.NewLine
				+ "For example:"
				+ Environment.NewLine
				+ "SUM(A1:A5)"
				+ Environment.NewLine
				+ "This would calculate the sum for the cell range A1 to A5.", this, m_tsFormula.Items["m_tbxFormula"].Bounds.X, m_tsFormula.Bounds.Y - 100);
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** ApplyFormula Method
        ** Apply a formula to the current table cell.
        **-----------------------------------------------------------------------------------------------------------*/
		private void ApplyFormula() {
			try {
				// Get the current table cell.
				TXTextControl.Table tblCurrentTable = m_txTextControl.Tables.GetItem();
				if (tblCurrentTable != null) {
					TXTextControl.TableCell tclCurrentTableCell = tblCurrentTable.Cells.GetItem();
					if (tclCurrentTableCell != null) {
						// Apply a formula to the current table cell.
						tclCurrentTableCell.Formula = m_tbxFormula.Text;
					}
				}
			} catch (Exception exc) {
				// Let TXTextControl do the validation.
				MessageBox.Show(exc.Message, "Formula Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** UpdateTableCellSettings Method
        ** Updates the UI based on the specified cell settings.
        ** Parameters:
        **		tableCell	The table cell.
        **-----------------------------------------------------------------------------------------------------------*/
		private void UpdateTableCellSettings(TXTextControl.TableCell tableCell) {
			if (tableCell != null) {
				// Read the current formula.
				m_tbxFormula.Text = tableCell.Formula;

				// Set the check state of the reference style.
				switch (m_txTextControl.FormulaReferenceStyle) {
					case TXTextControl.FormulaReferenceStyle.A1:
						m_btnA1.Checked = true;
						m_btnR1C1.Checked = false;
						break;
					case TXTextControl.FormulaReferenceStyle.R1C1:
						m_btnA1.Checked = false;
						m_btnR1C1.Checked = true;
						break;
				}

				// Set the check state of the cell format.
				switch (tableCell.CellFormat.TextType) {
					case TXTextControl.TextType.Standard:
						m_btnTextFormat.Checked = true;
						m_btnNumberFormat.Checked = false;
						m_cmbxFormats.Enabled = false;
						m_btnApplyNumberFormat.Enabled = false;
						m_cmbxFormats.Text = "";
						break;
					case TXTextControl.TextType.Number:
						m_btnTextFormat.Checked = false;
						m_btnNumberFormat.Checked = true;
						m_cmbxFormats.Enabled = true;
						m_btnApplyNumberFormat.Enabled = true;
						m_cmbxFormats.Text = tableCell.CellFormat.NumberFormat;
						break;
				}
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** SetCellFormat Method
        ** Determine that the cell's text is interpreted as text or as a number.
        ** Parameters:
        **		textType	The value how the cell's text is interpreted.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SetCellFormat(TXTextControl.TextType textType) {
			// Get the current table cell.
			TXTextControl.Table tblCurrentTable = m_txTextControl.Tables.GetItem();
			if (tblCurrentTable != null) {
				TXTextControl.TableCell tclCurrentTableCell = tblCurrentTable.Cells.GetItem();
				if (tclCurrentTableCell != null) {
					// Determine how the cell's text is interpreted.
					tclCurrentTableCell.CellFormat.TextType = textType;
					// Update the UI.
					UpdateTableCellSettings(tclCurrentTableCell);
				}
			}
		}
	}
}
