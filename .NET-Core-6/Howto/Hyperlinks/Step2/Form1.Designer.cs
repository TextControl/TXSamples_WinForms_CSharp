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
			this.m_tmiHyperlinks = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiInsertHyperlink = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiEditHyperlink = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiShowHyperlinks = new System.Windows.Forms.ToolStripMenuItem();
			this.m_txTextControl = new TXTextControl.TextControl();
			this.m_msMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_msMenu
			// 
			this.m_msMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.m_msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiHyperlinks});
			this.m_msMenu.Location = new System.Drawing.Point(0, 0);
			this.m_msMenu.Name = "m_msMenu";
			this.m_msMenu.Size = new System.Drawing.Size(800, 24);
			this.m_msMenu.TabIndex = 0;
			this.m_msMenu.Text = "menuStrip1";
			// 
			// m_tmiHyperlinks
			// 
			this.m_tmiHyperlinks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiInsertHyperlink,
            this.m_tmiEditHyperlink,
            this.m_tmiShowHyperlinks});
			this.m_tmiHyperlinks.Name = "m_tmiHyperlinks";
			this.m_tmiHyperlinks.Size = new System.Drawing.Size(75, 20);
			this.m_tmiHyperlinks.Text = "&Hyperlinks";
			this.m_tmiHyperlinks.DropDownOpening += new System.EventHandler(this.Hyperlinks_DropDownOpening);
			// 
			// m_tmiInsertHyperlink
			// 
			this.m_tmiInsertHyperlink.Name = "m_tmiInsertHyperlink";
			this.m_tmiInsertHyperlink.Size = new System.Drawing.Size(112, 22);
			this.m_tmiInsertHyperlink.Text = "&Insert...";
			this.m_tmiInsertHyperlink.Click += new System.EventHandler(this.OpenHyperlinkDialog_Click);
			// 
			// m_tmiEditHyperlink
			// 
			this.m_tmiEditHyperlink.Name = "m_tmiEditHyperlink";
			this.m_tmiEditHyperlink.Size = new System.Drawing.Size(112, 22);
			this.m_tmiEditHyperlink.Text = "&Edit...";
			this.m_tmiEditHyperlink.Click += new System.EventHandler(this.OpenHyperlinkDialog_Click);
			// 
			// m_tmiShowHyperlinks
			// 
			this.m_tmiShowHyperlinks.Checked = true;
			this.m_tmiShowHyperlinks.CheckOnClick = true;
			this.m_tmiShowHyperlinks.CheckState = System.Windows.Forms.CheckState.Checked;
			this.m_tmiShowHyperlinks.Name = "m_tmiShowHyperlinks";
			this.m_tmiShowHyperlinks.Size = new System.Drawing.Size(112, 22);
			this.m_tmiShowHyperlinks.Text = "&Show";
			this.m_tmiShowHyperlinks.Click += new System.EventHandler(this.ShowHyperlinks_Click);
			// 
			// m_txTextControl
			// 
			this.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_txTextControl.Font = new System.Drawing.Font("Arial", 10F);
			this.m_txTextControl.FormattingPrinter = "Standard";
			this.m_txTextControl.Location = new System.Drawing.Point(0, 24);
			this.m_txTextControl.Name = "m_txTextControl";
			this.m_txTextControl.Size = new System.Drawing.Size(800, 426);
			this.m_txTextControl.TabIndex = 1;
			this.m_txTextControl.UserNames = null;
			this.m_txTextControl.TextFieldCreated += new TXTextControl.TextFieldEventHandler(this.TextControl_TextFieldCreated);
			this.m_txTextControl.HypertextLinkClicked += new TXTextControl.HypertextLinkEventHandler(this.TextControl_HypertextLinkClicked);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.m_txTextControl);
			this.Controls.Add(this.m_msMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.m_msMenu;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Howto: Use Hypertext Links - Step 2: Adding a Dialog Box for Inserting Hypertext " +
    "Links";
			this.m_msMenu.ResumeLayout(false);
			this.m_msMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip m_msMenu;
		private TXTextControl.TextControl m_txTextControl;
		private System.Windows.Forms.ToolStripMenuItem m_tmiHyperlinks;
		private System.Windows.Forms.ToolStripMenuItem m_tmiInsertHyperlink;
		private System.Windows.Forms.ToolStripMenuItem m_tmiEditHyperlink;
		private System.Windows.Forms.ToolStripMenuItem m_tmiShowHyperlinks;
	}
}

