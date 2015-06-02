/* Class used to allow modification of quotes (changes will be committed in the controller class
 * 
 * 04/07/15 - Form was created and partially designed
 *            Fields were filled using the quote object
 *            
 * 04/13/15   Update functionality was added through the controller.                       
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

namespace CreatePurchaseOrders
{
    public partial class frmCreatePurchaseOrder : Form
    {
            
        //Quote object to hold the quote that will be passed in
        public Quote quote;
        CreatePurchaseOrdersController  controller = new CreatePurchaseOrdersController();

        public frmCreatePurchaseOrder(Quote q)
        {
            InitializeComponent();

            //Set the quote data member equal to the passed in quote object
            quote = q;

            //Fill the form fields using the quote object data memnbers
            tbID.Text = q.quoteID.ToString();
            tbSalesID.Text = q.salesAssociateID.ToString();
            tbName.Text = q.customerName;
            tbContact.Text = q.customerContact;
            tbEmail.Text = q.customerEmailAddress;
            lblCost.Text = q.totalCost.ToString();
            tbDiscount.Text = q.discount.ToString();
            tbStatus.Text = "Sanctioned";
                
           

            //Add an event handler for the items datagrid view to determine when a column is changed
            this.dgvItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellValueChanged);

            //Fill the datagridview for items using the list
            for (int i = 0; i < quote.items.Count; i++)
            {
                this.dgvItems.Rows.Add(quote.items[i], quote.prices[i].ToString());
            }

            //Fill the datagridview for notes using the list provided there are notes
            if (quote.notes.Count > 0)
            {
                for (int i = 0; i < quote.notes.Count; i++)
                {
                    this.dgvNotes.Rows.Add(quote.notes[i]);
                }
            }
        }

        //When datagridview cell is changed
        private void dgvItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


            int sum = 0;
            for (int i = 0; i < dgvItems.Rows.Count; ++i)
            {
                if (dgvItems.Rows[i].Cells[1].Value != "")
                {
                    sum += Convert.ToInt32(dgvItems.Rows[i].Cells[1].Value);

                }
            }

            //Remove the discount from the total
            sum -= quote.discount;

            lblCost.Text = sum.ToString();
            if (quote != null)
            {
                quote.totalCost = sum;
            }
        }

        //When the update button is clicked
        private void btnUpdate_Click(object sender, EventArgs e)
        {
           controller.convertToPurchaseOrder(quote);
           this.Close();
        }

        //Update the total cost displayed on the page
        private void tmrCost_Tick(object sender, EventArgs e)
        {
            lblCost.Text = (quote.totalCost - quote.discount).ToString();
        }

        //When the discount it added add it to the quote object
        private void tbDiscount_TextChanged(object sender, EventArgs e)
        {
            if(tbDiscount.Text!= "")
                quote.discount = Convert.ToInt32(tbDiscount.Text.ToString());
        }

        
        


    }
}
