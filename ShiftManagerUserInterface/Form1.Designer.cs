using ShiftManager;

namespace ShiftManagerUserInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label10;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.shiftTabMessageDisplay = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clockOutTimeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClockInTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PaymentsTabMessageDisplay = new System.Windows.Forms.Label();
            this.SubmitPaymentButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.paymentDateTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.paymentAmountTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Location = new System.Drawing.Point(3, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = System.Windows.Forms.DockStyle.Top;
            label10.Location = new System.Drawing.Point(3, 3);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(122, 20);
            label10.TabIndex = 8;
            label10.Text = "Payment Amount";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.shiftTabMessageDisplay);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.clockOutTimeTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ClockInTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Controls.Add(label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Shifts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // shiftTabMessageDisplay
            // 
            this.shiftTabMessageDisplay.AutoSize = true;
            this.shiftTabMessageDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.shiftTabMessageDisplay.Location = new System.Drawing.Point(3, 365);
            this.shiftTabMessageDisplay.Name = "shiftTabMessageDisplay";
            this.shiftTabMessageDisplay.Size = new System.Drawing.Size(0, 20);
            this.shiftTabMessageDisplay.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(3, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(786, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clockOutTimeTextBox
            // 
            this.clockOutTimeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.clockOutTimeTextBox.Location = new System.Drawing.Point(3, 157);
            this.clockOutTimeTextBox.Name = "clockOutTimeTextBox";
            this.clockOutTimeTextBox.Size = new System.Drawing.Size(786, 27);
            this.clockOutTimeTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(3, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Clock Out Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 5;
            // 
            // ClockInTextBox
            // 
            this.ClockInTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClockInTextBox.Location = new System.Drawing.Point(3, 90);
            this.ClockInTextBox.Name = "ClockInTextBox";
            this.ClockInTextBox.Size = new System.Drawing.Size(786, 27);
            this.ClockInTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Clock In Time and Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AccessibleName = "nameTextBox";
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameTextBox.Location = new System.Drawing.Point(3, 23);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(786, 27);
            this.nameTextBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PaymentsTabMessageDisplay);
            this.tabPage2.Controls.Add(this.SubmitPaymentButton);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.paymentDateTextBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.paymentAmountTextBox);
            this.tabPage2.Controls.Add(label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Payments";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PaymentsTabMessageDisplay
            // 
            this.PaymentsTabMessageDisplay.AutoSize = true;
            this.PaymentsTabMessageDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaymentsTabMessageDisplay.Location = new System.Drawing.Point(3, 365);
            this.PaymentsTabMessageDisplay.Name = "PaymentsTabMessageDisplay";
            this.PaymentsTabMessageDisplay.Size = new System.Drawing.Size(0, 20);
            this.PaymentsTabMessageDisplay.TabIndex = 15;
            // 
            // SubmitPaymentButton
            // 
            this.SubmitPaymentButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubmitPaymentButton.Location = new System.Drawing.Point(3, 385);
            this.SubmitPaymentButton.Name = "SubmitPaymentButton";
            this.SubmitPaymentButton.Size = new System.Drawing.Size(786, 29);
            this.SubmitPaymentButton.TabIndex = 14;
            this.SubmitPaymentButton.Text = "Submit Payment";
            this.SubmitPaymentButton.UseVisualStyleBackColor = true;
            this.SubmitPaymentButton.Click += new System.EventHandler(this.SubmitPaymentButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(3, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 13;
            // 
            // paymentDateTextBox
            // 
            this.paymentDateTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.paymentDateTextBox.Location = new System.Drawing.Point(3, 90);
            this.paymentDateTextBox.Name = "paymentDateTextBox";
            this.paymentDateTextBox.Size = new System.Drawing.Size(786, 27);
            this.paymentDateTextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(3, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(3, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 10;
            // 
            // paymentAmountTextBox
            // 
            this.paymentAmountTextBox.AccessibleName = "nameTextBox";
            this.paymentAmountTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.paymentAmountTextBox.Location = new System.Drawing.Point(3, 23);
            this.paymentAmountTextBox.Name = "paymentAmountTextBox";
            this.paymentAmountTextBox.Size = new System.Drawing.Size(786, 27);
            this.paymentAmountTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PaymentController paymentController = new PaymentController("Server=LAPTOP-8IUEFR6I\\SQLEXPRESS;Database=ShiftData;Integrated Security=SSPI;\r\n");
        private ShiftController shiftController = new ShiftController("Server=LAPTOP-8IUEFR6I\\SQLEXPRESS;Database=ShiftData;Integrated Security=SSPI;\r\n");
        private EmployeeController employeeController = new EmployeeController("Server=LAPTOP-8IUEFR6I\\SQLEXPRESS;Database=ShiftData;Integrated Security=SSPI;\r\n");
        private Label label2;
        private TextBox nameTextBox;
        private Button button1;
        private TextBox clockOutTimeTextBox;
        private Label label5;
        private Label label4;
        private TextBox ClockInTextBox;
        private Label label3;
        private Button SubmitPaymentButton;
        private Label label7;
        private TextBox paymentDateTextBox;
        private Label label8;
        private Label label9;
        private TextBox paymentAmountTextBox;
        private Label shiftTabMessageDisplay;
        private Label PaymentsTabMessageDisplay;
    }
}