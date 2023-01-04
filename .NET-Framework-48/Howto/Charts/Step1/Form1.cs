/*-------------------------------------------------------------------------------------------------------------
** Form1.cs File
**
** Description:
**      Sample project that is related to the 'Howto: Add charting support to your applications -> Creating 
**		a template that contains chart objects' article inside the 'Windows Forms User's Guide'.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Step1 {
	public partial class Form1 : Form {
		/*-------------------------------------------------------------------------------------------------------------
		** M E M B E R   V A R I A B L E S
		**-----------------------------------------------------------------------------------------------------------*/
		private DataTable m_dtData = new DataTable();
		private TXTextControl.DataVisualization.ChartFrame m_cfCurrentChart;


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
		** Creates the default data table.
		**-----------------------------------------------------------------------------------------------------------*/
		private void Form1_Load(object sender, EventArgs e) {
			// Add default data points for demo purposes.
			m_dtData.Columns.Add("Country");
			m_dtData.Columns.Add("Value");

			m_dtData.Rows.Add(new object[] { "United States", 700 });
			m_dtData.Rows.Add(new object[] { "Europe", 600 });
			m_dtData.Rows.Add(new object[] { "Asia", 800 });
			m_dtData.Rows.Add(new object[] { "Africa", 400 });
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** 'File' Drop Down
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** New_Click Handler
        ** Deletes the entire contents of a Text Control.
        **-----------------------------------------------------------------------------------------------------------*/
		private void New_Click(object sender, EventArgs e) {
			m_txTextControl.ResetContents();
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** Open_Click Handler
        ** Opens a built-in dialog to load a document into the TextControl.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Open_Click(object sender, EventArgs e) {
			m_txTextControl.Load();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** SaveAs_Click Handler
		** Opens a built-in dialog to save the document.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SaveAs_Click(object sender, EventArgs e) {
			m_txTextControl.Save();
		}


		/*-------------------------------------------------------------------------------------------------------------
		** 'Insert' Drop Down
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** Chart_Click Handler
		** Creates a new chart frame and adds it into the TextControl.
		**-----------------------------------------------------------------------------------------------------------*/
		private void Chart_Click(object sender, EventArgs e) {
			// Create an object of type System.Windows.Forms.DataVisualization.Charting.Chart,
			Chart chChart = new Chart();

			// Add a series and a chart area.
			chChart.Series.Add("series1");
			chChart.ChartAreas.Add("area1");

			// Set the data source.
			chChart.DataSource = m_dtData;

			// Set series members names for the X and Y values.
			chChart.Series[0].XValueMember = "Country";
			chChart.Series[0].YValueMembers = "Value";

			// Data bind to the selected data source.
			chChart.DataBind();

			// Create new ChartFrame.
			TXTextControl.DataVisualization.ChartFrame chartFrame = new TXTextControl.DataVisualization.ChartFrame(chChart);
			chartFrame.Name = "points";

			// Add it to the TextControl.
			m_txTextControl.Charts.Add(chartFrame, -1);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** TextControl_ChartSelected Handler
		** Sets the current chart frame and updates the chart panel controls.
		**-----------------------------------------------------------------------------------------------------------*/
		private void TextControl_ChartSelected(object sender, TXTextControl.DataVisualization.ChartEventArgs e) {
			// Set the current chart frame.
			m_cfCurrentChart = e.ChartFrame;

			// Update chart name text box and chart property grid.
			m_tbxChartName.Text = m_cfCurrentChart.Name;
			m_pgChartProperties.SelectedObject = m_cfCurrentChart.Chart;

			// Enable the chart panel.
			m_tlpChartPanel.Enabled = true;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** TextControl_ChartDeselected Handler
		** Sets the current chart frame to null and resets the chart panel controls.
		**-----------------------------------------------------------------------------------------------------------*/
		private void TextControl_ChartDeselected(object sender, TXTextControl.DataVisualization.ChartEventArgs e) {
			// Set the current chart frame to null.
			m_cfCurrentChart = null;

			// Reset chart name text box and chart property grid.
			m_tbxChartName.Text = "";
			m_pgChartProperties.SelectedObject = null;

			// Disable the chart panel.
			m_tlpChartPanel.Enabled = false;
		}


		/*-------------------------------------------------------------------------------------------------------------
		** Chart panel
		**-----------------------------------------------------------------------------------------------------------*/
		
		/*-------------------------------------------------------------------------------------------------------------
		** ChartName_TextChanged Handler
		** Updates the enabled state of the 'Apply Chart Name' button when the chart name text box text is changed.
		**-----------------------------------------------------------------------------------------------------------*/
		private void ChartName_TextChanged(object sender, EventArgs e) {
			m_btnApplyChartName.Enabled = m_tbxChartName.Text.Trim().Length > 0;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** ApplyChartName_Click Handler
		** Updates the chart name with the text of the chart name text box.
		**-----------------------------------------------------------------------------------------------------------*/
		private void ApplyChartName_Click(object sender, EventArgs e) {
			SetChartName();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** ChartName_KeyUp Handler
		** Updates the chart name with the text of the chart name text box when the Enter key is pressed.
		**-----------------------------------------------------------------------------------------------------------*/
		private void ChartName_KeyUp(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				SetChartName();
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** ChartProperties_PropertyValueChanged Handler
		** Refreshes the current chart frame layout when a property of the chart property grid is changed.
		**-----------------------------------------------------------------------------------------------------------*/
		private void ChartProperties_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
			m_cfCurrentChart.Refresh();
		}


		/*-------------------------------------------------------------------------------------------------------------
		** M E T H O D S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** SetChartName Method
        ** Updates the chart name with the text of the chart name text box.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SetChartName() {
			if (m_btnApplyChartName.Enabled) {
				m_cfCurrentChart.Name = m_tbxChartName.Text.Trim();
				m_txTextControl.Focus();
			}
		}
	}
}
