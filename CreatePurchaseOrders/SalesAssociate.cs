/* Class used to srtore sales associate data and commission 
 * 
 * 04/07/15 - Class was created
 * 
 * 4/13/14 - Sales commission computation and database storage was added.
 *  
 * 04/28/15   All functionality tested
 *
 * Programmer: Vivek Patel, Eric Johansen, Jacob Peterson Current: 04/28/15
 */
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

public class SalesAssociate
{
    //Data members
    public int salesID;
    public string firstName;
    public string lastName;
    public string streetAddress;
    public string city;
    public string state;
    public int zip;
    public string userID;
    public string password;
    public double totalCommission;


    //Constructor
    public SalesAssociate(int id, string first, string last, string street, string cty, string ste, int z, string user, string pass, double total)
    {
        salesID = id;
        firstName = first;
        lastName = last;
        streetAddress = street;
        city = cty;
        state = ste;
        zip = z;
        userID = user;
        password = pass;
        totalCommission = total;

    }

    public void computeSalesCommission(double total, double rate)
    {
        //Calculate total commission
        totalCommission = total * (rate / 100);

        //Objects for use with SQL Queries
        MySqlDataAdapter adap;
        DataSet dset;
        string sql;
        DataTable tbl;

        //Sql command sting for users
        sql = "Select * from salesassociates";
        
        //Connect to the database
        MySqlConnectionStringBuilder _connectionStr = new MySqlConnectionStringBuilder
        {
            Server = "67.163.4.82",
            Database = "csci467",
            UserID = "admin",
            Password = "csci4671@",
            ConnectionTimeout = 60,
            Port = 3307,
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

        //Set the command to select from sales associates if the id matches
        adap.SelectCommand = new MySqlCommand("select * from salesassociates where idNumber = @id");

        //add the id as a parameter
        adap.SelectCommand.Parameters.AddWithValue("@id", salesID);

        //set the connection to con
        adap.SelectCommand.Connection = con;

        //Create a new dataset
        dset = new DataSet();

        //fill the dataset
        adap.Fill(dset);

        //Extract the data table
        tbl = dset.Tables[0];

        //For each row (should only be 1 in this case)
        foreach (DataRow row in tbl.Rows)
        {
            //Grab the total commission
            string result = row["totalCommission"].ToString();

            //Add the new commission
            
        }
        
        //Create a new data adapter
        adap = new MySqlDataAdapter();

        //Set the update command to update the commission
        adap.UpdateCommand= new MySqlCommand("update salesassociates set totalCommission = totalCommission + @total where idNumber = @id");

        //Add the paramaters for the command
        adap.UpdateCommand.Parameters.AddWithValue("@total", totalCommission);
        adap.UpdateCommand.Parameters.AddWithValue("@id", salesID);

        //Set the connection to con
        adap.UpdateCommand.Connection = con;

        //Run the update command
        adap.UpdateCommand.ExecuteNonQuery();

        //Show a message if successful
        MessageBox.Show("Commission amount: " + totalCommission + " has been stored for sales associate " + salesID); 

        //Close the connection
        con.Close();

    }
}