namespace XMLEditing {
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
			this.m_tmiOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiSample = new System.Windows.Forms.ToolStripMenuItem();
			this.m_txTextControl = new TXTextControl.TextControl();
			this.m_bbButtonBar = new TXTextControl.ButtonBar();
			this.m_msMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_msMenu
			// 
			this.m_msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiFile});
			this.m_msMenu.Location = new System.Drawing.Point(0, 0);
			this.m_msMenu.Name = "m_msMenu";
			this.m_msMenu.Size = new System.Drawing.Size(800, 24);
			this.m_msMenu.TabIndex = 0;
			this.m_msMenu.Text = "menuStrip1";
			// 
			// m_tmiFile
			// 
			this.m_tmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiOpen,
            this.m_tmiSample});
			this.m_tmiFile.Name = "m_tmiFile";
			this.m_tmiFile.Size = new System.Drawing.Size(37, 20);
			this.m_tmiFile.Text = "&File";
			// 
			// m_tmiOpen
			// 
			this.m_tmiOpen.Name = "m_tmiOpen";
			this.m_tmiOpen.Size = new System.Drawing.Size(192, 22);
			this.m_tmiOpen.Text = "&Open...";
			this.m_tmiOpen.Click += new System.EventHandler(this.Open_Click);
			// 
			// m_tmiSample
			// 
			this.m_tmiSample.Name = "m_tmiSample";
			this.m_tmiSample.Size = new System.Drawing.Size(192, 22);
			this.m_tmiSample.Text = "&Load \'address_list.xml\'";
			this.m_tmiSample.Click += new System.EventHandler(this.LoadSample_Click);
			// 
			// m_txTextControl
			// 
			this.m_txTextControl.ButtonBar = this.m_bbButtonBar;
			this.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_txTextControl.Font = new System.Drawing.Font("Arial", 10F);
			this.m_txTextControl.FormattingPrinter = "Standard";
			this.m_txTextControl.Location = new System.Drawing.Point(0, 53);
			this.m_txTextControl.Name = "m_txTextControl";
			this.m_txTextControl.Size = new System.Drawing.Size(800, 397);
			this.m_txTextControl.TabIndex = 1;
			this.m_txTextControl.UserNames = null;
			this.m_txTextControl.XmlInvalid += new TXTextControl.XmlErrorEventHandler(this.TextControl_XmlInvalid);
			// 
			// m_bbButtonBar
			// 
			this.m_bbButtonBar.BackColor = System.Drawing.SystemColors.Control;
			this.m_bbButtonBar.ButtonOffsets = new int[] {
        10,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0};
			this.m_bbButtonBar.ButtonPositions = new TXTextControl.Button[] {
        TXTextControl.Button.StyleComboBox,
        TXTextControl.Button.XMLAddElementComboBox,
        TXTextControl.Button.XMLRemoveElementComboBox,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None,
        TXTextControl.Button.None};
			this.m_bbButtonBar.ButtonSeparators = new bool[] {
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false};
			this.m_bbButtonBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_bbButtonBar.Location = new System.Drawing.Point(0, 24);
			this.m_bbButtonBar.Name = "m_bbButtonBar";
			this.m_bbButtonBar.Size = new System.Drawing.Size(800, 29);
			this.m_bbButtonBar.TabIndex = 2;
			this.m_bbButtonBar.Text = "buttonBar1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.m_txTextControl);
			this.Controls.Add(this.m_bbButtonBar);
			this.Controls.Add(this.m_msMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.m_msMenu;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Howto: Use XML Files - XMLEditing";
			this.m_msMenu.ResumeLayout(false);
			this.m_msMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip m_msMenu;
		private System.Windows.Forms.ToolStripMenuItem m_tmiFile;
		private System.Windows.Forms.ToolStripMenuItem m_tmiOpen;
		private System.Windows.Forms.ToolStripMenuItem m_tmiSample;
		private TXTextControl.TextControl m_txTextControl;
		private TXTextControl.ButtonBar m_bbButtonBar;
	}
}

