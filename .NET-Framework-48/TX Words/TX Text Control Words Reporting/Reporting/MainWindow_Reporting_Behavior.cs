/*-------------------------------------------------------------------------------------------------------------
** MainWindow_Reporting_Behavior.cs File
**
** Description:
**		Handles the behavior of the added application menu's sample template button, the RibbonReportingTab's 
**		'Database Sample' button, 'Merge' group and the reporting "Result" tab.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TXTextControl.DocumentServer.DataSources;
using TXTextControl.Windows.Forms.Ribbon;

namespace TXTextControl.Words {
	partial class MainWindow {

		/*-------------------------------------------------------------------------------------------------------------
		** M E M B E R   V A R I A B L E S
		**-----------------------------------------------------------------------------------------------------------*/
		private bool m_bIsResultTabVisible = false;
		private bool m_bShowRightSidebar = false;
		private bool m_bShowLeftSidebar = false;
		private bool m_bShowBottomSidebar = false;
		private RibbonTab m_rtLastSelectedTab = null;

		private int m_iCurrentMergedFile = 0;
		private IList<byte[]> m_lstMergedFiles = null;

		private byte[] m_rbtTemplate = null;
		private EditMode m_emEditMode_Reporting = EditMode.Edit;
		private bool m_bIsReadOnly = false;
		private bool m_bAllowAllowEditingFormFields = true;
		private bool m_bAllowCopy = true;
		private bool m_bAllowPrinting = true;
		private MergeSettingsDialog m_dlgMergeSettingsDialog = new MergeSettingsDialog();
		private ExportMergeResultDialog m_dlgExportMergeResult = new ExportMergeResultDialog();


		/*-------------------------------------------------------------------------------------------------------------
        ** H A N D L E R S
        **-----------------------------------------------------------------------------------------------------------*/


		/*-------------------------------------------------------------------------------------------------------------
		** Application Menu
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** SampleInvoiceTemplate_Click Handler
		** Loads the sample 'Invoice' template.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SampleInvoiceTemplate_Click(object sender, EventArgs e) {
			Open(m_strFilesDirectory + "invoice.docx", StreamType.WordprocessingML);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** SamplePackingListTemplate_Click Handler
		** Loads the sample 'Packing List' template.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SamplePackingListTemplate_Click(object sender, EventArgs e) {
			Open(m_strFilesDirectory + "packinglist.docx", StreamType.WordprocessingML);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** SampleShippingLabelTemplate_Click Handler
		** Loads the sample 'Shipping Label' template.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SampleShippingLabelTemplate_Click(object sender, EventArgs e) {
			Open(m_strFilesDirectory + "shippinglabel.docx", StreamType.WordprocessingML);
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** RibbonReportingTab
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** SampleDatabaseButton_Click Handler
        ** Loads the sample database.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SampleDatabaseButton_Click(object sender, EventArgs e) {
			m_rtRibbonReportingTab.DataSourceManager.LoadXmlFile(m_strFilesDirectory + "sample_db.xml");
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** DataSourceManager_IsMergingPossibleChanged Handler
        ** Enable/Disable the 'Merge' group when the IsMergingPossible property value of the RibbonReportingTab's  
        ** DataSourceManager changed.
        **-----------------------------------------------------------------------------------------------------------*/
		private void DataSourceManager_IsMergingPossibleChanged(object sender, EventArgs e) {
			m_rgMerge.Enabled = m_rtRibbonReportingTab.DataSourceManager.IsMergingPossible;
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** MergeAndExport_Click Handler
        ** Opens an instance of the merge settings dialog to determine the settings for the following merge process. 
        ** When clicking the OK button, an instance of the MergeAndWaitDialog dialog is being opened to create the  
        ** corresponding files. When the merge process is finished, the dialog will be closed, the first created  
        ** record is loaded inside the TextControl and the "Results" tab is shown.
        **-----------------------------------------------------------------------------------------------------------*/
		private void MergeAndExport_Click(object sender, EventArgs e) {
			// Open an instance of the merge settings dialog. 
			if (m_dlgMergeSettingsDialog.ShowDialog() == DialogResult.OK) {
				// Save the current content of the TextControl
				m_txTextControl.Save(out m_rbtTemplate, BinaryStreamType.InternalUnicodeFormat);
				// Create merge settings and open an instance of the MergeAndWaitDialog dialog to create the 
				// corresponding files.
				MergeSettings mergeSettings = new MergeSettings() {
					AsSingleDocument = m_dlgMergeSettingsDialog.MergeIntoSingleFile,
					RemoveEmptyBlocks = m_dlgMergeSettingsDialog.RemoveEmptyBlocks,
					RemoveEmptyLines = m_dlgMergeSettingsDialog.RemoveEmptyLines,
					RemoveEmptyFields = m_dlgMergeSettingsDialog.RemoveEmptyFields,
					RemoveEmptyImages = m_dlgMergeSettingsDialog.RemoveEmptyImages,
					RemoveTrailingWhitespace = m_dlgMergeSettingsDialog.RemoveTrailingWhitespace
				};

				MergeAndWaitDialog dlgMergeAndWait = new MergeAndWaitDialog(m_rbtTemplate, m_dlgMergeSettingsDialog.MaxRecords, m_txTextControl, mergeSettings, m_rtRibbonReportingTab);
				dlgMergeAndWait.ShowDialog();

				// When the merge process is finished and merge files are created, the first 
				// created record is loaded inside the TextControl and the 'Result' tab is shown.
				if (dlgMergeAndWait.MergedFiles != null) {
					ShowResultTab(dlgMergeAndWait.MergedFiles);
				}

				// Throw the exception when triggered by merge process.
				if (dlgMergeAndWait.Exception != null) {
					throw dlgMergeAndWait.Exception;
				}
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** 'Reporting' ContextualTabGroup and 'Result' RibbonTab
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** ExitResultTab_Click Handler
        ** Closes/hides the 'Result' tab.
        **-----------------------------------------------------------------------------------------------------------*/
		private void ExitResultTab_Click(object sender, EventArgs e) {
			m_rbnRibbon.SelectedTab = m_rtLastSelectedTab;
			CloseResultTab();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** FirstRecord_Click Handler
		** Loads the first merged file.
		**-----------------------------------------------------------------------------------------------------------*/
		private void FirstRecord_Click(object sender, EventArgs e) {
			LoadMergeFile(0);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** PreviousRecord_Click Handler
		** Loads the previous merged file.
		**-----------------------------------------------------------------------------------------------------------*/
		private void PreviousRecord_Click(object sender, EventArgs e) {
			LoadMergeFile(m_iCurrentMergedFile - 1);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** NextRecord_Click Handler
		** Loads the next merged file.
		**-----------------------------------------------------------------------------------------------------------*/
		private void NextRecord_Click(object sender, EventArgs e) {
			LoadMergeFile(m_iCurrentMergedFile + 1);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** LastRecord_Click Handler
		** Loads the last merged file.
		**-----------------------------------------------------------------------------------------------------------*/
		private void LastRecord_Click(object sender, EventArgs e) {
			LoadMergeFile(m_lstMergedFiles.Count - 1);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Reporting_RibbonTabIndexChanged Handler
		** Closes/hides the 'Result' tab when another tab is selected.
		**-----------------------------------------------------------------------------------------------------------*/
		private void Reporting_RibbonTabIndexChanged(object sender, EventArgs e) {
			if (m_ctgReportingResult.Visible && m_rbnRibbon.SelectedTab != m_rtMergeResultsTab) {
				CloseResultTab();
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Reporting_TextControl_ContentChanged Handler
		** Closes/hides the 'Result' tab when a new document is loaded or the TextControl content was reset.
		**-----------------------------------------------------------------------------------------------------------*/
		private void Reporting_TextControl_ContentChanged(object sender, EventArgs e) {
			if (m_ctgReportingResult.Visible && m_rbnRibbon.SelectedTab == m_rtMergeResultsTab) {
				m_rbtTemplate = null;
				m_rbnRibbon.SelectedTab = m_rtLastSelectedTab;
				CloseResultTab();
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** ExportMergeResult_Click Handler
		** Opens a dialog to export the merge result.
		**-----------------------------------------------------------------------------------------------------------*/
		private void ExportMergeResult_Click(object sender, EventArgs e) {

			// Determine the directory path that is first shown when the 'Export Merge Result' dialog is opened.
			string strExportDirectory = Properties.Settings.Default.ExportDirectory;
			if (string.IsNullOrEmpty(strExportDirectory)) {
				strExportDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			}
			m_dlgExportMergeResult.Directory = strExportDirectory;

			// Set the current active document name as file prefix.
			m_dlgExportMergeResult.FilePrefix = m_strActiveDocumentName;

			// Open the 'Export Merge Result' dialog
			if (m_dlgExportMergeResult.ShowDialog() == DialogResult.OK) {
				// Get the directory where to export the merged files.
				strExportDirectory = System.IO.Path.GetFullPath(m_dlgExportMergeResult.Directory);

				// Use a ServerTextControl to load and export each merged file.
				using (ServerTextControl serverTextControl = new ServerTextControl()) {
					serverTextControl.Create();
					for (int i = 0; i < m_lstMergedFiles.Count; i++) {
						// Load the merged file into the ServerTextControl.
						serverTextControl.Load(m_lstMergedFiles[i], BinaryStreamType.InternalUnicodeFormat);

						// Export/Save the merge file from the ServerTextControl.
						string strPath = strExportDirectory + "\\" + m_dlgExportMergeResult.FilePrefix + (i + 1) + m_dlgExportMergeResult.Format.Extension;
						serverTextControl.Save(strPath, m_dlgExportMergeResult.Format.StreamType);
					}
				}

				// Open the directory where the merged files are exported.
				if (m_dlgExportMergeResult.openDirectory) {
					System.Diagnostics.Process.Start(strExportDirectory);
				}

				// Store the current used export directory inside the application settings.
				Properties.Settings.Default.ExportDirectory = strExportDirectory;
				Properties.Settings.Default.Save();
			}
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** M E T H O D S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** 'Reporting' ContextualTabGroup and 'Result' RibbonTab
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** SetResultTabBehavior Method
        ** Manages the 'Result' tab behavior that should be automatically closed when another tab is selected, a
        ** document is loaded or the TextControl content is reset.
        **-----------------------------------------------------------------------------------------------------------*/
		private void SetResultTabBehavior() {
			m_rbnRibbon.SelectedIndexChanged += Reporting_RibbonTabIndexChanged;
			m_txTextControl.ContentsReset += Reporting_TextControl_ContentChanged;
			m_txTextControl.DocumentLoaded += Reporting_TextControl_ContentChanged;
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** ShowResultTab Method
        ** Shows the 'Result' tab with the first record of the specified merged files.
        **
        ** Parameters:
        **      mergedFiles:    The merged files that should be provided to show inside the 'Result' tab.
        **-----------------------------------------------------------------------------------------------------------*/
		private void ShowResultTab(IList<byte[]> mergedFiles) {
			// Hide all sidebars
			HideSidebars();

			// Store the current TextControl document permissions and edit mode
			m_bIsReadOnly = m_txTextControl.DocumentPermissions.ReadOnly;
			m_bAllowAllowEditingFormFields = m_txTextControl.DocumentPermissions.AllowEditingFormFields;
			m_bAllowCopy = m_txTextControl.DocumentPermissions.AllowCopy;
			m_bAllowPrinting = m_txTextControl.DocumentPermissions.AllowPrinting;
			m_emEditMode_Reporting = m_txTextControl.EditMode;

			// Remember the current selected tab.
			m_rtLastSelectedTab = m_rbnRibbon.SelectedTab as RibbonTab;

			// Load the first record of the specified merged file.
			m_iCurrentMergedFile = 0;
			m_lstMergedFiles = mergedFiles;
			LoadMergeFile(m_iCurrentMergedFile);

			// Show the 'Result' contextual tab.
			m_ctgReportingResult.Visible = true;
			// Ensure that the "Table" contextual tab is hidden.
			m_ctgTableTools.Visible = false;
			// Show the 'Result' Tab.
			m_rbnRibbon.SelectedTab = m_rtMergeResultsTab;
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** CloseResultTab Method
        ** Closes/Hides the 'Result' tab.
        **-----------------------------------------------------------------------------------------------------------*/
		private void CloseResultTab() {
			// Reset some variables.
			m_iCurrentMergedFile = 0;
			m_lstMergedFiles = null;
			// Hide the 'Reporting' contextual tab.
			m_ctgReportingResult.Visible = false;

			// Reset the content and state to what was shown before the 'Result' tab was shown.
			if (m_rbtTemplate != null) {
				m_txTextControl.Load(m_rbtTemplate, BinaryStreamType.InternalUnicodeFormat);
			}
			ResetSaveButtonBehavior();

			// Set the edit mode and document permission to what were set before the 'Result' tab was shown.
			m_txTextControl.DocumentPermissions.ReadOnly = m_bIsReadOnly;
			m_txTextControl.DocumentPermissions.AllowEditingFormFields = m_bAllowAllowEditingFormFields;
			m_txTextControl.DocumentPermissions.AllowCopy = m_bAllowCopy;
			m_txTextControl.DocumentPermissions.AllowPrinting =m_bAllowPrinting;
			m_txTextControl.EditMode = m_emEditMode_Reporting;

			// Show the sidebars that where shown before the 'Result' tab was shown.
			ShowSidebars();
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** LoadMergeFile Method
        ** Load the merged file that is stored at the specified index inside merged files list.
        **
        ** Parameters:
        **      index:		The index of the merged file to load.
        **-----------------------------------------------------------------------------------------------------------*/
		private void LoadMergeFile(int index) {
			//  Load the merged file that is stored at the specified index inside merged files list.
			m_iCurrentMergedFile = index;
			m_txTextControl.DocumentLoaded -= Reporting_TextControl_ContentChanged; // Disable DocumentLoaded event handling
			m_txTextControl.Load(m_lstMergedFiles[m_iCurrentMergedFile], BinaryStreamType.InternalUnicodeFormat); // Load the merged file.
			m_txTextControl.DocumentLoaded += Reporting_TextControl_ContentChanged; // Enable DocumentLoaded event handling

			// The loaded merged file should not be editable.
			m_txTextControl.DocumentPermissions.ReadOnly = true;
			m_txTextControl.DocumentPermissions.AllowEditingFormFields = true;
			m_txTextControl.DocumentPermissions.AllowCopy = true;
			m_txTextControl.DocumentPermissions.AllowPrinting = true;
			m_txTextControl.EditMode = EditMode.ReadAndSelect; 

			// Update enabled states
			m_rbtnFirstRecord.Enabled =
			m_rbtnPreviousRecord.Enabled = m_iCurrentMergedFile > 0;
			m_rbtnNextRecord.Enabled =
			m_rbtnLastRecord.Enabled = m_iCurrentMergedFile < m_lstMergedFiles.Count - 1;

			DisableSaveButtonBehavior();

			// Update tool tip despriptions
			string strToolTipDescription = Properties.Resources.MergeResultsTab_Record_ToolTip_Description;
			m_rbtnFirstRecord.ToolTip.Description = string.Format(strToolTipDescription, 1);
			m_rbtnPreviousRecord.ToolTip.Description = string.Format(strToolTipDescription, m_iCurrentMergedFile);
			m_rbtnNextRecord.ToolTip.Description = string.Format(strToolTipDescription, m_iCurrentMergedFile + 2);
			m_rbtnLastRecord.ToolTip.Description = string.Format(strToolTipDescription, m_lstMergedFiles.Count);
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** HideSidebars Method
        ** Stores the Sidebar's IsShown property value of each sidebar before hiding them.
        **-----------------------------------------------------------------------------------------------------------*/
		private void HideSidebars() {
			if (m_bIsResultTabVisible != (m_bIsResultTabVisible = true)) {
				// Store the Sidebar's IsShown property value of each sidebar.
				m_bShowRightSidebar = m_sbSidebarRight.IsShown;
				m_bShowLeftSidebar = m_sbSidebarLeft.IsShown;
				m_bShowBottomSidebar = m_sbSidebarBottom.IsShown;
				// Hide sidebars
				m_sbSidebarRight.IsShown =
				m_sbSidebarLeft.IsShown =
				m_sbSidebarBottom.IsShown = false;
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** ShowSidebars Method
        ** Shows the sidebars that where shown before displaying the 'Result' tab.
        **-----------------------------------------------------------------------------------------------------------*/
		private void ShowSidebars() {
			if (m_bIsResultTabVisible != (m_bIsResultTabVisible = false)) {
				m_sbSidebarRight.IsShown = m_bShowRightSidebar;
				m_sbSidebarLeft.IsShown = m_bShowLeftSidebar;
				m_sbSidebarBottom.IsShown = m_bShowBottomSidebar;
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** DisableSaveButtonBehavior Method
		** Ensures that the template cannot be overridden by using the 'Save' button as long as the 'Result' tab is 
		** shown.
		**-----------------------------------------------------------------------------------------------------------*/
		private void DisableSaveButtonBehavior() {
			m_txTextControl.Changed -= TextControl_Changed;
			m_bIsDirtyDocument = false;
			UpdateMainWindowCaption();
			UpdateSaveEnabledState();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** ResetSaveButtonBehavior Method
		** Resets the 'Save' button behavior.
		**-----------------------------------------------------------------------------------------------------------*/
		private void ResetSaveButtonBehavior() {
			m_txTextControl.Changed += TextControl_Changed;
		}
	}
}

