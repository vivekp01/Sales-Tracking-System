/* Class used to retrieve all quotes from the database and show them in a DataGridView for user selection
 * 
 * 04/07/15 - Form was designed
 *            Datagridview was filled with quotes using the controller class method to retrieve the quotes from the database
 *            
 * 04/28/15   All functionality tested
 *           
 *
 * Programmer: Vivek Patel, Eric Johansen, Jacob Peterson Current: 04/28/15
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EditQuotes
{
    public partial class frmRetrieveQuotes : Form
    {
        List<Quote> quotes = new List<Quote>();
        ManageQuotesController controller = new ManageQuotesController();

        public frmRetrieveQuotes()
        {
            InitializeComponent();
            
            //Set autogenerate columns to false as columns have already been added
            dgvQuotes.AutoGenerateColumns = false;
            
            //Retrieve the quotes using the controller class method
            quotes = controller.retrieveQuotes(); 

            //For each quote put the values in the datagridview
            foreach (Quote q in quotes)
            {
                this.dgvQuotes.Rows.Add(q.quoteID, q.salesAssociateID, q.customerName, q.customerContact, q.customerEmailAddress, q.totalCost, q.status);
            }



        }

        //Method to handle a user clicking on a datagridview row
        private void dgvQuotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //For the row selected
            foreach (DataGridViewRow row in dgvQuotes.SelectedRows)
            {
                //Pass the quote object to a newly instantiated UpdateQuote form object
                frmUpdateQuote f = new frmUpdateQuote(quotes[dgvQuotes.CurrentCell.RowIndex]);

                //Show the Update form
                f.ShowDialog();

                //Retrieve the quotes using the controller class method
                quotes = controller.retrieveQuotes();

                //Clear out the datagrid view
                this.dgvQuotes.Rows.Clear();
                
                //For each quote put the values in the datagridview
                foreach (Quote q in quotes)
                {
                    this.dgvQuotes.Rows.Add(q.quoteID, q.salesAssociateID, q.customerName, q.customerContact, q.customerEmailAddress, q.totalCost, q.status);
                }
            }


        }



        

    }
}
