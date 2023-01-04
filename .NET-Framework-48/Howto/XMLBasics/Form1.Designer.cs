namespace XMLBasics {
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
			this.m_txTextControl = new TXTextControl.TextControl();
			this.m_msMenu = new System.Windows.Forms.MenuStrip();
			this.m_tmiFile = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiLoadAddressXML = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiLoadAddressListXML = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tmiLoadAddressInvalidXML = new System.Windows.Forms.ToolStripMenuItem();
			this.m_msMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_txTextControl
			// 
			this.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_txTextControl.Font = new System.Drawing.Font("Arial", 10F);
			this.m_txTextControl.FormattingPrinter = "Standard";
			this.m_txTextControl.Location = new System.Drawing.Point(0, 24);
			this.m_txTextControl.Name = "m_txTextControl";
			this.m_txTextControl.Size = new System.Drawing.Size(800, 426);
			this.m_txTextControl.TabIndex = 0;
			this.m_txTextControl.UserNames = null;
			this.m_txTextControl.XmlInvalid += new TXTextControl.XmlErrorEventHandler(this.TextControl_XmlInvalid);
			// 
			// m_msMenu
			// 
			this.m_msMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.m_msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiFile});
			this.m_msMenu.Location = new System.Drawing.Point(0, 0);
			this.m_msMenu.Name = "m_msMenu";
			this.m_msMenu.Size = new System.Drawing.Size(800, 24);
			this.m_msMenu.TabIndex = 1;
			this.m_msMenu.Text = "menuStrip1";
			// 
			// m_tmiFile
			// 
			this.m_tmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tmiOpen,
            this.m_tmiLoadAddressXML,
            this.m_tmiLoadAddressListXML,
            this.m_tmiLoadAddressInvalidXML});
			this.m_tmiFile.Name = "m_tmiFile";
			this.m_tmiFile.Size = new System.Drawing.Size(37, 20);
			this.m_tmiFile.Text = "&File";
			// 
			// m_tmiOpen
			// 
			this.m_tmiOpen.Name = "m_tmiOpen";
			this.m_tmiOpen.Size = new System.Drawing.Size(212, 22);
			this.m_tmiOpen.Text = "&Open...";
			this.m_tmiOpen.Click += new System.EventHandler(this.Open_Click);
			// 
			// m_tmiLoadAddressXML
			// 
			this.m_tmiLoadAddressXML.Name = "m_tmiLoadAddressXML";
			this.m_tmiLoadAddressXML.Size = new System.Drawing.Size(212, 22);
			this.m_tmiLoadAddressXML.Text = "Load \'&address.xml\'";
			this.m_tmiLoadAddressXML.Click += new System.EventHandler(this.Load_AddressXML_Sample_Click);
			// 
			// m_tmiLoadAddressListXML
			// 
			this.m_tmiLoadAddressListXML.Name = "m_tmiLoadAddressListXML";
			this.m_tmiLoadAddressListXML.Size = new System.Drawing.Size(212, 22);
			this.m_tmiLoadAddressListXML.Text = "&Load \'address_list.xml\'";
			this.m_tmiLoadAddressListXML.Click += new System.EventHandler(this.Load_AddressListXML_Sample_Click);
			// 
			// m_tmiLoadAddressInvalidXML
			// 
			this.m_tmiLoadAddressInvalidXML.Name = "m_tmiLoadAddressInvalidXML";
			this.m_tmiLoadAddressInvalidXML.Size = new System.Drawing.Size(212, 22);
			this.m_tmiLoadAddressInvalidXML.Text = "Load \'address_in&valid.xml\'";
			this.m_tmiLoadAddressInvalidXML.Click += new System.EventHandler(this.Load_AddressInvalidXML_Sample_Click);
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
			this.Text = "Howto: Use XML Files - The Sample Program";
			this.m_msMenu.ResumeLayout(false);
			this.m_msMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TXTextControl.TextControl m_txTextControl;
		private System.Windows.Forms.MenuStrip m_msMenu;
		private System.Windows.Forms.ToolStripMenuItem m_tmiFile;
		private System.Windows.Forms.ToolStripMenuItem m_tmiOpen;
		private System.Windows.Forms.ToolStripMenuItem m_tmiLoadAddressXML;
		private System.Windows.Forms.ToolStripMenuItem m_tmiLoadAddressListXML;
		private System.Windows.Forms.ToolStripMenuItem m_tmiLoadAddressInvalidXML;
	}
}

