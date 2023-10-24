using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManager
{
    public class PaymentController
    {
        private string connectionString;

        public PaymentController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertPayment(string amount, string date, int shiftID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Payments ( ShiftID, PaymentDate, Amount)\r\nVALUES ( " + shiftID + ",'" + date + "', '" + amount + "');";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
