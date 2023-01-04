
namespace TXTextControl.Words {
	partial class MainWindow {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.m_txTextControl = new TXTextControl.TextControl();
			this.m_rbnRibbon = new TXTextControl.Windows.Forms.Ribbon.Ribbon();
			this.m_rlblRecentFiles = new TXTextControl.Windows.Forms.Ribbon.RibbonLabel();
			this.m_rsepSeparator2 = new TXTextControl.Windows.Forms.Ribbon.RibbonSeperator();
			this.m_rbtnNew = new TXTextControl.Windows.Forms.Ribbon.RibbonButton();
			this.m_rbtnOpen = new TXTextControl.Windows.Forms.Ribbon.RibbonButton();
			this.m_rbtnSave = new TXTextControl.Windows.Forms.Ribbon.RibbonButton();
			this.m_rbtnSaveAs = new TXTextControl.Windows.Forms.Ribbon.RibbonButton();
			this.m_rsbtnPrint = new TXTextControl.Windows.Forms.Ribbon.RibbonSplitButton();
			this.m_rbtnPrint = new TXTextControl.Windows.Forms.Ribbon.RibbonButton();
			this.m_rbtnPrintQuick = new TXTextControl.Windows.Forms.Ribbon.RibbonButton();
			this.m_rbtnPrintPreview = new TXTextControl.Windows.Forms.Ribbon.RibbonButton();
			this.m_rtbtnAbout = new TXTextControl.Windows.Forms.Ribbon.RibbonToggleButton();
			this.m_ctgTableTools = new TXTextControl.Windows.Forms.Ribbon.ContextualTabGroup();
			this.m_rtRibbonTableLayoutTab = new TXTextControl.Windows.Forms.Ribbon.RibbonTableLayoutTab();
			this.m_rtRibbonFormulaTab = new TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab();
			this.m_ctgFrameTools = new TXTextControl.Windows.Forms.Ribbon.ContextualTabGroup();
			this.m_rtRibbonFrameLayoutTab = new TXTextControl.Windows.Forms.Ribbon.RibbonFrameLayoutTab();
			this.m_rtRibbonChartLayoutTab = new TXTextControl.Windows.Forms.Ribbon.RibbonChartLayoutTab();
			this.m_rtRibbonFormattingTab = new TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab();
			this.m_sbSidebarBottom = new TXTextControl.Windows.Forms.Sidebar();
			this.m_sbSidebarRight = new TXTextControl.Windows.Forms.Sidebar();
			this.m_rtRibbonInsertTab = new TXTextControl.Windows.Forms.Ribbon.RibbonInsertTab();
			this.m_rtRibbonPermissionsTab = new TXTextControl.Windows.Forms.Ribbon.RibbonPermissionsTab();
			this.m_rtRibbonFormFieldsTab = new TXTextControl.Windows.Forms.Ribbon.RibbonFormFieldsTab();
			this.m_rbHorizontalRulerBar = new TXTextControl.RulerBar();
			this.m_sbStatusBar = new TXTextControl.StatusBar();
			this.m_rbVerticalRulerBar = new TXTextControl.RulerBar();
			this.m_sbSidebarLeft = new TXTextControl.Windows.Forms.Sidebar();
			this.m_rbnRibbon.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_txTextControl
			// 
			this.m_txTextControl.AllowDrag = true;
			this.m_txTextControl.AllowDrop = true;
			this.m_txTextControl.DisplayColors.FormFieldColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_txTextControl.Font = new System.Drawing.Font("Arial", 10F);
			this.m_txTextControl.FormattingPrinter = "Standard";
			this.m_txTextControl.HideSelection = false;
			this.m_txTextControl.IsFormFieldValidationEnabled = true;
			this.m_txTextControl.Location = new System.Drawing.Point(333, 174);
			this.m_txTextControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.m_txTextControl.Name = "m_txTextControl";
			this.m_txTextControl.PageMargins.Bottom = 78.75D;
			this.m_txTextControl.PageMargins.Left = 78.75D;
			this.m_txTextControl.PageMargins.Right = 78.75D;
			this.m_txTextControl.PageMargins.Top = 78.75D;
			this.m_txTextControl.PageSize.Height = 1169.31D;
			this.m_txTextControl.PageSize.Width = 826.81D;
			this.m_txTextControl.Ribbon = this.m_rbnRibbon;
			this.m_txTextControl.RulerBar = this.m_rbHorizontalRulerBar;
			this.m_txTextControl.Size = new System.Drawing.Size(601, 628);
			this.m_txTextControl.StatusBar = this.m_sbStatusBar;
			this.m_txTextControl.TabIndex = 1;
			this.m_txTextControl.UserNames = null;
			this.m_txTextControl.VerticalRulerBar = this.m_rbVerticalRulerBar;
			// 
			// m_rbnRibbon
			// 
			this.m_rbnRibbon.ApplicationMenuHelpPaneItems.AddRange(new System.Windows.Forms.Control[] {
            this.m_rlblRecentFiles,
            this.m_rsepSeparator2});
			this.m_rbnRibbon.ApplicationMenuItems.AddRange(new System.Windows.Forms.Control[] {
            this.m_rbtnNew,
            this.m_rbtnOpen,
            this.m_rbtnSave,
            this.m_rbtnSaveAs,
            this.m_rsbtnPrint,
            this.m_rtbtnAbout});
			this.m_rbnRibbon.ContextualTabGroups.Add(this.m_ctgTableTools);
			this.m_rbnRibbon.ContextualTabGroups.Add(this.m_ctgFrameTools);
			this.m_rbnRibbon.Controls.Add(this.m_rtRibbonFormattingTab);
			this.m_rbnRibbon.Controls.Add(this.m_rtRibbonInsertTab);
			this.m_rbnRibbon.Controls.Add(this.m_rtRibbonPermissionsTab);
			this.m_rbnRibbon.Controls.Add(this.m_rtRibbonFormFieldsTab);
			this.m_rbnRibbon.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rbnRibbon.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_rbnRibbon.HotTrack = true;
			this.m_rbnRibbon.Location = new System.Drawing.Point(0, 31);
			this.m_rbnRibbon.Name = "m_rbnRibbon";
			this.m_rbnRibbon.SelectedIndex = 1;
			this.m_rbnRibbon.Size = new System.Drawing.Size(1234, 118);
			this.m_rbnRibbon.TabIndex = 2;
			this.m_rbnRibbon.Text = "ribbon1";
			// 
			// m_rlblRecentFiles
			// 
			this.m_rlblRecentFiles.BackColor = System.Drawing.Color.Transparent;
			this.m_rlblRecentFiles.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rlblRecentFiles.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_rlblRecentFiles.Location = new System.Drawing.Point(0, 0);
			this.m_rlblRecentFiles.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
			this.m_rlblRecentFiles.Name = "m_rlblRecentFiles";
			this.m_rlblRecentFiles.Size = new System.Drawing.Size(191, 24);
			this.m_rlblRecentFiles.TabIndex = 0;
			this.m_rlblRecentFiles.TabStop = false;
			this.m_rlblRecentFiles.Text = "ribbonLabel1";
			// 
			// m_rsepSeparator2
			// 
			this.m_rsepSeparator2.BackColor = System.Drawing.Color.Transparent;
			this.m_rsepSeparator2.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rsepSeparator2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_rsepSeparator2.Location = new System.Drawing.Point(0, 24);
			this.m_rsepSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
			this.m_rsepSeparator2.Name = "m_rsepSeparator2";
			this.m_rsepSeparator2.Size = new System.Drawing.Size(191, 5);
			this.m_rsepSeparator2.TabIndex = 0;
			this.m_rsepSeparator2.TabStop = false;
			this.m_rsepSeparator2.Text = "ribbonSeperator2";
			// 
			// m_rbtnNew
			// 
			this.m_rbtnNew.BackColor = System.Drawing.Color.Transparent;
			this.m_rbtnNew.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rbtnNew.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_rbtnNew.KeyTip = "";
			this.m_rbtnNew.Location = new System.Drawing.Point(0, 0);
			this.m_rbtnNew.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
			this.m_rbtnNew.Name = "m_rbtnNew";
			this.m_rbtnNew.Size = new System.Drawing.Size(191, 38);
			this.m_rbtnNew.TabIndex = 0;
			this.m_rbtnNew.Text = "New";
			// 
			// m_rbtnOpen
			// 
			this.m_rbtnOpen.BackColor = System.Drawing.Color.Transparent;
			this.m_rbtnOpen.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rbtnOpen.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_rbtnOpen.KeyTip = "";
			this.m_rbtnOpen.Location = new System.Drawing.Point(0, 38);
			this.m_rbtnOpen.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
			this.m_rbtnOpen.Name = "m_rbtnOpen";
			this.m_rbtnOpen.Size = new System.Drawing.Size(191, 38);
			this.m_rbtnOpen.TabIndex = 0;
			this.m_rbtnOpen.Text = "Open...";
			// 
			// m_rbtnSave
			// 
			this.m_rbtnSave.BackColor = System.Drawing.Color.Transparent;
			this.m_rbtnSave.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rbtnSave.Enabled = false;
			this.m_rbtnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_rbtnSave.KeyTip = "";
			this.m_rbtnSave.Location = new System.Drawing.Point(0, 76);
			this.m_rbtnSave.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
			this.m_rbtnSave.Name = "m_rbtnSave";
			this.m_rbtnSave.Size = new System.Drawing.Size(191, 38);
			this.m_rbtnSave.TabIndex = 0;
			this.m_rbtnSave.Text = "Save";
			// 
			// m_rbtnSaveAs
			// 
			this.m_rbtnSaveAs.BackColor = System.Drawing.Color.Transparent;
			this.m_rbtnSaveAs.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rbtnSaveAs.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_rbtnSaveAs.KeyTip = "";
			this.m_rbtnSaveAs.Location = new System.Drawing.Point(0, 114);
			this.m_rbtnSaveAs.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
			this.m_rbtnSaveAs.Name = "m_rbtnSaveAs";
			this.m_rbtnSaveAs.Size = new System.Drawing.Size(191, 38);
			this.m_rbtnSaveAs.TabIndex = 0;
			this.m_rbtnSaveAs.Text = "Save As...";
			// 
			// m_rsbtnPrint
			// 
			this.m_rsbtnPrint.BackColor = System.Drawing.Color.Transparent;
			this.m_rsbtnPrint.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rsbtnPrint.DropDownItems.AddRange(new System.Windows.Forms.Control[] {
            this.m_rbtnPrint,
            this.m_rbtnPrintQuick,
            this.m_rbtnPrintPreview});
			this.m_rsbtnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_rsbtnPrint.KeyTip = "";
			this.m_rsbtnPrint.Location = new System.Drawing.Point(0, 152);
			this.m_rsbtnPrint.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
			this.m_rsbtnPrint.Name = "m_rsbtnPrint";
			this.m_rsbtnPrint.Size = new System.Drawing.Size(191, 38);
			this.m_rsbtnPrint.TabIndex = 0;
			this.m_rsbtnPrint.Text = "Print...";
			// 
			// m_rbtnPrint
			// 
			this.m_rbtnPrint.BackColor = System.Drawing.Color.Transparent;
			this.m_rbtnPrint.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rbtnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_rbtnPrint.KeyTip = "";
			this.m_rbtnPrint.Location = new System.Drawing.Point(0, 0);
			this.m_rbtnPrint.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
			this.m_rbtnPrint.Name = "m_rbtnPrint";
			this.m_rbtnPrint.Size = new System.Drawing.Size(128, 38);
			this.m_rbtnPrint.TabIndex = 0;
			this.m_rbtnPrint.Text = "ribbonButton1";
			// 
			// m_rbtnPrintQuick
			// 
			this.m_rbtnPrintQuick.BackColor = System.Drawing.Color.Transparent;
			this.m_rbtnPrintQuick.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rbtnPrintQuick.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_rbtnPrintQuick.KeyTip = "";
			this.m_rbtnPrintQuick.Location = new System.Drawing.Point(0, 0);
			this.m_rbtnPrintQuick.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
			this.m_rbtnPrintQuick.Name = "m_rbtnPrintQuick";
			this.m_rbtnPrintQuick.Size = new System.Drawing.Size(128, 38);
			this.m_rbtnPrintQuick.TabIndex = 0;
			this.m_rbtnPrintQuick.Text = "ribbonButton2";
			// 
			// m_rbtnPrintPreview
			// 
			this.m_rbtnPrintPreview.BackColor = System.Drawing.Color.Transparent;
			this.m_rbtnPrintPreview.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rbtnPrintPreview.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_rbtnPrintPreview.KeyTip = "";
			this.m_rbtnPrintPreview.Location = new System.Drawing.Point(0, 0);
			this.m_rbtnPrintPreview.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
			this.m_rbtnPrintPreview.Name = "m_rbtnPrintPreview";
			this.m_rbtnPrintPreview.Size = new System.Drawing.Size(128, 38);
			this.m_rbtnPrintPreview.TabIndex = 0;
			this.m_rbtnPrintPreview.Text = "ribbonButton3";
			// 
			// m_rtbtnAbout
			// 
			this.m_rtbtnAbout.BackColor = System.Drawing.Color.Transparent;
			this.m_rtbtnAbout.Checked = true;
			this.m_rtbtnAbout.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rtbtnAbout.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_rtbtnAbout.KeyTip = "";
			this.m_rtbtnAbout.Location = new System.Drawing.Point(0, 0);
			this.m_rtbtnAbout.Name = "m_rtbtnAbout";
			this.m_rtbtnAbout.Size = new System.Drawing.Size(0, 0);
			this.m_rtbtnAbout.TabIndex = 0;
			this.m_rtbtnAbout.Text = "ribbonToggleButton1";
			// 
			// m_ctgTableTools
			// 
			this.m_ctgTableTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.m_ctgTableTools.ContextualTabs.Add(this.m_rtRibbonTableLayoutTab);
			this.m_ctgTableTools.ContextualTabs.Add(this.m_rtRibbonFormulaTab);
			this.m_ctgTableTools.Name = "m_ctgTableTools";
			// 
			// m_rtRibbonTableLayoutTab
			// 
			this.m_rtRibbonTableLayoutTab.Location = new System.Drawing.Point(0, 0);
			this.m_rtRibbonTableLayoutTab.Name = "m_rtRibbonTableLayoutTab";
			this.m_rtRibbonTableLayoutTab.Size = new System.Drawing.Size(200, 40);
			this.m_rtRibbonTableLayoutTab.TabIndex = 0;
			// 
			// m_rtRibbonFormulaTab
			// 
			this.m_rtRibbonFormulaTab.Location = new System.Drawing.Point(0, 0);
			this.m_rtRibbonFormulaTab.Name = "m_rtRibbonFormulaTab";
			this.m_rtRibbonFormulaTab.Size = new System.Drawing.Size(200, 40);
			this.m_rtRibbonFormulaTab.TabIndex = 0;
			// 
			// m_ctgFrameTools
			// 
			this.m_ctgFrameTools.BackColor = System.Drawing.Color.LightGray;
			this.m_ctgFrameTools.ContextualTabs.Add(this.m_rtRibbonFrameLayoutTab);
			this.m_ctgFrameTools.ContextualTabs.Add(this.m_rtRibbonChartLayoutTab);
			this.m_ctgFrameTools.Name = "m_ctgChartTools";
			// 
			// m_rtRibbonFrameLayoutTab
			// 
			this.m_rtRibbonFrameLayoutTab.Location = new System.Drawing.Point(0, 0);
			this.m_rtRibbonFrameLayoutTab.Name = "m_rtRibbonFrameLayoutTab";
			this.m_rtRibbonFrameLayoutTab.Size = new System.Drawing.Size(200, 40);
			this.m_rtRibbonFrameLayoutTab.TabIndex = 0;
			// 
			// m_rtRibbonChartLayoutTab
			// 
			this.m_rtRibbonChartLayoutTab.Location = new System.Drawing.Point(0, 0);
			this.m_rtRibbonChartLayoutTab.Name = "m_rtRibbonChartLayoutTab";
			this.m_rtRibbonChartLayoutTab.Size = new System.Drawing.Size(200, 40);
			this.m_rtRibbonChartLayoutTab.TabIndex = 0;
			// 
			// m_rtRibbonFormattingTab
			// 
			this.m_rtRibbonFormattingTab.FindHorizontalSidebar = this.m_sbSidebarBottom;
			this.m_rtRibbonFormattingTab.FindSidebar = this.m_sbSidebarRight;
			this.m_rtRibbonFormattingTab.GotoHorizontalSidebar = this.m_sbSidebarBottom;
			this.m_rtRibbonFormattingTab.Location = new System.Drawing.Point(4, 24);
			this.m_rtRibbonFormattingTab.Name = "m_rtRibbonFormattingTab";
			this.m_rtRibbonFormattingTab.ReplaceHorizontalSidebar = this.m_sbSidebarBottom;
			this.m_rtRibbonFormattingTab.ReplaceSidebar = this.m_sbSidebarRight;
			this.m_rtRibbonFormattingTab.Size = new System.Drawing.Size(1226, 90);
			this.m_rtRibbonFormattingTab.StylesSidebar = this.m_sbSidebarRight;
			this.m_rtRibbonFormattingTab.TabIndex = 1;
			// 
			// m_sbSidebarBottom
			// 
			this.m_sbSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_sbSidebarBottom.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_sbSidebarBottom.IsShown = false;
			this.m_sbSidebarBottom.Location = new System.Drawing.Point(308, 802);
			this.m_sbSidebarBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.m_sbSidebarBottom.Name = "m_sbSidebarBottom";
			this.m_sbSidebarBottom.Padding = new System.Windows.Forms.Padding(6);
			this.m_sbSidebarBottom.ShowTitle = false;
			this.m_sbSidebarBottom.Size = new System.Drawing.Size(626, 18);
			this.m_sbSidebarBottom.TabIndex = 6;
			this.m_sbSidebarBottom.Text = "m_sbHorizontalSidebar";
			this.m_sbSidebarBottom.TextControl = this.m_txTextControl;
			// 
			// m_sbSidebarRight
			// 
			this.m_sbSidebarRight.ContentLayout = TXTextControl.Windows.Forms.Sidebar.SidebarContentLayout.ConditionalInstructions;
			this.m_sbSidebarRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.m_sbSidebarRight.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_sbSidebarRight.Location = new System.Drawing.Point(934, 149);
			this.m_sbSidebarRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.m_sbSidebarRight.Name = "m_sbSidebarRight";
			this.m_sbSidebarRight.Padding = new System.Windows.Forms.Padding(6);
			this.m_sbSidebarRight.Size = new System.Drawing.Size(300, 671);
			this.m_sbSidebarRight.TabIndex = 8;
			this.m_sbSidebarRight.TextControl = this.m_txTextControl;
			// 
			// m_rtRibbonInsertTab
			// 
			this.m_rtRibbonInsertTab.Location = new System.Drawing.Point(4, 24);
			this.m_rtRibbonInsertTab.Name = "m_rtRibbonInsertTab";
			this.m_rtRibbonInsertTab.Size = new System.Drawing.Size(1226, 90);
			this.m_rtRibbonInsertTab.TabIndex = 2;
			// 
			// m_rtRibbonPermissionsTab
			// 
			this.m_rtRibbonPermissionsTab.AllowAddingUserNames = true;
			this.m_rtRibbonPermissionsTab.Location = new System.Drawing.Point(4, 24);
			this.m_rtRibbonPermissionsTab.Name = "m_rtRibbonPermissionsTab";
			this.m_rtRibbonPermissionsTab.RegisteredUserNames = new string[0];
			this.m_rtRibbonPermissionsTab.Size = new System.Drawing.Size(1226, 90);
			this.m_rtRibbonPermissionsTab.TabIndex = 7;
			// 
			// m_rtRibbonFormFieldsTab
			// 
			this.m_rtRibbonFormFieldsTab.ConditionalInstructionsSidebar = this.m_sbSidebarRight;
			this.m_rtRibbonFormFieldsTab.Location = new System.Drawing.Point(4, 24);
			this.m_rtRibbonFormFieldsTab.Name = "m_rtRibbonFormFieldsTab";
			this.m_rtRibbonFormFieldsTab.Size = new System.Drawing.Size(1226, 90);
			this.m_rtRibbonFormFieldsTab.TabIndex = 8;
			// 
			// m_rbHorizontalRulerBar
			// 
			this.m_rbHorizontalRulerBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rbHorizontalRulerBar.Location = new System.Drawing.Point(308, 149);
			this.m_rbHorizontalRulerBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.m_rbHorizontalRulerBar.Name = "m_rbHorizontalRulerBar";
			this.m_rbHorizontalRulerBar.Size = new System.Drawing.Size(626, 25);
			this.m_rbHorizontalRulerBar.TabIndex = 5;
			this.m_rbHorizontalRulerBar.Text = "rulerBar2";
			// 
			// m_sbStatusBar
			// 
			this.m_sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			this.m_sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_sbStatusBar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_sbStatusBar.Location = new System.Drawing.Point(0, 820);
			this.m_sbStatusBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.m_sbStatusBar.Name = "m_sbStatusBar";
			this.m_sbStatusBar.Size = new System.Drawing.Size(1234, 22);
			this.m_sbStatusBar.TabIndex = 3;
			// 
			// m_rbVerticalRulerBar
			// 
			this.m_rbVerticalRulerBar.Alignment = TXTextControl.RulerBarAlignment.Left;
			this.m_rbVerticalRulerBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_rbVerticalRulerBar.Location = new System.Drawing.Point(308, 174);
			this.m_rbVerticalRulerBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.m_rbVerticalRulerBar.Name = "m_rbVerticalRulerBar";
			this.m_rbVerticalRulerBar.Size = new System.Drawing.Size(25, 628);
			this.m_rbVerticalRulerBar.TabIndex = 4;
			this.m_rbVerticalRulerBar.Text = "rulerBar1";
			// 
			// m_sbSidebarLeft
			// 
			this.m_sbSidebarLeft.ContentLayout = TXTextControl.Windows.Forms.Sidebar.SidebarContentLayout.About;
			this.m_sbSidebarLeft.DialogStyle = TXTextControl.Windows.Forms.Sidebar.SidebarDialogStyle.StandardSizable;
			this.m_sbSidebarLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_sbSidebarLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_sbSidebarLeft.Location = new System.Drawing.Point(0, 149);
			this.m_sbSidebarLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.m_sbSidebarLeft.Name = "m_sbSidebarLeft";
			this.m_sbSidebarLeft.Padding = new System.Windows.Forms.Padding(6);
			this.m_sbSidebarLeft.ShowPinButton = false;
			this.m_sbSidebarLeft.Size = new System.Drawing.Size(308, 671);
			this.m_sbSidebarLeft.TabIndex = 7;
			this.m_sbSidebarLeft.TextControl = this.m_txTextControl;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1234, 842);
			this.Controls.Add(this.m_txTextControl);
			this.Controls.Add(this.m_rbVerticalRulerBar);
			this.Controls.Add(this.m_rbHorizontalRulerBar);
			this.Controls.Add(this.m_sbSidebarBottom);
			this.Controls.Add(this.m_sbSidebarRight);
			this.Controls.Add(this.m_sbSidebarLeft);
			this.Controls.Add(this.m_sbStatusBar);
			this.Controls.Add(this.m_rbnRibbon);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TX Text Control Words";
			this.m_rbnRibbon.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TXTextControl.TextControl m_txTextControl;
		private TXTextControl.Windows.Forms.Ribbon.Ribbon m_rbnRibbon;
		private TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab m_rtRibbonFormattingTab;
		private TXTextControl.Windows.Forms.Sidebar m_sbSidebarBottom;
		private TXTextControl.Windows.Forms.Sidebar m_sbSidebarRight;
		private TXTextControl.Windows.Forms.Ribbon.RibbonInsertTab m_rtRibbonInsertTab;
		private TXTextControl.Windows.Forms.Sidebar m_sbSidebarLeft;
		private TXTextControl.Windows.Forms.Ribbon.RibbonPermissionsTab m_rtRibbonPermissionsTab;
		private TXTextControl.Windows.Forms.Ribbon.RibbonFormFieldsTab m_rtRibbonFormFieldsTab;
		private TXTextControl.RulerBar m_rbHorizontalRulerBar;
		private TXTextControl.StatusBar m_sbStatusBar;
		private TXTextControl.RulerBar m_rbVerticalRulerBar;
		private TXTextControl.Windows.Forms.Ribbon.RibbonButton m_rbtnNew;
		private TXTextControl.Windows.Forms.Ribbon.RibbonButton m_rbtnOpen;
		private TXTextControl.Windows.Forms.Ribbon.RibbonButton m_rbtnSave;
		private TXTextControl.Windows.Forms.Ribbon.RibbonButton m_rbtnSaveAs;
		private TXTextControl.Windows.Forms.Ribbon.RibbonSplitButton m_rsbtnPrint;
		private TXTextControl.Windows.Forms.Ribbon.RibbonButton m_rbtnPrint;
		private TXTextControl.Windows.Forms.Ribbon.RibbonButton m_rbtnPrintQuick;
		private TXTextControl.Windows.Forms.Ribbon.RibbonButton m_rbtnPrintPreview;
		private TXTextControl.Windows.Forms.Ribbon.ContextualTabGroup m_ctgTableTools;
		private TXTextControl.Windows.Forms.Ribbon.RibbonTableLayoutTab m_rtRibbonTableLayoutTab;
		private TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab m_rtRibbonFormulaTab;
		private TXTextControl.Windows.Forms.Ribbon.ContextualTabGroup m_ctgFrameTools;
		private TXTextControl.Windows.Forms.Ribbon.RibbonFrameLayoutTab m_rtRibbonFrameLayoutTab;
		private TXTextControl.Windows.Forms.Ribbon.RibbonChartLayoutTab m_rtRibbonChartLayoutTab;
		private TXTextControl.Windows.Forms.Ribbon.RibbonLabel m_rlblRecentFiles;
		private TXTextControl.Windows.Forms.Ribbon.RibbonSeperator m_rsepSeparator2;
		private Windows.Forms.Ribbon.RibbonToggleButton m_rtbtnAbout;
	}
}

