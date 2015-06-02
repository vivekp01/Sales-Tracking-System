/* Login form used to authenticate users
 * This form uses the controller class to handle the actual authorization
 *
 * 04/01/15 - Form was designed
 * 
 * 04/07/15 - Login functionality was added so users could be authorized (Using the controller class)
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
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace EditQuotes
{
    public partial class frmLogin : Form
    {
        //Create conteroller class object for use within the login form
        ManageQuotesController controller = new ManageQuotesController();

        public frmLogin()
        {
            InitializeComponent();
        }

        //METHOD TO HANDLE LOGIN BUTTON CLICK
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Validate user input
            if (tbUser.Text == "" && tbPass.Text == "" )
            {
                MessageBox.Show("Please enter a username and password!", "Error!");
            }

            else if (tbUser.Text == "")
            {
                MessageBox.Show("Please enter a username!", "Error!");
            }

            else if (tbPass.Text == "")
            {
                MessageBox.Show("Please enter a password!", "Error!");
            }

            else
            {

                // Use input string to calculate MD5 hash
                MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(tbPass.Text);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                string pass =  sb.ToString();


                //Call the controller classes login function to authenticate the user
                string result = controller.login(tbUser.Text.ToString(), pass);


                //If the reretued value from the login function was Y allow access
                if (result.Equals("Y"))
                {

                    MessageBox.Show("Login Succeeded");
                    
                    //Instantiate the retrieveQuotes form
                    frmRetrieveQuotes select = new frmRetrieveQuotes();
                    
                    //Shopw the newly instantiated forn and close this one
                    select.ShowDialog();
                    this.Close();
                }
                else
                {
                    //Display an login failed message as the username or password was incorrect
                    MessageBox.Show("Login Failed: Invalid username or password");
                }
            }
        }
    }
}
