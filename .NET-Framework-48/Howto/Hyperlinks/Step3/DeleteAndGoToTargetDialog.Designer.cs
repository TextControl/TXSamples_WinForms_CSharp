namespace Step3 {
	partial class DeleteAndGoToTargetDialog {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAndGoToTargetDialog));
			this.m_tlpMainPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_btnOK = new System.Windows.Forms.Button();
			this.m_lblCurrentDocumentTargets = new System.Windows.Forms.Label();
			this.m_tlpContentPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_lbxDocumentTargets = new System.Windows.Forms.ListBox();
			this.m_btnGoTo = new System.Windows.Forms.Button();
			this.m_btnDelete = new System.Windows.Forms.Button();
			this.m_tlpMainPanel.SuspendLayout();
			this.m_tlpContentPanel.SuspendLayout();
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
			this.m_tlpMainPanel.Controls.Add(this.m_btnCancel, 2, 2);
			this.m_tlpMainPanel.Controls.Add(this.m_btnOK, 1, 2);
			this.m_tlpMainPanel.Controls.Add(this.m_lblCurrentDocumentTargets, 0, 0);
			this.m_tlpMainPanel.Controls.Add(this.m_tlpContentPanel, 0, 1);
			this.m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_tlpMainPanel.Location = new System.Drawing.Point(8, 11);
			this.m_tlpMainPanel.Name = "m_tlpMainPanel";
			this.m_tlpMainPanel.RowCount = 3;
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.m_tlpMainPanel.Size = new System.Drawing.Size(273, 199);
			this.m_tlpMainPanel.TabIndex = 0;
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.AutoSize = true;
			this.m_btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btnCancel.Location = new System.Drawing.Point(198, 176);
			this.m_btnCancel.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
			this.m_btnCancel.MinimumSize = new System.Drawing.Size(75, 23);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(75, 23);
			this.m_btnCancel.TabIndex = 7;
			this.m_btnCancel.Text = "Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			// 
			// m_btnOK
			// 
			this.m_btnOK.AutoSize = true;
			this.m_btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btnOK.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btnOK.Location = new System.Drawing.Point(112, 176);
			this.m_btnOK.Margin = new System.Windows.Forms.Padding(0);
			this.m_btnOK.MinimumSize = new System.Drawing.Size(75, 23);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(75, 23);
			this.m_btnOK.TabIndex = 6;
			this.m_btnOK.Text = "OK";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OK_Click);
			// 
			// m_lblCurrentDocumentTargets
			// 
			this.m_lblCurrentDocumentTargets.AutoSize = true;
			this.m_tlpMainPanel.SetColumnSpan(this.m_lblCurrentDocumentTargets, 3);
			this.m_lblCurrentDocumentTargets.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_lblCurrentDocumentTargets.Location = new System.Drawing.Point(0, 0);
			this.m_lblCurrentDocumentTargets.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.m_lblCurrentDocumentTargets.Name = "m_lblCurrentDocumentTargets";
			this.m_lblCurrentDocumentTargets.Size = new System.Drawing.Size(273, 13);
			this.m_lblCurrentDocumentTargets.TabIndex = 1;
			this.m_lblCurrentDocumentTargets.Text = "Document &Targets:";
			// 
			// m_tlpContentPanel
			// 
			this.m_tlpContentPanel.AutoSize = true;
			this.m_tlpContentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_tlpContentPanel.ColumnCount = 2;
			this.m_tlpMainPanel.SetColumnSpan(this.m_tlpContentPanel, 3);
			this.m_tlpContentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpContentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpContentPanel.Controls.Add(this.m_lbxDocumentTargets, 0, 0);
			this.m_tlpContentPanel.Controls.Add(this.m_btnGoTo, 1, 1);
			this.m_tlpContentPanel.Controls.Add(this.m_btnDelete, 1, 0);
			this.m_tlpContentPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tlpContentPanel.Location = new System.Drawing.Point(0, 21);
			this.m_tlpContentPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
			this.m_tlpContentPanel.Name = "m_tlpContentPanel";
			this.m_tlpContentPanel.RowCount = 3;
			this.m_tlpContentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpContentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpContentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpContentPanel.Size = new System.Drawing.Size(273, 140);
			this.m_tlpContentPanel.TabIndex = 2;
			// 
			// m_lbxDocumentTargets
			// 
			this.m_lbxDocumentTargets.FormattingEnabled = true;
			this.m_lbxDocumentTargets.Location = new System.Drawing.Point(3, 0);
			this.m_lbxDocumentTargets.Margin = new System.Windows.Forms.Padding(3, 0, 11, 0);
			this.m_lbxDocumentTargets.MinimumSize = new System.Drawing.Size(220, 150);
			this.m_lbxDocumentTargets.Name = "m_lbxDocumentTargets";
			this.m_tlpContentPanel.SetRowSpan(this.m_lbxDocumentTargets, 3);
			this.m_lbxDocumentTargets.Size = new System.Drawing.Size(220, 147);
			this.m_lbxDocumentTargets.TabIndex = 3;
			this.m_lbxDocumentTargets.SelectedIndexChanged += new System.EventHandler(this.DocumentTargets_SelectedIndexChanged);
			// 
			// m_btnGoTo
			// 
			this.m_btnGoTo.AutoSize = true;
			this.m_btnGoTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnGoTo.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btnGoTo.Enabled = false;
			this.m_btnGoTo.Location = new System.Drawing.Point(198, 31);
			this.m_btnGoTo.Margin = new System.Windows.Forms.Padding(0);
			this.m_btnGoTo.MinimumSize = new System.Drawing.Size(75, 23);
			this.m_btnGoTo.Name = "m_btnGoTo";
			this.m_btnGoTo.Size = new System.Drawing.Size(75, 23);
			this.m_btnGoTo.TabIndex = 5;
			this.m_btnGoTo.Text = "&Go To";
			this.m_btnGoTo.UseVisualStyleBackColor = true;
			this.m_btnGoTo.Click += new System.EventHandler(this.GoTo_Click);
			// 
			// m_btnDelete
			// 
			this.m_btnDelete.AutoSize = true;
			this.m_btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btnDelete.Enabled = false;
			this.m_btnDelete.Location = new System.Drawing.Point(198, 0);
			this.m_btnDelete.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.m_btnDelete.MinimumSize = new System.Drawing.Size(75, 23);
			this.m_btnDelete.Name = "m_btnDelete";
			this.m_btnDelete.Size = new System.Drawing.Size(75, 23);
			this.m_btnDelete.TabIndex = 4;
			this.m_btnDelete.Text = "&Delete";
			this.m_btnDelete.UseVisualStyleBackColor = true;
			this.m_btnDelete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// DeleteAndGoToTargetDialog
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(292, 221);
			this.Controls.Add(this.m_tlpMainPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DeleteAndGoToTargetDialog";
			this.Padding = new System.Windows.Forms.Padding(8, 11, 11, 11);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delete and Go To Document Target";
			this.Load += new System.EventHandler(this.DeleteAndGoToTargetDialog_Load);
			this.m_tlpMainPanel.ResumeLayout(false);
			this.m_tlpMainPanel.PerformLayout();
			this.m_tlpContentPanel.ResumeLayout(false);
			this.m_tlpContentPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel m_tlpMainPanel;
		private System.Windows.Forms.Label m_lblCurrentDocumentTargets;
		private System.Windows.Forms.ListBox m_lbxDocumentTargets;
		private System.Windows.Forms.Button m_btnGoTo;
		private System.Windows.Forms.Button m_btnDelete;
		private System.Windows.Forms.TableLayoutPanel m_tlpContentPanel;
		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
	}
}