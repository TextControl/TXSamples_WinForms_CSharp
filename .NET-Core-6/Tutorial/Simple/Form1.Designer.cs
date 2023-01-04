namespace Simple {
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
			this.textControl1 = new TXTextControl.TextControl();
			this.ribbon1 = new TXTextControl.Windows.Forms.Ribbon.Ribbon();
			this.ribbonFormattingTab1 = new TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab();
			this.ribbonInsertTab1 = new TXTextControl.Windows.Forms.Ribbon.RibbonInsertTab();
			this.ribbonPageLayoutTab1 = new TXTextControl.Windows.Forms.Ribbon.RibbonPageLayoutTab();
			this.ribbonViewTab1 = new TXTextControl.Windows.Forms.Ribbon.RibbonViewTab();
			this.ribbonProofingTab1 = new TXTextControl.Windows.Forms.Ribbon.RibbonProofingTab();
			this.rulerBar1 = new TXTextControl.RulerBar();
			this.statusBar1 = new TXTextControl.StatusBar();
			this.rulerBar2 = new TXTextControl.RulerBar();
			this.ribbon1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textControl1
			// 
			this.textControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textControl1.Font = new System.Drawing.Font("Arial", 10F);
			this.textControl1.FormattingPrinter = "Standard";
			this.textControl1.Location = new System.Drawing.Point(25, 143);
			this.textControl1.Name = "textControl1";
			this.textControl1.Ribbon = this.ribbon1;
			this.textControl1.RulerBar = this.rulerBar1;
			this.textControl1.Size = new System.Drawing.Size(775, 285);
			this.textControl1.StatusBar = this.statusBar1;
			this.textControl1.TabIndex = 0;
			this.textControl1.Text = "textControl1";
			this.textControl1.UserNames = null;
			this.textControl1.VerticalRulerBar = this.rulerBar2;
			// 
			// ribbon1
			// 
			this.ribbon1.Controls.Add(this.ribbonFormattingTab1);
			this.ribbon1.Controls.Add(this.ribbonInsertTab1);
			this.ribbon1.Controls.Add(this.ribbonPageLayoutTab1);
			this.ribbon1.Controls.Add(this.ribbonViewTab1);
			this.ribbon1.Controls.Add(this.ribbonProofingTab1);
			this.ribbon1.Dock = System.Windows.Forms.DockStyle.Top;
			this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ribbon1.HotTrack = true;
			this.ribbon1.Location = new System.Drawing.Point(0, 0);
			this.ribbon1.Name = "ribbon1";
			this.ribbon1.SelectedIndex = 1;
			this.ribbon1.Size = new System.Drawing.Size(800, 118);
			this.ribbon1.TabIndex = 1;
			this.ribbon1.Text = "ribbon1";
			// 
			// ribbonFormattingTab1
			// 
			this.ribbonFormattingTab1.Location = new System.Drawing.Point(4, 24);
			this.ribbonFormattingTab1.Name = "ribbonFormattingTab1";
			this.ribbonFormattingTab1.Size = new System.Drawing.Size(792, 90);
			this.ribbonFormattingTab1.TabIndex = 1;
			// 
			// ribbonInsertTab1
			// 
			this.ribbonInsertTab1.Location = new System.Drawing.Point(4, 24);
			this.ribbonInsertTab1.Name = "ribbonInsertTab1";
			this.ribbonInsertTab1.Size = new System.Drawing.Size(792, 90);
			this.ribbonInsertTab1.TabIndex = 2;
			// 
			// ribbonPageLayoutTab1
			// 
			this.ribbonPageLayoutTab1.Location = new System.Drawing.Point(4, 24);
			this.ribbonPageLayoutTab1.Name = "ribbonPageLayoutTab1";
			this.ribbonPageLayoutTab1.Size = new System.Drawing.Size(792, 90);
			this.ribbonPageLayoutTab1.TabIndex = 3;
			// 
			// ribbonViewTab1
			// 
			this.ribbonViewTab1.Location = new System.Drawing.Point(4, 24);
			this.ribbonViewTab1.Name = "ribbonViewTab1";
			this.ribbonViewTab1.Size = new System.Drawing.Size(792, 90);
			this.ribbonViewTab1.TabIndex = 4;
			// 
			// ribbonProofingTab1
			// 
			this.ribbonProofingTab1.Location = new System.Drawing.Point(4, 24);
			this.ribbonProofingTab1.Name = "ribbonProofingTab1";
			this.ribbonProofingTab1.Size = new System.Drawing.Size(792, 90);
			this.ribbonProofingTab1.TabIndex = 5;
			// 
			// rulerBar1
			// 
			this.rulerBar1.Dock = System.Windows.Forms.DockStyle.Top;
			this.rulerBar1.Location = new System.Drawing.Point(0, 118);
			this.rulerBar1.Name = "rulerBar1";
			this.rulerBar1.Size = new System.Drawing.Size(800, 25);
			this.rulerBar1.TabIndex = 3;
			this.rulerBar1.Text = "rulerBar1";
			// 
			// statusBar1
			// 
			this.statusBar1.BackColor = System.Drawing.SystemColors.Control;
			this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.statusBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.statusBar1.Location = new System.Drawing.Point(0, 428);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(800, 22);
			this.statusBar1.TabIndex = 5;
			// 
			// rulerBar2
			// 
			this.rulerBar2.Alignment = TXTextControl.RulerBarAlignment.Left;
			this.rulerBar2.Dock = System.Windows.Forms.DockStyle.Left;
			this.rulerBar2.Location = new System.Drawing.Point(0, 143);
			this.rulerBar2.Name = "rulerBar2";
			this.rulerBar2.Size = new System.Drawing.Size(25, 285);
			this.rulerBar2.TabIndex = 4;
			this.rulerBar2.Text = "rulerBar2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textControl1);
			this.Controls.Add(this.rulerBar2);
			this.Controls.Add(this.rulerBar1);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.ribbon1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tutorial: Getting Started with Windows Forms (.NET Framework)";
			this.ribbon1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private TXTextControl.TextControl textControl1;
		private TXTextControl.Windows.Forms.Ribbon.Ribbon ribbon1;
		private TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab ribbonFormattingTab1;
		private TXTextControl.Windows.Forms.Ribbon.RibbonInsertTab ribbonInsertTab1;
		private TXTextControl.Windows.Forms.Ribbon.RibbonPageLayoutTab ribbonPageLayoutTab1;
		private TXTextControl.Windows.Forms.Ribbon.RibbonViewTab ribbonViewTab1;
		private TXTextControl.Windows.Forms.Ribbon.RibbonProofingTab ribbonProofingTab1;
		private TXTextControl.RulerBar rulerBar1;
		private TXTextControl.StatusBar statusBar1;
		private TXTextControl.RulerBar rulerBar2;
	}
}

