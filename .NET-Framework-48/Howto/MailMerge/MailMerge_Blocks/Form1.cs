/*-------------------------------------------------------------------------------------------------------------
** Form1.cs File
**
** Description:
**      Sample project that is related to the 'Howto: Mail Merge -> Sample: Mail Merge with Repeating Blocks' 
**		article inside the 'Windows Forms User's Guide'.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Data;
using System.Windows.Forms;

namespace MailMerge_Blocks {
	public partial class Form1 : Form {
		/*-------------------------------------------------------------------------------------------------------------
        ** M E M B E R   V A R I A B L E S
        **-----------------------------------------------------------------------------------------------------------*/
		private DataSet m_dsData;


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
        ** Creates a new data set and loads the 'Template.docx' template.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Form1_Load(object sender, EventArgs e) {
			// Create a new data set and load the XML file
			m_dsData = new DataSet();
			m_dsData.ReadXml(@"Files\Data.xml");

			TXTextControl.LoadSettings lsLoadSettings = new TXTextControl.LoadSettings {
				ApplicationFieldFormat = TXTextControl.ApplicationFieldFormat.MSWord,
				LoadSubTextParts = true
			};

			// Load the 'Template.docx' template
			m_txTextControl.Load(@"Files\Template.docx", TXTextControl.StreamType.WordprocessingML, lsLoadSettings);
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** Merge_Click Handler
		** Use the MailMerge instance to merge the data.
        **-----------------------------------------------------------------------------------------------------------*/
		private void Merge_Click(object sender, EventArgs e) {
			m_mmMailMerge.Merge(m_dsData.Tables["orders"], true);
		}
	}
}
