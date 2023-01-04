namespace Step2 {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.m_msMenu = new System.Windows.Forms.MenuStrip();
			this.m_tmiFile = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiNew = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiSampleTemplate = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiCharts = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiMerge = new System.Windows.Forms.ToolStripMenuItem();
			this.m_txTextControl = new TXTextControl.TextControl();
			this.m_btButtonBar = new TXTextControl.ButtonBar();
			this.m_rbHorizontalRuler = new TXTextControl.RulerBar();
			this.m_sbStatusBar = new TXTextControl.StatusBar();
			this.m_rbVerticalRuler = new TXTextControl.RulerBar();
			this.m_msMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_msMenu
			// 
			this.m_msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiFile,
            this.m_tmiCharts});
			this.m_msMenu.Location = new System.Drawing.Point(0, 0);
			this.m_msMenu.Name = "m_msMenu";
			this.m_msMenu.Size = new System.Drawing.Size(800, 24);
			this.m_msMenu.TabIndex = 0;
			this.m_msMenu.Text = "menuStrip1";
			// 
			// m_tmiFile
			// 
			this.m_tmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiNew,
            this.m_tmiOpen,
            this.m_tmiSampleTemplate,
            this.m_tmiSaveAs});
			this.m_tmiFile.Name = "m_tmiFile";
			this.m_tmiFile.Size = new System.Drawing.Size(37, 20);
			this.m_tmiFile.Text = "&File";
			// 
			// m_tmiNew
			// 
			this.m_tmiNew.Name = "m_tmiNew";
			this.m_tmiNew.Size = new System.Drawing.Size(193, 22);
			this.m_tmiNew.Text = "&New";
			this.m_tmiNew.Click += new System.EventHandler(this.New_Click);
			// 
			// m_tmiOpen
			// 
			this.m_tmiOpen.Name = "m_tmiOpen";
			this.m_tmiOpen.Size = new System.Drawing.Size(193, 22);
			this.m_tmiOpen.Text = "&Open...";
			this.m_tmiOpen.Click += new System.EventHandler(this.Open_Click);
			// 
			// m_tmiSampleTemplate
			// 
			this.m_tmiSampleTemplate.Name = "m_tmiSampleTemplate";
			this.m_tmiSampleTemplate.Size = new System.Drawing.Size(193, 22);
			this.m_tmiSampleTemplate.Text = "Load Sample &Template";
			this.m_tmiSampleTemplate.Click += new System.EventHandler(this.SampleTemplate_Click);
			// 
			// m_tmiSaveAs
			// 
			this.m_tmiSaveAs.Name = "m_tmiSaveAs";
			this.m_tmiSaveAs.Size = new System.Drawing.Size(193, 22);
			this.m_tmiSaveAs.Text = "&Save As...";
			this.m_tmiSaveAs.Click += new System.EventHandler(this.SaveAs_Click);
			// 
			// m_tmiCharts
			// 
			this.m_tmiCharts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiMerge});
			this.m_tmiCharts.Name = "m_tmiCharts";
			this.m_tmiCharts.Size = new System.Drawing.Size(53, 20);
			this.m_tmiCharts.Text = "&Charts";
			// 
			// m_tmiMerge
			// 
			this.m_tmiMerge.Name = "m_tmiMerge";
			this.m_tmiMerge.Size = new System.Drawing.Size(108, 22);
			this.m_tmiMerge.Text = "&Merge";
			this.m_tmiMerge.Click += new System.EventHandler(this.Merge_Click);
			// 
			// m_txTextControl
			// 
			this.m_txTextControl.ButtonBar = this.m_btButtonBar;
			this.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_txTextControl.Font = new System.Drawing.Font("Arial", 10F);
			this.m_txTextControl.FormattingPrinter = "Standard";
			this.m_txTextControl.Location = new System.Drawing.Point(25, 78);
			this.m_txTextControl.Name = "m_txTextControl";
			this.m_txTextControl.PageMargins.Bottom = 78.75D;
			this.m_txTextControl.PageMargins.Left = 78.75D;
			this.m_txTextControl.PageMargins.Right = 78.75D;
			this.m_txTextControl.PageMargins.Top = 78.75D;
			this.m_txTextControl.PageSize.Height = 1169.31D;
			this.m_txTextControl.PageSize.Width = 826.81D;
			this.m_txTextControl.RulerBar = this.m_rbHorizontalRuler;
			this.m_txTextControl.Size = new System.Drawing.Size(775, 350);
			this.m_txTextControl.StatusBar = this.m_sbStatusBar;
			this.m_txTextControl.TabIndex = 1;
			this.m_txTextControl.UserNames = null;
			this.m_txTextControl.VerticalRulerBar = this.m_rbVerticalRuler;
			// 
			// m_btButtonBar
			// 
			this.m_btButtonBar.BackColor = System.Drawing.SystemColors.Control;
			this.m_btButtonBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btButtonBar.Location = new System.Drawing.Point(0, 24);
			this.m_btButtonBar.Name = "m_btButtonBar";
			this.m_btButtonBar.Size = new System.Drawing.Size(800, 29);
			this.m_btButtonBar.TabIndex = 2;
			this.m_btButtonBar.Text = "buttonBar1";
			// 
			// m_rbHorizontalRuler
			// 
			this.m_rbHorizontalRuler.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rbHorizontalRuler.Location = new System.Drawing.Point(0, 53);
			this.m_rbHorizontalRuler.Name = "m_rbHorizontalRuler";
			this.m_rbHorizontalRuler.Size = new System.Drawing.Size(800, 25);
			this.m_rbHorizontalRuler.TabIndex = 5;
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
			this.m_sbStatusBar.TabIndex = 3;
			// 
			// m_rbVerticalRuler
			// 
			this.m_rbVerticalRuler.Alignment = TXTextControl.RulerBarAlignment.Left;
			this.m_rbVerticalRuler.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_rbVerticalRuler.Location = new System.Drawing.Point(0, 78);
			this.m_rbVerticalRuler.Name = "m_rbVerticalRuler";
			this.m_rbVerticalRuler.Size = new System.Drawing.Size(25, 350);
			this.m_rbVerticalRuler.TabIndex = 4;
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
			this.Controls.Add(this.m_btButtonBar);
			this.Controls.Add(this.m_sbStatusBar);
			this.Controls.Add(this.m_msMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.m_msMenu;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Howto: Add charting support to your applications - Merging the chart objects with" +
    " data";
			this.m_msMenu.ResumeLayout(false);
			this.m_msMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip m_msMenu;
		private TXTextControl.TextControl m_txTextControl;
		private TXTextControl.ButtonBar m_btButtonBar;
		private TXTextControl.RulerBar m_rbHorizontalRuler;
		private TXTextControl.StatusBar m_sbStatusBar;
		private TXTextControl.RulerBar m_rbVerticalRuler;
		private System.Windows.Forms.ToolStripMenuItem m_tmiFile;
		private System.Windows.Forms.ToolStripMenuItem m_tmiNew;
		private System.Windows.Forms.ToolStripMenuItem m_tmiOpen;
		private System.Windows.Forms.ToolStripMenuItem m_tmiSaveAs;
		private System.Windows.Forms.ToolStripMenuItem m_tmiCharts;
		private System.Windows.Forms.ToolStripMenuItem m_tmiMerge;
		private System.Windows.Forms.ToolStripMenuItem m_tmiSampleTemplate;
	}
}

