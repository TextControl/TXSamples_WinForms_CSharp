namespace MailMerge_Nested_Blocks {
	partial class Form1 {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.m_sepSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.m_tmiDatasource = new System.Windows.Forms.ToolStripDropDownButton();
			this.m_tmiLoadSampleDatasource = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiLoadXML = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tbxLoadedDatabaseFile = new System.Windows.Forms.ToolStripTextBox();
			this.m_lblLoadedDatabaseFile = new System.Windows.Forms.ToolStripLabel();
			this.m_sepSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.m_tmiCreateReport = new System.Windows.Forms.ToolStripButton();
			this.m_tsReporting = new System.Windows.Forms.ToolStrip();
			this.m_lblProgress = new System.Windows.Forms.ToolStripLabel();
			this.m_pbProgress = new System.Windows.Forms.ToolStripProgressBar();
			this.m_mmMailMerge = new TXTextControl.DocumentServer.MailMerge(this.components);
			this.m_txTextControl = new TXTextControl.TextControl();
			this.m_bbButtonBar = new TXTextControl.ButtonBar();
			this.m_rbHorizontalRuler = new TXTextControl.RulerBar();
			this.m_sbStatusBar = new TXTextControl.StatusBar();
			this.m_rbVerticalRuler = new TXTextControl.RulerBar();
			this.m_tsReporting.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_sepSeparator2
			// 
			this.m_sepSeparator2.Name = "m_sepSeparator2";
			this.m_sepSeparator2.Size = new System.Drawing.Size(6, 23);
			// 
			// m_tmiDatasource
			// 
			this.m_tmiDatasource.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.m_tmiDatasource.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiLoadSampleDatasource,
            this.m_tmiLoadXML});
			this.m_tmiDatasource.Margin = new System.Windows.Forms.Padding(0);
			this.m_tmiDatasource.Name = "m_tmiDatasource";
			this.m_tmiDatasource.Size = new System.Drawing.Size(79, 23);
			this.m_tmiDatasource.Text = "&Datasource";
			// 
			// m_tmiLoadSampleDatasource
			// 
			this.m_tmiLoadSampleDatasource.Name = "m_tmiLoadSampleDatasource";
			this.m_tmiLoadSampleDatasource.Size = new System.Drawing.Size(204, 22);
			this.m_tmiLoadSampleDatasource.Text = "Load &Sample Datasource";
			this.m_tmiLoadSampleDatasource.Click += new System.EventHandler(this.LoadSampleDatasource_Click);
			// 
			// m_tmiLoadXML
			// 
			this.m_tmiLoadXML.Name = "m_tmiLoadXML";
			this.m_tmiLoadXML.Size = new System.Drawing.Size(204, 22);
			this.m_tmiLoadXML.Text = "&Load XML...";
			this.m_tmiLoadXML.Click += new System.EventHandler(this.LoadXML_Click);
			// 
			// m_tbxLoadedDatabaseFile
			// 
			this.m_tbxLoadedDatabaseFile.AutoSize = false;
			this.m_tbxLoadedDatabaseFile.Enabled = false;
			this.m_tbxLoadedDatabaseFile.Margin = new System.Windows.Forms.Padding(11, 0, 5, 0);
			this.m_tbxLoadedDatabaseFile.Name = "m_tbxLoadedDatabaseFile";
			this.m_tbxLoadedDatabaseFile.Size = new System.Drawing.Size(150, 23);
			// 
			// m_lblLoadedDatabaseFile
			// 
			this.m_lblLoadedDatabaseFile.Margin = new System.Windows.Forms.Padding(11, 1, 0, 0);
			this.m_lblLoadedDatabaseFile.Name = "m_lblLoadedDatabaseFile";
			this.m_lblLoadedDatabaseFile.Size = new System.Drawing.Size(118, 22);
			this.m_lblLoadedDatabaseFile.Text = "Loaded database file:";
			// 
			// m_sepSeparator1
			// 
			this.m_sepSeparator1.Name = "m_sepSeparator1";
			this.m_sepSeparator1.Size = new System.Drawing.Size(6, 23);
			// 
			// m_tmiCreateReport
			// 
			this.m_tmiCreateReport.Enabled = false;
			this.m_tmiCreateReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.m_tmiCreateReport.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.m_tmiCreateReport.Name = "m_tmiCreateReport";
			this.m_tmiCreateReport.Size = new System.Drawing.Size(83, 23);
			this.m_tmiCreateReport.Text = "&Create Report";
			this.m_tmiCreateReport.Click += new System.EventHandler(this.CreateReport_Click);
			// 
			// m_tsReporting
			// 
			this.m_tsReporting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiDatasource,
            this.m_lblLoadedDatabaseFile,
            this.m_tbxLoadedDatabaseFile,
            this.m_sepSeparator1,
            this.m_tmiCreateReport,
            this.m_sepSeparator2,
            this.m_lblProgress,
            this.m_pbProgress});
			this.m_tsReporting.Location = new System.Drawing.Point(0, 0);
			this.m_tsReporting.Name = "m_tsReporting";
			this.m_tsReporting.Padding = new System.Windows.Forms.Padding(0, 3, 1, 3);
			this.m_tsReporting.Size = new System.Drawing.Size(800, 29);
			this.m_tsReporting.TabIndex = 8;
			this.m_tsReporting.Text = "toolStrip1";
			// 
			// m_lblProgress
			// 
			this.m_lblProgress.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.m_lblProgress.Name = "m_lblProgress";
			this.m_lblProgress.Size = new System.Drawing.Size(55, 23);
			this.m_lblProgress.Text = "Progress:";
			// 
			// m_pbProgress
			// 
			this.m_pbProgress.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
			this.m_pbProgress.Name = "m_pbProgress";
			this.m_pbProgress.Size = new System.Drawing.Size(100, 23);
			this.m_pbProgress.Step = 1;
			// 
			// m_mmMailMerge
			// 
			this.m_mmMailMerge.DataSourceCulture = new System.Globalization.CultureInfo("de-DE");
			this.m_mmMailMerge.DateFieldUtcOffset = null;
			this.m_mmMailMerge.MergeCulture = new System.Globalization.CultureInfo("de-DE");
			this.m_mmMailMerge.TextComponent = this.m_txTextControl;
			this.m_mmMailMerge.BlockRowMerged += new TXTextControl.DocumentServer.MailMerge.BlockRowMergedHandler(this.MailMerge_BlockRowMerged);
			// 
			// m_txTextControl
			// 
			this.m_txTextControl.ButtonBar = this.m_bbButtonBar;
			this.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_txTextControl.Font = new System.Drawing.Font("Arial", 10F);
			this.m_txTextControl.FormattingPrinter = "Standard";
			this.m_txTextControl.Location = new System.Drawing.Point(25, 83);
			this.m_txTextControl.Name = "m_txTextControl";
			this.m_txTextControl.RulerBar = this.m_rbHorizontalRuler;
			this.m_txTextControl.Size = new System.Drawing.Size(775, 345);
			this.m_txTextControl.StatusBar = this.m_sbStatusBar;
			this.m_txTextControl.TabIndex = 9;
			this.m_txTextControl.UserNames = null;
			this.m_txTextControl.VerticalRulerBar = this.m_rbVerticalRuler;
			// 
			// m_bbButtonBar
			// 
			this.m_bbButtonBar.BackColor = System.Drawing.SystemColors.Control;
			this.m_bbButtonBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_bbButtonBar.Location = new System.Drawing.Point(0, 29);
			this.m_bbButtonBar.Name = "m_bbButtonBar";
			this.m_bbButtonBar.Size = new System.Drawing.Size(800, 29);
			this.m_bbButtonBar.TabIndex = 10;
			this.m_bbButtonBar.Text = "buttonBar1";
			// 
			// m_rbHorizontalRuler
			// 
			this.m_rbHorizontalRuler.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rbHorizontalRuler.Location = new System.Drawing.Point(0, 58);
			this.m_rbHorizontalRuler.Name = "m_rbHorizontalRuler";
			this.m_rbHorizontalRuler.Size = new System.Drawing.Size(800, 25);
			this.m_rbHorizontalRuler.TabIndex = 13;
			this.m_rbHorizontalRuler.Text = "rulerBar2";
			// 
			// m_sbStatusBar
			// 
			this.m_sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			this.m_sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_sbStatusBar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_sbStatusBar.Location = new System.Drawing.Point(0, 428);
			this.m_sbStatusBar.Name = "m_sbStatusBar";
			this.m_sbStatusBar.Size = new System.Drawing.Size(800, 22);
			this.m_sbStatusBar.TabIndex = 11;
			// 
			// m_rbVerticalRuler
			// 
			this.m_rbVerticalRuler.Alignment = TXTextControl.RulerBarAlignment.Left;
			this.m_rbVerticalRuler.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_rbVerticalRuler.Location = new System.Drawing.Point(0, 83);
			this.m_rbVerticalRuler.Name = "m_rbVerticalRuler";
			this.m_rbVerticalRuler.Size = new System.Drawing.Size(25, 345);
			this.m_rbVerticalRuler.TabIndex = 12;
			this.m_rbVerticalRuler.Text = "rulerBar1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.m_txTextControl);
			this.Controls.Add(this.m_rbVerticalRuler);
			this.Controls.Add(this.m_rbHorizontalRuler);
			this.Controls.Add(this.m_bbButtonBar);
			this.Controls.Add(this.m_tsReporting);
			this.Controls.Add(this.m_sbStatusBar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Howto: Mail Merge - Sample: Mail Merge with Nested Repeating Blocks";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.m_tsReporting.ResumeLayout(false);
			this.m_tsReporting.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStripSeparator m_sepSeparator2;
		private System.Windows.Forms.ToolStripDropDownButton m_tmiDatasource;
		private System.Windows.Forms.ToolStripTextBox m_tbxLoadedDatabaseFile;
		private System.Windows.Forms.ToolStripLabel m_lblLoadedDatabaseFile;
		private System.Windows.Forms.ToolStripSeparator m_sepSeparator1;
		private System.Windows.Forms.ToolStripButton m_tmiCreateReport;
		private System.Windows.Forms.ToolStrip m_tsReporting;
		private System.Windows.Forms.ToolStripLabel m_lblProgress;
		private TXTextControl.DocumentServer.MailMerge m_mmMailMerge;
		private TXTextControl.TextControl m_txTextControl;
		private TXTextControl.ButtonBar m_bbButtonBar;
		private TXTextControl.RulerBar m_rbHorizontalRuler;
		private TXTextControl.StatusBar m_sbStatusBar;
		private TXTextControl.RulerBar m_rbVerticalRuler;
		private System.Windows.Forms.ToolStripMenuItem m_tmiLoadXML;
		private System.Windows.Forms.ToolStripMenuItem m_tmiLoadSampleDatasource;
		private System.Windows.Forms.ToolStripProgressBar m_pbProgress;
	}
}

