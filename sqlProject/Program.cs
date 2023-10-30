// See https://aka.ms/new-console-template for more information
using sqlProject;
class Program 
{         
    private string connectionString = "Data Source=SRV2\\PUPILS;Initial Catalog=WebElectricStore;Integrated Security=True";

    static void Main(string[] args)
    {
        DataAccess da = new DataAccess();
        Console.WriteLine("Are you want to insert new category y/n");
        string resC= Console.ReadLine();
        while (resC=="y")
        {
               da.InsertDataCategory("Data Source=SRV2\\PUPILS;Initial Catalog=WebElectricStore;Integrated Security=True");
               da.readDataCategory("Data Source=SRV2\\PUPILS;Initial Catalog=WebElectricStore;Integrated Security=True");
               Console.WriteLine("Are you want to insert new category y/n");
               resC = Console.ReadLine();
        }
        Console.WriteLine("Are you want to insert new product y/n");
        string resP = Console.ReadLine();
        while (resP == "y")
        {
            da.InserData("Data Source=SRV2\\PUPILS;Initial Catalog=WebElectricStore;Integrated Security=True");
            da.readData("Data Source=SRV2\\PUPILS;Initial Catalog=WebElectricStore;Integrated Security=True");
            Console.WriteLine("Are you want to insert new products y/n");
            resP = Console.ReadLine();
        }
    
    }
}