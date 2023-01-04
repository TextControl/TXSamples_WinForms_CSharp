/*-------------------------------------------------------------------------------------------------------------
** MainWindow_Reporting_Layout.cs File
**
** Description:
**		Sets the layout of the added application menu's sample template button, the RibbonReportingTab's  
**		'Database Sample' button,  Merge' group and the reporting "Result" tab.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System.Drawing;
using TXTextControl.Windows.Forms;
using TXTextControl.Windows.Forms.Ribbon;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
        ** M E M B E R   V A R I A B L E S
        **-----------------------------------------------------------------------------------------------------------*/
		// RibbonReportingTab
		private RibbonButton m_rbtnSampleDatabaseButton = null;
		private readonly RibbonGroup m_rgMerge = new RibbonGroup();
		private RibbonButton m_rbtnMergeAndExport = null;

		// Result Tab
		private RibbonGroup m_rgMergeResultsTab_ResultGroup = new RibbonGroup();
		private RibbonButton m_rbtnExitMergeResultsTab = new RibbonButton();

		private RibbonGroup m_rgNavigateGroup = new RibbonGroup();
		private RibbonButton m_rbtnFirstRecord = new RibbonButton();
		private RibbonButton m_rbtnPreviousRecord = new RibbonButton();
		private RibbonButton m_rbtnNextRecord = new RibbonButton();
		private RibbonButton m_rbtnLastRecord = new RibbonButton();

		private RibbonGroup m_rgExportGroup = new RibbonGroup();
		private RibbonButton m_rbtnExportMergeResult = null;

		/*-------------------------------------------------------------------------------------------------------------
        ** M E T H O D S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** Application Menu
		**-----------------------------------------------------------------------------------------------------------*/
		/*-------------------------------------------------------------------------------------------------------------
		** SetOpenSampleTemplateButtonDesign Method
		** Sets the design of the menu button with a drop down menu that references to three different templates which are
		** associated with the sample base.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SetOpenSampleTemplateButtonDesign() {
			m_rmbtnOpenSampleTemplate.SmallIcon = GetSmallIcon("TXTextControl.Words.Images.OpenSampleTemplate_Small.svg");
			m_rmbtnOpenSampleTemplate.LargeIcon = GetLargeIcon("TXTextControl.Words.Images.OpenSampleTemplate_Large.svg");
			m_rmbtnOpenSampleTemplate.Text = Properties.Resources.ApplicationMenu_OpenSampleTemplate;
			m_rmbtnOpenSampleTemplate.KeyTip = Properties.Resources.ApplicationMenu_OpenSampleTemplate_KeyTip;
			m_rmbtnOpenSampleTemplate.ToolTip.Title = Properties.Resources.ApplicationMenu_OpenSampleTemplate_ToolTip_Title;
			m_rmbtnOpenSampleTemplate.ToolTip.Description = Properties.Resources.ApplicationMenu_OpenSampleTemplate_ToolTip_Description;

			m_rbtnSampleInvoiceTemplate.Text = Properties.Resources.ApplicationMenu_SampleInvoiceTemplate;
			m_rbtnSampleInvoiceTemplate.KeyTip = Properties.Resources.ApplicationMenu_SampleInvoiceTemplate_KeyTip;
			m_rbtnSampleInvoiceTemplate.Click += SampleInvoiceTemplate_Click;
			m_rbtnSamplePackingListTemplate.Text = Properties.Resources.ApplicationMenu_SamplePackingListTemplate;
			m_rbtnSamplePackingListTemplate.KeyTip = Properties.Resources.ApplicationMenu_SamplePackingListTemplate_KeyTip;
			m_rbtnSamplePackingListTemplate.Click += SamplePackingListTemplate_Click;
			m_rbtnSampleShippingLabelTemplate.Text = Properties.Resources.ApplicationMenu_SampleShippingLabelTemplate;
			m_rbtnSampleShippingLabelTemplate.KeyTip = Properties.Resources.ApplicationMenu_SampleShippingLabelTemplate_KeyTip;
			m_rbtnSampleShippingLabelTemplate.Click += SampleShippingLabelTemplate_Click;
		}

		
		/*-------------------------------------------------------------------------------------------------------------
        ** RibbonReportingTab
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** AddSampleDatabaseButton Method
        ** Creates a ribbon button that loads the sampled database when clicked. That button is added to the drop 
        ** down menu of the 'Select Data Source' button.
        **-----------------------------------------------------------------------------------------------------------*/
		private void AddSampleDatabaseButton() {
			// Create the ribbon button
			m_rbtnSampleDatabaseButton = new RibbonButton() {
				Text = Properties.Resources.RibbonReportingTab_LoadSampleDatabase,
				SmallIcon = GetSmallIcon("TXTextControl.Words.Images.SampleDatabase_Small.svg"),
				DisplayMode = IconTextRelation.SmallIconLabeled,
			};

			// Add tool tips
			m_rbtnSampleDatabaseButton.ToolTip.Title = Properties.Resources.RibbonReportingTab_LoadSampleDatabase_ToolTip_Title;
			m_rbtnSampleDatabaseButton.ToolTip.Description = Properties.Resources.RibbonReportingTab_LoadSampleDatabase_ToolTip_Description;

			// Add the handler that loads the sampled database when clicked
			m_rbtnSampleDatabaseButton.Click += SampleDatabaseButton_Click;

			// Add the ribbon button to the drop down menu of the 'Select Data Source' button.
			RibbonSplitButton rsbtnSelectDataSource = m_rtRibbonReportingTab.FindItem(RibbonReportingTab.RibbonItem.TXITEM_DataSource) as RibbonSplitButton;
			rsbtnSelectDataSource.DropDownItems.Insert(4, m_rbtnSampleDatabaseButton);
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** AddMergeGroup Method
        ** Creates a ribbon group with a ribbon button that starts merging files and switches to the 'Result' tab when 
        ** clicked.
        **
        ** Parameters:
        **      ribbonTab:   The ribbon tab where to add the created ribbon group.
        **-----------------------------------------------------------------------------------------------------------*/
		private void AddMergeGroup(RibbonReportingTab ribbonTab) {
			// Create the icons for the ribbon group and ribbon button.
			Bitmap bmpSmallIcon = GetSmallIcon("TXTextControl.Words.Images.MergeAndExport_Small.svg");
			Bitmap bmpLargeIcon = GetLargeIcon("TXTextControl.Words.Images.MergeAndExport_Large.svg");

			// Set ribbon group design
			SetReportingGroupDesign(null, m_rgMerge, "Merge");
			m_rgMerge.SmallIcon = bmpSmallIcon;
			m_rgMerge.LargeIcon = bmpLargeIcon;

			// Add a ribbon button that starts merging files and switches to the 'Result' tab when clicked.
			AddMergeAndExportButton(m_rgMerge, bmpSmallIcon, bmpLargeIcon);

			// Add the ribbon group to the ribbon tab
			ribbonTab.RibbonGroups.Add(m_rgMerge);

			// The group's enabled state depends on the IsMergingPossible property value of the 
			// RibbonReportingTab's DataSourceManager 
			m_rgMerge.Enabled = m_rtRibbonReportingTab.DataSourceManager.IsMergingPossible;
			m_rtRibbonReportingTab.DataSourceManager.IsMergingPossibleChanged += DataSourceManager_IsMergingPossibleChanged;
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** AddMergeAndExportButton Method
        ** Creates a ribbon button that starts merging files and switches to the 'Result' tab when clicked. That 
        ** ribbon button is added to the specified ribbon group. 
        **
        ** Parameters:
        **      ribbonGroup:    The ribbon group where to add the created ribbon button.
        **      smallIcon:      The bitmap that is used as the ribbon button's small icon.
        **      largeIcon:      The bitmap that is used as the ribbon button's large icon.
        **-----------------------------------------------------------------------------------------------------------*/
		private void AddMergeAndExportButton(RibbonGroup ribbonGroup, Bitmap smallIcon, Bitmap largeIcon) {

			// Create the ribbon button
			m_rbtnMergeAndExport = new RibbonButton() {
				Text = Properties.Resources.MergeAndExport,
				SmallIcon = smallIcon,
				LargeIcon = largeIcon,
				KeyTip = Properties.Resources.MergeAndExport_KeyTip
			};

			// Add tool tips
			m_rbtnMergeAndExport.ToolTip.Title = Properties.Resources.MergeAndExport_ToolTip_Title;
			m_rbtnMergeAndExport.ToolTip.Description = Properties.Resources.MergeAndExport_ToolTip_Description;

			// Add the handler that starts merging files and switches to the 'Result' tab when clicked.
			m_rbtnMergeAndExport.Click += MergeAndExport_Click;

			// Add the ribbon button to the ribbon group
			ribbonGroup.RibbonItems.Add(m_rbtnMergeAndExport);
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** 'Reporting' ContextualTabGroup and 'Result' RibbonTab
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** SetMergeResultsTabDesign Method
		** Creates groups and sets the design of the reporting 'Result' tab.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SetMergeResultsTabDesign() {
			// Set the header texts of the  'Result' contextual tab group and ribbon tab.
			m_ctgReportingResult.Header = Properties.Resources.ContextualTabGroup_Reporting;
			m_rtMergeResultsTab.Text = Properties.Resources.MergeResultsTab;
			// Set the key tip of the 'Result' ribbon tab.
			m_rtMergeResultsTab.KeyTip = Properties.Resources.MergeResultsTab_KeyTip;

			// Create the 'Result', 'Navigate' and 'Export' groups.
			CreateResultGroup();
			CreateNavigateGroup();
			CreateExportGroup();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** CreateResultGroup Method
		** Creates the reporting 'Result' tab's 'Result' group.
		**-----------------------------------------------------------------------------------------------------------*/
		private void CreateResultGroup() {
			// Set the design of the 'Result' group and the "Exit" button.
			SetReportingGroupDesign(ResourceProvider.FileMenuItem.TXITEM_Exit.ToString(), m_rgMergeResultsTab_ResultGroup, "MergeResultsTab_Result");
			SetReportingButtonDesign(ResourceProvider.FileMenuItem.TXITEM_Exit.ToString(), m_rbtnExitMergeResultsTab, "MergeResultsTab_Exit");

			// Add a handler to the "Exit" button that closes the 'Result' tab when the button is clicked.
			m_rbtnExitMergeResultsTab.Click += ExitResultTab_Click;

			// Add the "Exit" button to the 'Result' tab's 'Result' group.
			m_rgMergeResultsTab_ResultGroup.RibbonItems.Add(m_rbtnExitMergeResultsTab);

			// Add the 'Result' group to the reporting 'Result' tab.
			m_rtMergeResultsTab.RibbonGroups.Add(m_rgMergeResultsTab_ResultGroup);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** CreateNavigateGroup Method
		** Creates the reporting 'Result' tab's "Navigate" group.
		**-----------------------------------------------------------------------------------------------------------*/
		private void CreateNavigateGroup() {
			// Set the design of the "Navigate" group and the navigate buttons.
			SetReportingGroupDesign(ResourceProvider.GeneralItem.TXITEM_NavigateToNext.ToString(), m_rgNavigateGroup, "MergeResultsTab_Navigate");
			SetReportingButtonDesign(ResourceProvider.GeneralItem.TXITEM_NavigateToFirst.ToString(), m_rbtnFirstRecord, "MergeResultsTab_FirstRecord");
			SetReportingButtonDesign(ResourceProvider.GeneralItem.TXITEM_NavigateToPrevious.ToString(), m_rbtnPreviousRecord, "MergeResultsTab_PreviousRecord");
			SetReportingButtonDesign(ResourceProvider.GeneralItem.TXITEM_NavigateToNext.ToString(), m_rbtnNextRecord, "MergeResultsTab_NextRecord");
			SetReportingButtonDesign(ResourceProvider.GeneralItem.TXITEM_NavigateToLast.ToString(), m_rbtnLastRecord, "MergeResultsTab_LastRecord");

			// Add the handlers to the navigate buttons to load the specified record when the button is clicked.
			m_rbtnFirstRecord.Click += FirstRecord_Click;
			m_rbtnPreviousRecord.Click += PreviousRecord_Click;
			m_rbtnNextRecord.Click += NextRecord_Click;
			m_rbtnLastRecord.Click += LastRecord_Click;

			// Add the navigate buttons to the 'Result' tab's "Navigate" group.
			m_rgNavigateGroup.RibbonItems.AddRange(new RibbonButton[] { m_rbtnFirstRecord, m_rbtnPreviousRecord, m_rbtnNextRecord, m_rbtnLastRecord });

			// Add the "Navigate" group to the reporting 'Result' tab.
			m_rtMergeResultsTab.RibbonGroups.Add(m_rgNavigateGroup);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** CreateExportGroup Method
		** Creates the reporting 'Result' tab's "Export" group.
		**-----------------------------------------------------------------------------------------------------------*/
		private void CreateExportGroup() {
			// Create the icons for the ribbon group and ribbon button.
			Bitmap bmpSmallIcon = GetSmallIcon("TXTextControl.Words.Images.MergeAndExport_Small.svg");
			Bitmap bmpLargeIcon = GetLargeIcon("TXTextControl.Words.Images.MergeAndExport_Large.svg");

			// Set ribbon group design
			SetReportingGroupDesign(null, m_rgExportGroup, "MergeResultsTab_Export");
			m_rgExportGroup.SmallIcon = bmpSmallIcon;
			m_rgExportGroup.LargeIcon = bmpLargeIcon;

			// Add a ribbon button that opens a dialog to export the merge result.
			AddExportMergeResultButton(m_rgExportGroup, bmpSmallIcon, bmpLargeIcon);

			// Add the ribbon group to the ribbon tab
			m_rtMergeResultsTab.RibbonGroups.Add(m_rgExportGroup);
		}

		/*-------------------------------------------------------------------------------------------------------
		** SetReportingGroupDesign Method
		** Sets the icons, text, key tip and settings for a specific RibbonGroup.
		**
		** Parameters:
		**      identifier:		The id that is used as name and to identify the corresponding icons.
		**      ribbonGroup:	The ribbon group to update.
		**      resourceID:     The resource id that is used to identify the correponding text and key tip.
		**-----------------------------------------------------------------------------------------------------*/
		private void SetReportingGroupDesign(string identifier, RibbonGroup ribbonGroup, string resourceID) {
			// Set icons and the name of the ribbon group
			ribbonGroup.Name = identifier;
			if (!string.IsNullOrEmpty(identifier)) {
				ribbonGroup.SmallIcon = ResourceProvider.GetSmallIcon(identifier, m_fDPI);
				ribbonGroup.LargeIcon = ResourceProvider.GetLargeIcon(identifier, m_fDPI);
			}

			// Set some group settings.
			ribbonGroup.IsAddToQuickAccessToolbarEnabled = false;
			ribbonGroup.DialogBoxLauncher.Visible = false;
			ribbonGroup.HorizontalContentAlignment = HorizontalAlignment.Center;

			// Set the ribbon group's text and key tip.
			ribbonGroup.Text = m_rmResources.GetString(resourceID);
			ribbonGroup.KeyTip = m_rmResources.GetString(resourceID + "_KeyTip");
		}

		/*-------------------------------------------------------------------------------------------------------------
		** AddExportMergeResultButton Method
		** Creates a ribbon button that opens a dialog to export the merge result when clicked. That 
		** ribbon button is added to the specified ribbon group. 
		**
		** Parameters:
		**      ribbonGroup:    The ribbon group where to add the created ribbon button.
		**      smallIcon:      The bitmap that is used as the ribbon button's small icon.
		**      largeIcon:      The bitmap that is used as the ribbon button's large icon.
		**-----------------------------------------------------------------------------------------------------------*/
		private void AddExportMergeResultButton(RibbonGroup ribbonGroup, Bitmap smallIcon, Bitmap largeIcon) {

			// Create the ribbon button
			m_rbtnExportMergeResult = new RibbonButton() {
				Text = Properties.Resources.ExportMergeResult,
				SmallIcon = smallIcon,
				LargeIcon = largeIcon,
				KeyTip = Properties.Resources.ExportMergeResult_KeyTip
			};

			// Add tool tips
			m_rbtnExportMergeResult.ToolTip.Title = Properties.Resources.ExportMergeResult_ToolTip_Title;
			m_rbtnExportMergeResult.ToolTip.Description = Properties.Resources.ExportMergeResult_ToolTip_Description;

			// Add the handler that opens a dialog to export the merge result.
			m_rbtnExportMergeResult.Click += ExportMergeResult_Click;

			// Add the ribbon button to the ribbon group
			ribbonGroup.RibbonItems.Add(m_rbtnExportMergeResult);
		}

		/*-------------------------------------------------------------------------------------------------------
		** SetReportingButtonDesign Method
		** Sets the icons, text, key tip and tool tip for a specific RibbonButton.
		**
		** Parameters:
		**      iconID:			The id that is used as name and to identify the corresponding icons.
		**      ribbonGroup:	The ribbon button to update.
		**      resourceID:     The resource id that is used to identify the correponding text, key tip and 
		**						tool tip
		**-----------------------------------------------------------------------------------------------------*/
		private void SetReportingButtonDesign(string identifier, RibbonButton ribbonButton, string resourceID) {
			// Set icons and the name of the ribbon button
			ribbonButton.Name = identifier;
			ribbonButton.SmallIcon = ResourceProvider.GetSmallIcon(identifier, m_fDPI);
			ribbonButton.LargeIcon = ResourceProvider.GetLargeIcon(identifier, m_fDPI);

			// Set the ribbon button's text, key tip and tool tip.
			ribbonButton.Text = m_rmResources.GetString(resourceID);
			ribbonButton.KeyTip = m_rmResources.GetString(resourceID + "_KeyTip");
			ribbonButton.ToolTip.Title = m_rmResources.GetString(resourceID + "_ToolTip_Title");
			ribbonButton.ToolTip.Description = m_rmResources.GetString(resourceID + "_ToolTip_Description");

			// Add the button to the list of custom ribbon buttons that are updated when the application's
			m_lstCustomRibbonButtons.Add(ribbonButton);
		}
	}
}
