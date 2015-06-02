/* Login form used to authenticate users
 * This form uses the controller class to handle the actual authorization
 *
 * 04/07/15 Added login, and retrieve quotes functionality 
 * 
 * 04/07/15 - Login functionality was added so users could be authorized (Using the controller class)
 *
 * 04/13/15 Added convert to purchase order functionality
 * 
 * 04/28/15   All functionality tested
 * 
 * Programmer: Vivek Patel, Eric Johansen, Jacob Peterson Current: 04/28/15
 */

using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Text;
using System.Net.Sockets;
using System.Net;

public class CreatePurchaseOrdersController

{

    //Default constructor
    public CreatePurchaseOrdersController()
    {

    }

    /***************************************************************
        Method: login(string, string)

        Function: Compare username and password with those in the database (specifically the users table)
    
        Arguments: username and password as strings

        Returns:  Y is username and password match a database entry or N if they dont.    
    ***************************************************************/
    public string login(string user, string pass)
    {
        //Objects for use with SQL Queries
        MySqlDataAdapter adap;
        DataSet dset;
        string sql;
        DataTable tbl;

        //Sql command sting for users
        sql = "Select * from users";

        //Connect to the database
        MySqlConnectionStringBuilder _connectionStr = new MySqlConnectionStringBuilder
        {
            Server = "127.0.0.1",
            Database = "csci467",
            UserID = "root",
            Password = "csci4671@",
            ConnectionTimeout = 60,
            Port = 3306,
            AllowZeroDateTime = true
        };

        //Create a new mysql connection
        MySqlConnection con = new MySqlConnection(_connectionStr.ConnectionString);

        //Try to open the connection
        try
        {
            con.Open();
        }
        catch
        {
            Console.WriteLine("Error, help i can't get connected!");
        }

        //Create a new data adapter with the query and the connectionn
        adap = new MySqlDataAdapter(sql, con);

        //Set the select command connection
        adap.SelectCommand.Connection = con;

        //Create the DataSet
        dset = new DataSet();

        //Fill the DataSet
        adap.Fill(dset);

        //Extract the DataTable
        tbl = dset.Tables[0];

        //Loop through the rows and check username and password
        foreach (DataRow row in tbl.Rows)
        {
            //If the username and password match then return Y
            if (user.ToLower() == row["username"].ToString().ToLower() && pass.ToLower() == row["password"].ToString().ToLower())
            {
                return "Y";
            }

        }

        //if the username and password do not match or there was an error then return N
        return "N";
    }
    /***************************************************************
        Method: List<Quotes> retrieveQuotes()

        Function: Query the database and store all quotes in a list of quote objects.
    
        Arguments: NONE

        Returns:  List of quote objects  
    ***************************************************************/
    public List<Quote> retrieveQuotes()
    {
        //Quote list and quote object
        List<Quote> quotes = new List<Quote>();
        Quote q = new Quote(0, 0, 0, " ", " ", " ", " ", 0);


        //Objects for use with SQL Queries
        MySqlDataAdapter adap;
        DataSet dset;
        string sql;
        DataTable tbl, tbl1, tbl2;

        //Sql command sting for quotes
        sql = "Select * from quotes where Status = 'Sanctioned'";

        //Connect to the database
        MySqlConnectionStringBuilder _connectionStr = new MySqlConnectionStringBuilder
        {
            Server = "127.0.0.1",
            Database = "csci467",
            UserID = "root",
            Password = "csci4671@",
            ConnectionTimeout = 60,
            Port = 3306,
            AllowZeroDateTime = true
        };

        //Create a new mysql connection
        MySqlConnection con = new MySqlConnection(_connectionStr.ConnectionString);

        //Try to open the connection
        try
        {
            con.Open();
        }
        catch
        {
            Console.WriteLine("Error, help i can't get connected!");
        }

        //Create a new data adapter with the query and the connectionn
        adap = new MySqlDataAdapter(sql, con);

        //Set the select command connection
        adap.SelectCommand.Connection = con;

        //Create the DataSet
        dset = new DataSet();

        //Fill the DataSet
        adap.Fill(dset);

        //Extract the DataTable
        tbl = dset.Tables[0];

        //Loop through the rows and check username and password
        foreach (DataRow row in tbl.Rows)
        {
            q = new Quote(Convert.ToInt32(row["QuoteID"]), Convert.ToInt32(row["TotalCost"]), Convert.ToInt32(row["salesAssociateID"]), row["customerName"].ToString(), row["customerContact"].ToString(), row["CustomerEmailAddress"].ToString(), row["Status"].ToString(), Convert.ToInt32(row["discount"]));


            sql = "select * from items";

            //Create a new data adapter 
            adap = new MySqlDataAdapter(sql, con);

            //Set the command to select all the items where the quote id matches the one retrieved in the previous connection
            adap.SelectCommand = new MySqlCommand("Select * from items where QuoteID = @quoteID");
            adap.SelectCommand.Parameters.AddWithValue("@quoteID", q.quoteID);

            //Set the select command connection
            adap.SelectCommand.Connection = con;

            //Create the DataSet
            dset = new DataSet();

            //Fill the DataSet
            adap.Fill(dset);

            //Extract the DataTable
            tbl1 = dset.Tables[0];

            //Loop through the rows and add the items and prices to the quote object lists
            foreach (DataRow row1 in tbl1.Rows)
            {
                q.items.Add(row1["itemDescription"].ToString());
                q.prices.Add(Convert.ToInt32(row1["itemPrice"]));
            }

            //Reset the sql string for use with next command
            sql = "select * from secretnotes";

            //Create a new data adapter 
            adap = new MySqlDataAdapter(sql, con);

            //Set the command to select all the notes where the quote id matches the one retrieved in the first connection
            adap.SelectCommand = new MySqlCommand("Select * from secretNotes where QuoteID = @quoteID");
            adap.SelectCommand.Parameters.AddWithValue("@quoteID", q.quoteID);

            //Set the select command connection
            adap.SelectCommand.Connection = con;

            //Create the DataSet
            dset = new DataSet();

            //Fill the DataSet
            adap.Fill(dset);

            //Extract the DataTable
            tbl2 = dset.Tables[0];

            //Loop through the rows and add the notes to the quote object lists
            foreach (DataRow row1 in tbl2.Rows)
            {
                q.notes.Add(row1["secretNote"].ToString());
            }

            //Add the quote to the list of quote objects
            quotes.Add(q);
        }

        con.Close();

        //Return the list of quotes
        return quotes;

    }

