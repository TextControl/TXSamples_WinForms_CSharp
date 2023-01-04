
namespace TXTextControl.Words
{
    internal partial class FrameNameDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.m_tlpMainPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_lblFrameName = new System.Windows.Forms.Label();
			this.m_tbxFrameName = new System.Windows.Forms.TextBox();
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
			this.m_tlpMainPanel.Controls.Add(this.m_btnCancel, 3, 2);
			this.m_tlpMainPanel.Controls.Add(this.m_lblFrameName, 0, 0);
			this.m_tlpMainPanel.Controls.Add(this.m_tbxFrameName, 0, 1);
			this.m_tlpMainPanel.Controls.Add(this.m_btnOK, 1, 2);
			this.m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_tlpMainPanel.Location = new System.Drawing.Point(9, 13);
			this.m_tlpMainPanel.Margin = new System.Windows.Forms.Padding(0);
			this.m_tlpMainPanel.Name = "m_tlpMainPanel";
			this.m_tlpMainPanel.RowCount = 4;
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpMainPanel.Size = new System.Drawing.Size(278, 87);
			this.m_tlpMainPanel.TabIndex = 0;
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.AutoSize = true;
			this.m_btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btnCancel.Location = new System.Drawing.Point(191, 64);
			this.m_btnCancel.Margin = new System.Windows.Forms.Padding(0);
			this.m_btnCancel.MinimumSize = new System.Drawing.Size(87, 27);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(87, 27);
			this.m_btnCancel.TabIndex = 3;
			this.m_btnCancel.Text = "Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			// 
			// m_lblFrameName
			// 
			this.m_lblFrameName.AutoSize = true;
			this.m_tlpMainPanel.SetColumnSpan(this.m_lblFrameName, 3);
			this.m_lblFrameName.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_lblFrameName.Location = new System.Drawing.Point(0, 0);
			this.m_lblFrameName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
			this.m_lblFrameName.Name = "m_lblFrameName";
			this.m_lblFrameName.Size = new System.Drawing.Size(278, 15);
			this.m_lblFrameName.TabIndex = 0;
			this.m_lblFrameName.Text = "Frame name:";
			// 
			// m_tbxFrameName
			// 
			this.m_tlpMainPanel.SetColumnSpan(this.m_tbxFrameName, 3);
			this.m_tbxFrameName.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tbxFrameName.Location = new System.Drawing.Point(3, 24);
			this.m_tbxFrameName.Margin = new System.Windows.Forms.Padding(3, 0, 0, 17);
			this.m_tbxFrameName.MinimumSize = new System.Drawing.Size(291, 4);
			this.m_tbxFrameName.Name = "m_tbxFrameName";
			this.m_tbxFrameName.Size = new System.Drawing.Size(291, 23);
			this.m_tbxFrameName.TabIndex = 1;
			// 
			// m_btnOK
			// 
			this.m_btnOK.AutoSize = true;
			this.m_btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btnOK.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_btnOK.Location = new System.Drawing.Point(91, 64);
			this.m_btnOK.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
			this.m_btnOK.MinimumSize = new System.Drawing.Size(87, 27);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(87, 27);
			this.m_btnOK.TabIndex = 2;
			this.m_btnOK.Text = "OK";
			this.m_btnOK.UseVisualStyleBackColor = true;
			// 
			// FrameNameDialog
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(300, 113);
			this.Controls.Add(this.m_tlpMainPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrameNameDialog";
			this.Padding = new System.Windows.Forms.Padding(9, 13, 13, 13);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Enter Frame Name";
			this.m_tlpMainPanel.ResumeLayout(false);
			this.m_tlpMainPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel m_tlpMainPanel;
        private System.Windows.Forms.Button m_btnCancel;
        private System.Windows.Forms.Label m_lblFrameName;
        private System.Windows.Forms.TextBox m_tbxFrameName;
        private System.Windows.Forms.Button m_btnOK;
    }
}