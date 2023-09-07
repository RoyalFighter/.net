using System.Data.SqlClient;

namespace B1
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
            string query = "create table tbl_employee (id int, name varchar(60), department varchar(60), address varchar(60), email varchar(60), position varchar(60))";
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
            Console.Write("Enter id: ");
            int _id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter name: ");
            string _name = Console.ReadLine();
            Console.Write("Enter department: ");
            string _department = Console.ReadLine();
            Console.Write("Enter address: ");
            string _address = Console.ReadLine();
            Console.Write("Enter email ");
            string _email = Console.ReadLine();
            Console.Write("Enter position ");
            string _position = Console.ReadLine();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "insert into tbl_std values (@id, @name, @department, @address, @email, @position)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", _id);
                cmd.Parameters.AddWithValue("@name", _name);
                cmd.Parameters.AddWithValue("@department", _department);
                cmd.Parameters.AddWithValue("@address", _address);
                cmd.Parameters.AddWithValue("@email", _email);
                cmd.Parameters.AddWithValue("@position", _position);
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
                    Console.WriteLine("Deleted the record successfully");
                }
                else Console.WriteLine($"No record with the name {_name}");
            }
        }
    }
    public class Program2
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=.; Database=SanisB1; Integrated Security= true";
            Program program = new Program(connectionString);
            /*program.CreateTable();*/  //Create table then comment out this line of code
            /*program.Insert();*/
            program.Delete();
        }
    }
}