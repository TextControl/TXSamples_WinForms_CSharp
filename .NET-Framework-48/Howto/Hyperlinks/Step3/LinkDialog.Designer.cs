namespace Step3 {
	partial class LinkDialog {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinkDialog));
			this.m_tlpMainPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_tbxHyperlink = new System.Windows.Forms.TextBox();
			this.m_lblLink = new System.Windows.Forms.Label();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_lblDisplayedText = new System.Windows.Forms.Label();
			this.m_tbxDisplayedText = new System.Windows.Forms.TextBox();
			this.m_btnOK = new System.Windows.Forms.Button();
			this.m_tlpLinkType = new System.Windows.Forms.TableLayoutPanel();
			this.m_rbtnTypeDocumentLink = new System.Windows.Forms.RadioButton();
			this.m_lblLinkType = new System.Windows.Forms.Label();
			this.m_rbtnTypeHyperlink = new System.Windows.Forms.RadioButton();
			this.m_cmbxDocumentTargets = new System.Windows.Forms.ComboBox();
			this.m_tlpMainPanel.SuspendLayout();
			this.m_tlpLinkType.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_tlpMainPanel
			// 
			this.m_tlpMainPanel.AutoSize = true;
			this.m_tlpMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_tlpMainPanel.ColumnCount = 3;
			this.m_tlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpMainPanel.Controls.Add(this.m_tbxHyperlink, 0, 4);
			this.m_tlpMainPanel.Controls.Add(this.m_lblLink, 0, 3);
			this.m_tlpMainPanel.Controls.Add(this.m_btnCancel, 2, 6);
			this.m_tlpMainPanel.Controls.Add(this.m_lblDisplayedText, 0, 1);
			this.m_tlpMainPanel.Controls.Add(this.m_tbxDisplayedText, 0, 2);
			this.m_tlpMainPanel.Controls.Add(this.m_btnOK, 1, 6);
			this.m_tlpMainPanel.Controls.Add(this.m_tlpLinkType, 0, 0);
			this.m_tlpMainPanel.Controls.Add(this.m_cmbxDocumentTargets, 0, 4);
			this.m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_tlpMainPanel.Location = new System.Drawing.Point(8, 11);
			this.m_tlpMainPanel.Margin = new System.Windows.Forms.Padding(0);
			this.m_tlpMainPanel.Name = "m_tlpMainPanel";
			this.m_tlpMainPanel.RowCount = 7;
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.Size = new System.Drawing.Size(355, 185);
			this.m_tlpMainPanel.TabIndex = 1;
			// 
			// m_tbxHyperlink
			// 
			this.m_tlpMainPanel.SetColumnSpan(this.m_tbxHyperlink, 3);
			this.m_tbxHyperlink.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tbxHyperlink.Location = new System.Drawing.Point(3, 137);
			this.m_tbxHyperlink.Margin = new System.Windows.Forms.Padding(3, 0, 0, 15);
			this.m_tbxHyperlink.MinimumSize = new System.Drawing.Size(250, 21);
			this.m_tbxHyperlink.Name = "m_tbxHyperlink";
			this.m_tbxHyperlink.Size = new System.Drawing.Size(352, 20);
			this.m_tbxHyperlink.TabIndex = 7;
			this.m_tbxHyperlink.TextChanged += new System.EventHandler(this.LinkParameter_Changed);
			// 
			// m_lblLink
			// 
			this.m_lblLink.AutoSize = true;
			this.m_lblLink.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_lblLink.Location = new System.Drawing.Point(0, 80);
			this.m_lblLink.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.m_lblLink.Name = "m_lblLink";
			this.m_lblLink.Size = new System.Drawing.Size(30, 13);
			this.m_lblLink.TabIndex = 6;
			this.m_lblLink.Text = "&Link:";
			this.m_lblLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.AutoSize = true;
			this.m_btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_btnCancel.Location = new System.Drawing.Point(280, 172);
			this.m_btnCancel.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
			this.m_btnCancel.MinimumSize = new System.Drawing.Size(75, 23);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(75, 23);
			this.m_btnCancel.TabIndex = 10;
			this.m_btnCancel.Text = "Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			// 
			// m_lblDisplayedText
			// 
			this.m_lblDisplayedText.AutoSize = true;
			this.m_tlpMainPanel.SetColumnSpan(this.m_lblDisplayedText, 3);
			this.m_lblDisplayedText.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_lblDisplayedText.Location = new System.Drawing.Point(0, 28);
			this.m_lblDisplayedText.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.m_lblDisplayedText.Name = "m_lblDisplayedText";
			this.m_lblDisplayedText.Size = new System.Drawing.Size(355, 13);
			this.m_lblDisplayedText.TabIndex = 4;
			this.m_lblDisplayedText.Text = "&Displayed Text:";
			// 
			// m_tbxDisplayedText
			// 
			this.m_tlpMainPanel.SetColumnSpan(this.m_tbxDisplayedText, 3);
			this.m_tbxDisplayedText.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tbxDisplayedText.Location = new System.Drawing.Point(3, 49);
			this.m_tbxDisplayedText.Margin = new System.Windows.Forms.Padding(3, 0, 0, 11);
			this.m_tbxDisplayedText.MinimumSize = new System.Drawing.Size(250, 4);
			this.m_tbxDisplayedText.Name = "m_tbxDisplayedText";
			this.m_tbxDisplayedText.Size = new System.Drawing.Size(352, 20);
			this.m_tbxDisplayedText.TabIndex = 5;
			this.m_tbxDisplayedText.TextChanged += new System.EventHandler(this.LinkParameter_Changed);
			// 
			// m_btnOK
			// 
			this.m_btnOK.AutoSize = true;
			this.m_btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btnOK.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_btnOK.Enabled = false;
			this.m_btnOK.Location = new System.Drawing.Point(194, 172);
			this.m_btnOK.Margin = new System.Windows.Forms.Padding(0);
			this.m_btnOK.MinimumSize = new System.Drawing.Size(75, 23);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(75, 23);
			this.m_btnOK.TabIndex = 9;
			this.m_btnOK.Text = "OK";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OK_Click);
			// 
			// m_tlpLinkType
			// 
			this.m_tlpLinkType.AutoSize = true;
			this.m_tlpLinkType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_tlpLinkType.ColumnCount = 4;
			this.m_tlpMainPanel.SetColumnSpan(this.m_tlpLinkType, 3);
			this.m_tlpLinkType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpLinkType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpLinkType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpLinkType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpLinkType.Controls.Add(this.m_rbtnTypeDocumentLink, 2, 0);
			this.m_tlpLinkType.Controls.Add(this.m_lblLinkType, 0, 0);
			this.m_tlpLinkType.Controls.Add(this.m_rbtnTypeHyperlink, 1, 0);
			this.m_tlpLinkType.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tlpLinkType.Location = new System.Drawing.Point(0, 0);
			this.m_tlpLinkType.Margin = new System.Windows.Forms.Padding(0, 0, 0, 11);
			this.m_tlpLinkType.Name = "m_tlpLinkType";
			this.m_tlpLinkType.RowCount = 1;
			this.m_tlpLinkType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpLinkType.Size = new System.Drawing.Size(355, 17);
			this.m_tlpLinkType.TabIndex = 1;
			// 
			// m_rbtnTypeDocumentLink
			// 
			this.m_rbtnTypeDocumentLink.AutoSize = true;
			this.m_rbtnTypeDocumentLink.Location = new System.Drawing.Point(148, 0);
			this.m_rbtnTypeDocumentLink.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
			this.m_rbtnTypeDocumentLink.Name = "m_rbtnTypeDocumentLink";
			this.m_rbtnTypeDocumentLink.Size = new System.Drawing.Size(97, 17);
			this.m_rbtnTypeDocumentLink.TabIndex = 4;
			this.m_rbtnTypeDocumentLink.Text = "D&ocument Link";
			this.m_rbtnTypeDocumentLink.UseVisualStyleBackColor = true;
			// 
			// m_lblLinkType
			// 
			this.m_lblLinkType.AutoSize = true;
			this.m_lblLinkType.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_lblLinkType.Location = new System.Drawing.Point(0, 0);
			this.m_lblLinkType.Margin = new System.Windows.Forms.Padding(0);
			this.m_lblLinkType.Name = "m_lblLinkType";
			this.m_lblLinkType.Size = new System.Drawing.Size(57, 17);
			this.m_lblLinkType.TabIndex = 2;
			this.m_lblLinkType.Text = "Link &Type:";
			this.m_lblLinkType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_rbtnTypeHyperlink
			// 
			this.m_rbtnTypeHyperlink.AutoSize = true;
			this.m_rbtnTypeHyperlink.Checked = true;
			this.m_rbtnTypeHyperlink.Location = new System.Drawing.Point(68, 0);
			this.m_rbtnTypeHyperlink.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
			this.m_rbtnTypeHyperlink.Name = "m_rbtnTypeHyperlink";
			this.m_rbtnTypeHyperlink.Size = new System.Drawing.Size(69, 17);
			this.m_rbtnTypeHyperlink.TabIndex = 3;
			this.m_rbtnTypeHyperlink.TabStop = true;
			this.m_rbtnTypeHyperlink.Text = "&Hyperlink";
			this.m_rbtnTypeHyperlink.UseVisualStyleBackColor = true;
			this.m_rbtnTypeHyperlink.CheckedChanged += new System.EventHandler(this.Type_CheckedChanged);
			// 
			// m_cmbxDocumentTargets
			// 
			this.m_tlpMainPanel.SetColumnSpan(this.m_cmbxDocumentTargets, 3);
			this.m_cmbxDocumentTargets.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_cmbxDocumentTargets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_cmbxDocumentTargets.FormattingEnabled = true;
			this.m_cmbxDocumentTargets.Location = new System.Drawing.Point(3, 101);
			this.m_cmbxDocumentTargets.Margin = new System.Windows.Forms.Padding(3, 0, 0, 15);
			this.m_cmbxDocumentTargets.MinimumSize = new System.Drawing.Size(250, 0);
			this.m_cmbxDocumentTargets.Name = "m_cmbxDocumentTargets";
			this.m_cmbxDocumentTargets.Size = new System.Drawing.Size(352, 21);
			this.m_cmbxDocumentTargets.TabIndex = 8;
			this.m_cmbxDocumentTargets.Visible = false;
			this.m_cmbxDocumentTargets.SelectedIndexChanged += new System.EventHandler(this.LinkParameter_Changed);
			// 
			// LinkDialog
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(374, 207);
			this.Controls.Add(this.m_tlpMainPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LinkDialog";
			this.Padding = new System.Windows.Forms.Padding(8, 11, 11, 11);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.CustomLinkDialog_Load);
			this.m_tlpMainPanel.ResumeLayout(false);
			this.m_tlpMainPanel.PerformLayout();
			this.m_tlpLinkType.ResumeLayout(false);
			this.m_tlpLinkType.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel m_tlpMainPanel;
		private System.Windows.Forms.Label m_lblLink;
		private System.Windows.Forms.Label m_lblDisplayedText;
		private System.Windows.Forms.TextBox m_tbxDisplayedText;
		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.TableLayoutPanel m_tlpLinkType;
		private System.Windows.Forms.RadioButton m_rbtnTypeDocumentLink;
		private System.Windows.Forms.Label m_lblLinkType;
		private System.Windows.Forms.RadioButton m_rbtnTypeHyperlink;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.TextBox m_tbxHyperlink;
		private System.Windows.Forms.ComboBox m_cmbxDocumentTargets;
	}
}