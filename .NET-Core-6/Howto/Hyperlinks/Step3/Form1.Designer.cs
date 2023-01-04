namespace Step3 {
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
			this.m_tmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiLinks = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiInsertLink = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiEditLink = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiShowHyperlinks = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiShowDocumentLinks = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiDocumentTargets = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiInsertDocumentTarget = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiEditDocumentTarget = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiDeleteAndGoTo = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiShowDocumentTargets = new System.Windows.Forms.ToolStripMenuItem();
			this.m_txTextControl = new TXTextControl.TextControl();
			this.m_msMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_msMenu
			// 
			this.m_msMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.m_msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiFile,
            this.m_tmiLinks,
            this.m_tmiDocumentTargets});
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
			// m_tmiLinks
			// 
			this.m_tmiLinks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiInsertLink,
            this.m_tmiEditLink,
            this.m_tmiShowHyperlinks,
            this.m_tmiShowDocumentLinks});
			this.m_tmiLinks.Name = "m_tmiLinks";
			this.m_tmiLinks.Size = new System.Drawing.Size(46, 20);
			this.m_tmiLinks.Text = "&Links";
			this.m_tmiLinks.DropDownOpening += new System.EventHandler(this.Links_DropDownOpening);
			// 
			// m_tmiInsertLink
			// 
			this.m_tmiInsertLink.Name = "m_tmiInsertLink";
			this.m_tmiInsertLink.Size = new System.Drawing.Size(192, 22);
			this.m_tmiInsertLink.Text = "&Insert...";
			this.m_tmiInsertLink.Click += new System.EventHandler(this.OpenCustomLinkDialog_Click);
			// 
			// m_tmiEditLink
			// 
			this.m_tmiEditLink.Name = "m_tmiEditLink";
			this.m_tmiEditLink.Size = new System.Drawing.Size(192, 22);
			this.m_tmiEditLink.Text = "&Edit...";
			this.m_tmiEditLink.Click += new System.EventHandler(this.OpenCustomLinkDialog_Click);
			// 
			// m_tmiShowHyperlinks
			// 
			this.m_tmiShowHyperlinks.Checked = true;
			this.m_tmiShowHyperlinks.CheckOnClick = true;
			this.m_tmiShowHyperlinks.CheckState = System.Windows.Forms.CheckState.Checked;
			this.m_tmiShowHyperlinks.Name = "m_tmiShowHyperlinks";
			this.m_tmiShowHyperlinks.Size = new System.Drawing.Size(192, 22);
			this.m_tmiShowHyperlinks.Text = "Show &Hyperlinks";
			this.m_tmiShowHyperlinks.Click += new System.EventHandler(this.ShowHyperlinks_Click);
			// 
			// m_tmiShowDocumentLinks
			// 
			this.m_tmiShowDocumentLinks.Checked = true;
			this.m_tmiShowDocumentLinks.CheckOnClick = true;
			this.m_tmiShowDocumentLinks.CheckState = System.Windows.Forms.CheckState.Checked;
			this.m_tmiShowDocumentLinks.Name = "m_tmiShowDocumentLinks";
			this.m_tmiShowDocumentLinks.Size = new System.Drawing.Size(192, 22);
			this.m_tmiShowDocumentLinks.Text = "Show &Document Links";
			this.m_tmiShowDocumentLinks.Click += new System.EventHandler(this.ShowDocumentLinks_Click);
			// 
			// m_tmiDocumentTargets
			// 
			this.m_tmiDocumentTargets.Checked = true;
			this.m_tmiDocumentTargets.CheckOnClick = true;
			this.m_tmiDocumentTargets.CheckState = System.Windows.Forms.CheckState.Checked;
			this.m_tmiDocumentTargets.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiInsertDocumentTarget,
            this.m_tmiEditDocumentTarget,
            this.m_tmiDeleteAndGoTo,
            this.m_tmiShowDocumentTargets});
			this.m_tmiDocumentTargets.Name = "m_tmiDocumentTargets";
			this.m_tmiDocumentTargets.Size = new System.Drawing.Size(115, 20);
			this.m_tmiDocumentTargets.Text = "&Document Targets";
			this.m_tmiDocumentTargets.DropDownOpening += new System.EventHandler(this.DocumentTargets_DropDownOpening);
			// 
			// m_tmiInsertDocumentTarget
			// 
			this.m_tmiInsertDocumentTarget.Name = "m_tmiInsertDocumentTarget";
			this.m_tmiInsertDocumentTarget.Size = new System.Drawing.Size(172, 22);
			this.m_tmiInsertDocumentTarget.Text = "&Insert..";
			this.m_tmiInsertDocumentTarget.Click += new System.EventHandler(this.InsertDocumentTarget_Click);
			// 
			// m_tmiEditDocumentTarget
			// 
			this.m_tmiEditDocumentTarget.Name = "m_tmiEditDocumentTarget";
			this.m_tmiEditDocumentTarget.Size = new System.Drawing.Size(172, 22);
			this.m_tmiEditDocumentTarget.Text = "&Edit...";
			this.m_tmiEditDocumentTarget.Click += new System.EventHandler(this.EditDocumentTarget_Click);
			// 
			// m_tmiDeleteAndGoTo
			// 
			this.m_tmiDeleteAndGoTo.Name = "m_tmiDeleteAndGoTo";
			this.m_tmiDeleteAndGoTo.Size = new System.Drawing.Size(172, 22);
			this.m_tmiDeleteAndGoTo.Text = "&Delete and Go To...";
			this.m_tmiDeleteAndGoTo.Click += new System.EventHandler(this.DeleteAndGoToTarget_Click);
			// 
			// m_tmiShowDocumentTargets
			// 
			this.m_tmiShowDocumentTargets.CheckOnClick = true;
			this.m_tmiShowDocumentTargets.Name = "m_tmiShowDocumentTargets";
			this.m_tmiShowDocumentTargets.Size = new System.Drawing.Size(172, 22);
			this.m_tmiShowDocumentTargets.Text = "&Show";
			this.m_tmiShowDocumentTargets.Click += new System.EventHandler(this.ShowDocumentTargets_Click);
			// 
			// m_txTextControl
			// 
			this.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_txTextControl.DocumentTargetMarkers = true;
			this.m_txTextControl.Font = new System.Drawing.Font("Arial", 10F);
			this.m_txTextControl.FormattingPrinter = "Standard";
			this.m_txTextControl.Location = new System.Drawing.Point(0, 24);
			this.m_txTextControl.Margin = new System.Windows.Forms.Padding(0);
			this.m_txTextControl.Name = "m_txTextControl";
			this.m_txTextControl.Size = new System.Drawing.Size(800, 426);
			this.m_txTextControl.TabIndex = 1;
			this.m_txTextControl.UserNames = null;
			this.m_txTextControl.TextFieldCreated += new TXTextControl.TextFieldEventHandler(this.TextControl_TextFieldCreated);
			this.m_txTextControl.HypertextLinkClicked += new TXTextControl.HypertextLinkEventHandler(this.TextControl_HypertextLinkClicked);
			this.m_txTextControl.DocumentLinkClicked += new TXTextControl.DocumentLinkEventHandler(this.TextControl_DocumentLinkClicked);
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
			this.Text = "Howto: Use Hypertext Links - Step 3: Adding Document Targets";
			this.m_msMenu.ResumeLayout(false);
			this.m_msMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip m_msMenu;
		private TXTextControl.TextControl m_txTextControl;
		private System.Windows.Forms.ToolStripMenuItem m_tmiFile;
		private System.Windows.Forms.ToolStripMenuItem m_tmiNew;
		private System.Windows.Forms.ToolStripMenuItem m_tmiOpen;
		private System.Windows.Forms.ToolStripMenuItem m_tmiSaveAs;
		private System.Windows.Forms.ToolStripMenuItem m_tmiLinks;
		private System.Windows.Forms.ToolStripMenuItem m_tmiInsertLink;
		private System.Windows.Forms.ToolStripMenuItem m_tmiEditLink;
		private System.Windows.Forms.ToolStripMenuItem m_tmiShowHyperlinks;
		private System.Windows.Forms.ToolStripMenuItem m_tmiShowDocumentLinks;
		private System.Windows.Forms.ToolStripMenuItem m_tmiDocumentTargets;
		private System.Windows.Forms.ToolStripMenuItem m_tmiInsertDocumentTarget;
		private System.Windows.Forms.ToolStripMenuItem m_tmiEditDocumentTarget;
		private System.Windows.Forms.ToolStripMenuItem m_tmiShowDocumentTargets;
		private System.Windows.Forms.ToolStripMenuItem m_tmiDeleteAndGoTo;
	}
}

