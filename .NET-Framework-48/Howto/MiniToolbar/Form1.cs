/*-------------------------------------------------------------------------------------------------------------
** Form1.cs File
**
** Description:
**		Sample project that is related to the 'Howto: Manipulate the MiniToolbar' article inside
**		the 'Windows Forms User's Guide'.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Windows.Forms;

namespace MiniToolbar {
	public partial class Form1 : Form {
		/*-------------------------------------------------------------------------------------------------------------
		** C O N S T R U C T O R
		**-----------------------------------------------------------------------------------------------------------*/
		public Form1() {
			InitializeComponent();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** H A N D L E R S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** Form1_Load Handler
        ** Load the sample document.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Form1_Load(object sender, EventArgs e) {
			m_txTextControl.Load(@"Files\Sample.tx", TXTextControl.StreamType.InternalFormat);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** TextControl_TextMiniToolbarInitialized Handler
		** Modify the basic structure of the TextMiniToolbar.
		**-----------------------------------------------------------------------------------------------------------*/
		private void TextControl_TextMiniToolbarInitialized(object sender, TXTextControl.MiniToolbarInitializedEventArgs e) {
			// Ensure that the TextMiniToolbar's table layout group won't be displayed if the input position is inside a table.
			e.MiniToolbar.RibbonGroups.Remove((e.MiniToolbar as TXTextControl.TextMiniToolbar).FindItem(TXTextControl.TextMiniToolbar.RibbonItem.TXITEM_TableLayoutGroup) as TXTextControl.Windows.Forms.Ribbon.RibbonGroup);

			// Create and add a ribbon group to the TextMiniToolbar that provides an "Edit Hyperlink" button.
			e.MiniToolbar.RibbonGroups.Add(CreateEditHyperlinkGroup());
		}

		/*-------------------------------------------------------------------------------------------------------------
		** TextControl_MiniToolbarOpening Handler
		** Update the TextMiniToolbar's content visibility.
		**-----------------------------------------------------------------------------------------------------------*/
		private void TextControl_MiniToolbarOpening(object sender, TXTextControl.MiniToolbarOpeningEventArgs e) {
			// Check whether the opening mini tool bar is of type TextMiniToolbar.
			if (e.MiniToolbar is TXTextControl.TextMiniToolbar) {
				e.MiniToolbar.RibbonGroups[1].Visible = true;   // Ensure that the TextMiniToolbar's Styles group is always shown (even if the input position is inside a table)
				e.MiniToolbar.RibbonGroups[1].ShowSeperator =   // Ensure that the Styles group's separator and...
				e.MiniToolbar.RibbonGroups[2].Visible =         // ... the "Edit Hyperlink" group are displayed if...

				(e.MiniToolbarContext & TXTextControl.ContextMenuLocation.TextField) == TXTextControl.ContextMenuLocation.TextField && // ... the current context is TextField and ...
				m_txTextControl.HypertextLinks.GetItem() != null; // ... the text field is of type TXTextControl.HypertextLink.
			}
		}

		/*-------------------------------------------------------------------------------------------------------------
		** EditHyperlink_Click Handler
		** Opens the TXTextControl HyperlinkDialog.
		**-----------------------------------------------------------------------------------------------------------*/
		private void EditHyperlink_Click(object sender, EventArgs e) {
			new TXTextControl.HyperlinkDialog(m_txTextControl).ShowDialog(m_txTextControl);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** M E T H O D S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** CreateEditHyperlinkGroup Method
		** Creates a RibbonGroup that contains an 'Edit Hyperlink' button.
		** 
		** Returns:		The created RibbonGroup.
		**-----------------------------------------------------------------------------------------------------------*/
		private TXTextControl.Windows.Forms.Ribbon.RibbonGroup CreateEditHyperlinkGroup() {
			// Create a ribbon group that contains...
			TXTextControl.Windows.Forms.Ribbon.RibbonGroup rgEditHyperlinkGroup = new TXTextControl.Windows.Forms.Ribbon.RibbonGroup() {
				ShowSeperator = false
			};
			// ... a button to open the TextControl Edit HyperlinkDialog.
			TXTextControl.Windows.Forms.Ribbon.RibbonButton rbtnEditHyperlink = new TXTextControl.Windows.Forms.Ribbon.RibbonButton();
			rbtnEditHyperlink.Text = "Edit Hyperlink";
			rbtnEditHyperlink.LargeIcon = TXTextControl.Windows.Forms.ResourceProvider.GetLargeIcon(TXTextControl.Windows.Forms.Ribbon.RibbonInsertTab.RibbonItem.TXITEM_InsertHyperlink.ToString(), this);
			rbtnEditHyperlink.Click += EditHyperlink_Click;

			// Add the edit hyperlink button to group.
			rgEditHyperlinkGroup.RibbonItems.Add(rbtnEditHyperlink);

			return rgEditHyperlinkGroup;
		}
	}
}
