using System.Data.SqlClient;

namespace A1
{
    public class Program
    {
        private string connectionString;
        public Program(string connectionString)
        {
            this.connectionString = connectionString; 
        }
        //create table
        public void CreateTable()
        {
            string query = "create table tbl_std (roll int, name varchar(60), faculty varchar(60), address varchar(60), phone varchar(60))";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int output = cmd.ExecuteNonQuery();
                if (output > 0)
                {
                    Console.WriteLine("Table creation error");
                }
                else Console.WriteLine("Table Created Successfully");
                conn.Close();
            }
        }

        public void Insert()
        {
            Console.Write("Enter roll no: ");
            int _rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter name: ");
            string _name = Console.ReadLine();
            Console.Write("Enter faculty: ");
            string _faculty = Console.ReadLine();
            Console.Write("Enter address: ");
            string _address = Console.ReadLine();
            Console.Write("Give me your phone no: ");
            string _phoneNo = Console.ReadLine();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "insert into tbl_std values (@roll, @name, @faculty, @address, @phone)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@roll", _rollNo);
                cmd.Parameters.AddWithValue("@name", _name);
                cmd.Parameters.AddWithValue("@faculty", _faculty);
                cmd.Parameters.AddWithValue("@address", _address);
                cmd.Parameters.AddWithValue("@phone", _phoneNo);
                conn.Open();
                int output = cmd.ExecuteNonQuery();
                conn.Close();
                if (output > 0)
                {
                    Console.WriteLine("Inserted the values.");
                }
                else Console.WriteLine("No data inserted. Something went wrong");
            }
        }
        public void Delete()
        {
            Console.Write("Enter name to delete: ");
            string _name = Console.ReadLine();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "delete from tbl_std where name = @name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", _name);
                conn.Open();
                int output = cmd.ExecuteNonQuery();
                conn.Close();
                if (output > 0)
                {
                    Console.WriteLine("Deleted the record successfully OG");
                }
                else Console.WriteLine($"No record with the name {_name}");
            }
        }
    }
    public class Program2
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=.; Database=SanisA1; Integrated Security= true";
            Program program = new Program(connectionString);
            /*program.CreateTable();*/  //Create table then comment out this line of code
            /*program.Insert();*/
            program.Delete();
        }
    }
}