﻿/*-------------------------------------------------------------------------------------------------------------
** MainWindow_DpiChanged.cs File
**
** Description:
**     Handles custom image updating when the application resolution changed.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TXTextControl.Windows.Forms;
using TXTextControl.Windows.Forms.Ribbon;

namespace TXTextControl.Words {
	partial class MainWindow {

		/*-------------------------------------------------------------------------------------------------------------
		** M E M B E R   V A R I A B L E S
		**-----------------------------------------------------------------------------------------------------------*/

		private readonly List<RibbonButton> m_lstCustomRibbonButtons = new List<RibbonButton>();
		private float m_fDPI = 0;


		/*-------------------------------------------------------------------------------------------------------------
        ** O V E R R I D D E N   M E T H O D S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** WndProc Method (overridden)
        ** Overridden to get the DPI value when the window is created and to update the icons of the custom 
        ** ribbon buttons and groups when the dpi value changed.
        **
        ** Parameters:
        **      message:   The Windows Message to process.
        **-----------------------------------------------------------------------------------------------------------*/
		protected override void WndProc(ref Message message) {
			switch (message.Msg) {
				case 0x0001: // WM_CREATE
							 // Get the DPI value from the created handle.
					using (Graphics g = Graphics.FromHwnd(this.Handle)) {
						m_fDPI = g.DpiX;
					}
					break;
				case 0x02E0: // WM_DPICHANGED
							 // Get the new DPI value when the dpi value changed.
					int iNewDPI = (int)message.WParam & 0xFFFF;
					if (m_fDPI != (m_fDPI = iNewDPI)) {
						// Step through those custom ribbon buttons that show an image that is provided
						// by the TXTextControl.ResourceProvider
						foreach (RibbonButton customButton in m_lstCustomRibbonButtons) {
							customButton.SmallIcon = ResourceProvider.GetSmallIcon(customButton.Name, m_fDPI);
							customButton.LargeIcon = ResourceProvider.GetLargeIcon(customButton.Name, m_fDPI);
						}

						// Update the icons of those ribbons and groups that use a custom SVG.  

						// Update the small icons
						m_rmbtnOpenSampleTemplate.SmallIcon = GetSmallIcon("TXTextControl.Words.Images.OpenSampleTemplate_Small.svg");
					
						m_rbtnSampleDatabaseButton.SmallIcon = GetSmallIcon("TXTextControl.Words.Images.SampleDatabase_Small.svg");

						m_rgMerge.SmallIcon =
						m_rbtnMergeAndExport.SmallIcon =GetSmallIcon("TXTextControl.Words.Images.MergeAndExport_Small.svg");

						m_rgMergeResultsTab_ResultGroup.SmallIcon = ResourceProvider.GetSmallIcon(m_rgMergeResultsTab_ResultGroup.Name, m_fDPI);
						m_rgNavigateGroup.SmallIcon = ResourceProvider.GetSmallIcon(m_rgMergeResultsTab_ResultGroup.Name, m_fDPI);


						// Update the large icons.
						m_rmbtnOpenSampleTemplate.LargeIcon = GetLargeIcon("TXTextControl.Words.Images.OpenSampleTemplate_Large.svg");
					
						m_rgMerge.LargeIcon =
						m_rbtnMergeAndExport.LargeIcon = GetSmallIcon("TXTextControl.Words.Images.MergeAndExport_Large.svg");

						m_rgMergeResultsTab_ResultGroup.LargeIcon = ResourceProvider.GetLargeIcon(m_rgMergeResultsTab_ResultGroup.Name, m_fDPI);
						m_rgNavigateGroup.LargeIcon = ResourceProvider.GetLargeIcon(m_rgNavigateGroup.Name, m_fDPI);
					}
					break;
			}
			base.WndProc(ref message);
		}
	}
}
