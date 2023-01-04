/*-------------------------------------------------------------------------------------------------------------
** MergeSettingsDialog.cs File
**
** Description:
**     Provides a dialog to determine the settings for the following merge process.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Windows.Forms;
namespace TXTextControl.Words {
	/*-------------------------------------------------------------------------------------------------------------
	** MergeSettingsDialog Class
	** Implements a dialog to determine the settings for the following merge process.
    **-----------------------------------------------------------------------------------------------------------*/
	public partial class MergeSettingsDialog : Form {
		/*-------------------------------------------------------------------------------------------------------------
		** C O N S T R U C T O R
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** MergeSettingsDialog Constructor
		** Creates a dialog to determine the settings for the following merge process.
		**-----------------------------------------------------------------------------------------------------------*/
		public MergeSettingsDialog() {
			InitializeComponent();

			// Set caption and label texts.
			Text = Properties.Resources.MergeSettingsDialog_Caption;
			m_lblRecords.Text = Properties.Resources.MergeSettingsDialog_Records;
			m_lblNumberOfRecords.Text = Properties.Resources.MergeSettingsDialog_NumberOfRecords;
			m_chbxMergeAllRecords.Text = Properties.Resources.MergeSettingsDialog_MergeAllRecords;
			m_chbxMergeIntoSingleDocument.Text = Properties.Resources.MergeSettingsDialog_MergeIntoSingleDocument;
			m_lblRemoveEmptyMergeElements.Text = Properties.Resources.MergeSettingsDialog_RemoveEmptyMergeElements;
			m_chbxBlocks.Text = Properties.Resources.MergeSettingsDialog_Blocks;
			m_chbxFields.Text = Properties.Resources.MergeSettingsDialog_Fields;
			m_chbxLines.Text = Properties.Resources.MergeSettingsDialog_Lines;
			m_chbxImages.Text = Properties.Resources.MergeSettingsDialog_Images;
			m_chbxTrailingWhitespace.Text = Properties.Resources.MergeSettingsDialog_TrailingWhitespace;
			m_btnOK.Text = Properties.Resources.MergeSettingsDialog_OK;
			m_btnCancel.Text = Properties.Resources.MergeSettingsDialog_Cancel;
		}


		/*-------------------------------------------------------------------------------------------------------------
		** P R O P E R T I E S 
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** MaxRecords Property
		** Returns the number of files that should be merged. If the "Merge all records" check box is checked, the
		** property returns int:MaxValue
		**-----------------------------------------------------------------------------------------------------------*/
		internal int MaxRecords { get { return m_chbxMergeAllRecords.Checked ? int.MaxValue : (int)m_nudNumberOfRecords.Value; } }

		/*-------------------------------------------------------------------------------------------------------------
		** MergeIntoSingleFile Property
		** Returns a value indicating whether all created files should be merged into a single file.
		**-----------------------------------------------------------------------------------------------------------*/
		internal bool MergeIntoSingleFile { get { return m_chbxMergeIntoSingleDocument.Checked; } }

		/*-------------------------------------------------------------------------------------------------------------
		** RemoveEmptyBlocks Property
		** Returns a value indicating whether or not the content of empty merge blocks should be removed from the 
		** template.
		**-----------------------------------------------------------------------------------------------------------*/
		internal bool RemoveEmptyBlocks { get { return m_chbxBlocks.Checked; } }

		/*-------------------------------------------------------------------------------------------------------------
		** RemoveEmptyFields Property
		** Returns a value indicating whether or not empty fields should be removed from the template.
		**-----------------------------------------------------------------------------------------------------------*/
		internal bool RemoveEmptyFields { get { return m_chbxFields.Checked; } }

		/*-------------------------------------------------------------------------------------------------------------
		** RemoveEmptyLines Property
		** Returns a value indicating whether or not text lines which are empty after merging should be removed from 
		** the template.
		**-----------------------------------------------------------------------------------------------------------*/
		internal bool RemoveEmptyLines { get { return m_chbxLines.Checked; } }

		/*-------------------------------------------------------------------------------------------------------------
		** RemoveEmptyImages Property
		** Returns a value indicating whether or not images which don't have merge data should be removed from the 
		** template.
		**-----------------------------------------------------------------------------------------------------------*/
		internal bool RemoveEmptyImages { get { return m_chbxImages.Checked; } }

		/*-------------------------------------------------------------------------------------------------------------
		** RemoveTrailingWhitespace Property
		** Returns a value indicating whether trailing whitespace should be removed before saving a document. 
		**-----------------------------------------------------------------------------------------------------------*/
		internal bool RemoveTrailingWhitespace { get { return m_chbxTrailingWhitespace.Checked; } }


		/*-------------------------------------------------------------------------------------------------------------
		** H A N D L E R S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** OK_Click Handler
		** Closes the dialog with DialogResult.OK when clicked.
		**-----------------------------------------------------------------------------------------------------------*/
		private void OK_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		/*-------------------------------------------------------------------------------------------------------------
		** MergeAllRecords_CheckedChanged Handler
		** Enables/Disables the "Number of records:" label and numeric up down when the "Merge all records" check box
		** was checked.
		**-----------------------------------------------------------------------------------------------------------*/
		private void MergeAllRecords_CheckedChanged(object sender, EventArgs e) {
			m_lblNumberOfRecords.Enabled =
			m_nudNumberOfRecords.Enabled = !m_chbxMergeAllRecords.Checked;
		}
	}
}
