
namespace TXTextControl.Words {
	partial class UserAccessDialog {
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
			this.m_lblNewPassword = new System.Windows.Forms.Label();
			this.m_tbxNewPassword = new System.Windows.Forms.TextBox();
			this.m_tbxConfirmPassword = new System.Windows.Forms.TextBox();
			this.m_lblConfirmPassword = new System.Windows.Forms.Label();
			this.m_lblUser = new System.Windows.Forms.Label();
			this.m_lblUserName = new System.Windows.Forms.Label();
			this.m_lblPassword = new System.Windows.Forms.Label();
			this.m_tbxPassword = new System.Windows.Forms.TextBox();
			this.m_tlpButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_btnDelete = new System.Windows.Forms.Button();
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
			this.m_tlpMainPanel.Controls.Add(this.m_lblNewPassword, 0, 2);
			this.m_tlpMainPanel.Controls.Add(this.m_tbxNewPassword, 0, 2);
			this.m_tlpMainPanel.Controls.Add(this.m_tbxConfirmPassword, 1, 3);
			this.m_tlpMainPanel.Controls.Add(this.m_lblConfirmPassword, 0, 3);
			this.m_tlpMainPanel.Controls.Add(this.m_lblUser, 0, 0);
			this.m_tlpMainPanel.Controls.Add(this.m_lblUserName, 1, 0);
			this.m_tlpMainPanel.Controls.Add(this.m_lblPassword, 0, 1);
			this.m_tlpMainPanel.Controls.Add(this.m_tbxPassword, 1, 1);
			this.m_tlpMainPanel.Controls.Add(this.m_tlpButtonsPanel, 0, 4);
			this.m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_tlpMainPanel.Location = new System.Drawing.Point(9, 13);
			this.m_tlpMainPanel.Margin = new System.Windows.Forms.Padding(0);
			this.m_tlpMainPanel.Name = "m_tlpMainPanel";
			this.m_tlpMainPanel.RowCount = 6;
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
			this.m_tlpMainPanel.Size = new System.Drawing.Size(334, 145);
			this.m_tlpMainPanel.TabIndex = 0;
			// 
			// m_lblNewPassword
			// 
			this.m_lblNewPassword.AutoSize = true;
			this.m_lblNewPassword.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_lblNewPassword.Location = new System.Drawing.Point(0, 56);
			this.m_lblNewPassword.Margin = new System.Windows.Forms.Padding(0, 0, 9, 9);
			this.m_lblNewPassword.Name = "m_lblNewPassword";
			this.m_lblNewPassword.Size = new System.Drawing.Size(87, 23);
			this.m_lblNewPassword.TabIndex = 5;
			this.m_lblNewPassword.Text = "New Password:";
			this.m_lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_tbxNewPassword
			// 
			this.m_tbxNewPassword.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tbxNewPassword.Location = new System.Drawing.Point(119, 56);
			this.m_tbxNewPassword.Margin = new System.Windows.Forms.Padding(3, 0, 0, 9);
			this.m_tbxNewPassword.MinimumSize = new System.Drawing.Size(233, 4);
			this.m_tbxNewPassword.Name = "m_tbxNewPassword";
			this.m_tbxNewPassword.Size = new System.Drawing.Size(233, 23);
			this.m_tbxNewPassword.TabIndex = 6;
			this.m_tbxNewPassword.UseSystemPasswordChar = true;
			this.m_tbxNewPassword.TextChanged += new System.EventHandler(this.Password_TextChanged);
			// 
			// m_tbxConfirmPassword
			// 
			this.m_tbxConfirmPassword.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tbxConfirmPassword.Enabled = false;
			this.m_tbxConfirmPassword.Location = new System.Drawing.Point(119, 88);
			this.m_tbxConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 0, 0, 9);
			this.m_tbxConfirmPassword.MinimumSize = new System.Drawing.Size(233, 4);
			this.m_tbxConfirmPassword.Name = "m_tbxConfirmPassword";
			this.m_tbxConfirmPassword.PasswordChar = '*';
			this.m_tbxConfirmPassword.Size = new System.Drawing.Size(233, 23);
			this.m_tbxConfirmPassword.TabIndex = 8;
			this.m_tbxConfirmPassword.UseSystemPasswordChar = true;
			this.m_tbxConfirmPassword.TextChanged += new System.EventHandler(this.Password_TextChanged);
			// 
			// m_lblConfirmPassword
			// 
			this.m_lblConfirmPassword.AutoSize = true;
			this.m_lblConfirmPassword.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_lblConfirmPassword.Location = new System.Drawing.Point(0, 88);
			this.m_lblConfirmPassword.Margin = new System.Windows.Forms.Padding(0, 0, 9, 9);
			this.m_lblConfirmPassword.Name = "m_lblConfirmPassword";
			this.m_lblConfirmPassword.Size = new System.Drawing.Size(107, 23);
			this.m_lblConfirmPassword.TabIndex = 7;
			this.m_lblConfirmPassword.Text = "Confirm Password:";
			this.m_lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_lblUser
			// 
			this.m_lblUser.AutoSize = true;
			this.m_lblUser.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_lblUser.Location = new System.Drawing.Point(0, 0);
			this.m_lblUser.Margin = new System.Windows.Forms.Padding(0, 0, 13, 9);
			this.m_lblUser.Name = "m_lblUser";
			this.m_lblUser.Size = new System.Drawing.Size(33, 15);
			this.m_lblUser.TabIndex = 1;
			this.m_lblUser.Text = "User:";
			this.m_lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_lblUserName
			// 
			this.m_lblUserName.AutoSize = true;
			this.m_lblUserName.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_lblUserName.Location = new System.Drawing.Point(116, 0);
			this.m_lblUserName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
			this.m_lblUserName.Name = "m_lblUserName";
			this.m_lblUserName.Size = new System.Drawing.Size(81, 15);
			this.m_lblUserName.TabIndex = 2;
			this.m_lblUserName.Text = "[Current User]";
			this.m_lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_lblPassword
			// 
			this.m_lblPassword.AutoSize = true;
			this.m_lblPassword.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_lblPassword.Location = new System.Drawing.Point(0, 24);
			this.m_lblPassword.Margin = new System.Windows.Forms.Padding(0, 0, 9, 9);
			this.m_lblPassword.Name = "m_lblPassword";
			this.m_lblPassword.Size = new System.Drawing.Size(60, 23);
			this.m_lblPassword.TabIndex = 3;
			this.m_lblPassword.Text = "Password:";
			this.m_lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_tbxPassword
			// 
			this.m_tbxPassword.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tbxPassword.Location = new System.Drawing.Point(119, 24);
			this.m_tbxPassword.Margin = new System.Windows.Forms.Padding(3, 0, 0, 9);
			this.m_tbxPassword.MinimumSize = new System.Drawing.Size(233, 4);
			this.m_tbxPassword.Name = "m_tbxPassword";
			this.m_tbxPassword.Size = new System.Drawing.Size(233, 23);
			this.m_tbxPassword.TabIndex = 4;
			this.m_tbxPassword.UseSystemPasswordChar = true;
			this.m_tbxPassword.TextChanged += new System.EventHandler(this.Password_TextChanged);
			// 
			// m_tlpButtonsPanel
			// 
			this.m_tlpButtonsPanel.AutoSize = true;
			this.m_tlpButtonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_tlpButtonsPanel.ColumnCount = 4;
			this.m_tlpMainPanel.SetColumnSpan(this.m_tlpButtonsPanel, 2);
			this.m_tlpButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tlpButtonsPanel.Controls.Add(this.m_btnDelete, 0, 0);
			this.m_tlpButtonsPanel.Controls.Add(this.m_btnOK, 2, 0);
			this.m_tlpButtonsPanel.Controls.Add(this.m_btnCancel, 3, 0);
			this.m_tlpButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tlpButtonsPanel.Location = new System.Drawing.Point(0, 128);
			this.m_tlpButtonsPanel.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.m_tlpButtonsPanel.Name = "m_tlpButtonsPanel";
			this.m_tlpButtonsPanel.RowCount = 1;
			this.m_tlpButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpButtonsPanel.Size = new System.Drawing.Size(334, 27);
			this.m_tlpButtonsPanel.TabIndex = 9;
			// 
			// m_btnDelete
			// 
			this.m_btnDelete.AutoSize = true;
			this.m_btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btnDelete.Enabled = false;
			this.m_btnDelete.Location = new System.Drawing.Point(0, 0);
			this.m_btnDelete.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
			this.m_btnDelete.MinimumSize = new System.Drawing.Size(87, 27);
			this.m_btnDelete.Name = "m_btnDelete";
			this.m_btnDelete.Size = new System.Drawing.Size(87, 27);
			this.m_btnDelete.TabIndex = 10;
			this.m_btnDelete.Text = "Delete";
			this.m_btnDelete.UseVisualStyleBackColor = true;
			this.m_btnDelete.Visible = false;
			this.m_btnDelete.Click += new System.EventHandler(this.Delete_Click);
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
			this.m_btnOK.TabIndex = 11;
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
			this.m_btnCancel.TabIndex = 12;
			this.m_btnCancel.Text = "Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			// 
			// UserAccessDialog
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(356, 171);
			this.Controls.Add(this.m_tlpMainPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UserAccessDialog";
			this.Padding = new System.Windows.Forms.Padding(9, 13, 13, 13);
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Account Settings";
			this.m_tlpMainPanel.ResumeLayout(false);
			this.m_tlpMainPanel.PerformLayout();
			this.m_tlpButtonsPanel.ResumeLayout(false);
			this.m_tlpButtonsPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel m_tlpMainPanel;
		private System.Windows.Forms.TextBox m_tbxConfirmPassword;
		private System.Windows.Forms.Label m_lblConfirmPassword;
		private System.Windows.Forms.Label m_lblUser;
		private System.Windows.Forms.Label m_lblUserName;
		private System.Windows.Forms.Label m_lblPassword;
		private System.Windows.Forms.TextBox m_tbxPassword;
		private System.Windows.Forms.TableLayoutPanel m_tlpButtonsPanel;
		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.Label m_lblNewPassword;
		private System.Windows.Forms.TextBox m_tbxNewPassword;
		private System.Windows.Forms.Button m_btnDelete;
	}
}