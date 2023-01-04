/*-------------------------------------------------------------------------------------------------------------
** Form1.cs File
**
** Description:
**      Sample project that is related to the 'Howto: Mail Merge -> Sample: Simple Mail Merge' 
**		article inside the 'Windows Forms User's Guide'.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Data;
using System.Windows.Forms;

namespace MailMerge_Simple {
	public partial class Form1 : Form {
		/*-------------------------------------------------------------------------------------------------------------
        ** M E M B E R   V A R I A B L E S
        **-----------------------------------------------------------------------------------------------------------*/
		private DataSet m_dsAddresses;


		/*-------------------------------------------------------------------------------------------------------------
        ** C O N S T R U C T O R S
        **-----------------------------------------------------------------------------------------------------------*/
		public Form1() {
			InitializeComponent();
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** H A N D L E R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** Form1_Load Handler
        ** Creates the addresses data set, adds an item for each database field to the 'Add' item drop down and 
        ** loads the 'Instructions.tx' sample template.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Form1_Load(object sender, EventArgs e) {
			// Create a new DataSet and load the XML file.
			m_dsAddresses = new DataSet();
			m_dsAddresses.ReadXml(@"Files\Data.xml");

			// Create a new ToolStripMenuItem for each database field.
			foreach (DataColumn dataColumn in m_dsAddresses.Tables[0].Columns) {
				ToolStripMenuItem tmiDatabaseFieldItem = new ToolStripMenuItem(dataColumn.ColumnName);
				tmiDatabaseFieldItem.Click += new EventHandler(DatabaseFieldItem_Click);
				m_tmiAdd.DropDown.Items.Add(tmiDatabaseFieldItem);
			}

			// Load the 'Instructions.tx' sample template.
			m_txTextControl.Selection.Load(@"Files\Instructions.tx", TXTextControl.StreamType.InternalUnicodeFormat);
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** 'Application Fields' Drop Down
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** ApplicationFields_DropDownOpening Handler
        ** Sets the enabled state of the 'Add' and 'Properties' items when the 'Application Fields' 
        ** drop down is opening.
        **-----------------------------------------------------------------------------------------------------------*/
		private void ApplicationFields_DropDownOpening(object sender, EventArgs e) {
			m_tmiProperties.Enabled = m_txTextControl.ApplicationFields.GetItem() == null ? false : true;
			m_tmiAdd.Enabled = m_txTextControl.ApplicationFields.CanAdd;
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** DatabaseFieldItem_Click Handler
        ** Creates with the text of the clicked database field item a new TXTextControl.DocumentServer.Fields.MergeField  
        ** and adds it to TextControl.
        **-----------------------------------------------------------------------------------------------------------*/
		private void DatabaseFieldItem_Click(object sender, EventArgs e) {
			ToolStripMenuItem tmiClickedItem = (ToolStripMenuItem)sender;
			InsertMergeField(tmiClickedItem.Text);
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** Properties_Click Handler
        ** Creates with the text of the clicked database field item a new TXTextControl.DocumentServer.Fields.MergeField  
        ** and adds it to TextControl.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Properties_Click(object sender, EventArgs e) {
			TXTextControl.DocumentServer.Fields.MergeField mfMergeField = new TXTextControl.DocumentServer.Fields.MergeField(m_txTextControl.ApplicationFields.GetItem());
			mfMergeField.ShowDialog(this);
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** 'Mail Merge' Drop Down
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** MailMerge_DropDownOpening Handler
        ** Sets the enabled state of the 'Merge' item when the 'Mail Merge' drop down is opening.
        **-----------------------------------------------------------------------------------------------------------*/
		private void MailMerge_DropDownOpening(object sender, EventArgs e) {
			m_tmiMerge.Enabled = m_txTextControl.ApplicationFields.Count > 0;
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** Merge_Click Handler
        ** Use the MailMerge instance to merge the data into the application fields.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Merge_Click(object sender, EventArgs e) {
			m_mmMailMerge.Merge(m_dsAddresses.Tables[0], true);
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** M E T H O D S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** InsertMergeField Method
        ** Creates with the text of the clicked database field item a new TXTextControl.DocumentServer.Fields.MergeField  
        ** and adds it to TextControl.
        **
        ** Parameters:
        **		name:		The name of the merge field that is created and added to the TextControl.
        **-----------------------------------------------------------------------------------------------------------*/
		private void InsertMergeField(string name) {
			// Create a new TXTextControl.DocumentServer.Fields.MergeField
			// and add it to TextControl.
			TXTextControl.DocumentServer.Fields.MergeField mfMergeField = new TXTextControl.DocumentServer.Fields.MergeField();
			mfMergeField.Name = name;
			mfMergeField.Text = "{ " + name + " }";
			mfMergeField.ApplicationField.HighlightMode = TXTextControl.HighlightMode.Activated;
			mfMergeField.ApplicationField.DoubledInputPosition = true;

			m_txTextControl.ApplicationFields.Add(mfMergeField.ApplicationField);
		}
	}
}
