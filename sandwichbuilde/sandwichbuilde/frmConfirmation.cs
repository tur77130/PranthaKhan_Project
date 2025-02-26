using System;
using System.Windows.Forms;

namespace sandwichbuilde
{
    public partial class frmConfirmation : Form
    {
        private Order _order;

        public frmConfirmation(Order order)
        {
            InitializeComponent();
            _order = order;
            DisplayOrderDetails();
        }

        // Display order details
        private void DisplayOrderDetails()
        {
            // Display customer information
            textBox1.Text = $"Name: {_order.Customer.Name}\r\n" +
                            $"Phone: {_order.Customer.Phone}\r\n" +
                            $"Address: {_order.Customer.Address}, {_order.Customer.City}, {_order.Customer.Zip}\r\n" +
                            $"Delivery Method: {_order.Customer.DeliveryMethod}";

            // Display sandwich details
            LblDisplayTotal.Text = $"Total Cost: {_order.CalculateTotalCost():C}";
        }

        // Empty event handlers (required for UI interaction)
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void LblDisplayTotal_Click(object sender, EventArgs e) { }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {

        }
    }
}