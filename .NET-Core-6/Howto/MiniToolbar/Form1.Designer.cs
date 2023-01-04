namespace MiniToolbar {
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
			this.m_txTextControl = new TXTextControl.TextControl();
			this.SuspendLayout();
			// 
			// m_txTextControl
			// 
			this.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_txTextControl.Font = new System.Drawing.Font("Arial", 10F);
			this.m_txTextControl.FormattingPrinter = "Standard";
			this.m_txTextControl.Location = new System.Drawing.Point(0, 0);
			this.m_txTextControl.Name = "m_txTextControl";
			this.m_txTextControl.ShowMiniToolbar = ((TXTextControl.MiniToolbarButton)((TXTextControl.MiniToolbarButton.LeftButton | TXTextControl.MiniToolbarButton.RightButton)));
			this.m_txTextControl.Size = new System.Drawing.Size(800, 450);
			this.m_txTextControl.TabIndex = 0;
			this.m_txTextControl.UserNames = null;
			this.m_txTextControl.TextMiniToolbarInitialized += new TXTextControl.MiniToolbarInitializedEventHandler(this.TextControl_TextMiniToolbarInitialized);
			this.m_txTextControl.MiniToolbarOpening += new TXTextControl.MiniToolbarOpeningEventHandler(this.TextControl_MiniToolbarOpening);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.m_txTextControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Howto: Manipulate the MiniToolbar";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private TXTextControl.TextControl m_txTextControl;
	}
}

