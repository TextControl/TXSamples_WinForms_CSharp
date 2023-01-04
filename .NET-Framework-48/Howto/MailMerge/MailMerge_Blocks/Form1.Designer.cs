namespace MailMerge_Blocks {
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
			this.m_msMenu = new System.Windows.Forms.MenuStrip();
			this.m_tmiMailMerge = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiMerge = new System.Windows.Forms.ToolStripMenuItem();
			this.m_txTextControl = new TXTextControl.TextControl();
			this.m_bbButtonBar = new TXTextControl.ButtonBar();
			this.m_rbHorizontalRuler = new TXTextControl.RulerBar();
			this.m_sbStatusBar = new TXTextControl.StatusBar();
			this.m_rbVerticalRuler = new TXTextControl.RulerBar();
			this.m_mmMailMerge = new TXTextControl.DocumentServer.MailMerge(this.components);
			this.m_msMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_msMenu
			// 
			this.m_msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiMailMerge});
			this.m_msMenu.Location = new System.Drawing.Point(0, 0);
			this.m_msMenu.Name = "m_msMenu";
			this.m_msMenu.Size = new System.Drawing.Size(800, 24);
			this.m_msMenu.TabIndex = 6;
			this.m_msMenu.Text = "menuStrip1";
			// 
			// m_tmiMailMerge
			// 
			this.m_tmiMailMerge.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiMerge});
			this.m_tmiMailMerge.Name = "m_tmiMailMerge";
			this.m_tmiMailMerge.Size = new System.Drawing.Size(79, 20);
			this.m_tmiMailMerge.Text = "&Mail Merge";
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
			this.m_txTextControl.ButtonBar = this.m_bbButtonBar;
			this.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_txTextControl.Font = new System.Drawing.Font("Arial", 10F);
			this.m_txTextControl.FormattingPrinter = "Standard";
			this.m_txTextControl.Location = new System.Drawing.Point(25, 78);
			this.m_txTextControl.Name = "m_txTextControl";
			this.m_txTextControl.RulerBar = this.m_rbHorizontalRuler;
			this.m_txTextControl.Size = new System.Drawing.Size(775, 350);
			this.m_txTextControl.StatusBar = this.m_sbStatusBar;
			this.m_txTextControl.TabIndex = 7;
			this.m_txTextControl.UserNames = null;
			this.m_txTextControl.VerticalRulerBar = this.m_rbVerticalRuler;
			// 
			// m_bbButtonBar
			// 
			this.m_bbButtonBar.BackColor = System.Drawing.SystemColors.Control;
			this.m_bbButtonBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_bbButtonBar.Location = new System.Drawing.Point(0, 24);
			this.m_bbButtonBar.Name = "m_bbButtonBar";
			this.m_bbButtonBar.Size = new System.Drawing.Size(800, 29);
			this.m_bbButtonBar.TabIndex = 8;
			this.m_bbButtonBar.Text = "buttonBar1";
			// 
			// m_rbHorizontalRuler
			// 
			this.m_rbHorizontalRuler.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rbHorizontalRuler.Location = new System.Drawing.Point(0, 53);
			this.m_rbHorizontalRuler.Name = "m_rbHorizontalRuler";
			this.m_rbHorizontalRuler.Size = new System.Drawing.Size(800, 25);
			this.m_rbHorizontalRuler.TabIndex = 11;
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
			this.m_sbStatusBar.TabIndex = 9;
			// 
			// m_rbVerticalRuler
			// 
			this.m_rbVerticalRuler.Alignment = TXTextControl.RulerBarAlignment.Left;
			this.m_rbVerticalRuler.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_rbVerticalRuler.Location = new System.Drawing.Point(0, 78);
			this.m_rbVerticalRuler.Name = "m_rbVerticalRuler";
			this.m_rbVerticalRuler.Size = new System.Drawing.Size(25, 350);
			this.m_rbVerticalRuler.TabIndex = 10;
			this.m_rbVerticalRuler.Text = "rulerBar1";
			// 
			// m_mmMailMerge
			// 
			this.m_mmMailMerge.DataSourceCulture = new System.Globalization.CultureInfo("de-DE");
			this.m_mmMailMerge.DateFieldUtcOffset = null;
			this.m_mmMailMerge.MergeCulture = new System.Globalization.CultureInfo("de-DE");
			this.m_mmMailMerge.TextComponent = this.m_txTextControl;
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
			this.Controls.Add(this.m_sbStatusBar);
			this.Controls.Add(this.m_msMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Howto: Mail Merge - Sample: Mail Merge with Repeating Blocks";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.m_msMenu.ResumeLayout(false);
			this.m_msMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip m_msMenu;
		private System.Windows.Forms.ToolStripMenuItem m_tmiMailMerge;
		private System.Windows.Forms.ToolStripMenuItem m_tmiMerge;
		private TXTextControl.TextControl m_txTextControl;
		private TXTextControl.ButtonBar m_bbButtonBar;
		private TXTextControl.RulerBar m_rbHorizontalRuler;
		private TXTextControl.StatusBar m_sbStatusBar;
		private TXTextControl.RulerBar m_rbVerticalRuler;
		private TXTextControl.DocumentServer.MailMerge m_mmMailMerge;
	}
}

