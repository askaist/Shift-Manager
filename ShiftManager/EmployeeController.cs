using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManager
{
    public class EmployeeController
    {
        private string connectionString;

        public EmployeeController(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public void CreateNewEmployee(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Employees ( EmployeeName)\r\nVALUES ( '" + name + "');";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
