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
using System.Resources;
using System.Windows.Forms;
using TXTextControl.Windows.Forms;

namespace TXTextControl.Words {
	public partial class MainWindow : Form {
		/*-------------------------------------------------------------------------------------------------------------
		** M E M B E R   V A R I A B L E S
		**-----------------------------------------------------------------------------------------------------------*/
		private VersionInfo.ProductLevel m_plTXLicense;
		private readonly ResourceManager m_rmResources = null;

		// File Info
		// Values that are updated when opening, creating or saving a document
		private string m_strActiveDocumentName = Properties.Resources.MainWindow_Caption_Untitled; // The document's name is '[Untitled]' on default.
		private string m_strActiveDocumentPath = null; // The path of the active document.
		private StreamType m_stLastLoadedType = StreamType.RichTextFormat; // The StreamType that was last used to load a document. If no document has been loaded so far, RichtTextFormat is used. 
		private StreamType m_stLastSavedType = StreamType.RichTextFormat;  // The StreamType that was last used to save a document. If no document has been saved so far, RichtTextFormat is used. 
		private StreamType m_stActiveDocumentType = StreamType.RichTextFormat; // The StreamType that was last used to load or save the current document.
		private string m_strUserPasswordPDF = string.Empty; // Tthe password for the user when the document is reopened.
		private string m_strCssFileName = null; //The path and filename of a CSS file belonging to a HTML document.
		private CssSaveMode m_svCssSaveMode = CssSaveMode.None; // Specifies how to save stylesheet data with a HTML document.
		private bool m_bIsUnknownDocument = true; // A flag that indicates whether or not the active document is loaded/saved or created (unknown)		
		private bool m_bIsDirtyDocument = false; // A flag that indicates whether or not the document is 'dirty'


		/*-------------------------------------------------------------------------------------------------------------
        ** C O N S T R U C T O R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** MainWindow Constructor
        **-----------------------------------------------------------------------------------------------------------*/
		public MainWindow() {
			InitializeComponent();
			// Create the ResourceManager instance.
			Type tpMainWindow = this.GetType();
			m_rmResources = new ResourceManager(tpMainWindow.Namespace + ".Properties.Resources", tpMainWindow.Assembly);

			// Get and set saved application settings.
			LoadRightToLeftSettings();
			LoadKnownUserSettings();
			LoadRecentFiles();

			// Add handlers.
			this.FormClosing += MainWindow_FormClosing; // Checks whether the current document is dirty before the application is closed
			m_txTextControl.Changed += TextControl_Changed; // Updates the internal 'is dirty document' flag
		}


		/*-------------------------------------------------------------------------------------------------------------
		** O V E R R I D D E N   M E T H O D S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------
		** OnLoad Method (overridden)
		** Sets the requested layout and behavior for all added controls.
		**-----------------------------------------------------------------------------------------------------*/
		protected override void OnLoad(EventArgs e) {
			// Gets the TextControl license level.
			m_plTXLicense = m_txTextControl.GetVersionInfo().Level;

			// Items
			SetItemsDesign();
			SetItemsHandlers();
			CreateShapeAndBarcodeItems();

			// Main Window
			UpdateMainWindowCaption(); // Set caption

			// Drag & Drop
			SetDragAndDropBehavior();

			// Open Hyperlink
			SetOpenHyperlinkBehavior();

			// Shortcuts
			SetShortcutBehavior();

			// Tool Bars
			SetRulerBarsDesign();
			SetStatusBarDesign();

			// Mini Toolbar
			m_txTextControl.ShowMiniToolbar = MiniToolbarButton.LeftButton | MiniToolbarButton.RightButton;

			this.ActiveControl = m_txTextControl;
			base.OnLoad(e);
		}


		/*-------------------------------------------------------------------------------------------------------------
		** M E T H O D S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** UpdateMainWindowCaption Method
        ** Updates the application caption with the name of the active document and the product name.
        **-----------------------------------------------------------------------------------------------------------*/
		private void UpdateMainWindowCaption() {
			this.Text = m_strActiveDocumentName + (m_bIsDirtyDocument ? "*" : "") + " - " + Properties.Resources.MainWindow_Caption_Product;
			this.Refresh();
		}


