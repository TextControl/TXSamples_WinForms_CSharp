/*-------------------------------------------------------------------------------------------------------------
** MainWindow_ViewMenuItem.cs File
**
** Description: Provides methods to set the layout and behavior of the 'View' menu items.
**     
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System.Windows.Forms;

namespace TXTextControl.Words {
	partial class MainWindow {
		/*-------------------------------------------------------------------------------------------------------------
		** SetViewItemsTexts Method
		**
		** Sets the texts of the 'View' menu items.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SetViewItemsTexts() {
			// 'View'
			SetItemText(m_tmiView);

			// 'Page Layout'
			SetItemText(m_tmiView_PageLayout);

			// 'Draft'
			SetItemText(m_tmiView_Draft);

			// 'Button Bar'
			SetItemText(m_tmiView_ButtonBar);

			// 'Status Bar'
			SetItemText(m_tmiView_StatusBar);

			// 'Horizontal Ruler'
			SetItemText(m_tmiView_HorizontalRuler);

			// 'Vertical Ruler'
			SetItemText(m_tmiView_VerticalRuler);

			// 'Table Gridlines'
			SetItemText(m_tmiView_TableGridlines);

			// 'Bookmark Markers'
			SetItemText(m_tmiView_BookmarkMarkers);

			// 'Text Frame Marker Lines'
			SetItemText(m_tmiView_TextFrameMarkerLines);

			// 'Drawing Marker Lines'
			SetItemText(m_tmiView_DrawingMarkerLines);

			// 'Control Chars'
			SetItemText(m_tmiView_ControlChars);

			// 'Editable Regions'
			SetItemText(m_tmiView_EditableRegions);
			SetItemText(m_tmiView_EditableRegions_Always);
			SetItemText(m_tmiView_EditableRegions_Current);
			SetItemText(m_tmiView_EditableRegions_Never);

			// 'Tracked Changes'
			SetItemText(m_tmiView_TrackedChanges);

			// 'Comments'
			SetItemText(m_tmiView_Comments);
			SetItemText(m_tmiView_Comments_Always);
			SetItemText(m_tmiView_Comments_Current);
			SetItemText(m_tmiView_Comments_Never);

			// 'Zoom'
			SetItemText(m_tmiView_Zoom);
			SetItemText(m_tmiView_Zoom_50, Properties.Resources.Item_View_Zoom_Factor_Text, "&50");
			SetItemText(m_tmiView_Zoom_75, Properties.Resources.Item_View_Zoom_Factor_Text, "&75");
			SetItemText(m_tmiView_Zoom_100, Properties.Resources.Item_View_Zoom_Factor_Text, "&100");
			SetItemText(m_tmiView_Zoom_150, Properties.Resources.Item_View_Zoom_Factor_Text, "15&0");
			SetItemText(m_tmiView_Zoom_200, Properties.Resources.Item_View_Zoom_Factor_Text, "&200");
			SetItemText(m_tmiView_Zoom_300, Properties.Resources.Item_View_Zoom_Factor_Text, "&300");
			SetItemText(m_tmiView_Zoom_400, Properties.Resources.Item_View_Zoom_Factor_Text, "&400");

			// 'Right to Left Layout'
			SetItemText(m_tmiView_RightToLeftLayout);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** SetViewItemsImages Method
		**
		** Sets the images of the 'View' menu items.
		**-----------------------------------------------------------------------------------------------------------*/
		private void SetViewItemsImages() {
			// 'Page Layout'
			SetItemImage(m_tmiView_PageLayout, Windows.Forms.Ribbon.RibbonViewTab.RibbonItem.TXITEM_PrintLayout.ToString());

			// 'Draft'
			SetItemImage(m_tmiView_Draft, Windows.Forms.Ribbon.RibbonViewTab.RibbonItem.TXITEM_Draft.ToString());

			// 'Table Gridlines'
			SetItemImage(m_tmiView_TableGridlines, Windows.Forms.Ribbon.RibbonViewTab.RibbonItem.TXITEM_ShowTableGridlines.ToString());

			// 'Bookmark Markers'
			SetItemImage(m_tmiView_BookmarkMarkers, Windows.Forms.Ribbon.RibbonViewTab.RibbonItem.TXITEM_ShowBookmarkMarkers.ToString());

			// 'Text Frame Marker Lines'
			SetItemImage(m_tmiView_TextFrameMarkerLines, Windows.Forms.Ribbon.RibbonViewTab.RibbonItem.TXITEM_ShowTextFrameMarkersLines.ToString());

			// 'Drawing Marker Lines'
			SetItemImage(m_tmiView_DrawingMarkerLines, Windows.Forms.Ribbon.RibbonViewTab.RibbonItem.TXITEM_ShowDrawingFrameMarkersLines.ToString());

			// 'Control Chars'
			SetItemImage(m_tmiView_ControlChars, Windows.Forms.Ribbon.RibbonViewTab.RibbonItem.TXITEM_ShowControlChars.ToString());

			// 'Editable Regions'
			SetItemImage(m_tmiView_EditableRegions, Windows.Forms.Ribbon.RibbonPermissionsTab.RibbonItem.TXITEM_HighlightEditableRegions.ToString());

			// 'Tracked Changes'
			SetItemImage(m_tmiView_TrackedChanges, Windows.Forms.Ribbon.RibbonProofingTab.RibbonItem.TXITEM_TrackChanges.ToString());

			// 'Comments'
			SetItemImage(m_tmiView_Comments, Windows.Forms.Ribbon.RibbonProofingTab.RibbonItem.TXITEM_CommentsViewMode.ToString());

			// 'Zoom'
			SetItemImage(m_tmiView_Zoom, Windows.Forms.Ribbon.RibbonViewTab.RibbonItem.TXITEM_ZoomFactor.ToString());

			// 'Right to Left Layout'
			m_tmiView_RightToLeftLayout.Image = GetSmallIcon("TXTextControl.Words.Images.RightToLeft_Small.svg");
		}

		/*-------------------------------------------------------------------------------------------------------------
		** ConnectViewItemsHandlers Method
		**
		** Connects the 'View' menu items to Click and DropDownOpening handlers.
		**-----------------------------------------------------------------------------------------------------------*/
		private void ConnectViewItemsHandlers() {
			// 'Page Layout'
			m_tmiView_PageLayout.Click += View_PageLayout_Click;

			// 'Draft'
			m_tmiView_Draft.Click += View_Draft_Click;

			// 'Button Bar'
			m_tmiView_ButtonBar.Click += View_ButtonBar_Click;

			// 'Status Bar'
			m_tmiView_StatusBar.Click += View_StatusBar_Click;

			// 'Horizontal Ruler'
			m_tmiView_HorizontalRuler.Click += View_HorizontalRuler_Click;

			// 'Vertical Ruler'
			m_tmiView_VerticalRuler.Click += View_VerticalRuler_Click;

			// 'Table Gridlines'
			m_tmiView_TableGridlines.Click += View_TableGridlines_Click;

			// 'Bookmark Markers'
			m_tmiView_BookmarkMarkers.Click += View_BookmarkMarkers_Click;

			// 'Text Frame Marker Lines'
			m_tmiView_TextFrameMarkerLines.Click += View_TextFrameMarkerLines_Click;

			// 'Drawing Marker Lines'
			m_tmiView_DrawingMarkerLines.Click += View_DrawingMarkerLines_Click;

			// 'Control Chars'
			m_tmiView_ControlChars.Click += View_ControlChars_Click;

			// 'Editable Regions'
			m_tmiView_EditableRegions_Always.Click += View_EditableRegions_Always_Click;
			m_tmiView_EditableRegions_Current.Click += View_EditableRegions_Current_Click;
			m_tmiView_EditableRegions_Never.Click += View_EditableRegions_Never_Click;

			// 'Tracked Changes'
			m_tmiView_TrackedChanges.Click += View_TrackedChanges_Click;

			// 'Comments'
			m_tmiView_Comments_Always.Click += View_Comments_Always_Click;
			m_tmiView_Comments_Current.Click += View_Comments_Current_Click;
			m_tmiView_Comments_Never.Click += View_Comments_Never_Click;

			// 'Zoom'
			foreach (ToolStripMenuItem item in m_tmiView_Zoom.DropDownItems) {
				item.Click += View_Zoom_MenuItem_Click;
			}

			// 'Right to Left Layout'
			m_tmiView_RightToLeftLayout.Click += View_RightToLeftLayout_Click;


			// DropDownOpening Handlers
			m_tmiView.DropDownOpening += View_DropDownOpening;
			m_tmiView_EditableRegions.DropDownOpening += View_EditableRegions_DropDownOpening;
			m_tmiView_Comments.DropDownOpening += View_Comments_DropDownOpening;
			m_tmiView_Zoom.DropDownOpening += View_Zoom_DropDownOpening;
		}
	}
}
