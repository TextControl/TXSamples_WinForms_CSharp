/*-------------------------------------------------------------------------------------------------------------
** Form1.cs File
**
** Description:
**      Sample project that is related to the 'Howto: Mail Merge -> Sample: Mail Merge with Nested 
**		Repeating Blocks' article inside the 'Windows Forms User's Guide'.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Data;
using System.Windows.Forms;

namespace MailMerge_Nested_Blocks {
	public partial class Form1 : Form {
		/*-------------------------------------------------------------------------------------------------------------
        ** C O N S T R U C T O R S
        **-----------------------------------------------------------------------------------------------------------*/
		public Form1() {
			InitializeComponent();
		}


		/*-------------------------------------------------------------------------------------------------------------
		** H A N D L E R S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** Form1_Load Handler
        ** Creates load the 'Accruals Report.docx' template.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Form1_Load(object sender, EventArgs e) {
			// Set the image of the 'Create Report' button.
			m_tmiCreateReport.Image = TXTextControl.Windows.Forms.ResourceProvider.GetSmallIcon(TXTextControl.Windows.Forms.ResourceProvider.GeneralItem.TXITEM_NavigateToNext.ToString(), this);

			// Load the DOCX template.
			TXTextControl.LoadSettings lsLoadSettings = new TXTextControl.LoadSettings {
				ApplicationFieldFormat = TXTextControl.ApplicationFieldFormat.MSWord,
				LoadSubTextParts = true
			};
			m_txTextControl.Load(@"Files\Accruals Report.docx", TXTextControl.StreamType.WordprocessingML, lsLoadSettings);

			// Do not show table grid lines.
			m_txTextControl.Tables.GridLines = false;
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** LoadSampleDatasource_Click Handler
        ** Get the reference to the 'Data.xml' sample
        **-----------------------------------------------------------------------------------------------------------*/
		private void LoadSampleDatasource_Click(object sender, EventArgs e) {
			// Update the text box.
			m_tbxLoadedDatabaseFile.Tag = @"Files\Data.xml";
			m_tbxLoadedDatabaseFile.Text = "Data.xml";
			m_tmiCreateReport.Enabled = true;
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** LoadXML_Click Handler
        ** Create and open an OpenFileDialog to get the reference to an XML database.
        **-----------------------------------------------------------------------------------------------------------*/
		private void LoadXML_Click(object sender, EventArgs e) {
			// Create and open an OpenFileDialog to load an XML database.
			OpenFileDialog dlgLoadXML = new OpenFileDialog();
			dlgLoadXML.Filter = "XML Database | *.xml";
			dlgLoadXML.InitialDirectory = Application.StartupPath;

			if (dlgLoadXML.ShowDialog(this) == DialogResult.OK) {
				// Update the text box.
				m_tbxLoadedDatabaseFile.Tag = dlgLoadXML.FileName;
				m_tbxLoadedDatabaseFile.Text = dlgLoadXML.SafeFileName;
				m_tmiCreateReport.Enabled = true;
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** CreateReport_Click Handler
        ** Merge the template with the data source.
        **-----------------------------------------------------------------------------------------------------------*/
		private void CreateReport_Click(object sender, EventArgs e) {
			try {
				// Load the XML file.
				DataSet dsData = new DataSet();
				dsData.ReadXml(m_tbxLoadedDatabaseFile.Tag as string, XmlReadMode.Auto);

				// Add the relations for the main block and its child blocks.
				DataRelation relCompanyEmployee = new DataRelation("company_employee",
					 dsData.Tables["company"].Columns["company_number"],
					 dsData.Tables["employee"].Columns["company_number"]);

				DataRelation relEmployeeSick = new DataRelation("employee_sick",
					 dsData.Tables["employee"].Columns["employee_number"],
					 dsData.Tables["sick"].Columns["employee_number"]);

				DataRelation relEmployeeVacation = new DataRelation("employee_vacation",
					 dsData.Tables["employee"].Columns["employee_number"],
					 dsData.Tables["vacation"].Columns["employee_number"]);

				dsData.Relations.Add(relCompanyEmployee);
				dsData.Relations.Add(relEmployeeSick);
				dsData.Relations.Add(relEmployeeVacation);

				// Update the progress bar.
				m_pbProgress.Maximum = dsData.Tables["employee"].Rows.Count;

				// Merge.
				m_mmMailMerge.Merge(dsData.Tables["company"], true);

				// Reset the progress bar.
				m_pbProgress.Value = 0;
			} catch (Exception exc) {
				MessageBox.Show(this, exc.Message);
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** MailMerge_BlockRowMerged Handler
        ** Update the progress bar when the 'employee' merge block is handled.
        **-----------------------------------------------------------------------------------------------------------*/
		private void MailMerge_BlockRowMerged(object sender, TXTextControl.DocumentServer.MailMerge.BlockRowMergedEventArgs e) {
			if (e.MergeBlockName == "employee") {
				m_pbProgress.PerformStep();
			}
		}
	}
}
