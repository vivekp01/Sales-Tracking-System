/* Quotes class for use with the Manager Interface, Purchase Order Interface and associated controllers
 * 
 * 04/07/15 - Class was created
 * 
 * 04/28/15   All functionality tested
 *
 * Programmer: Vivek Patel, Eric Johansen, Jacob Peterson Current: 04/28/15
 */

using System;
using System.Collections.Generic;

public class Quote
{
    //Data members
    public int quoteID;
    public int totalCost;
    public int salesAssociateID;
    public string customerName;
    public string customerContact;
    public string customerEmailAddress;
    public string status;
    public int discount;
    public List<string> items;
    public List<int> prices;
    public List<string> notes;

    //Constructor
	public Quote(int id, int cost, int salesID, string name, string contact, string email, string stat, int disc)
	{
        quoteID = id;
        totalCost = cost;
        salesAssociateID = salesID;
        customerName = name;
        customerContact = contact;
        customerEmailAddress = email;
        status = stat;
        discount = disc;
        items = new List<string>();
        notes = new List<string>();
        prices = new List<int>();

	}
}
