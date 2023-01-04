namespace Step1 {
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
			this.m_tlpMainPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_msMenu = new System.Windows.Forms.MenuStrip();
			this.m_tmiFile = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiNew = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiInsert = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiChart = new System.Windows.Forms.ToolStripMenuItem();
			this.m_pnlTextControlPanel = new System.Windows.Forms.Panel();
			this.m_txTextControl = new TXTextControl.TextControl();
			this.m_bbButtonBar = new TXTextControl.ButtonBar();
			this.m_rbHorizontalRuler = new TXTextControl.RulerBar();
			this.m_sbStatusBar = new TXTextControl.StatusBar();
			this.m_rbVerticalRuler = new TXTextControl.RulerBar();
			this.m_tlpChartPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_lblChartName = new System.Windows.Forms.Label();
			this.m_tbxChartName = new System.Windows.Forms.TextBox();
			this.m_btnApplyChartName = new System.Windows.Forms.Button();
			this.m_pgChartProperties = new System.Windows.Forms.PropertyGrid();
			this.m_tlpMainPanel.SuspendLayout();
			this.m_msMenu.SuspendLayout();
			this.m_pnlTextControlPanel.SuspendLayout();
			this.m_tlpChartPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_tlpMainPanel
			// 
			this.m_tlpMainPanel.ColumnCount = 2;
			this.m_tlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpMainPanel.Controls.Add(this.m_msMenu, 0, 0);
			this.m_tlpMainPanel.Controls.Add(this.m_pnlTextControlPanel, 0, 1);
			this.m_tlpMainPanel.Controls.Add(this.m_tlpChartPanel, 1, 1);
			this.m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_tlpMainPanel.Location = new System.Drawing.Point(0, 0);
			this.m_tlpMainPanel.Name = "m_tlpMainPanel";
			this.m_tlpMainPanel.RowCount = 2;
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpMainPanel.Size = new System.Drawing.Size(1032, 469);
			this.m_tlpMainPanel.TabIndex = 0;
			// 
			// m_msMenu
			// 
			this.m_tlpMainPanel.SetColumnSpan(this.m_msMenu, 2);
			this.m_msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiFile,
            this.m_tmiInsert});
			this.m_msMenu.Location = new System.Drawing.Point(0, 0);
			this.m_msMenu.Name = "m_msMenu";
			this.m_msMenu.Size = new System.Drawing.Size(1032, 24);
			this.m_msMenu.TabIndex = 0;
			this.m_msMenu.Text = "menuStrip1";
			// 
			// m_tmiFile
			// 
			this.m_tmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiNew,
            this.m_tmiOpen,
            this.m_tmiSaveAs});
			this.m_tmiFile.Name = "m_tmiFile";
			this.m_tmiFile.Size = new System.Drawing.Size(37, 20);
			this.m_tmiFile.Text = "&File";
			// 
			// m_tmiNew
			// 
			this.m_tmiNew.Name = "m_tmiNew";
			this.m_tmiNew.Size = new System.Drawing.Size(123, 22);
			this.m_tmiNew.Text = "&New";
			this.m_tmiNew.Click += new System.EventHandler(this.New_Click);
			// 
			// m_tmiOpen
			// 
			this.m_tmiOpen.Name = "m_tmiOpen";
			this.m_tmiOpen.Size = new System.Drawing.Size(123, 22);
			this.m_tmiOpen.Text = "&Open...";
			this.m_tmiOpen.Click += new System.EventHandler(this.Open_Click);
			// 
			// m_tmiSaveAs
			// 
			this.m_tmiSaveAs.Name = "m_tmiSaveAs";
			this.m_tmiSaveAs.Size = new System.Drawing.Size(123, 22);
			this.m_tmiSaveAs.Text = "&Save As...";
			this.m_tmiSaveAs.Click += new System.EventHandler(this.SaveAs_Click);
			// 
			// m_tmiInsert
			// 
			this.m_tmiInsert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiChart});
			this.m_tmiInsert.Name = "m_tmiInsert";
			this.m_tmiInsert.Size = new System.Drawing.Size(48, 20);
			this.m_tmiInsert.Text = "&Insert";
			// 
			// m_tmiChart
			// 
			this.m_tmiChart.Name = "m_tmiChart";
			this.m_tmiChart.Size = new System.Drawing.Size(103, 22);
			this.m_tmiChart.Text = "&Chart";
			this.m_tmiChart.Click += new System.EventHandler(this.Chart_Click);
			// 
			// m_pnlTextControlPanel
			// 
			this.m_pnlTextControlPanel.Controls.Add(this.m_txTextControl);
			this.m_pnlTextControlPanel.Controls.Add(this.m_rbVerticalRuler);
			this.m_pnlTextControlPanel.Controls.Add(this.m_rbHorizontalRuler);
			this.m_pnlTextControlPanel.Controls.Add(this.m_bbButtonBar);
			this.m_pnlTextControlPanel.Controls.Add(this.m_sbStatusBar);
			this.m_pnlTextControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_pnlTextControlPanel.Location = new System.Drawing.Point(0, 24);
			this.m_pnlTextControlPanel.Margin = new System.Windows.Forms.Padding(0);
			this.m_pnlTextControlPanel.Name = "m_pnlTextControlPanel";
			this.m_pnlTextControlPanel.Size = new System.Drawing.Size(674, 445);
			this.m_pnlTextControlPanel.TabIndex = 1;
			// 
			// m_txTextControl
			// 
			this.m_txTextControl.ButtonBar = this.m_bbButtonBar;
			this.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_txTextControl.Font = new System.Drawing.Font("Arial", 10F);
			this.m_txTextControl.FormattingPrinter = "Standard";
			this.m_txTextControl.Location = new System.Drawing.Point(25, 54);
			this.m_txTextControl.Name = "m_txTextControl";
			this.m_txTextControl.RulerBar = this.m_rbHorizontalRuler;
			this.m_txTextControl.Size = new System.Drawing.Size(649, 369);
			this.m_txTextControl.StatusBar = this.m_sbStatusBar;
			this.m_txTextControl.TabIndex = 0;
			this.m_txTextControl.UserNames = null;
			this.m_txTextControl.VerticalRulerBar = this.m_rbVerticalRuler;
			this.m_txTextControl.ChartSelected += new TXTextControl.DataVisualization.ChartEventHandler(this.TextControl_ChartSelected);
			this.m_txTextControl.ChartDeselected += new TXTextControl.DataVisualization.ChartEventHandler(this.TextControl_ChartDeselected);
			// 
			// m_bbButtonBar
			// 
			this.m_bbButtonBar.BackColor = System.Drawing.SystemColors.Control;
			this.m_bbButtonBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_bbButtonBar.Location = new System.Drawing.Point(0, 0);
			this.m_bbButtonBar.Name = "m_bbButtonBar";
			this.m_bbButtonBar.Size = new System.Drawing.Size(674, 29);
			this.m_bbButtonBar.TabIndex = 1;
			this.m_bbButtonBar.Text = "buttonBar1";
			// 
			// m_rbHorizontalRuler
			// 
			this.m_rbHorizontalRuler.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rbHorizontalRuler.Location = new System.Drawing.Point(0, 29);
			this.m_rbHorizontalRuler.Name = "m_rbHorizontalRuler";
			this.m_rbHorizontalRuler.Size = new System.Drawing.Size(674, 25);
			this.m_rbHorizontalRuler.TabIndex = 4;
			this.m_rbHorizontalRuler.Text = "rulerBar2";
			// 
			// m_sbStatusBar
			// 
			this.m_sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			this.m_sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_sbStatusBar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_sbStatusBar.Location = new System.Drawing.Point(0, 423);
			this.m_sbStatusBar.Name = "m_sbStatusBar";
			this.m_sbStatusBar.Size = new System.Drawing.Size(674, 22);
			this.m_sbStatusBar.TabIndex = 2;
			// 
			// m_rbVerticalRuler
			// 
			this.m_rbVerticalRuler.Alignment = TXTextControl.RulerBarAlignment.Left;
			this.m_rbVerticalRuler.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_rbVerticalRuler.Location = new System.Drawing.Point(0, 54);
			this.m_rbVerticalRuler.Name = "m_rbVerticalRuler";
			this.m_rbVerticalRuler.Size = new System.Drawing.Size(25, 369);
			this.m_rbVerticalRuler.TabIndex = 3;
			this.m_rbVerticalRuler.Text = "rulerBar1";
			// 
			// m_tlpChartPanel
			// 
			this.m_tlpChartPanel.AutoSize = true;
			this.m_tlpChartPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_tlpChartPanel.ColumnCount = 3;
			this.m_tlpChartPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpChartPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpChartPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpChartPanel.Controls.Add(this.m_lblChartName, 0, 0);
			this.m_tlpChartPanel.Controls.Add(this.m_tbxChartName, 1, 0);
			this.m_tlpChartPanel.Controls.Add(this.m_btnApplyChartName, 2, 0);
			this.m_tlpChartPanel.Controls.Add(this.m_pgChartProperties, 0, 2);
			this.m_tlpChartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_tlpChartPanel.Enabled = false;
			this.m_tlpChartPanel.Location = new System.Drawing.Point(685, 24);
			this.m_tlpChartPanel.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
			this.m_tlpChartPanel.Name = "m_tlpChartPanel";
			this.m_tlpChartPanel.RowCount = 3;
			this.m_tlpChartPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpChartPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpChartPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
			this.m_tlpChartPanel.Size = new System.Drawing.Size(347, 445);
			this.m_tlpChartPanel.TabIndex = 2;
			// 
			// m_lblChartName
			// 
			this.m_lblChartName.AutoSize = true;
			this.m_lblChartName.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_lblChartName.Location = new System.Drawing.Point(0, 0);
			this.m_lblChartName.Margin = new System.Windows.Forms.Padding(0);
			this.m_lblChartName.Name = "m_lblChartName";
			this.m_lblChartName.Size = new System.Drawing.Size(66, 23);
			this.m_lblChartName.TabIndex = 0;
			this.m_lblChartName.Text = "Chart &Name:";
			this.m_lblChartName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_tbxChartName
			// 
			this.m_tbxChartName.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tbxChartName.Location = new System.Drawing.Point(77, 2);
			this.m_tbxChartName.Margin = new System.Windows.Forms.Padding(11, 2, 0, 0);
			this.m_tbxChartName.MinimumSize = new System.Drawing.Size(100, 4);
			this.m_tbxChartName.Name = "m_tbxChartName";
			this.m_tbxChartName.Size = new System.Drawing.Size(219, 20);
			this.m_tbxChartName.TabIndex = 1;
			this.m_tbxChartName.TextChanged += new System.EventHandler(this.ChartName_TextChanged);
			this.m_tbxChartName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ChartName_KeyUp);
			// 
			// m_btnApplyChartName
			// 
			this.m_btnApplyChartName.AutoSize = true;
			this.m_btnApplyChartName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnApplyChartName.Enabled = false;
			this.m_btnApplyChartName.Location = new System.Drawing.Point(307, 0);
			this.m_btnApplyChartName.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
			this.m_btnApplyChartName.MinimumSize = new System.Drawing.Size(40, 23);
			this.m_btnApplyChartName.Name = "m_btnApplyChartName";
			this.m_btnApplyChartName.Size = new System.Drawing.Size(40, 23);
			this.m_btnApplyChartName.TabIndex = 2;
			this.m_btnApplyChartName.Text = "✔";
			this.m_btnApplyChartName.UseVisualStyleBackColor = true;
			this.m_btnApplyChartName.Click += new System.EventHandler(this.ApplyChartName_Click);
			// 
			// m_pgChartProperties
			// 
			this.m_tlpChartPanel.SetColumnSpan(this.m_pgChartProperties, 3);
			this.m_pgChartProperties.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_pgChartProperties.Location = new System.Drawing.Point(0, 31);
			this.m_pgChartProperties.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.m_pgChartProperties.Name = "m_pgChartProperties";
			this.m_pgChartProperties.Size = new System.Drawing.Size(347, 414);
			this.m_pgChartProperties.TabIndex = 3;
			this.m_pgChartProperties.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.ChartProperties_PropertyValueChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1032, 469);
			this.Controls.Add(this.m_tlpMainPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.m_msMenu;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Howto: Add charting support to your applications - Creating a template that conta" +
    "ins chart objects";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.m_tlpMainPanel.ResumeLayout(false);
			this.m_tlpMainPanel.PerformLayout();
			this.m_msMenu.ResumeLayout(false);
			this.m_msMenu.PerformLayout();
			this.m_pnlTextControlPanel.ResumeLayout(false);
			this.m_tlpChartPanel.ResumeLayout(false);
			this.m_tlpChartPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel m_tlpMainPanel;
		private System.Windows.Forms.MenuStrip m_msMenu;
		private System.Windows.Forms.ToolStripMenuItem m_tmiFile;
		private System.Windows.Forms.ToolStripMenuItem m_tmiOpen;
		private System.Windows.Forms.ToolStripMenuItem m_tmiSaveAs;
		private System.Windows.Forms.ToolStripMenuItem m_tmiInsert;
		private System.Windows.Forms.ToolStripMenuItem m_tmiChart;
		private System.Windows.Forms.Panel m_pnlTextControlPanel;
		private TXTextControl.TextControl m_txTextControl;
		private TXTextControl.ButtonBar m_bbButtonBar;
		private TXTextControl.RulerBar m_rbHorizontalRuler;
		private TXTextControl.StatusBar m_sbStatusBar;
		private TXTextControl.RulerBar m_rbVerticalRuler;
		private System.Windows.Forms.TableLayoutPanel m_tlpChartPanel;
		private System.Windows.Forms.Label m_lblChartName;
		private System.Windows.Forms.TextBox m_tbxChartName;
		private System.Windows.Forms.Button m_btnApplyChartName;
		private System.Windows.Forms.PropertyGrid m_pgChartProperties;
		private System.Windows.Forms.ToolStripMenuItem m_tmiNew;
	}
}

