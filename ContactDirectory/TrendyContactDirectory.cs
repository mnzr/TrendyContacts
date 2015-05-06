using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactDirectory
{
    /// <summary>
    /// Class that represents the Main Form of the application
    /// </summary>
    public partial class TrendyContactDirectory : Form
    {
        /// <summary>
        /// Constructor of the form which will create and initialize all the controls of the form
        /// </summary>
        public TrendyContactDirectory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler when the user clicks on the company logo. Displays the about information
        /// </summary>
        /// <param name="sender">the image (picture box) control</param>
        /// <param name="e"></param>
        private void logoBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trendy Contact Directory helps you save your contacts. (C) TrendBreaker LTD.");
        }

        /// <summary>
        /// Event handler for saving new record being added to the contacts table when clicked.
        /// </summary>
        /// <param name="sender">The save button on the binding navigarot tool.</param>
        /// <param name="e"></param>
        private void contactsBindingSourceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactsBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.contactDataSet);
        }

        private void TrendyContactDirectory_Load(object sender, EventArgs e)
        {
            // fill the local data set which caches the databasae data local in memory with data from the database
            contactsTableAdapter1.Fill(contactDataSet.Contacts);
        }

        private void OnClose(object sender, EventArgs e)
        {
            // Close the form and the application
            Close();
        }

        
    }
}
