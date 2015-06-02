/* Controller class to manage sales associates
 *
 * 04/13/15 - Class was created
 * 
 * 04/15/14 - Login, update, and add functionality was added
 *
 * 04/16/14 - Delete functionality was added
 * 
 * 04/28/15   All functionality was tested
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

public class ManageSalesAssociateInformationController

{

    //Default constructor
    public ManageSalesAssociateInformationController()
    {
        //Does Nothing
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

        //Set the command to select users who are roots
        adap.SelectCommand = new MySqlCommand("select * from users where usergroup = @group");

        adap.SelectCommand.Parameters.AddWithValue("@group", "admin");


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
        Method: List<Quotes> retrieveAssociates()

        Function: Query the database and store all sales associates in a list of sales associate objects.
    
        Arguments: NONE

        Returns:  List of sales associates objects  
    ***************************************************************/
    public List<SalesAssociate> retrieveSalesAssociate()
    {
        //Quote list and quote object
        List<SalesAssociate> associates = new List<SalesAssociate>();

        SalesAssociate s = new SalesAssociate(0, "", "", "", "", "", 0, "", "", 0);


        //Objects for use with SQL Queries
        MySqlDataAdapter adap;
        DataSet dset;
        string sql;
        DataTable tbl;

        //Sql command sting for quotes
        sql = "Select * from salesassociates";

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

            s = new SalesAssociate(Convert.ToInt32(row["idNumber"]), row["firstName"].ToString(), row["lastName"].ToString(), row["streetAddress"].ToString(), row["city"].ToString(), row["state"].ToString(), Convert.ToInt32(row["zip"]), row["userID"].ToString(), row["password"].ToString(), Convert.ToInt32(row["totalCommission"]));
            associates.Add(s);
        }
        con.Close();

        //Return the list of quotes
        return associates;

    }

    /***************************************************************
        Method: void CreateSalesAssociate()

        Function: Add a sales associate to the database
    
        Arguments: Sales associate object

        Returns:  Nothing
    ***************************************************************/
    public void CreateSalesAssociate(SalesAssociate s)
    {
        //Objects for use with SQL Queries
        MySqlDataAdapter adap;
        string sql;
        
        //Sql command sting for quotes
        sql = "Select * from salesassociates";

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


        //Set sql command string to get the max sales associate id
        sql = "select max(idNumber) as idNumber from salesassociates";

        //Set the command equal to to the sql command we just set
        MySqlCommand cmd = new MySqlCommand(sql);

        //Set the connection to the open connection
        cmd.Connection = con;

        //Get the returned value
        int idnum = Convert.ToInt32(cmd.ExecuteScalar());

        //Set the id number to one greater than the current highest
        s.salesID = idnum + 1;

        
        //Create a new data adapter
        adap = new MySqlDataAdapter(sql, con);

        //Set the command to insert
        adap.InsertCommand = new MySqlCommand("insert into salesassociates(idNumber, firstName, lastName, streetAddress, city, state, zip, userID, password, totalCommission) values(@id, @first, @last, @street, @city, @state, @zip, @user, @pass, @total)");

        //Add the valuses as parameters
        adap.InsertCommand.Parameters.AddWithValue("@id", s.salesID);
        adap.InsertCommand.Parameters.AddWithValue("@first", s.firstName);
        adap.InsertCommand.Parameters.AddWithValue("@last", s.lastName);
        adap.InsertCommand.Parameters.AddWithValue("@street", s.streetAddress);
        adap.InsertCommand.Parameters.AddWithValue("@city", s.city);
        adap.InsertCommand.Parameters.AddWithValue("@state", s.state);
        adap.InsertCommand.Parameters.AddWithValue("@zip", s.zip);
        adap.InsertCommand.Parameters.AddWithValue("@user", s.userID);
        adap.InsertCommand.Parameters.AddWithValue("@pass", s.password);
        adap.InsertCommand.Parameters.AddWithValue("@total", s.totalCommission);

        //Set the connection to the one we openened 
        adap.InsertCommand.Connection = con;

        //Run the command
        adap.InsertCommand.ExecuteNonQuery();
     
        //Close the connection
        con.Close();

        MessageBox.Show("Successfully Added the Sales Associate!");


    }

    /***************************************************************
        Method: void updateSalesAssociate()

        Function: Update sales associatte information in the database
    
        Arguments: Sales associate object

        Returns:  Nothing
    ***************************************************************/
    public void modifyData(SalesAssociate s)
    {

        //Objects for use with SQL Queries
        MySqlDataAdapter adap;
        string sql;

        //Sql command sting for quotes
        sql = " ";

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


        adap = new MySqlDataAdapter(sql, con);

        adap.UpdateCommand = new MySqlCommand("update salesassociates set firstName = @first,  lastName = @last, streetAddress = @street, city = @city, state = @state, zip = @zip, userID = @user where idNumber = @id");

        adap.UpdateCommand.Parameters.AddWithValue("@first", s.firstName);
        adap.UpdateCommand.Parameters.AddWithValue("@last", s.lastName);
        adap.UpdateCommand.Parameters.AddWithValue("@street", s.streetAddress);
        adap.UpdateCommand.Parameters.AddWithValue("@city", s.city);
        adap.UpdateCommand.Parameters.AddWithValue("@state", s.state);
        adap.UpdateCommand.Parameters.AddWithValue("@zip", Convert.ToInt32(s.zip));
        adap.UpdateCommand.Parameters.AddWithValue("@user", s.userID);
        adap.UpdateCommand.Parameters.AddWithValue("@id", Convert.ToInt32(s.salesID));

        adap.UpdateCommand.Connection = con;

        adap.UpdateCommand.ExecuteNonQuery();

        con.Close();

        MessageBox.Show("Successfully Updated the Associate");
    }

    /***************************************************************
        Method: void deleteSalesAssociate()

        Function: Delete a sales associate from the database
    
        Arguments: Sales associate object

        Returns:  Nothing
    ***************************************************************/
    public void deleteSalesAssociate(SalesAssociate s)
    {
        DialogResult dialogResult = MessageBox.Show("Are you sure tyou would like to delete " + s.firstName + " " + s.lastName, "Are you sure?", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            //Objects for use with SQL Queries
            MySqlDataAdapter adap;
            string sql;

            //Sql command sting for quotes
            sql = " ";

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


            adap = new MySqlDataAdapter(sql, con);

            adap.DeleteCommand = new MySqlCommand("delete from salesassociates where idNumber = @id");

            adap.DeleteCommand.Parameters.AddWithValue("@id", s.salesID);

            adap.DeleteCommand.Connection = con;

            adap.DeleteCommand.ExecuteNonQuery();

            con.Close();
        }
        else if (dialogResult == DialogResult.No)
        {
            MessageBox.Show("Do not Delete");
        }
    }
}