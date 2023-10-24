namespace ShiftManagerUserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shiftController.AddClockIn(ClockInTextBox.Text);
            clockOutTimeTextBox.Text = "";
            ClockInTextBox.Text = string.Empty;
            shiftTabMessageDisplay.Text = "Successfully saved";

            


        }

        private void SubmitPaymentButton_Click(object sender, EventArgs e)
        {
            paymentController.InsertPayment(paymentAmountTextBox.Text, paymentDateTextBox.Text, 1);
            paymentDateTextBox.Text = "";
            paymentDateTextBox.Text = "";
            PaymentsTabMessageDisplay.Text = "Successfully paid";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}