/*-------------------------------------------------------------------------------------------------------------
** MainWindow.cs File
**
** Description:
**     Implements TX Text Control Words.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using TXTextControl.Windows.Forms;
using TXTextControl.Windows.Forms.Ribbon;

namespace TXTextControl.Words {
	public partial class MainWindow : RibbonForm {
		/*-------------------------------------------------------------------------------------------------------------
		** M E M B E R   V A R I A B L E S
		**-----------------------------------------------------------------------------------------------------------*/
		private readonly string m_strFilesDirectory = @"Files\";


		/*-------------------------------------------------------------------------------------------------------------
        ** C O N S T R U C T O R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** MainWindow Constructor
        **-----------------------------------------------------------------------------------------------------------*/
		public MainWindow() {
			InitializeComponent();
			// Get and set saved application settings.
			LoadRightToLeftSettings();
			LoadRecentFiles();
		}


		/*-------------------------------------------------------------------------------------------------------------
		** O V E R R I D D E N   M E T H O D S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------
        ** OnLoad Method (overridden)
        ** Sets the requested behavior for all added controls.
        **-----------------------------------------------------------------------------------------------------*/
		protected override void OnLoad(EventArgs e) {
			// Select the 'View' tab
			m_rbnRibbon.SelectedIndex = 3;

			// Main Window:
			UpdateMainWindowCaption(); // Set caption

			// Application Menu items:
			SetAppMenuDesign();
			SetAppMenuBehavior();

			// QAT:
			SetQATItemsDesign();
			SetUndoRedoButtonsBehavior();

			// Sidebars:
			SetSidebarBehavior();

			// Mini Toolbar
			m_txTextControl.ShowMiniToolbar = MiniToolbarButton.LeftButton | MiniToolbarButton.RightButton;

			// Contextual Tabs:
			SetContextualTabsBehavior();

			// Toolbars:
			SetRulerBarsDesign();
			SetStatusBarDesign();

			// Right to left:
			AddAppViewGroup(m_rtRibbonViewTab);

			// About:
			UpdateAboutSidebar();

			// Set the TextControl as active control when shown.
			this.ActiveControl = m_txTextControl;
			base.OnLoad(e);
		}


		/*-------------------------------------------------------------------------------------------------------------
		** M E T H O D S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------
        ** SetAppMenuDesign Method
        ** Updates the design of the menu items.
        **-----------------------------------------------------------------------------------------------------*/
		private void SetAppMenuDesign() {
			SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_New.ToString(), m_rbtnNew);
			SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_Open.ToString(), m_rbtnOpen);
			SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_Save.ToString(), m_rbtnSave);
			SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_SaveAs.ToString(), m_rbtnSaveAs);
			SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_Print.ToString(), m_rsbtnPrint);
			SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_Print.ToString(), m_rbtnPrint);
			SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_PrintQuick.ToString(), m_rbtnPrintQuick);
			SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_PrintPreview.ToString(), m_rbtnPrintPreview);
			SetRibbonButtonDesign(ResourceProvider.FileMenuItem.TXITEM_About.ToString(), m_rtbtnAbout, Properties.Resources.AboutButton_ToolTip_Description);

			// Set Recent Files overview label text
			m_rlblRecentFiles.Text = Properties.Resources.ApplicationMenu_ResentFiles;
		}

		/*-------------------------------------------------------------------------------------------------------
        ** SetAppMenuBehavior Method
        ** Connects all necessary handlers to the application menu items.
        **-----------------------------------------------------------------------------------------------------*/
		private void SetAppMenuBehavior() {
			// Common
			m_txTextControl.Changed += TextControl_Changed; // Updates the internal 'is dirty document' flag
			this.FormClosing += MainWindow_FormClosing; // Saves the recent files before the application is closed

			// New:
			m_rbtnNew.Click += New_Click;

			// Open:
			m_rbtnOpen.Click += Open_Click;

			// Save:
			m_rbtnSave.Click += Save_Click;

			// Save As:
			m_rbtnSaveAs.Click += SaveAs_Click;

			// Print:
			m_rsbtnPrint.ButtonClick += Print_Click; // Print(Split Button)
			m_rbtnPrint.Click += Print_Click; // Print (Drop Down Button)
			m_rbtnPrintQuick.Click += PrintQuick_Click; // Print Quick (Drop Down Button)
			m_rbtnPrintPreview.Click += PrintPreview_Click; // Print Preview (Drop Down Button)         
			m_txTextControl.PropertyChanged += TextControl_PropertyChanged_Print; // Add handler for the print buttons Enable state handling

			// About:
			m_rtbtnAbout.CheckedChanged += About_CheckedChanged;
		}

		/*-------------------------------------------------------------------------------------------------------
        ** SetRibbonButtonDesign Method
        ** Sets the icons, text, key tip and tool tip for a specific RibbonButton.
        **
        ** Parameters:
        **      resourceID:     The id that is used to identify the corresponding texts and icons.
        **      ribbonButton:   The ribbon button to update.
        **      args:           Optional strings that are used to format the displayed texts.
        **-----------------------------------------------------------------------------------------------------*/
		private void SetRibbonButtonDesign(string resourceID, RibbonButton ribbonButton, params string[] args) {
			ribbonButton.Name = resourceID;
			ribbonButton.SmallIcon = ResourceProvider.GetSmallIcon(resourceID, this);
			ribbonButton.LargeIcon = ResourceProvider.GetLargeIcon(resourceID, this);
			ribbonButton.KeyTip = ResourceProvider.GetKeyTip(resourceID);

			if (args.Length > 0) {
				ribbonButton.Text = string.Format(ResourceProvider.GetText(resourceID), args);
				ribbonButton.ToolTip.Title = string.Format(ResourceProvider.GetToolTipTitle(resourceID), args);
				ribbonButton.ToolTip.Description = string.Format(ResourceProvider.GetToolTipDescription(resourceID), args);
			}
			else {
				ribbonButton.Text = ResourceProvider.GetText(resourceID);
				ribbonButton.ToolTip.Title = ResourceProvider.GetToolTipTitle(resourceID);
				ribbonButton.ToolTip.Description = ResourceProvider.GetToolTipDescription(resourceID);
			}
			m_lstCustomRibbonButtons.Add(ribbonButton);
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** GetSmallIcon Method
        ** Creates a small bitmap icon from an embedded SVG resource.
        **
        ** Parameters:
        **      path:   The path to the embedded SVG resource.
        **
        ** Returns:     The created small bitmap.
        **-----------------------------------------------------------------------------------------------------------*/
		private Bitmap GetSmallIcon(string path) {
			Assembly asm = Assembly.GetExecutingAssembly();
			Bitmap bmp = null;

			using (Stream sStream = asm.GetManifestResourceStream(path)) {
				bmp = ResourceProvider.GetSmallIcon(sStream, this);
			}
			return bmp;
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** GetLargeIcon Method
        ** Creates a large bitmap icon from an embedded SVG resource.
        **
        ** Parameters:
        **      path:   The path to the embedded SVG resource.
        **
        ** Returns:     The created large bitmap.
        **-----------------------------------------------------------------------------------------------------------*/
		private Bitmap GetLargeIcon(string path) {
			Assembly asm = Assembly.GetExecutingAssembly();
			Bitmap bmp = null;

			using (Stream sStream = asm.GetManifestResourceStream(path)) {
				bmp = ResourceProvider.GetLargeIcon(sStream, this);
			}
			return bmp;
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** H A N D L E R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** MainWindow_FormClosing Handler
		** Saves the recent files to the Properties.Settings.Default.RecentFiles property.
		**-----------------------------------------------------------------------------------------------------------*/
		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
			// Save the recent files to the Properties.Settings.Default.RecentFiles property
			SaveRecentFiles();
		}

		/*-------------------------------------------------------------------------------------------------------
        ** Application_ThreadException Handler
        ** Handles an exception by showing a message box that explains the reason for the exception.
        **-----------------------------------------------------------------------------------------------------*/
		internal static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e) {
			string strProductName = ((AssemblyProductAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyProductAttribute))).Product;

			// TX Text Control Feature is not available
			if (e.Exception is TXTextControl.LicenseLevelException) {
				MessageBox.Show(string.Format(Properties.Resources.MessageBox_Application_ThreadException_Text, e.Exception.Message), strProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			// All other exceptions
			MessageBox.Show(string.Format(Properties.Resources.MessageBox_Application_ThreadException_Text, e.Exception.Message), strProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
