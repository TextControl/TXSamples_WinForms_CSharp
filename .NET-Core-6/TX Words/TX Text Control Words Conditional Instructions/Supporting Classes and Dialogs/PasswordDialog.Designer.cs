
namespace TXTextControl.Words {
	partial class PasswordDialog {
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
			this.m_lblEnterPassword = new System.Windows.Forms.Label();
			this.m_lbProtectedDocument = new System.Windows.Forms.Label();
			this.m_lblPassword = new System.Windows.Forms.Label();
			this.m_tbxPassword = new System.Windows.Forms.TextBox();
			this.m_tlpButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_btnOK = new System.Windows.Forms.Button();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_tlpMainPanel.SuspendLayout();
			this.m_tlpButtonsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_tlpMainPanel
			// 
			this.m_tlpMainPanel.AutoSize = true;
			this.m_tlpMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_tlpMainPanel.ColumnCount = 2;
			this.m_tlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpMainPanel.Controls.Add(this.m_lblEnterPassword, 0, 1);
			this.m_tlpMainPanel.Controls.Add(this.m_lbProtectedDocument, 0, 0);
			this.m_tlpMainPanel.Controls.Add(this.m_lblPassword, 0, 2);
			this.m_tlpMainPanel.Controls.Add(this.m_tbxPassword, 1, 2);
			this.m_tlpMainPanel.Controls.Add(this.m_tlpButtonsPanel, 0, 3);
			this.m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_tlpMainPanel.Location = new System.Drawing.Point(9, 13);
			this.m_tlpMainPanel.Margin = new System.Windows.Forms.Padding(0);
			this.m_tlpMainPanel.Name = "m_tlpMainPanel";
			this.m_tlpMainPanel.RowCount = 5;
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpMainPanel.Size = new System.Drawing.Size(334, 105);
			this.m_tlpMainPanel.TabIndex = 0;
			// 
			// m_lblEnterPassword
			// 
			this.m_lblEnterPassword.AutoSize = true;
			this.m_tlpMainPanel.SetColumnSpan(this.m_lblEnterPassword, 2);
			this.m_lblEnterPassword.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_lblEnterPassword.Location = new System.Drawing.Point(0, 23);
			this.m_lblEnterPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 11);
			this.m_lblEnterPassword.Name = "m_lblEnterPassword";
			this.m_lblEnterPassword.Size = new System.Drawing.Size(334, 15);
			this.m_lblEnterPassword.TabIndex = 2;
			this.m_lblEnterPassword.Text = "Enter a password to open the document.";
			this.m_lblEnterPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_lbProtectedDocument
			// 
			this.m_lbProtectedDocument.AutoSize = true;
			this.m_tlpMainPanel.SetColumnSpan(this.m_lbProtectedDocument, 2);
			this.m_lbProtectedDocument.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_lbProtectedDocument.Location = new System.Drawing.Point(0, 0);
			this.m_lbProtectedDocument.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.m_lbProtectedDocument.Name = "m_lbProtectedDocument";
			this.m_lbProtectedDocument.Size = new System.Drawing.Size(334, 15);
			this.m_lbProtectedDocument.TabIndex = 1;
			this.m_lbProtectedDocument.Text = "\'{0}\' is protected.";
			this.m_lbProtectedDocument.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_lblPassword
			// 
			this.m_lblPassword.AutoSize = true;
			this.m_lblPassword.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_lblPassword.Location = new System.Drawing.Point(0, 49);
			this.m_lblPassword.Margin = new System.Windows.Forms.Padding(0);
			this.m_lblPassword.Name = "m_lblPassword";
			this.m_lblPassword.Size = new System.Drawing.Size(60, 23);
			this.m_lblPassword.TabIndex = 3;
			this.m_lblPassword.Text = "Password:";
			this.m_lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_tbxPassword
			// 
			this.m_tbxPassword.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tbxPassword.Location = new System.Drawing.Point(71, 49);
			this.m_tbxPassword.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
			this.m_tbxPassword.MinimumSize = new System.Drawing.Size(233, 4);
			this.m_tbxPassword.Name = "m_tbxPassword";
			this.m_tbxPassword.Size = new System.Drawing.Size(263, 23);
			this.m_tbxPassword.TabIndex = 4;
			this.m_tbxPassword.UseSystemPasswordChar = true;
			this.m_tbxPassword.TextChanged += new System.EventHandler(this.Password_TextChanged);
			// 
			// m_tlpButtonsPanel
			// 
			this.m_tlpButtonsPanel.AutoSize = true;
			this.m_tlpButtonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_tlpButtonsPanel.ColumnCount = 3;
			this.m_tlpMainPanel.SetColumnSpan(this.m_tlpButtonsPanel, 2);
			this.m_tlpButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.m_tlpButtonsPanel.Controls.Add(this.m_btnOK, 1, 0);
			this.m_tlpButtonsPanel.Controls.Add(this.m_btnCancel, 2, 0);
			this.m_tlpButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tlpButtonsPanel.Location = new System.Drawing.Point(0, 87);
			this.m_tlpButtonsPanel.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
			this.m_tlpButtonsPanel.Name = "m_tlpButtonsPanel";
			this.m_tlpButtonsPanel.RowCount = 1;
			this.m_tlpButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpButtonsPanel.Size = new System.Drawing.Size(334, 27);
			this.m_tlpButtonsPanel.TabIndex = 5;
			// 
			// m_btnOK
			// 
			this.m_btnOK.AutoSize = true;
			this.m_btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnOK.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btnOK.Enabled = false;
			this.m_btnOK.Location = new System.Drawing.Point(147, 0);
			this.m_btnOK.Margin = new System.Windows.Forms.Padding(0);
			this.m_btnOK.MinimumSize = new System.Drawing.Size(87, 27);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(87, 27);
			this.m_btnOK.TabIndex = 6;
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
			this.m_btnCancel.Location = new System.Drawing.Point(247, 0);
			this.m_btnCancel.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.m_btnCancel.MinimumSize = new System.Drawing.Size(87, 27);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(87, 27);
			this.m_btnCancel.TabIndex = 7;
			this.m_btnCancel.Text = "Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			// 
			// PasswordDialog
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(356, 131);
			this.Controls.Add(this.m_tlpMainPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PasswordDialog";
			this.Padding = new System.Windows.Forms.Padding(9, 13, 13, 13);
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PasswordDialog";
			this.m_tlpMainPanel.ResumeLayout(false);
			this.m_tlpMainPanel.PerformLayout();
			this.m_tlpButtonsPanel.ResumeLayout(false);
			this.m_tlpButtonsPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel m_tlpMainPanel;
		private System.Windows.Forms.Label m_lbProtectedDocument;
		private System.Windows.Forms.Label m_lblPassword;
		private System.Windows.Forms.TextBox m_tbxPassword;
		private System.Windows.Forms.TableLayoutPanel m_tlpButtonsPanel;
		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.Label m_lblEnterPassword;
	}
}