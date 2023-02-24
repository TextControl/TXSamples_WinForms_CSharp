/*-------------------------------------------------------------------------------------------------------------
** MergeAndWaitDialog.cs File
**
** Description:
**     Provides a dialog to create the merged files that should be displayed by the preview tab.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TXTextControl.DocumentServer.DataSources;
using TXTextControl.Windows.Forms.Ribbon;

namespace TXTextControl.Words {
	/*------------------------------------------------------------------------------------------------
	** Class MergeWaitDialog
	** A dialog to create the merged files that should be displayed by the preview tab.
	**----------------------------------------------------------------------------------------------*/
	partial class MergeAndWaitDialog : Form {

		/*------------------------------------------------------------------------------------------------
		** M E M B E R S
		**----------------------------------------------------------------------------------------------*/
		private IList<byte[]> m_lstMergedFiles = null;
		private bool m_bIsMergeProcessCanceled = false;
		private Exception m_exException = null;
		private readonly object[] m_roArgs = null;


		/*------------------------------------------------------------------------------------------------
		** C O N S T R U C T O R
		**----------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** MergeAndWaitDialog Constructor
		** Creates dialog to create the merged files that should be displayed by the preview tab.
		**
		** Parameters:
		**				template:		The template that is used to create the merged files.	
		**				maxPreviews:	The maximum number of merged files that should be created.	
		**				textControl:	The TextControl that is used to create the merged files.
		**				mergeSettings:	The merge settings that are used to create the merged files.	
		**				reportingTab:	The RibbonReportingTab instance that contains the 
		**								DataSourceManager that is used to create the merged files.
		**-----------------------------------------------------------------------------------------------------------*/
		public MergeAndWaitDialog(byte[] template, int maxPreviews, TextControl textControl, MergeSettings mergeSettings, RibbonReportingTab reportingTab) {
			InitializeComponent();
			// Set caption and label texts.
			this.Text = Properties.Resources.MergeAndWaitDialog_Caption;
			m_lblMerging.Text = Properties.Resources.MergeAndWaitDialog_Merging;

			// Sets the last selected master table of the ReportingTab's MasterTable Menu as datasource.
			SetLastSelectedMasterTable(reportingTab);

			// Store the arguments that are necessary to merge files.
			m_roArgs = new object[] { template, maxPreviews, textControl, mergeSettings, reportingTab };
		}


		/*------------------------------------------------------------------------------------------------
		** P R O P E R T I E S
		**----------------------------------------------------------------------------------------------*/

		/*------------------------------------------------------------------------------------------------
		** MergedFiles Property
		** Returns the merged files.
		**----------------------------------------------------------------------------------------------*/
		internal IList<byte[]> MergedFiles { get { return m_lstMergedFiles; } }

		/*------------------------------------------------------------------------------------------------
		** Exception Property
		** Returns the corresponding exception if triggered by the merge process.
		**----------------------------------------------------------------------------------------------*/
		internal Exception Exception { get { return m_exException; } }


		/*------------------------------------------------------------------------------------------------
		** O V E R R I D D E N   M E T H O D S
		**----------------------------------------------------------------------------------------------*/

		/*------------------------------------------------------------------------------------------------
		** OnLoad Method (overridden)
		** Starts the merge process with a background operation.
		**----------------------------------------------------------------------------------------------*/
		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			// Start the merge process with a background operation.
			m_bwMergeFiles.RunWorkerAsync(m_roArgs);
		}

		/*------------------------------------------------------------------------------------------------
		** OnFormClosing Method (overridden)
		** If the dialog was closed by the user, the dialog is disabled and a DataRowMerged event handler 
		** is added to the DataSourceManager that cancels the merge process.
		**----------------------------------------------------------------------------------------------*/
		protected override void OnFormClosing(FormClosingEventArgs e) {
			if (m_bwMergeFiles.IsBusy) {
				this.Enabled = false;
				m_bIsMergeProcessCanceled = true;
				RibbonReportingTab rtReportingTab = (RibbonReportingTab)m_roArgs[4];
				rtReportingTab.DataSourceManager.DataRowMerged -= DataRowMerged_Handler;
				rtReportingTab.DataSourceManager.DataRowMerged += DataRowMerged_Handler;
				e.Cancel = true;
			}
			base.OnFormClosing(e);
		}


		/*------------------------------------------------------------------------------------------------
		** M E T H O D S
		**----------------------------------------------------------------------------------------------*/

		/*------------------------------------------------------------------------------------------------
		** MergePreview Method
		** Creates a list of merged files by calling the RibbonReportingTab's DataSourceManager.Merge
		** method.
		**
		** Parameters:
		**				template:		The template that is used to create the merged files.	
		**				maxPreviews:	The maximum number of merged files that should be created.	
		**				textControl:	The TextControl that is used to create the merged files.
		**				mergeSettings:	The settings that are used to to create the merged files.
		**				reportingTab:	The RibbonReportingTab instance that contains the 
		**								DataSourceManager that is used to create the merged files.
		**----------------------------------------------------------------------------------------------*/
		private void MergePreview(byte[] template, int maxPreviews, TextControl textControl, MergeSettings mergeSettings, RibbonReportingTab reportingTab) {
			try {
				m_lstMergedFiles = reportingTab.DataSourceManager.Merge(template, maxPreviews, textControl, mergeSettings);
			} catch (Exception e) {
				// Store the exception if thrown.
				m_exException = e;
			}
		}

		/*------------------------------------------------------------------------------------------------
		** SetLastSelectedMasterTable Method
		** Sets the last selected master table of the ReportingTab's MasterTable Menu as datasource.
		**
		** Parameters:
		**				reportingTab:	The RibbonReportingTab instances that contains the master table.
		**----------------------------------------------------------------------------------------------*/
		private void SetLastSelectedMasterTable(RibbonReportingTab reportingTab) {
			RibbonMenuButton rmbtnTXITEM_SelectMasterTable = reportingTab.FindItem(RibbonReportingTab.RibbonItem.TXITEM_SelectMasterTable) as RibbonMenuButton;
			foreach (Control dropDownItem in rmbtnTXITEM_SelectMasterTable.DropDownItems) {
				RibbonToggleButton rtbnTable = dropDownItem as RibbonToggleButton;
				if (rtbnTable != null && rtbnTable.Checked) {
					reportingTab.DataSourceManager.MasterDataTableInfo = rtbnTable.Tag as DataTableInfo;
					break;
				}
			}
		}


		/*------------------------------------------------------------------------------------------------
		** E V E N T H A N D L E R 
		**----------------------------------------------------------------------------------------------*/

		/*------------------------------------------------------------------------------------------------
		** BackgroundWorker_DoWork Handler
		** Start creating a list of merged preview files when the background worker starts its background
		** operation.
		**----------------------------------------------------------------------------------------------*/
		private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) {
			object[] roArgs = e.Argument as object[];
			MergePreview((byte[])roArgs[0], (int)roArgs[1], (TextControl)roArgs[2], (MergeSettings)roArgs[3], (RibbonReportingTab)roArgs[4]);
		}

		/*------------------------------------------------------------------------------------------------
		** BackgroundWorker_RunWorkerCompleted Handler
		** Closes the dialog when the background operation was completed. Furthermore the list of merged 
		** files is reset to null if no merged file  was created or the merge process was canceled. 
		**----------------------------------------------------------------------------------------------*/
		private void BackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e) {
			if (m_bIsMergeProcessCanceled || (m_lstMergedFiles != null && m_lstMergedFiles.Count == 0)) {
				m_lstMergedFiles = null;
			}
			this.Close();
		}

		/*------------------------------------------------------------------------------------------------
		** DataRowMerged_Handler Handler
		** That handler is only added when the user tries to cancel the merge process by closing the 
		** dialog. In this case the merge process is stopped after the next data row is merged.
		**----------------------------------------------------------------------------------------------*/
		private void DataRowMerged_Handler(object sender, DocumentServer.MailMerge.DataRowMergedEventArgs e) {
			(sender as DataSourceManager).DataRowMerged -= DataRowMerged_Handler;
			e.Cancel = true; // Cancel the merge process.
		}
	}
}
