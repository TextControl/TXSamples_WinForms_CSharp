namespace Step2 {
	partial class CustomHyperlinkDialog {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomHyperlinkDialog));
			this.m_tlpMainPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_tbxLink = new System.Windows.Forms.TextBox();
			this.m_lblLink = new System.Windows.Forms.Label();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_lblHyperlinkText = new System.Windows.Forms.Label();
			this.m_tbxHyperlinkText = new System.Windows.Forms.TextBox();
			this.m_btnOK = new System.Windows.Forms.Button();
			this.m_tlpMainPanel.SuspendLayout();
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
			this.m_tlpMainPanel.Controls.Add(this.m_tbxLink, 0, 3);
			this.m_tlpMainPanel.Controls.Add(this.m_lblLink, 0, 2);
			this.m_tlpMainPanel.Controls.Add(this.m_btnCancel, 2, 4);
			this.m_tlpMainPanel.Controls.Add(this.m_lblHyperlinkText, 0, 0);
			this.m_tlpMainPanel.Controls.Add(this.m_tbxHyperlinkText, 0, 1);
			this.m_tlpMainPanel.Controls.Add(this.m_btnOK, 1, 4);
			this.m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_tlpMainPanel.Location = new System.Drawing.Point(8, 11);
			this.m_tlpMainPanel.Margin = new System.Windows.Forms.Padding(0);
			this.m_tlpMainPanel.Name = "m_tlpMainPanel";
			this.m_tlpMainPanel.RowCount = 5;
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.Size = new System.Drawing.Size(311, 140);
			this.m_tlpMainPanel.TabIndex = 0;
			// 
			// m_tbxLink
			// 
			this.m_tlpMainPanel.SetColumnSpan(this.m_tbxLink, 3);
			this.m_tbxLink.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tbxLink.Location = new System.Drawing.Point(3, 73);
			this.m_tbxLink.Margin = new System.Windows.Forms.Padding(3, 0, 0, 15);
			this.m_tbxLink.MinimumSize = new System.Drawing.Size(250, 4);
			this.m_tbxLink.Name = "m_tbxLink";
			this.m_tbxLink.Size = new System.Drawing.Size(308, 20);
			this.m_tbxLink.TabIndex = 4;
			this.m_tbxLink.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// m_lblLink
			// 
			this.m_lblLink.AutoSize = true;
			this.m_tlpMainPanel.SetColumnSpan(this.m_lblLink, 3);
			this.m_lblLink.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_lblLink.Location = new System.Drawing.Point(0, 52);
			this.m_lblLink.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.m_lblLink.Name = "m_lblLink";
			this.m_lblLink.Size = new System.Drawing.Size(311, 13);
			this.m_lblLink.TabIndex = 3;
			this.m_lblLink.Text = "&Link:";
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.AutoSize = true;
			this.m_btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btnCancel.Location = new System.Drawing.Point(236, 108);
			this.m_btnCancel.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
			this.m_btnCancel.MinimumSize = new System.Drawing.Size(75, 23);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(75, 23);
			this.m_btnCancel.TabIndex = 6;
			this.m_btnCancel.Text = "Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			// 
			// m_lblHyperlinkText
			// 
			this.m_lblHyperlinkText.AutoSize = true;
			this.m_tlpMainPanel.SetColumnSpan(this.m_lblHyperlinkText, 3);
			this.m_lblHyperlinkText.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_lblHyperlinkText.Location = new System.Drawing.Point(0, 0);
			this.m_lblHyperlinkText.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.m_lblHyperlinkText.Name = "m_lblHyperlinkText";
			this.m_lblHyperlinkText.Size = new System.Drawing.Size(311, 13);
			this.m_lblHyperlinkText.TabIndex = 1;
			this.m_lblHyperlinkText.Text = "&Hyperlink Text:";
			// 
			// m_tbxHyperlinkText
			// 
			this.m_tlpMainPanel.SetColumnSpan(this.m_tbxHyperlinkText, 3);
			this.m_tbxHyperlinkText.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tbxHyperlinkText.Location = new System.Drawing.Point(3, 21);
			this.m_tbxHyperlinkText.Margin = new System.Windows.Forms.Padding(3, 0, 0, 11);
			this.m_tbxHyperlinkText.MinimumSize = new System.Drawing.Size(250, 4);
			this.m_tbxHyperlinkText.Name = "m_tbxHyperlinkText";
			this.m_tbxHyperlinkText.Size = new System.Drawing.Size(308, 20);
			this.m_tbxHyperlinkText.TabIndex = 2;
			this.m_tbxHyperlinkText.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// m_btnOK
			// 
			this.m_btnOK.AutoSize = true;
			this.m_btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btnOK.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btnOK.Enabled = false;
			this.m_btnOK.Location = new System.Drawing.Point(150, 108);
			this.m_btnOK.Margin = new System.Windows.Forms.Padding(0);
			this.m_btnOK.MinimumSize = new System.Drawing.Size(75, 23);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(75, 23);
			this.m_btnOK.TabIndex = 5;
			this.m_btnOK.Text = "OK";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OK_Click);
			// 
			// CustomHyperlinkDialog
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(330, 162);
			this.Controls.Add(this.m_tlpMainPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CustomHyperlinkDialog";
			this.Padding = new System.Windows.Forms.Padding(8, 11, 11, 11);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.CustomHyperlinkDialog_Load);
			this.m_tlpMainPanel.ResumeLayout(false);
			this.m_tlpMainPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel m_tlpMainPanel;
		private System.Windows.Forms.TextBox m_tbxLink;
		private System.Windows.Forms.Label m_lblLink;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.Label m_lblHyperlinkText;
		private System.Windows.Forms.TextBox m_tbxHyperlinkText;
		private System.Windows.Forms.Button m_btnOK;
	}
}