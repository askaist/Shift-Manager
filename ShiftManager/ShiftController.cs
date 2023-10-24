using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System;
using System.Data.SqlClient;




namespace ShiftManager
{
    public class ShiftController
    {

        private string connectionString;


        public ShiftController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddClockIn(string dateTime)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                string query = "INSERT INTO Shifts ( EmployeeID, ClockInTime, ClockOutTime)\r\nVALUES ( 1,'" + dateTime + "', null);";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.ExecuteNonQuery();
                }
            }

            


        }

        public void AddClockOut(int shiftID, string dateTime) {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Shifts\r\nSET ClockOutTime = ' " + dateTime + "'\r\nWHERE ShiftID = " + shiftID + ";";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.ExecuteNonQuery();
                }
            }


        }

        public void RemoveClockIn(int shiftID) {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Shifts\r\nSET ClockInTime = NULL\r\nWHERE ShiftID = " + shiftID + ";";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.ExecuteNonQuery();
                }
            }


        }

        public void RemoveClockOut(int shiftID) {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Shifts\r\nSET ClockOutTime = NULL\r\nWHERE ShiftID = " + shiftID + ";";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.ExecuteNonQuery();
                }
            }


        }

        public DataTable retrieveShiftData()
        {
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT * FROM Shifts";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                        
                    }
                }
            }
        }


        public static void Main(string[] args)
        {

        }




    }
}
