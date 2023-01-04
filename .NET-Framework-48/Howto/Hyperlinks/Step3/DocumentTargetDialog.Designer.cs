namespace Step3 {
	partial class DocumentTargetDialog {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentTargetDialog));
			this.m_tlpMainPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_lbxAllDocumentTargets = new System.Windows.Forms.ListBox();
			this.m_btnOK = new System.Windows.Forms.Button();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_lblCurrentDocumentTargets = new System.Windows.Forms.Label();
			this.m_lbxCurrentDocumentTargets = new System.Windows.Forms.ListBox();
			this.m_lblAllDocumentTargets = new System.Windows.Forms.Label();
			this.m_chbxCanBeDeleted = new System.Windows.Forms.CheckBox();
			this.m_tlpNamePanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_lblName = new System.Windows.Forms.Label();
			this.m_tbxTargetName = new System.Windows.Forms.TextBox();
			this.m_btnChangeName = new System.Windows.Forms.Button();
			this.m_tlpMainPanel.SuspendLayout();
			this.m_tlpNamePanel.SuspendLayout();
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
			this.m_tlpMainPanel.Controls.Add(this.m_lbxAllDocumentTargets, 0, 4);
			this.m_tlpMainPanel.Controls.Add(this.m_btnOK, 1, 6);
			this.m_tlpMainPanel.Controls.Add(this.m_btnCancel, 2, 6);
			this.m_tlpMainPanel.Controls.Add(this.m_lblCurrentDocumentTargets, 0, 1);
			this.m_tlpMainPanel.Controls.Add(this.m_lbxCurrentDocumentTargets, 0, 2);
			this.m_tlpMainPanel.Controls.Add(this.m_lblAllDocumentTargets, 0, 3);
			this.m_tlpMainPanel.Controls.Add(this.m_chbxCanBeDeleted, 0, 5);
			this.m_tlpMainPanel.Controls.Add(this.m_tlpNamePanel, 0, 0);
			this.m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_tlpMainPanel.Location = new System.Drawing.Point(8, 11);
			this.m_tlpMainPanel.Margin = new System.Windows.Forms.Padding(0);
			this.m_tlpMainPanel.Name = "m_tlpMainPanel";
			this.m_tlpMainPanel.RowCount = 7;
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.m_tlpMainPanel.Size = new System.Drawing.Size(340, 323);
			this.m_tlpMainPanel.TabIndex = 0;
			// 
			// m_lbxAllDocumentTargets
			// 
			this.m_tlpMainPanel.SetColumnSpan(this.m_lbxAllDocumentTargets, 3);
			this.m_lbxAllDocumentTargets.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_lbxAllDocumentTargets.FormattingEnabled = true;
			this.m_lbxAllDocumentTargets.Location = new System.Drawing.Point(3, 182);
			this.m_lbxAllDocumentTargets.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
			this.m_lbxAllDocumentTargets.MinimumSize = new System.Drawing.Size(320, 100);
			this.m_lbxAllDocumentTargets.Name = "m_lbxAllDocumentTargets";
			this.m_lbxAllDocumentTargets.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.m_lbxAllDocumentTargets.Size = new System.Drawing.Size(337, 95);
			this.m_lbxAllDocumentTargets.TabIndex = 7;
			// 
			// m_btnOK
			// 
			this.m_btnOK.AutoSize = true;
			this.m_btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btnOK.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btnOK.Location = new System.Drawing.Point(179, 313);
			this.m_btnOK.Margin = new System.Windows.Forms.Padding(0);
			this.m_btnOK.MinimumSize = new System.Drawing.Size(75, 23);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(75, 23);
			this.m_btnOK.TabIndex = 9;
			this.m_btnOK.Text = "OK";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OK_Click);
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.AutoSize = true;
			this.m_btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btnCancel.Location = new System.Drawing.Point(265, 313);
			this.m_btnCancel.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
			this.m_btnCancel.MinimumSize = new System.Drawing.Size(75, 23);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(75, 23);
			this.m_btnCancel.TabIndex = 10;
			this.m_btnCancel.Text = "Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			// 
			// m_lblCurrentDocumentTargets
			// 
			this.m_lblCurrentDocumentTargets.AutoSize = true;
			this.m_tlpMainPanel.SetColumnSpan(this.m_lblCurrentDocumentTargets, 3);
			this.m_lblCurrentDocumentTargets.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_lblCurrentDocumentTargets.Location = new System.Drawing.Point(0, 34);
			this.m_lblCurrentDocumentTargets.Margin = new System.Windows.Forms.Padding(0, 11, 0, 0);
			this.m_lblCurrentDocumentTargets.Name = "m_lblCurrentDocumentTargets";
			this.m_lblCurrentDocumentTargets.Size = new System.Drawing.Size(340, 13);
			this.m_lblCurrentDocumentTargets.TabIndex = 4;
			this.m_lblCurrentDocumentTargets.Text = "&Document targets at current input position:";
			// 
			// m_lbxCurrentDocumentTargets
			// 
			this.m_tlpMainPanel.SetColumnSpan(this.m_lbxCurrentDocumentTargets, 3);
			this.m_lbxCurrentDocumentTargets.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_lbxCurrentDocumentTargets.FormattingEnabled = true;
			this.m_lbxCurrentDocumentTargets.Location = new System.Drawing.Point(3, 55);
			this.m_lbxCurrentDocumentTargets.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
			this.m_lbxCurrentDocumentTargets.MinimumSize = new System.Drawing.Size(320, 100);
			this.m_lbxCurrentDocumentTargets.Name = "m_lbxCurrentDocumentTargets";
			this.m_lbxCurrentDocumentTargets.Size = new System.Drawing.Size(337, 95);
			this.m_lbxCurrentDocumentTargets.TabIndex = 5;
			this.m_lbxCurrentDocumentTargets.SelectedIndexChanged += new System.EventHandler(this.CurrentDocumentTargets_SelectedIndexChanged);
			// 
			// m_lblAllDocumentTargets
			// 
			this.m_lblAllDocumentTargets.AutoSize = true;
			this.m_tlpMainPanel.SetColumnSpan(this.m_lblAllDocumentTargets, 3);
			this.m_lblAllDocumentTargets.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_lblAllDocumentTargets.Location = new System.Drawing.Point(0, 161);
			this.m_lblAllDocumentTargets.Margin = new System.Windows.Forms.Padding(0, 11, 0, 0);
			this.m_lblAllDocumentTargets.Name = "m_lblAllDocumentTargets";
			this.m_lblAllDocumentTargets.Size = new System.Drawing.Size(340, 13);
			this.m_lblAllDocumentTargets.TabIndex = 6;
			this.m_lblAllDocumentTargets.Text = "D&ocument targets in document:";
			// 
			// m_chbxCanBeDeleted
			// 
			this.m_chbxCanBeDeleted.AutoSize = true;
			this.m_chbxCanBeDeleted.Checked = true;
			this.m_chbxCanBeDeleted.CheckState = System.Windows.Forms.CheckState.Checked;
			this.m_tlpMainPanel.SetColumnSpan(this.m_chbxCanBeDeleted, 3);
			this.m_chbxCanBeDeleted.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_chbxCanBeDeleted.Location = new System.Drawing.Point(3, 288);
			this.m_chbxCanBeDeleted.Margin = new System.Windows.Forms.Padding(3, 11, 0, 8);
			this.m_chbxCanBeDeleted.Name = "m_chbxCanBeDeleted";
			this.m_chbxCanBeDeleted.Size = new System.Drawing.Size(337, 17);
			this.m_chbxCanBeDeleted.TabIndex = 8;
			this.m_chbxCanBeDeleted.Text = "&Can be deleted during editing";
			this.m_chbxCanBeDeleted.UseVisualStyleBackColor = true;
			this.m_chbxCanBeDeleted.CheckedChanged += new System.EventHandler(this.CanBeDeleted_CheckedChanged);
			// 
			// m_tlpNamePanel
			// 
			this.m_tlpNamePanel.AutoSize = true;
			this.m_tlpNamePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_tlpNamePanel.ColumnCount = 3;
			this.m_tlpMainPanel.SetColumnSpan(this.m_tlpNamePanel, 3);
			this.m_tlpNamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpNamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpNamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpNamePanel.Controls.Add(this.m_lblName, 0, 0);
			this.m_tlpNamePanel.Controls.Add(this.m_tbxTargetName, 1, 0);
			this.m_tlpNamePanel.Controls.Add(this.m_btnChangeName, 2, 0);
			this.m_tlpNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tlpNamePanel.Location = new System.Drawing.Point(0, 0);
			this.m_tlpNamePanel.Margin = new System.Windows.Forms.Padding(0);
			this.m_tlpNamePanel.Name = "m_tlpNamePanel";
			this.m_tlpNamePanel.RowCount = 1;
			this.m_tlpNamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpNamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
			this.m_tlpNamePanel.Size = new System.Drawing.Size(340, 23);
			this.m_tlpNamePanel.TabIndex = 11;
			// 
			// m_lblName
			// 
			this.m_lblName.AutoSize = true;
			this.m_lblName.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_lblName.Location = new System.Drawing.Point(0, 0);
			this.m_lblName.Margin = new System.Windows.Forms.Padding(0);
			this.m_lblName.Name = "m_lblName";
			this.m_lblName.Size = new System.Drawing.Size(72, 23);
			this.m_lblName.TabIndex = 1;
			this.m_lblName.Text = "&Target Name:";
			this.m_lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_tbxTargetName
			// 
			this.m_tbxTargetName.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tbxTargetName.Location = new System.Drawing.Point(83, 2);
			this.m_tbxTargetName.Margin = new System.Windows.Forms.Padding(11, 2, 0, 0);
			this.m_tbxTargetName.Name = "m_tbxTargetName";
			this.m_tbxTargetName.Size = new System.Drawing.Size(206, 20);
			this.m_tbxTargetName.TabIndex = 2;
			this.m_tbxTargetName.TextChanged += new System.EventHandler(this.TargetName_TextChanged);
			// 
			// m_btnChangeName
			// 
			this.m_btnChangeName.AutoSize = true;
			this.m_btnChangeName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnChangeName.Dock = System.Windows.Forms.DockStyle.Right;
			this.m_btnChangeName.Location = new System.Drawing.Point(300, 0);
			this.m_btnChangeName.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
			this.m_btnChangeName.MinimumSize = new System.Drawing.Size(40, 23);
			this.m_btnChangeName.Name = "m_btnChangeName";
			this.m_btnChangeName.Size = new System.Drawing.Size(40, 23);
			this.m_btnChangeName.TabIndex = 3;
			this.m_btnChangeName.Text = "✔";
			this.m_btnChangeName.UseVisualStyleBackColor = true;
			this.m_btnChangeName.Click += new System.EventHandler(this.ChangeName_Click);
			// 
			// DocumentTargetDialog
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(359, 345);
			this.Controls.Add(this.m_tlpMainPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DocumentTargetDialog";
			this.Padding = new System.Windows.Forms.Padding(8, 11, 11, 11);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.DocumentTargetDialog_Load);
			this.m_tlpMainPanel.ResumeLayout(false);
			this.m_tlpMainPanel.PerformLayout();
			this.m_tlpNamePanel.ResumeLayout(false);
			this.m_tlpNamePanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel m_tlpMainPanel;
		private System.Windows.Forms.ListBox m_lbxAllDocumentTargets;
		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Label m_lblName;
		private System.Windows.Forms.TextBox m_tbxTargetName;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.Label m_lblCurrentDocumentTargets;
		private System.Windows.Forms.ListBox m_lbxCurrentDocumentTargets;
		private System.Windows.Forms.Label m_lblAllDocumentTargets;
		private System.Windows.Forms.CheckBox m_chbxCanBeDeleted;
		private System.Windows.Forms.TableLayoutPanel m_tlpNamePanel;
		private System.Windows.Forms.Button m_btnChangeName;
	}
}