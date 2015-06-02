/* Form to manage sales associates
 *
 * 04/13/15 - Form was  partially designed
 * 
 * 04/15/14 - Form was completed, update and add functionality was added through controller
 *
 * 04/16/14 - Delete functionality was added through controller class
 * 
 * 04/28/15   All functionality was tested
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
using System.Security.Cryptography;

namespace AdminInterface
{
    public partial class frmManageAssociates : Form
    {
        SalesAssociate associate;
        List<SalesAssociate> associates = new List<SalesAssociate>();
        ManageSalesAssociateInformationController controller = new ManageSalesAssociateInformationController();

        public frmManageAssociates()
        {
            InitializeComponent();
            
            //Retrieve all associates for editing
            retrieveAssociates();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Temp int for zip vlidation
            int temp;

            if (int.TryParse(tbNewZip.Text, out temp) == false)
            {
                MessageBox.Show("ZIP code must be numerical!", "Error!");
            }
            else if (tbNewFirst.Text == "" || tbNewLast.Text == "" || tbNewStreet.Text == "" || tbNewCity.Text == "" || tbNewState.Text == "" || tbNewZip.Text == "" || tbNewUserID.Text == "" || tbPass.Text == "")
            {
                MessageBox.Show("Please fill in ALL fields!", "Error!");
            }
            else
            {
                //Hash the password
                MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(tbPass.Text);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                string pass = sb.ToString().ToLower();


                //Create a new sales associate object using the field data and the hashed password
                SalesAssociate s = new SalesAssociate(0, tbNewFirst.Text, tbNewLast.Text, tbNewStreet.Text, tbNewCity.Text, tbNewState.Text, Convert.ToInt32(tbNewZip.Text), tbNewUserID.Text, pass, 0);
                
                //Call the controller class Add method to add the new associate to the database
                controller.CreateSalesAssociate(s);

                tbNewFirst.Text = "";
                tbNewLast.Text = "";
                tbNewStreet.Text = "";
                tbNewCity.Text = "";
                tbNewState.Text = "";
                tbNewZip.Text = "";
                tbNewUserID.Text = "";
                tbPass.Text = "";

                //Update the datagrid views with the new associate
                dgvAssociates.Rows.Clear();
                dgvDelete.Rows.Clear();
                retrieveAssociates();

            }


        }

        public void retrieveAssociates()
        {
            //Set autogenerate columns to false as columns have already been added
            dgvAssociates.AutoGenerateColumns = false;

            //Retrieve the quotes using the controller class method
            associates = controller.retrieveSalesAssociate();

            //For each quote put the values in the datagridviews
            foreach (SalesAssociate s in associates)
            {
                this.dgvAssociates.Rows.Add(s.salesID, s.firstName, s.lastName, s.streetAddress, s.city, s.state, s.zip, s.totalCommission);
                this.dgvDelete.Rows.Add(s.salesID, s.firstName, s.lastName, s.streetAddress, s.city, s.state, s.zip, s.totalCommission);

            }
        }


        private void dgvAssociates_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //For the row selected
            foreach (DataGridViewRow row in dgvAssociates.SelectedRows)
            {
                //Grab the selected associate object
                associate = associates[dgvAssociates.CurrentCell.RowIndex];
                
                //Set the fields to the selected associates values
                tbID.Text = associate.salesID.ToString();
                tbFirst.Text = associate.firstName;
                tbLast.Text = associate.lastName;
                tbStreet.Text = associate.streetAddress;
                tbCity.Text = associate.city;
                tbState.Text = associate.state;
                tbZip.Text = associate.zip.ToString();
                tbUserID.Text = associate.userID;
                tbCommission.Text = associate.totalCommission.ToString();

                //Show the selected sales associate data
                tbID.Visible = true;
                tbFirst.Visible = true;
                tbLast.Visible = true;
                tbStreet.Visible = true;
                tbCity.Visible = true;
                tbState.Visible = true;
                tbZip.Visible = true;
                tbUserID.Visible = true;
                tbCommission.Visible = true;
                btnUpdate.Visible = true;
                lblFirst.Visible = true;
                lblLast.Visible = true;
                lblStreet.Visible = true;
                lblCity.Visible = true;
                lblState.Visible = true;
                lblZip.Visible = true;
                lblUserID.Visible = true;
                lblComm.Visible = true;
                lblID.Visible = true;

                //Hide the datagrid view
                dgvAssociates.Visible = false;
                lblUpdate.Visible = false;


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Temp int for zip validation
            int temp;

            if (int.TryParse(tbZip.Text, out temp) == false)
            {
                MessageBox.Show("ZIP code must be numerical!", "Error!");
            }
            else if (tbFirst.Text == "" || tbLast.Text == "" || tbStreet.Text == "" || tbCity.Text == "" || tbState.Text == "" || tbZip.Text == "" || tbUserID.Text == "")
            {
                MessageBox.Show("Please fill in ALL fields!", "Error!");
            }
            else
            {
                //Set the sales object values to the modified ones
                associate.firstName = tbFirst.Text;
                associate.lastName = tbLast.Text;
                associate.streetAddress = tbStreet.Text;
                associate.city = tbCity.Text;
                associate.state = tbState.Text;
                associate.zip = Convert.ToInt32(tbZip.Text);
                associate.userID = tbUserID.Text;

                //Call the controller class update command to run the update
                controller.modifyData(associate);

                //Hide the sales associate data fields
                tbID.Visible = false;
                tbFirst.Visible = false;
                tbLast.Visible = false;
                tbStreet.Visible = false;
                tbCity.Visible = false;
                tbState.Visible = false;
                tbZip.Visible = false;
                tbUserID.Visible = false;
                tbCommission.Visible = false;
                btnUpdate.Visible = false;
                lblFirst.Visible = false;
                lblLast.Visible = false;
                lblStreet.Visible = false;
                lblCity.Visible = false;
                lblState.Visible = false;
                lblZip.Visible = false;
                lblUserID.Visible = false;
                lblComm.Visible = false;
                lblID.Visible = false;


                //Show the datagrid view and retrieve the sales associates
                dgvAssociates.Rows.Clear();
                dgvDelete.Rows.Clear();
                retrieveAssociates();
                dgvAssociates.Visible = true;
                lblUpdate.Visible = true;
            }
        }

        private void dgvDelete_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Set the sales associate object equal to the one selected
            associate = associates[dgvDelete.CurrentCell.RowIndex];

            //Delete the associate
            controller.deleteSalesAssociate(associate);

            //Reset the data grid views with the sales associates
            dgvAssociates.Rows.Clear();
            dgvDelete.Rows.Clear();
            retrieveAssociates();

            //Hide the sales associate data fields (in case the deleted associate was in edit mode)
            tbID.Visible = false;
            tbFirst.Visible = false;
            tbLast.Visible = false;
            tbStreet.Visible = false;
            tbCity.Visible = false;
            tbState.Visible = false;
            tbZip.Visible = false;
            tbUserID.Visible = false;
            tbCommission.Visible = false;
            btnUpdate.Visible = false;
            lblFirst.Visible = false;
            lblLast.Visible = false;
            lblStreet.Visible = false;
            lblCity.Visible = false;
            lblState.Visible = false;
            lblZip.Visible = false;
            lblUserID.Visible = false;
            lblComm.Visible = false;
            lblID.Visible = false;

            //Show the datagrid view
            dgvAssociates.Visible = true;
            lblUpdate.Visible = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Generate a random password using crypto class
            char[] chars = new char[62];
            chars =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[8];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder result = new StringBuilder(8);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }

            //Store the password in a string
            string pass = result.ToString();

            //If the password is not secure enough then re-generate it otherwise use it
            if (!(pass.Any(char.IsDigit)) || !(pass.Any(char.IsUpper)) || !(pass.Any(char.IsLower)) || !(pass.IndexOfAny(new char[] { '!', '@', '#', '$', '%', '^' }) != -1))
            {
                btnGenerate.PerformClick();
            }
            else
            {
                tbPass.Text = pass;
            }
        }



 
    }
}