    /***************************************************************
        Method: string convertToPurchaseOrder(Quote q)

        Function: Pass qouote data to the external purchase order system. Calculate the commission using the salesAssociate class method
    
        Arguments: Quote object

        Returns:  Nothing  
    ***************************************************************/
    public void convertToPurchaseOrder(Quote q)
    {
        //Create a string to pass to the purchase order system
        StringBuilder s = new StringBuilder();
        s.Append(q.quoteID).Append(":").Append(q.customerName).Append(":").Append(q.totalCost);
        string data = s.ToString();


        //Create UDP client
        UdpClient udpClient = new UdpClient(4446);

        try
        {
            udpClient.Connect("blitz.cs.niu.edu", 4446);

            // Create a byte array to pass to the server
            Byte[] sendBytes = Encoding.ASCII.GetBytes(data);

            //Send the data to the client
            udpClient.Send(sendBytes, sendBytes.Length);

            //Create an end point to receive data
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

            //Create a byte array with returned data
            Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);

            //Convert byte array to string
            string returnData = Encoding.ASCII.GetString(receiveBytes);

            //Close the udp client
            udpClient.Close();
            
            //Create a new sales associate object using the ID
            SalesAssociate sales = new SalesAssociate(q.salesAssociateID, " ", " ", " ", " ", " ",0, " ", " ", 0);

            int start, end;

            //If the returned data contains commission: it is a new purchase order
            if (returnData.Contains("commision:"))
            {
                //Find the end index of commission:
                start = returnData.IndexOf("commision:", 0) + "commision:".Length;
                
                //Find the index of the %
                end = returnData.IndexOf("%", start);
                
                //Get the rate using the two found indexes
                int rate = Convert.ToInt32(returnData.Substring(start, end - start));

                //Show the retuened purchase order info from the external system
                MessageBox.Show(returnData);

                //Compute the sales commission using the sales associate class method
                sales.computeSalesCommission(q.totalCost, rate);
            }
            else
            {
                //Show a message indicating the purchase order has already been submitted
                MessageBox.Show(returnData);
            }

        }

        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}