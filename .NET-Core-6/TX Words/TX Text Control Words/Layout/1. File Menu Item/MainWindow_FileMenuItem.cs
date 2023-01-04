/*-------------------------------------------------------------------------------------------------------------
** MainWindow_FileMenuItem.cs File
**
** Description: Provides methods to set the layout and behavior of the 'File' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System.Collections.Specialized;
using TXTextControl.Windows.Forms;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** M E M B E R   V A R I A B L E S
		**-----------------------------------------------------------------------------------------------------------*/

		// 'Open...' item
		private readonly PDFImportSettings m_isPDFImportSettings = PDFImportSettings.GenerateTextFrames | PDFImportSettings.LoadEmbeddedFiles;

		// 'Recent Files' item
		private const int m_iMaxRecentFiles = 10;
		private StringCollection m_colRecentFiles;

		// 'Sign In...' and '[Current user]' items
		private UserInfo m_uiCurrentUser = null; // Info about the current user.
		private string m_strUserName = ""; // Environment.UserName


		/*-------------------------------------------------------------------------------------------------------------
        ** M E T H O D S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** SetFileItemsTexts Method
		**
		** Sets the texts of the 'File' menu items.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SetFileItemsTexts() {
			SetItemText(m_tmiFile);

			// 'New'
			SetItemText(m_tmiFile_New);

			// 'Open...'
			SetItemText(m_tmiFile_Open);

			// 'Recent Files'
			SetItemText(m_tmiFile_RecentFiles);

			// 'Save'
			SetItemText(m_tmiFile_Save);

			// 'Save As...'
			SetItemText(m_tmiFile_SaveAs);

			// 'Page Setup...'
			SetItemText(m_tmiFile_PageSetup);

			// 'Print Preview...'
			SetItemText(m_tmiFile_PrintPreview);

			// 'Print...'
			SetItemText(m_tmiFile_Print);

			// 'Print Quick'
			SetItemText(m_tmiFile_PrintQuick);

			// 'Sign In...'
			SetItemText(m_tmiFile_SignIn);

			// '[Current User]'
			SetItemText(m_tmiFile_CurrentUser,m_strUserName);
			SetItemText(m_tmiFile_CurrentUser_AccountSettings);
			SetItemText(m_tmiFile_CurrentUser_SignOut);

			// 'Exit'
			SetItemText(m_tmiFile_Exit);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** SetFileItemsImages Method
		**
		** Sets the images of the 'File' menu items.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SetFileItemsImages() {
			// 'New'
			SetItemImage(m_tmiFile_New, ResourceProvider.FileMenuItem.TXITEM_New.ToString());

			// 'Open...'
			SetItemImage(m_tmiFile_Open, ResourceProvider.FileMenuItem.TXITEM_Open.ToString());

			// 'Save'
			SetItemImage(m_tmiFile_Save, ResourceProvider.FileMenuItem.TXITEM_Save.ToString());

			// 'Save As...'
			SetItemImage(m_tmiFile_SaveAs, ResourceProvider.FileMenuItem.TXITEM_SaveAs.ToString());

			// 'Page Setup...'
			SetItemImage(m_tmiFile_PageSetup, Windows.Forms.Ribbon.RibbonPageLayoutTab.RibbonItem.TXITEM_PageMargins.ToString());

			// 'Print Preview...'
			SetItemImage(m_tmiFile_PrintPreview, ResourceProvider.FileMenuItem.TXITEM_PrintPreview.ToString());

			// 'Print...'
			SetItemImage(m_tmiFile_Print, ResourceProvider.FileMenuItem.TXITEM_Print.ToString());

			// 'Print Quick'
			SetItemImage(m_tmiFile_PrintQuick, ResourceProvider.FileMenuItem.TXITEM_PrintQuick.ToString());

			// 'Sign In...'
			SetItemImage(m_tmiFile_SignIn, ResourceProvider.FileMenuItem.TXITEM_SignIn.ToString());

			// '[Current User]'
			SetItemImage(m_tmiFile_CurrentUser, ResourceProvider.FileMenuItem.TXITEM_CurrentUser.ToString());
			SetItemImage(m_tmiFile_CurrentUser_AccountSettings, ResourceProvider.FileMenuItem.TXITEM_AccountSettings.ToString());
			SetItemImage(m_tmiFile_CurrentUser_SignOut, ResourceProvider.FileMenuItem.TXITEM_SignOut.ToString());

			// 'Exit'
			SetItemImage(m_tmiFile_Exit, ResourceProvider.FileMenuItem.TXITEM_Exit.ToString());
		}

		/*-------------------------------------------------------------------------------------------------------------
		** ConnectFileItemsHandlers Method
		**
		** Connects the 'File' menu items to Click and DropDownOpening handlers.
		**-----------------------------------------------------------------------------------------------------------*/
		private void ConnectFileItemsHandlers() {
			// Click Handlers:

			// 'New'
			m_tmiFile_New.Click += File_New_Click;

			// 'Open...'
			m_tmiFile_Open.Click += File_Open_Click;

			// 'Save'
			m_tmiFile_Save.Click += File_Save_Click;

			// 'Save As...'
			m_tmiFile_SaveAs.Click += File_SaveAs_Click;

			// 'Page Setup...'
			m_tmiFile_PageSetup.Click += File_PageSetup_Click;

			// 'Print Preview...'
			m_tmiFile_PrintPreview.Click += File_PrintPreview_Click;

			// 'Print...'
			m_tmiFile_Print.Click += File_Print_Click;

			// 'Print Quick'
			m_tmiFile_PrintQuick.Click += File_PrintQuick_Click;
		
			// 'Sign In...'
			m_tmiFile_SignIn.Click += File_SignIn_Click;

			// '[Current User]'
			m_tmiFile_CurrentUser_AccountSettings.Click += File_CurrentUser_AccountSettings_Click;
			m_tmiFile_CurrentUser_SignOut.Click += File_CurrentUser_SignOut_Click;

			// 'Exit'
			m_tmiFile_Exit.Click += File_Exit_Click;


			// DropDownOpening Handlers

			// 'File'
			m_tmiFile.DropDownOpening += File_DropDownOpening;
		}
	}
}
