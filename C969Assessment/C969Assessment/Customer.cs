using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace C969Assessment
{
    // This class stores customers pulled from the database
    internal class Customer
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public int addressId { get; set; }
        public byte active { get; set; }
        public string createDate { get; set; }
        public string createdBy { get; set; }
        public string lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }

        public static MySqlDataReader reader;
        public static MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM customer", DatabaseConnection.connection);

        public static List<Customer> custList = getCustomers();

        // Default constructor
        public Customer()
        {
        }

        public Customer(int customerId, string customerName, int addressId, byte active, string createDate, string createdBy, string lastUpdate, string lastUpdateBy)
        {
            this.customerId = customerId;
            this.customerName = $"'{customerName}'";
            this.addressId = addressId;
            this.active = active;
            this.createDate = $"'{createDate}'";
            this.createdBy = $"'{createdBy}'";
            this.lastUpdate = $"'{lastUpdate}'";
            this.lastUpdateBy = $"'{lastUpdateBy}'";

            custList.Add(this);
        }

        // Query database for all customers, then store each in an Customer object, which is then tracked in a list of customers
        public static List<Customer> getCustomers()
        {
            List<Customer> customers = new List<Customer>();
            reader = dataAdapter.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.customerId = reader.GetInt32("customerId");
                customer.customerName = reader.GetString("customerName");
                customer.addressId = reader.GetInt32("addressId");
                customer.active = reader.GetByte("active");
                customer.createDate = reader.GetDateTime("createDate").ToLocalTime().ToString();
                customer.createdBy = reader.GetString("createdBy");
                customer.lastUpdate = reader.GetDateTime("lastUpdate").ToLocalTime().ToString();
                customer.lastUpdateBy = reader.GetString("lastUpdateBy");

                customers.Add(customer);
            }
            reader.Close();

            return customers;
        }

        // Add a customer to the database
        public static void addToDb(Customer customer)
        {
            MySqlCommand addCmd = new MySqlCommand("INSERT INTO customer(customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(" + customer.customerId + "," + customer.customerName + "," + customer.addressId + "," + customer.active + "," + customer.createDate + "," + customer.createdBy + "," + customer.lastUpdate + "," + customer.lastUpdateBy + ");", DatabaseConnection.connection);
            addCmd.ExecuteNonQuery();
            custList = getCustomers();
        }

        // Modify an customer entry in the database
        public static void modifyDb(Customer customer)
        {
            MySqlCommand updateCmd = new MySqlCommand("UPDATE customer SET customerName = " + customer.customerName + ", " + "addressId = " + customer.addressId + ", " + "active = " + customer.active + ", " + "lastUpdate = " + customer.lastUpdate + ", " + "lastUpdateBy = " + customer.lastUpdateBy + "WHERE customerId = " + customer.customerId + ";", DatabaseConnection.connection);
            updateCmd.ExecuteNonQuery();

            custList = getCustomers();
        }
    }
}