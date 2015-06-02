/* Class used to allow modification of quotes (changes will be committed in the controller class
 * 
 * 04/07/15 - Form was created and partially designed
 *            Fields were filled using the quote object
 *            
 * 04/13/15   Update functionality was added through the controller.                       
 * 
 * 04/28/15   All functionality tested
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
    public partial class frmUpdateQuote : Form
    {
            
        //Quote object to hold the quote that will be passed in
        public Quote quote;
        ManageQuotesController  controller = new ManageQuotesController();

        public frmUpdateQuote(Quote q)
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

            if (q.status == "Unsanctioned")
            {
                cbStatus.SelectedIndex = 1;
            }
            else
            {
                cbStatus.SelectedIndex = 0;
            }


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
            int temp;

            for (int i = 0; i < dgvItems.Rows.Count-1; ++i)
            {
                if (dgvItems.Rows[i].Cells[1].Value != "" && dgvItems.Rows[i].Cells[1].Value != null && int.TryParse(dgvItems.Rows[i].Cells[1].Value.ToString(), out temp))
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
            quote.items = new List<string>();
            quote.prices = new List<int>();
            quote.notes = new List<string>();

            if (cbStatus.SelectedIndex == 1)
            {
                quote.status = "Unsanctioned";
            }
            else
            {
                quote.status = "Sanctioned";
            }

            //Update the discount in the quote object
            quote.discount = Convert.ToInt32(tbDiscount.Text.ToString());

            //Store new items and prices in the quote object
            for (int i = 0; i < dgvItems.Rows.Count-1; ++i)
            {        
                //Store the items and prices in the item and prices list
                if (dgvItems.Rows[i].Cells[0].Value != "" && dgvItems.Rows[i].Cells[1].Value != "")
                {
                    quote.items.Add(dgvItems.Rows[i].Cells[0].Value.ToString());
                    quote.prices.Add(Convert.ToInt32(dgvItems.Rows[i].Cells[1].Value));
                }
            }

            //Store new notes in the quote object
            for (int i = 0; i < dgvNotes.Rows.Count - 1; ++i)
            {
                if (dgvNotes.Rows[i].Cells[0].Value != null)
                {
                    //Store the items and prices in the item and prices list
                    quote.notes.Add(dgvNotes.Rows[i].Cells[0].Value.ToString());
                }
            }


            //Commit the changes to the db using the controller method. 
            string result = controller.updateQuote(quote);

            MessageBox.Show(result);
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
