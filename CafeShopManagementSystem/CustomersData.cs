using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class CustomersData
{
    SqlConnection connect = new SqlConnection(
        @"Data Source=DESKTOP-M26C3G9;Initial Catalog=aplikasiCafe;Integrated Security=True"
    );

    public int Id { get; set; }
    public int CustomerID { get; set; }
    public double TotalPrice { get; set; }
    public double Amount { get; set; }
    public double Change { get; set; }
    public DateTime Date { get; set; }

    public List<CustomersData> allCustomersData()
    {
        List<CustomersData> list = new List<CustomersData>();

        try
        {
            connect.Open();

            string query =
                "SELECT id, customer_id, total_price, amount, [change], date FROM customers";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    CustomersData c = new CustomersData();

                    c.Id = reader.GetInt32(0);
                    c.CustomerID = reader.GetInt32(1);
                    c.TotalPrice = Convert.ToDouble(reader["total_price"]);
                    c.Amount = Convert.ToDouble(reader["amount"]);
                    c.Change = Convert.ToDouble(reader["change"]);
                    c.Date = Convert.ToDateTime(reader["date"]);

                    list.Add(c);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);
        }
        finally
        {
            connect.Close();
        }

        return list;
    }
}
