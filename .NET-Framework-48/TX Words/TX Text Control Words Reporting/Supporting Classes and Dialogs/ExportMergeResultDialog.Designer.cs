namespace TXTextControl.Words {
	partial class ExportMergeResultDialog {
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
			this.m_tlpMainPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_btnOpenFolderBrowser = new System.Windows.Forms.Button();
			this.m_lblFilePrefix = new System.Windows.Forms.Label();
			this.m_lblDirectory = new System.Windows.Forms.Label();
			this.m_lblFormat = new System.Windows.Forms.Label();
			this.m_tbxDirectory = new System.Windows.Forms.TextBox();
			this.m_tbxFilePrefix = new System.Windows.Forms.TextBox();
			this.m_cmbxFormat = new System.Windows.Forms.ComboBox();
			this.m_tlpBottomPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_btnOK = new System.Windows.Forms.Button();
			this.m_chbxopenDirectory = new System.Windows.Forms.CheckBox();
			this.m_tlpMainPanel.SuspendLayout();
			this.m_tlpBottomPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_tlpMainPanel
			// 
			this.m_tlpMainPanel.AutoSize = true;
			this.m_tlpMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_tlpMainPanel.ColumnCount = 3;
			this.m_tlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpMainPanel.Controls.Add(this.m_btnOpenFolderBrowser, 2, 1);
			this.m_tlpMainPanel.Controls.Add(this.m_lblFilePrefix, 0, 0);
			this.m_tlpMainPanel.Controls.Add(this.m_lblDirectory, 0, 1);
			this.m_tlpMainPanel.Controls.Add(this.m_lblFormat, 0, 2);
			this.m_tlpMainPanel.Controls.Add(this.m_tbxDirectory, 1, 1);
			this.m_tlpMainPanel.Controls.Add(this.m_tbxFilePrefix, 1, 0);
			this.m_tlpMainPanel.Controls.Add(this.m_cmbxFormat, 1, 2);
			this.m_tlpMainPanel.Controls.Add(this.m_tlpBottomPanel, 0, 4);
			this.m_tlpMainPanel.Controls.Add(this.m_chbxopenDirectory, 0, 3);
			this.m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_tlpMainPanel.Location = new System.Drawing.Point(11, 11);
			this.m_tlpMainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.m_tlpMainPanel.Name = "m_tlpMainPanel";
			this.m_tlpMainPanel.RowCount = 5;
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.Size = new System.Drawing.Size(275, 156);
			this.m_tlpMainPanel.TabIndex = 0;
			// 
			// m_btnOpenFolderBrowser
			// 
			this.m_btnOpenFolderBrowser.AutoSize = true;
			this.m_btnOpenFolderBrowser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnOpenFolderBrowser.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btnOpenFolderBrowser.Location = new System.Drawing.Point(249, 31);
			this.m_btnOpenFolderBrowser.Margin = new System.Windows.Forms.Padding(11, 0, 0, 8);
			this.m_btnOpenFolderBrowser.MaximumSize = new System.Drawing.Size(47, 923);
			this.m_btnOpenFolderBrowser.Name = "m_btnOpenFolderBrowser";
			this.m_btnOpenFolderBrowser.Size = new System.Drawing.Size(26, 25);
			this.m_btnOpenFolderBrowser.TabIndex = 5;
			this.m_btnOpenFolderBrowser.Text = "...";
			this.m_btnOpenFolderBrowser.UseVisualStyleBackColor = true;
			this.m_btnOpenFolderBrowser.Click += new System.EventHandler(this.OpenFolderBrowser_Click);
			// 
			// m_lblFilePrefix
			// 
			this.m_lblFilePrefix.AutoSize = true;
			this.m_lblFilePrefix.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_lblFilePrefix.Location = new System.Drawing.Point(0, 0);
			this.m_lblFilePrefix.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.m_lblFilePrefix.Name = "m_lblFilePrefix";
			this.m_lblFilePrefix.Size = new System.Drawing.Size(61, 23);
			this.m_lblFilePrefix.TabIndex = 1;
			this.m_lblFilePrefix.Text = "File &Prefix:";
			this.m_lblFilePrefix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_lblDirectory
			// 
			this.m_lblDirectory.AutoSize = true;
			this.m_lblDirectory.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_lblDirectory.Location = new System.Drawing.Point(0, 31);
			this.m_lblDirectory.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.m_lblDirectory.Name = "m_lblDirectory";
			this.m_lblDirectory.Size = new System.Drawing.Size(58, 25);
			this.m_lblDirectory.TabIndex = 3;
			this.m_lblDirectory.Text = "&Directory:";
			this.m_lblDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_lblFormat
			// 
			this.m_lblFormat.AutoSize = true;
			this.m_lblFormat.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_lblFormat.Location = new System.Drawing.Point(0, 64);
			this.m_lblFormat.Margin = new System.Windows.Forms.Padding(0);
			this.m_lblFormat.Name = "m_lblFormat";
			this.m_lblFormat.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.m_lblFormat.Size = new System.Drawing.Size(48, 31);
			this.m_lblFormat.TabIndex = 6;
			this.m_lblFormat.Text = "&Format:";
			this.m_lblFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_tbxDirectory
			// 
			this.m_tbxDirectory.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tbxDirectory.Location = new System.Drawing.Point(72, 32);
			this.m_tbxDirectory.Margin = new System.Windows.Forms.Padding(11, 1, 0, 8);
			this.m_tbxDirectory.MinimumSize = new System.Drawing.Size(233, 4);
			this.m_tbxDirectory.Name = "m_tbxDirectory";
			this.m_tbxDirectory.Size = new System.Drawing.Size(233, 23);
			this.m_tbxDirectory.TabIndex = 4;
			this.m_tbxDirectory.TextChanged += new System.EventHandler(this.Directory_TextChanged);
			// 
			// m_tbxFilePrefix
			// 
			this.m_tlpMainPanel.SetColumnSpan(this.m_tbxFilePrefix, 2);
			this.m_tbxFilePrefix.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tbxFilePrefix.Location = new System.Drawing.Point(72, 0);
			this.m_tbxFilePrefix.Margin = new System.Windows.Forms.Padding(11, 0, 0, 8);
			this.m_tbxFilePrefix.Name = "m_tbxFilePrefix";
			this.m_tbxFilePrefix.Size = new System.Drawing.Size(203, 23);
			this.m_tbxFilePrefix.TabIndex = 2;
			// 
			// m_cmbxFormat
			// 
			this.m_tlpMainPanel.SetColumnSpan(this.m_cmbxFormat, 2);
			this.m_cmbxFormat.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_cmbxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_cmbxFormat.FormattingEnabled = true;
			this.m_cmbxFormat.Location = new System.Drawing.Point(72, 64);
			this.m_cmbxFormat.Margin = new System.Windows.Forms.Padding(11, 0, 0, 8);
			this.m_cmbxFormat.Name = "m_cmbxFormat";
			this.m_cmbxFormat.Size = new System.Drawing.Size(203, 23);
			this.m_cmbxFormat.TabIndex = 7;
			// 
			// m_tlpBottomPanel
			// 
			this.m_tlpBottomPanel.AutoSize = true;
			this.m_tlpBottomPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_tlpBottomPanel.ColumnCount = 3;
			this.m_tlpMainPanel.SetColumnSpan(this.m_tlpBottomPanel, 3);
			this.m_tlpBottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpBottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpBottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpBottomPanel.Controls.Add(this.m_btnCancel, 2, 0);
			this.m_tlpBottomPanel.Controls.Add(this.m_btnOK, 1, 0);
			this.m_tlpBottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tlpBottomPanel.Location = new System.Drawing.Point(0, 134);
			this.m_tlpBottomPanel.Margin = new System.Windows.Forms.Padding(0, 17, 0, 0);
			this.m_tlpBottomPanel.Name = "m_tlpBottomPanel";
			this.m_tlpBottomPanel.RowCount = 1;
			this.m_tlpBottomPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpBottomPanel.Size = new System.Drawing.Size(275, 27);
			this.m_tlpBottomPanel.TabIndex = 9;
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.AutoSize = true;
			this.m_btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btnCancel.Location = new System.Drawing.Point(187, 0);
			this.m_btnCancel.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.m_btnCancel.MinimumSize = new System.Drawing.Size(88, 27);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(88, 27);
			this.m_btnCancel.TabIndex = 11;
			this.m_btnCancel.Text = "Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			// 
			// m_btnOK
			// 
			this.m_btnOK.AutoSize = true;
			this.m_btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnOK.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btnOK.Enabled = false;
			this.m_btnOK.Location = new System.Drawing.Point(86, 0);
			this.m_btnOK.Margin = new System.Windows.Forms.Padding(0);
			this.m_btnOK.MinimumSize = new System.Drawing.Size(88, 27);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(88, 27);
			this.m_btnOK.TabIndex = 10;
			this.m_btnOK.Text = "OK";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OK_Click);
			// 
			// m_chbxopenDirectory
			// 
			this.m_chbxopenDirectory.AutoSize = true;
			this.m_tlpMainPanel.SetColumnSpan(this.m_chbxopenDirectory, 3);
			this.m_chbxopenDirectory.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_chbxopenDirectory.Location = new System.Drawing.Point(3, 98);
			this.m_chbxopenDirectory.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.m_chbxopenDirectory.Name = "m_chbxopenDirectory";
			this.m_chbxopenDirectory.Size = new System.Drawing.Size(272, 19);
			this.m_chbxopenDirectory.TabIndex = 8;
			this.m_chbxopenDirectory.Text = "&Open directory after export";
			this.m_chbxopenDirectory.UseVisualStyleBackColor = true;
			// 
			// ExportMergeResultDialog
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(297, 178);
			this.Controls.Add(this.m_tlpMainPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExportMergeResultDialog";
			this.Padding = new System.Windows.Forms.Padding(11);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Export Merge Result";
			this.m_tlpMainPanel.ResumeLayout(false);
			this.m_tlpMainPanel.PerformLayout();
			this.m_tlpBottomPanel.ResumeLayout(false);
			this.m_tlpBottomPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel m_tlpMainPanel;
		private System.Windows.Forms.Button m_btnOpenFolderBrowser;
		private System.Windows.Forms.Label m_lblFilePrefix;
		private System.Windows.Forms.Label m_lblDirectory;
		private System.Windows.Forms.Label m_lblFormat;
		private System.Windows.Forms.TextBox m_tbxDirectory;
		private System.Windows.Forms.TextBox m_tbxFilePrefix;
		private System.Windows.Forms.ComboBox m_cmbxFormat;
		private System.Windows.Forms.TableLayoutPanel m_tlpBottomPanel;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.CheckBox m_chbxopenDirectory;
	}
}