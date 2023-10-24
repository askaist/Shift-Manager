using System.Data;
using FluentAssertions;
using ShiftManager;

namespace ShiftManagerTest
{

    public class Tests



    {

        ShiftController shiftController = new ShiftController("Server=LAPTOP-8IUEFR6I\\SQLEXPRESS;Database=ShiftData;Integrated Security=SSPI;\r\n");
        EmployeeController employeeController = new EmployeeController("Server=LAPTOP-8IUEFR6I\\SQLEXPRESS;Database=ShiftData;Integrated Security=SSPI;\r\n");

        [Test]
        public void AddClockIn()
        {
            bool error = false;

            try
            {
                shiftController.AddClockIn("10/23/2023 8:57 pm");
            }catch(Exception ex)
            {
                error = true;
            }
                
           
            error.Should().BeFalse();
                
            


            
            
        }

        [Test]
        public void AddClockOut()
        {
            bool error = false;


            shiftController.AddClockOut(15, "10/23/2023 12:00 pm");

            error = true;






        }

        [Test]
        public void removeClockInShift()
        {
            bool error = false;


            shiftController.RemoveClockIn(12);

            error = true;






        }




        [Test]
        public void removeClockOutShift()
        {
            bool error = false;


            shiftController.RemoveClockOut(10);

            error = true;






        }

        [Test]
        public void RetrieveShiftData()
        {
            bool error = false;


            DataTable shiftData = shiftController.retrieveShiftData();

           






        }

        [Test]
        public void CreateNewEmployee()
        {
            bool error = false;


            employeeController.CreateNewEmployee("Jim Jones");








        }



    }
}