		/*-------------------------------------------------------------------------------------------------------
        ** SetItemsDesign Method
        ** Sets the texts and images of all menu items.
        **-----------------------------------------------------------------------------------------------------*/
		private void SetItemsDesign() {
			// 'File'
			SetFileItemsTexts();
			SetFileItemsImages();

			// 'Edit'
			SetEditItemsTexts();
			SetEditItemsImages();

			// 'View'
			SetViewItemsTexts();
			SetViewItemsImages();

			// 'Insert'
			SetInsertItemsTexts();
			SetInsertItemsImages();

			// 'Format'
			SetFormatItemsTexts();
			SetFormatItemsImages();

			// 'Table'
			SetTableItemsTexts();
			SetTableItemsImages();
		}

		/*-------------------------------------------------------------------------------------------------------
        ** SetItemsHandlers Method
        ** Connects the menu items to Click and DropDownOpening handlers.
        **-----------------------------------------------------------------------------------------------------*/
		private void SetItemsHandlers() {
			// 'File'
			ConnectFileItemsHandlers();

			// 'Edit'
			ConnectEditItemsHandlers();

			// 'View'
			ConnectViewItemsHandlers();

			// 'Insert'
			ConnectInsertItemsHandlers();

			// 'Format'
			ConnectFormatItemsHandlers();

			// 'Table'
			ConnectTableItemsHandlers();
		}

		/*-------------------------------------------------------------------------------------------------------
        ** SetItemText Method
        ** Sets the text of the specified item.
        **
		** Parameters:
		**      item:		The item where to set the text.
		**		args:		Optional: If no string is set, only the resource text that corresponds to the item's
		**					name is set. If one string is set, the resource text is formatted with that string.
		**					If two strings are set, the first string is the text to set and the second string
		**					is the format value.
        **-----------------------------------------------------------------------------------------------------*/
		private void SetItemText(ToolStripItem item, params string[] args) {
			string strText;
			string strFormat;
			switch (args.Length) {
				case 0: // Only the resource text that corresponds to the item's name is set.
					strText = m_rmResources.GetString("Item_" + item.Name.Substring(5) + "_Text");
					strFormat = "";
					break;
				case 1: // The resource text is formatted.
					strText = m_rmResources.GetString("Item_" + item.Name.Substring(5) + "_Text");
					strFormat = args[0];
					break;
				case 2: // Two strings are set: the first string is the text to set and the second string is the format value.
					strText = args[0];
					strFormat = args[1];
					break;
				default:
					return;

			}

			// Set the text.
			item.Text = string.Format(strText, strFormat);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** SetItemImage Method
		** Creates an image that correspond to the referenced image id. That image is set as the item's icon.
		**
		** Parameters:
		**      item:		The item where to set the created image.
		**		iamgeID:	The id of the image to create.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SetItemImage(ToolStripMenuItem item, string imageID) {
			item.Image = ResourceProvider.GetSmallIcon(imageID, m_fDPI);
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
        ** H A N D L E R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------
        ** Application_ThreadException Handler
        ** Handles an exception by showing a message box that explains the reason for the exception.
        **-----------------------------------------------------------------------------------------------------*/
		internal static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e) {
			string strProductName = ((AssemblyProductAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyProductAttribute))).Product;

			// TX Text Control Feature is not available
			if (e.Exception is LicenseLevelException) {
				MessageBox.Show(string.Format(Properties.Resources.MessageBox_Application_ThreadException_Text, e.Exception.Message), strProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			// All other exceptions
			MessageBox.Show(string.Format(Properties.Resources.MessageBox_Application_ThreadException_Text, e.Exception.Message), strProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** TextControl_Changed Handler
		**
		** Updates the 'Is Dirty Document' flag to true if the document changed.
		**-----------------------------------------------------------------------------------------------------------*/
		private void TextControl_Changed(object sender, EventArgs e) {
			if (m_bIsDirtyDocument != (m_bIsDirtyDocument = true)) {
				// Update caption and save items enabled state.
				UpdateMainWindowCaption();
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** MainWindow_FormClosing Handler
        ** Invokes the SaveDirtyDocumentOnExit method to handle dirty documents. If the method returns false, the 
        ** closing of the application will be canceled. If the form closing is not canceled, the recent files
        ** are saved to the Properties.Settings.Default.RecentFiles property.
        **-----------------------------------------------------------------------------------------------------------*/
		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
			if (!(e.Cancel = !SaveDirtyDocumentOnExit())) {
				// Save the recent files to the Properties.Settings.Default.RecentFiles property
				SaveRecentFiles();
				// Save the know users to the Properties.Settings.Default.KnownUsers property
				SaveKnownUserSettings();
			}
		}
	}
}
