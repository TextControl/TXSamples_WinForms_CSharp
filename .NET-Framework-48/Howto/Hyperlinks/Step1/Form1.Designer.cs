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
			this.m_btnInsertHyperlink = new System.Windows.Forms.Button();
			this.m_btnSaveAs = new System.Windows.Forms.Button();
			this.m_txTextControl = new TXTextControl.TextControl();
			this.m_tlpMainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_tlpMainPanel
			// 
			this.m_tlpMainPanel.ColumnCount = 3;
			this.m_tlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpMainPanel.Controls.Add(this.m_btnInsertHyperlink, 0, 1);
			this.m_tlpMainPanel.Controls.Add(this.m_btnSaveAs, 1, 1);
			this.m_tlpMainPanel.Controls.Add(this.m_txTextControl, 0, 0);
			this.m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_tlpMainPanel.Location = new System.Drawing.Point(11, 11);
			this.m_tlpMainPanel.Margin = new System.Windows.Forms.Padding(0);
			this.m_tlpMainPanel.Name = "m_tlpMainPanel";
			this.m_tlpMainPanel.RowCount = 2;
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.Size = new System.Drawing.Size(778, 428);
			this.m_tlpMainPanel.TabIndex = 0;
			// 
			// m_btnInsertHyperlink
			// 
			this.m_btnInsertHyperlink.AutoSize = true;
			this.m_btnInsertHyperlink.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnInsertHyperlink.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btnInsertHyperlink.Location = new System.Drawing.Point(0, 405);
			this.m_btnInsertHyperlink.Margin = new System.Windows.Forms.Padding(0);
			this.m_btnInsertHyperlink.MinimumSize = new System.Drawing.Size(75, 23);
			this.m_btnInsertHyperlink.Name = "m_btnInsertHyperlink";
			this.m_btnInsertHyperlink.Size = new System.Drawing.Size(114, 23);
			this.m_btnInsertHyperlink.TabIndex = 0;
			this.m_btnInsertHyperlink.Text = "Insert &Hypertext Link";
			this.m_btnInsertHyperlink.UseVisualStyleBackColor = true;
			this.m_btnInsertHyperlink.Click += new System.EventHandler(this.InsertHyperlink_Click);
			// 
			// m_btnSaveAs
			// 
			this.m_btnSaveAs.AutoSize = true;
			this.m_btnSaveAs.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btnSaveAs.Location = new System.Drawing.Point(125, 405);
			this.m_btnSaveAs.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
			this.m_btnSaveAs.MinimumSize = new System.Drawing.Size(75, 23);
			this.m_btnSaveAs.Name = "m_btnSaveAs";
			this.m_btnSaveAs.Size = new System.Drawing.Size(108, 23);
			this.m_btnSaveAs.TabIndex = 1;
			this.m_btnSaveAs.Text = "&Save as HTML File";
			this.m_btnSaveAs.UseVisualStyleBackColor = true;
			this.m_btnSaveAs.Click += new System.EventHandler(this.SaveAs_Click);
			// 
			// m_txTextControl
			// 
			this.m_tlpMainPanel.SetColumnSpan(this.m_txTextControl, 3);
			this.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_txTextControl.Font = new System.Drawing.Font("Arial", 10F);
			this.m_txTextControl.FormattingPrinter = "Standard";
			this.m_txTextControl.Location = new System.Drawing.Point(0, 0);
			this.m_txTextControl.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
			this.m_txTextControl.Name = "m_txTextControl";
			this.m_txTextControl.Size = new System.Drawing.Size(778, 390);
			this.m_txTextControl.TabIndex = 2;
			this.m_txTextControl.UserNames = null;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.m_tlpMainPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(11);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Howto: Use Hypertext Links - Step 1: Inserting a Hypertext Link";
			this.m_tlpMainPanel.ResumeLayout(false);
			this.m_tlpMainPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel m_tlpMainPanel;
		private System.Windows.Forms.Button m_btnInsertHyperlink;
		private System.Windows.Forms.Button m_btnSaveAs;
		private TXTextControl.TextControl m_txTextControl;
	}
}

