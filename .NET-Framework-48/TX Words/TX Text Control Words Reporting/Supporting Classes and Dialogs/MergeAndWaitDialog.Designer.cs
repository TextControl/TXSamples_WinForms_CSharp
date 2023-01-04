namespace TXTextControl.Words {
	partial class MergeAndWaitDialog {
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



		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.m_pbProgressBar = new System.Windows.Forms.ProgressBar();
			this.m_lblMerging = new System.Windows.Forms.Label();
			this.m_tlpMainPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_bwMergeFiles = new System.ComponentModel.BackgroundWorker();
			this.m_tlpMainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_pbProgressBar
			// 
			this.m_pbProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_pbProgressBar.Location = new System.Drawing.Point(3, 20);
			this.m_pbProgressBar.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.m_pbProgressBar.MarqueeAnimationSpeed = 50;
			this.m_pbProgressBar.MinimumSize = new System.Drawing.Size(220, 0);
			this.m_pbProgressBar.Name = "m_pbProgressBar";
			this.m_pbProgressBar.Size = new System.Drawing.Size(220, 50);
			this.m_pbProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.m_pbProgressBar.TabIndex = 0;
			this.m_pbProgressBar.Value = 100;
			// 
			// m_lblMerging
			// 
			this.m_lblMerging.AutoSize = true;
			this.m_lblMerging.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_lblMerging.Location = new System.Drawing.Point(0, 0);
			this.m_lblMerging.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.m_lblMerging.Name = "m_lblMerging";
			this.m_lblMerging.Size = new System.Drawing.Size(219, 15);
			this.m_lblMerging.TabIndex = 1;
			this.m_lblMerging.Text = "Merging…";
			// 
			// m_tlpMainPanel
			// 
			this.m_tlpMainPanel.AutoSize = true;
			this.m_tlpMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_tlpMainPanel.ColumnCount = 1;
			this.m_tlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpMainPanel.Controls.Add(this.m_pbProgressBar, 0, 1);
			this.m_tlpMainPanel.Controls.Add(this.m_lblMerging, 0, 0);
			this.m_tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_tlpMainPanel.Location = new System.Drawing.Point(8, 11);
			this.m_tlpMainPanel.Name = "m_tlpMainPanel";
			this.m_tlpMainPanel.RowCount = 3;
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tlpMainPanel.Size = new System.Drawing.Size(219, 36);
			this.m_tlpMainPanel.TabIndex = 2;
			// 
			// m_bwMergeFiles
			// 
			this.m_bwMergeFiles.WorkerSupportsCancellation = true;
			this.m_bwMergeFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
			this.m_bwMergeFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
			// 
			// MergeAndWaitDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(238, 58);
			this.Controls.Add(this.m_tlpMainPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MergeAndWaitDialog";
			this.Padding = new System.Windows.Forms.Padding(8, 11, 11, 11);
			this.RightToLeftLayout = true;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Please wait";
			this.m_tlpMainPanel.ResumeLayout(false);
			this.m_tlpMainPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}



		private System.Windows.Forms.ProgressBar m_pbProgressBar;
		private System.Windows.Forms.Label m_lblMerging;
		private System.Windows.Forms.TableLayoutPanel m_tlpMainPanel;
		private System.ComponentModel.BackgroundWorker m_bwMergeFiles;
	}
}