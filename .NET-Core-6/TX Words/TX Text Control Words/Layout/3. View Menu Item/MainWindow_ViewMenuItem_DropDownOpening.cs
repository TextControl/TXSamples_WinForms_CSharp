/*-------------------------------------------------------------------------------------------------------------
** MainWindow_ViewMenuItem_DropDownOpening.cs File
**
** Description: Provides all DropDownOpening handlers associated with 'View' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Windows.Forms;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** View_DropDownOpening Handler
		**
		** Updates the checked state of 'View' drop down menu items.
		** 
		** Item: 'View'
		**-----------------------------------------------------------------------------------------------------------*/
		private void View_DropDownOpening(object sender, EventArgs e) {
			// 'Page Layout'
			m_tmiView_PageLayout.Checked = m_txTextControl.ViewMode == ViewMode.PageView;

			// 'Draft'
			m_tmiView_Draft.Checked = m_txTextControl.ViewMode == ViewMode.Normal;

			// 'Button Bar'
			m_tmiView_ButtonBar.Checked = m_bbButtonBar.Visible;

			// 'Status Bar'
			m_tmiView_StatusBar.Checked = m_sbStatusBar.Visible;

			// 'Horizontal Ruler'
			m_tmiView_HorizontalRuler.Checked = m_rbHorizontalRulerBar.Visible;

			// 'Vertical Ruler'
			m_tmiView_VerticalRuler.Checked = m_rbVerticalRulerBar.Visible;

			// 'Table Gridlines'
			m_tmiView_TableGridlines.Checked = m_txTextControl.Tables.GridLines;

			// 'Bookmark Markers'
			m_tmiView_BookmarkMarkers.Checked = m_txTextControl.DocumentTargetMarkers;

			// 'Text Frame Marker Lines'
			m_tmiView_TextFrameMarkerLines.Checked = m_txTextControl.TextFrameMarkerLines;

			// 'Drawing Marker Lines'
			m_tmiView_DrawingMarkerLines.Checked = m_txTextControl.DrawingMarkerLines;

			if (m_plTXLicense >= VersionInfo.ProductLevel.Professional) {
				// 'Tracked Changes'

				// Step through all tracked changes to get their common highlight mode.
				TrackedChangeCollection colTrackedChanges = m_txTextControl.TrackedChanges;
				int iCount = colTrackedChanges.Count;
				HighlightMode hmCurrentHighlightMode = HighlightMode.Always;
				for (int i = 1; i < iCount; i++) {
					hmCurrentHighlightMode = colTrackedChanges[i].HighlightMode;
					// Check whether the current tracked change highlight mode differs to the next one's
					if (hmCurrentHighlightMode != colTrackedChanges[i + 1].HighlightMode) {
						// In that case set the 'Tracked Changes' item's checked state to CheckState.Indeterminate
						m_tmiView_TrackedChanges.CheckState = CheckState.Indeterminate;
						return;
					}
				}

				// The 'Tracked Changes' item is checked if the highlight mode of all tracked changes
				// is set to HighlightMode.Always
				m_tmiView_TrackedChanges.Checked = hmCurrentHighlightMode == HighlightMode.Always;
			}

			// 'Right to Left Layout'
			m_tmiView_RightToLeftLayout.Checked = this.RightToLeftLayout;

		}

		/*-------------------------------------------------------------------------------------------------------------
		** View_EditableRegions_DropDownOpening Handler
		**
		** Updates the checked state of 'Editable Regions' drop down menu items.
		** 
		** Item: 'Editable Regions'
		**-----------------------------------------------------------------------------------------------------------*/
		private void View_EditableRegions_DropDownOpening(object sender, EventArgs e) {
			// Set the check states of the 'Editable Regions' drop down items.
			HighlightMode hmHighlightMode = m_txTextControl.EditableRegionHighlightMode;
			m_tmiView_EditableRegions_Always.Checked = hmHighlightMode == HighlightMode.Always;
			m_tmiView_EditableRegions_Current.Checked = hmHighlightMode == HighlightMode.Activated;
			m_tmiView_EditableRegions_Never.Checked = hmHighlightMode == HighlightMode.Never;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** View_Comments_DropDownOpening Handler
		**
		** Updates the checked state of 'Comments' drop down menu items.
		** 
		** Item: 'Comments'
		**-----------------------------------------------------------------------------------------------------------*/
		private void View_Comments_DropDownOpening(object sender, EventArgs e) {
			// Set the check states of the 'Comments' drop down items.
			HighlightMode hmHighlightMode = m_txTextControl.CommentHighlightMode;
			m_tmiView_Comments_Always.Checked = hmHighlightMode == HighlightMode.Always;
			m_tmiView_Comments_Current.Checked = hmHighlightMode == HighlightMode.Activated;
			m_tmiView_Comments_Never.Checked = hmHighlightMode == HighlightMode.Never;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** View_Zoom_DropDownOpening Handler
		**
		** Updates the checked state of 'Zoom' drop down menu items.
		** 
		** Item: 'Zoom'
		**-----------------------------------------------------------------------------------------------------------*/
		private void View_Zoom_DropDownOpening(object sender, EventArgs e) {
			// Set the check states of the 'Zoom' drop down items.
			string strZoomFactor = m_txTextControl.ZoomFactor.ToString();
			foreach (ToolStripMenuItem item in m_tmiView_Zoom.DropDownItems) {
				item.Checked = item.Tag.ToString() == strZoomFactor;
			}
		}
	}
}
