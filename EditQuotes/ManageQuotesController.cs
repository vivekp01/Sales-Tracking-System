/* Controller class used to handle all external system access for all other forms and classes
 *
 * 04/07/15 - Class was created
 *            Login method was written to interface with the Quotes database and verify usernames and passwords 
 *            retrieveQuotes method was created to reteieve all quotes and associated items, prices and notes
 * 
 * 04/13/15   Update quote was written with full functionality
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

public class ManageQuotesController
{

    //Default constructor
	public ManageQuotesController()
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
        Quote q = new Quote(0,0,0," ", " ", " ", " ", 0);


        //Objects for use with SQL Queries
        MySqlDataAdapter adap;
        DataSet dset;
        string sql;
        DataTable tbl, tbl1, tbl2;

        //Sql command sting for quotes
        sql = "Select * from quotes";

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

        adap.SelectCommand = new MySqlCommand("select * from quotes where Status = @status");

        adap.SelectCommand.Parameters.AddWithValue("@status", "Unsanctioned");

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
    Method: string updateQuote(Quote Q)

    Function: Store the updated quote data in the database
    
    Arguments: QUoteo 0bject to update

    Returns:  String with update status (success or failure)
    ***************************************************************/
    public string updateQuote(Quote Q)
    {
        //Grab the lists to be updated / added to the database
        List<string> items = Q.items;
        List<int> prices = Q.prices;

        //Create a mysql command for the inserts
        MySqlCommand cmd = new MySqlCommand();


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


        //Delete all notes
        cmd.CommandText= "DELETE FROM secretnotes WHERE quoteID=@id;";
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@id", Q.quoteID);
        cmd.ExecuteNonQuery();

        //Insert the edited / new notes
        foreach (string  n in Q.notes)
        {
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO secretNotes(QuoteID, secretNote) VALUES (@id, @note);";
            cmd.Parameters.AddWithValue("@id", Q.quoteID);
            cmd.Parameters.AddWithValue("@note", n);
            cmd.ExecuteNonQuery();
        }


        //Delete all items
        cmd.Parameters.Clear();
        cmd.CommandText = "DELETE FROM items WHERE quoteID=@id;";
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@id", Q.quoteID);
        cmd.ExecuteNonQuery();

        //Insert the edited / new items and prices. 
        for( int i = 0; i < items.Count; i++)
        {
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO items(QuoteID, itemDescription, itemPrice) VALUES (@id, @item, @price);";
            cmd.Parameters.AddWithValue("@id", Q.quoteID);
            cmd.Parameters.AddWithValue("@item", items[i]);
            cmd.Parameters.AddWithValue("@price", prices[i]);
            cmd.ExecuteNonQuery();
        }


        //Insert the new total
        cmd.Parameters.Clear();
        cmd.CommandText = "UPDATE quotes set TotalCost = @total WHERE quoteID=@id;";
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@id", Q.quoteID);
        cmd.Parameters.AddWithValue("@total", Q.totalCost);
        cmd.ExecuteNonQuery();

        //Insert the discount
        cmd.Parameters.Clear();
        cmd.CommandText = "UPDATE quotes set discount = @disc WHERE quoteID=@id;";
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@id", Q.quoteID);
        cmd.Parameters.AddWithValue("@disc", Q.discount);
        cmd.ExecuteNonQuery();


        //Update the status
        cmd.Parameters.Clear();
        cmd.CommandText = "UPDATE quotes set status = @stat WHERE quoteID=@id;";
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@id", Q.quoteID);
        cmd.Parameters.AddWithValue("@stat", Q.status);
        cmd.ExecuteNonQuery();

        //Close the connection
        con.Close();

        //Return success message
        return "Successfully Updated the Quote!";
    }


}
