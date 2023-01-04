namespace Spreadsheet {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.m_ttInfo = new System.Windows.Forms.ToolTip(this.components);
			this.m_sepSeparator01 = new System.Windows.Forms.ToolStripSeparator();
			this.m_btnA1 = new System.Windows.Forms.ToolStripButton();
			this.m_btnR1C1 = new System.Windows.Forms.ToolStripButton();
			this.m_lblReferenceStyle = new System.Windows.Forms.ToolStripLabel();
			this.m_tsFormulaSettings = new System.Windows.Forms.ToolStrip();
			this.m_btnEnableCalculation = new System.Windows.Forms.ToolStripButton();
			this.m_btnApplyNumberFormat = new System.Windows.Forms.ToolStripButton();
			this.m_cmbxFormats = new System.Windows.Forms.ToolStripComboBox();
			this.m_lblNumberFormat = new System.Windows.Forms.ToolStripLabel();
			this.m_btnNumberFormat = new System.Windows.Forms.ToolStripButton();
			this.m_btnTextFormat = new System.Windows.Forms.ToolStripButton();
			this.m_lblCellTextType = new System.Windows.Forms.ToolStripLabel();
			this.m_sepSeparator02 = new System.Windows.Forms.ToolStripSeparator();
			this.m_btnRemove = new System.Windows.Forms.ToolStripButton();
			this.m_btnAccept = new System.Windows.Forms.ToolStripButton();
			this.m_tbxFormula = new System.Windows.Forms.ToolStripTextBox();
			this.m_btnAddFunction = new System.Windows.Forms.ToolStripButton();
			this.m_cmbxFunctions = new System.Windows.Forms.ToolStripComboBox();
			this.m_tsFormula = new System.Windows.Forms.ToolStrip();
			this.m_txTextControl = new TXTextControl.TextControl();
			this.m_rbHorizontalRuler = new TXTextControl.RulerBar();
			this.m_sbStaturBar = new TXTextControl.StatusBar();
			this.m_rbVerticalRuler = new TXTextControl.RulerBar();
			this.m_tsFormulaSettings.SuspendLayout();
			this.m_tsFormula.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_ttInfo
			// 
			this.m_ttInfo.IsBalloon = true;
			this.m_ttInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.m_ttInfo.ToolTipTitle = "Next Step";
			// 
			// m_sepSeparator01
			// 
			this.m_sepSeparator01.Name = "m_sepSeparator01";
			this.m_sepSeparator01.Size = new System.Drawing.Size(6, 25);
			// 
			// m_btnA1
			// 
			this.m_btnA1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.m_btnA1.Name = "m_btnA1";
			this.m_btnA1.Size = new System.Drawing.Size(25, 22);
			this.m_btnA1.Text = "A1";
			this.m_btnA1.Click += new System.EventHandler(this.A1_Click);
			// 
			// m_btnR1C1
			// 
			this.m_btnR1C1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.m_btnR1C1.Name = "m_btnR1C1";
			this.m_btnR1C1.Size = new System.Drawing.Size(38, 22);
			this.m_btnR1C1.Text = "R1C1";
			this.m_btnR1C1.Click += new System.EventHandler(this.R1C1_Click);
			// 
			// m_lblReferenceStyle
			// 
			this.m_lblReferenceStyle.Name = "m_lblReferenceStyle";
			this.m_lblReferenceStyle.Size = new System.Drawing.Size(90, 22);
			this.m_lblReferenceStyle.Text = "Reference Style:";
			// 
			// m_tsFormulaSettings
			// 
			this.m_tsFormulaSettings.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.m_tsFormulaSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_lblReferenceStyle,
            this.m_btnR1C1,
            this.m_btnA1,
            this.m_sepSeparator01,
            this.m_btnEnableCalculation});
			this.m_tsFormulaSettings.Location = new System.Drawing.Point(0, 0);
			this.m_tsFormulaSettings.Name = "m_tsFormulaSettings";
			this.m_tsFormulaSettings.Size = new System.Drawing.Size(1034, 25);
			this.m_tsFormulaSettings.TabIndex = 8;
			this.m_tsFormulaSettings.Text = "toolStrip1";
			// 
			// m_btnEnableCalculation
			// 
			this.m_btnEnableCalculation.CheckOnClick = true;
			this.m_btnEnableCalculation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.m_btnEnableCalculation.Name = "m_btnEnableCalculation";
			this.m_btnEnableCalculation.Size = new System.Drawing.Size(109, 22);
			this.m_btnEnableCalculation.Text = "Enable Calculation";
			this.m_btnEnableCalculation.Click += new System.EventHandler(this.EnableCalculation_Click);
			// 
			// m_btnApplyNumberFormat
			// 
			this.m_btnApplyNumberFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.m_btnApplyNumberFormat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.m_btnApplyNumberFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_btnApplyNumberFormat.Name = "m_btnApplyNumberFormat";
			this.m_btnApplyNumberFormat.Size = new System.Drawing.Size(23, 22);
			this.m_btnApplyNumberFormat.ToolTipText = "Apply Number Format";
			this.m_btnApplyNumberFormat.Click += new System.EventHandler(this.ApplyNumberFormat_Click);
			// 
			// m_cmbxFormats
			// 
			this.m_cmbxFormats.Name = "m_cmbxFormats";
			this.m_cmbxFormats.Size = new System.Drawing.Size(121, 25);
			// 
			// m_lblNumberFormat
			// 
			this.m_lblNumberFormat.Name = "m_lblNumberFormat";
			this.m_lblNumberFormat.Size = new System.Drawing.Size(95, 22);
			this.m_lblNumberFormat.Text = "Number Format:";
			// 
			// m_btnNumberFormat
			// 
			this.m_btnNumberFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.m_btnNumberFormat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.m_btnNumberFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_btnNumberFormat.Name = "m_btnNumberFormat";
			this.m_btnNumberFormat.Size = new System.Drawing.Size(23, 22);
			this.m_btnNumberFormat.ToolTipText = "Number Format";
			this.m_btnNumberFormat.Click += new System.EventHandler(this.NumberFormat_Click);
			// 
			// m_btnTextFormat
			// 
			this.m_btnTextFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.m_btnTextFormat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.m_btnTextFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_btnTextFormat.Name = "m_btnTextFormat";
			this.m_btnTextFormat.Size = new System.Drawing.Size(23, 22);
			this.m_btnTextFormat.ToolTipText = "Text Format";
			this.m_btnTextFormat.Click += new System.EventHandler(this.TextFormat_Click);
			// 
			// m_lblCellTextType
			// 
			this.m_lblCellTextType.Name = "m_lblCellTextType";
			this.m_lblCellTextType.Size = new System.Drawing.Size(81, 22);
			this.m_lblCellTextType.Text = "Cell Text Type:";
			// 
			// m_sepSeparator02
			// 
			this.m_sepSeparator02.Name = "m_sepSeparator02";
			this.m_sepSeparator02.Size = new System.Drawing.Size(6, 25);
			// 
			// m_btnRemove
			// 
			this.m_btnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.m_btnRemove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.m_btnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_btnRemove.Name = "m_btnRemove";
			this.m_btnRemove.Size = new System.Drawing.Size(23, 22);
			this.m_btnRemove.ToolTipText = "Remove Formula";
			this.m_btnRemove.Click += new System.EventHandler(this.Remove_Click);
			// 
			// m_btnAccept
			// 
			this.m_btnAccept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.m_btnAccept.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.m_btnAccept.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_btnAccept.Name = "m_btnAccept";
			this.m_btnAccept.Size = new System.Drawing.Size(23, 22);
			this.m_btnAccept.ToolTipText = "Accept Formula";
			this.m_btnAccept.Click += new System.EventHandler(this.Accept_Click);
			// 
			// m_tbxFormula
			// 
			this.m_tbxFormula.Name = "m_tbxFormula";
			this.m_tbxFormula.Size = new System.Drawing.Size(300, 25);
			this.m_tbxFormula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Formula_KeyPress);
			this.m_tbxFormula.TextChanged += new System.EventHandler(this.Formula_TextChanged);
			// 
			// m_btnAddFunction
			// 
			this.m_btnAddFunction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.m_btnAddFunction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.m_btnAddFunction.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_btnAddFunction.Name = "m_btnAddFunction";
			this.m_btnAddFunction.Size = new System.Drawing.Size(23, 22);
			this.m_btnAddFunction.ToolTipText = "Add Function";
			this.m_btnAddFunction.Click += new System.EventHandler(this.AddFunction_Click);
			// 
			// m_cmbxFunctions
			// 
			this.m_cmbxFunctions.Name = "m_cmbxFunctions";
			this.m_cmbxFunctions.Size = new System.Drawing.Size(121, 25);
			// 
			// m_tsFormula
			// 
			this.m_tsFormula.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.m_tsFormula.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_cmbxFunctions,
            this.m_btnAddFunction,
            this.m_tbxFormula,
            this.m_btnAccept,
            this.m_btnRemove,
            this.m_sepSeparator02,
            this.m_lblCellTextType,
            this.m_btnTextFormat,
            this.m_btnNumberFormat,
            this.m_lblNumberFormat,
            this.m_cmbxFormats,
            this.m_btnApplyNumberFormat});
			this.m_tsFormula.Location = new System.Drawing.Point(0, 25);
			this.m_tsFormula.Name = "m_tsFormula";
			this.m_tsFormula.Size = new System.Drawing.Size(1034, 25);
			this.m_tsFormula.TabIndex = 7;
			this.m_tsFormula.Text = "toolStrip1";
			// 
			// m_txTextControl
			// 
			this.m_txTextControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_txTextControl.Font = new System.Drawing.Font("Arial", 10F);
			this.m_txTextControl.FormattingPrinter = "Standard";
			this.m_txTextControl.Location = new System.Drawing.Point(0, 50);
			this.m_txTextControl.Name = "m_txTextControl";
			this.m_txTextControl.RulerBar = this.m_rbHorizontalRuler;
			this.m_txTextControl.Size = new System.Drawing.Size(1034, 439);
			this.m_txTextControl.StatusBar = this.m_sbStaturBar;
			this.m_txTextControl.TabIndex = 9;
			this.m_txTextControl.UserNames = null;
			this.m_txTextControl.VerticalRulerBar = this.m_rbVerticalRuler;
			this.m_txTextControl.InputPositionChanged += new System.EventHandler(this.TextControl_InputPositionChanged);
			// 
			// m_rbHorizontalRuler
			// 
			this.m_rbHorizontalRuler.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_rbHorizontalRuler.FormulaMode = TXTextControl.RulerBarFormulaMode.Auto;
			this.m_rbHorizontalRuler.Location = new System.Drawing.Point(25, 50);
			this.m_rbHorizontalRuler.Name = "m_rbHorizontalRuler";
			this.m_rbHorizontalRuler.Size = new System.Drawing.Size(1009, 25);
			this.m_rbHorizontalRuler.TabIndex = 11;
			this.m_rbHorizontalRuler.Text = "rulerBar2";
			// 
			// m_sbStaturBar
			// 
			this.m_sbStaturBar.BackColor = System.Drawing.SystemColors.Control;
			this.m_sbStaturBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_sbStaturBar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.m_sbStaturBar.Location = new System.Drawing.Point(0, 489);
			this.m_sbStaturBar.Name = "m_sbStaturBar";
			this.m_sbStaturBar.Size = new System.Drawing.Size(1034, 22);
			this.m_sbStaturBar.TabIndex = 12;
			// 
			// m_rbVerticalRuler
			// 
			this.m_rbVerticalRuler.Alignment = TXTextControl.RulerBarAlignment.Left;
			this.m_rbVerticalRuler.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_rbVerticalRuler.FormulaMode = TXTextControl.RulerBarFormulaMode.Auto;
			this.m_rbVerticalRuler.Location = new System.Drawing.Point(0, 50);
			this.m_rbVerticalRuler.Name = "m_rbVerticalRuler";
			this.m_rbVerticalRuler.Size = new System.Drawing.Size(25, 439);
			this.m_rbVerticalRuler.TabIndex = 10;
			this.m_rbVerticalRuler.Text = "rulerBar1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1034, 511);
			this.Controls.Add(this.m_rbHorizontalRuler);
			this.Controls.Add(this.m_rbVerticalRuler);
			this.Controls.Add(this.m_txTextControl);
			this.Controls.Add(this.m_tsFormula);
			this.Controls.Add(this.m_tsFormulaSettings);
			this.Controls.Add(this.m_sbStaturBar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Howto: Use Spreadsheet Formulas in Tables";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.m_tsFormulaSettings.ResumeLayout(false);
			this.m_tsFormulaSettings.PerformLayout();
			this.m_tsFormula.ResumeLayout(false);
			this.m_tsFormula.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolTip m_ttInfo;
		private System.Windows.Forms.ToolStripSeparator m_sepSeparator01;
		private System.Windows.Forms.ToolStripButton m_btnA1;
		private System.Windows.Forms.ToolStripButton m_btnR1C1;
		private System.Windows.Forms.ToolStripLabel m_lblReferenceStyle;
		private System.Windows.Forms.ToolStrip m_tsFormulaSettings;
		private System.Windows.Forms.ToolStripButton m_btnEnableCalculation;
		private System.Windows.Forms.ToolStripButton m_btnApplyNumberFormat;
		private System.Windows.Forms.ToolStripComboBox m_cmbxFormats;
		private System.Windows.Forms.ToolStripLabel m_lblNumberFormat;
		private System.Windows.Forms.ToolStripButton m_btnNumberFormat;
		private System.Windows.Forms.ToolStripButton m_btnTextFormat;
		private System.Windows.Forms.ToolStripLabel m_lblCellTextType;
		private System.Windows.Forms.ToolStripSeparator m_sepSeparator02;
		private System.Windows.Forms.ToolStripButton m_btnRemove;
		private System.Windows.Forms.ToolStripButton m_btnAccept;
		private System.Windows.Forms.ToolStripTextBox m_tbxFormula;
		private System.Windows.Forms.ToolStripButton m_btnAddFunction;
		private System.Windows.Forms.ToolStripComboBox m_cmbxFunctions;
		private System.Windows.Forms.ToolStrip m_tsFormula;
		private TXTextControl.TextControl m_txTextControl;
		private TXTextControl.RulerBar m_rbHorizontalRuler;
		private TXTextControl.StatusBar m_sbStaturBar;
		private TXTextControl.RulerBar m_rbVerticalRuler;
	}
}

