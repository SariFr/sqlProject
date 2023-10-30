using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace sqlProject;

public class DataAccess
{
    public int InsertDataCategory(string connectionString)
    {
        string  Name;
        Console.WriteLine("insert name category");
        Name = Console.ReadLine();

        string query = "INSERT INTO CATEGORY(Name )" +
                     "VALUES (@Name)";

        using (SqlConnection con = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            cmd.Parameters.Add("@Name", SqlDbType.NChar, 50).Value = Name;

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            return rowsAffected;
        }
    }
    public int InserData(string connectionString)
    {
      

        string categoryId, Name, Price, Des, Image;
        Console.WriteLine("insert category");
        categoryId = Console.ReadLine();
        Console.WriteLine("insert name product");
        Name = Console.ReadLine();
        Console.WriteLine("insert price");
        Price = Console.ReadLine();
        Console.WriteLine("insert Des");
        Des = Console.ReadLine();
        Console.WriteLine("insert image");
        Image = Console.ReadLine();


        string query = "INSERT INTO PRODUCT(categoryId, Name, Price, Des, Image)" +
                     "VALUES (@CategoryId, @Name, @Price, @Des, @Image)";
    
        using (SqlConnection con=new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            cmd.Parameters.Add("@CategoryId",SqlDbType.NChar, 50).Value = categoryId;
            cmd.Parameters.Add("@Name", SqlDbType.NChar, 50).Value = Name;
            cmd.Parameters.Add("@Price", SqlDbType.NChar, 50).Value = Price;
            cmd.Parameters.Add("@Des", SqlDbType.NChar, 50).Value = Des;
            cmd.Parameters.Add("@Image", SqlDbType.NChar, 50).Value = Image;

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            return rowsAffected;
        }


    }


    internal void readData(string connectionString)
    {
        string queryString = "select * from Product";
        using (SqlConnection connection= new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}",
                        reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                }
                reader.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }




    internal void readDataCategory(string connectionString)
    {
        string queryString = "select * from Category";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}",
                        reader[0], reader[1]);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }



















    //private static void CreateCommand(string queryString,string connectionString)
    //{
    //    using (SqlConnection connection=new SqlConnection(connectionString))
    //    {
    //        SqlCommand command = new SqlCommand(queryString, connection);
    //        command.Connection.Open();
    //        command.ExecuteNonQuery();
    //    }
    //}
}
