/*-------------------------------------------------------------------------------------------------------------
** Form1.cs File
**
** Description:
**      Sample project that is related to the 'Howto: Add charting support to your applications -> Merging 
**		the chart objects with data' article inside the 'Windows Forms User's Guide'.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Step2 {
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
        ** 'File' Drop Down
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** New_Click Handler
        ** Deletes the entire contents of a TextControl.
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
        ** SampleTemplate_Click Handler
        ** Loads a sample template that contains charts.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SampleTemplate_Click(object sender, EventArgs e) {
			m_txTextControl.Load(@"Files\SampleTemplate.rtf", TXTextControl.StreamType.RichTextFormat);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** SaveAs_Click Handler
		** Opens a built-in dialog to save the document.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SaveAs_Click(object sender, EventArgs e) {
			m_txTextControl.Save();
		}


		/*-------------------------------------------------------------------------------------------------------------
		** 'Charts' Drop Down
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** Merge_Click Handler
		** Merge data with chart frames.
		**-----------------------------------------------------------------------------------------------------------*/
		private void Merge_Click(object sender, EventArgs e) {
			// Check whether the current document contains chart frames.
			TXTextControl.DataVisualization.ChartCollection colChartFrames = m_txTextControl.Charts;
			if (colChartFrames.Count == 0) {
				MessageBox.Show(this, "To merge data with charts it is necessary to load a template that contains chart frames.", "No Chart Frames detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Create a new DataSet and load the XML data.
			DataSet dsDataSet = new DataSet();
			dsDataSet.ReadXml(@"Files\Data.xml");

			foreach (TXTextControl.DataVisualization.ChartFrame chartFrame in colChartFrames) {
				// Check whether the DataSet contains data
				// related to the chart name.
				if (!dsDataSet.Tables.Contains(chartFrame.Name)) {
					continue;
				}

				// Get the Chart object from the chart frame.
				Chart chChart = chartFrame.Chart as Chart;

				// Set the x and y values to the first 2 columns of the DataTable.
				chChart.Series[0].XValueMember = dsDataSet.Tables[chartFrame.Name].Columns[0].ColumnName;
				chChart.Series[0].YValueMembers = dsDataSet.Tables[chartFrame.Name].Columns[1].ColumnName;

				// Set the data to the chart.
				chChart.DataSource = dsDataSet.Tables[chartFrame.Name];

				// Data bind to the selected data source.
				chChart.DataBind();

				// Update the chartFrame to reflect the changes.
				chartFrame.Refresh();
			}
		}
	}
}
