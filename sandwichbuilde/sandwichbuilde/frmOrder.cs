using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace sandwichbuilde
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        // Populate pre-made sandwiches when the form loads
        private void frmOrder_Load(object sender, EventArgs e)
        {
            PopulatePreMadeSandwiches();
        }

        // Define pre-made sandwiches
        private List<PreMadeSandwich> GetPreMadeSandwiches()
        {
            return new List<PreMadeSandwich>
            {
                new PreMadeSandwich
                {
                    Name = "Classic Club",
                    Description = "Turkey, bacon, lettuce, tomato, and mayo on toasted bread.",
                    Price = 8.99m,
                    Meats = new List<string> { "Turkey", "Bacon" },
                    Toppings = new List<string> { "Lettuce", "Tomato" },
                    Sauces = new List<string> { "Mayo" },
                    Cheeses = new List<string> { "Cheddar" },
                    ImagePath = "Club.jpg" // Image file name
                },
                new PreMadeSandwich
                {
                    Name = "Italian Sub",
                    Description = "Salami, ham, pepperoni, provolone, lettuce, tomato, and Italian dressing.",
                    Price = 9.99m,
                    Meats = new List<string> { "Salami", "Ham", "Pepperoni" },
                    Toppings = new List<string> { "Lettuce", "Tomato" },
                    Sauces = new List<string> { "Italian Dressing" },
                    Cheeses = new List<string> { "Provolone" },
                    ImagePath = "Ittlian.jpg" // Image file name
                },
                new PreMadeSandwich
                {
                    Name = "Veggie Delight",
                    Description = "Avocado, cucumber, bell peppers, spinach, and hummus on whole wheat bread.",
                    Price = 7.99m,
                    Toppings = new List<string> { "Avocado", "Cucumber", "Bell Peppers", "Spinach" },
                    Sauces = new List<string> { "Hummus" },
                    ImagePath = "Vigge.jpg" // Image file name
                }
            };
        }

        // Populate the pre-made sandwiches ComboBox
        private void PopulatePreMadeSandwiches()
        {
            var preMadeSandwiches = GetPreMadeSandwiches();
            cboPreMadeSandwiches.DataSource = preMadeSandwiches;
            cboPreMadeSandwiches.DisplayMember = "Name"; // Show the sandwich name in the ComboBox
        }

        // Handle Pre-made vs. Custom sandwich selection
        private void rdoPreMade_CheckedChanged(object sender, EventArgs e)
        {
            cboPreMadeSandwiches.Visible = rdoPreMade.Checked;
            lblSandwichDescription.Visible = rdoPreMade.Checked;
            picSandwichImage.Visible = rdoPreMade.Checked;

            // Hide custom sandwich controls
            cboBreadType.Visible = !rdoPreMade.Checked;
            cboSize.Visible = !rdoPreMade.Checked;
            // Add similar lines for other custom controls

            // Clear the image if switching to pre-made sandwiches
            if (rdoPreMade.Checked)
            {
                picSandwichImage.Image = null;
            }
        }

        private void rdoCustom_CheckedChanged(object sender, EventArgs e)
        {
            cboBreadType.Visible = rdoCustom.Checked;
            cboSize.Visible = rdoCustom.Checked;
            // Add similar lines for other custom controls

            // Hide pre-made sandwich controls
            cboPreMadeSandwiches.Visible = !rdoCustom.Checked;
            lblSandwichDescription.Visible = !rdoCustom.Checked;
            picSandwichImage.Visible = rdoCustom.Checked;

            // Load the default image for custom sandwiches
            if (rdoCustom.Checked)
            {
                //try
                //{
                string defaultImagePath = Path.Combine(Application.StartupPath, "Regular crust.jpg");
                Console.WriteLine("p");
                if (File.Exists(defaultImagePath))
                {
                    picSandwichImage.Image = Image.FromFile(defaultImagePath);
                    Console.WriteLine("k");
                }
                else
                {
                    MessageBox.Show($"Default image not found: {defaultImagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    picSandwichImage.Image = null; // Clear the image if the file doesn't exist
                }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show($"Error loading default not found image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    picSandwichImage.Image = null; // Clear the image if there's an error
                //}
            }
        }

        // Handle "Next" button click
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Create Customer object
            var customer = new Customer
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
                City = txtcity.Text,
                Zip = txtZip.Text,
                DeliveryMethod = rdoDelivery.Checked ? "Delivery" : "Pickup"
            };

            // Create Sandwich object
            Sandwich sandwich;
            if (rdoPreMade.Checked)
            {
                var selectedSandwich = cboPreMadeSandwiches.SelectedItem as PreMadeSandwich;
                sandwich = new Sandwich(selectedSandwich); // Use pre-made constructor
            }
            else
            {
                sandwich = new Sandwich
                {
                    Size = cboSize.SelectedItem?.ToString(),
                    BreadType = cboBreadType.SelectedItem?.ToString(),
                    Sauces = GetSelectedSauces(),
                    Meats = GetSelectedMeats(),
                    Cheeses = GetSelectedCheeses(),
                    Toppings = GetSelectedToppings(),
                    PremiumAdditions = GetSelectedPremiumAdditions()
                };
            }

            // Create Order object
            var order = new Order
            {
                OrderDate = DateTime.Now,
                Customer = customer,
                Sandwich = sandwich,
                Tip = decimal.TryParse(txtTips.Text, out decimal tip) ? tip : 0
            };

            // Open Confirmation Form
            var confirmationForm = new frmConfirmation(order);
            confirmationForm.Show();
        }

        // Helper methods to get selected sauces, meats, cheeses, toppings, and premium additions
        private List<string> GetSelectedSauces()
        {
            var sauces = new List<string>();
            if (chkMayo.Checked) sauces.Add("Mayo");
            if (chkHoneymustrd.Checked) sauces.Add("Honey Mustard");
            if (chkRanch.Checked) sauces.Add("Ranch");
            if (chkSIgnature.Checked) sauces.Add("Signature Sauce");
            return sauces;
        }

        private List<string> GetSelectedMeats()
        {
            var meats = new List<string>();
            if (chkChicken.Checked) meats.Add("Chicken");
            if (chkHam.Checked) meats.Add("Ham");
            if (chkRostBeef.Checked) meats.Add("Roast Beef");
            if (chkBrisket.Checked) meats.Add("Brisket");
            return meats;
        }

        private List<string> GetSelectedCheeses()
        {
            var cheeses = new List<string>();
            // Add logic for cheese checkboxes
            return cheeses;
        }

        private List<string> GetSelectedToppings()
        {
            var toppings = new List<string>();
            if (chlLettuce.Checked) toppings.Add("Lettuce");
            if (chkTommato.Checked) toppings.Add("Tomato");
            if (chkOnion.Checked) toppings.Add("Onion");
            if (chkSweetPeppers.Checked) toppings.Add("Sweet Peppers");
            return toppings;
        }

        private List<string> GetSelectedPremiumAdditions()
        {
            var premiumAdditions = new List<string>();
            if (chkExtraChicken.Checked) premiumAdditions.Add("Extra Chicken");
            if (chkExtraHam.Checked) premiumAdditions.Add("Extra Ham");
            if (chkextraRoastbeef.Checked) premiumAdditions.Add("Extra Roast Beef");
            return premiumAdditions;
        }

        // Close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Display ingredients of the selected pre-made sandwich
        private void lblIngafiance_Click(object sender, EventArgs e)
        {
            if (rdoPreMade.Checked) // Ensure a pre-made sandwich is selected
            {
                var selectedSandwich = cboPreMadeSandwiches.SelectedItem as PreMadeSandwich;
                if (selectedSandwich != null)
                {
                    // Build a string with all the ingredients
                    string ingredients = "Ingredients:\n";
                    ingredients += $"Meats: {string.Join(", ", selectedSandwich.Meats)}\n";
                    ingredients += $"Toppings: {string.Join(", ", selectedSandwich.Toppings)}\n";
                    ingredients += $"Sauces: {string.Join(", ", selectedSandwich.Sauces)}\n";
                    ingredients += $"Cheeses: {string.Join(", ", selectedSandwich.Cheeses)}\n";
                    ingredients += $"Premium Additions: {string.Join(", ", selectedSandwich.PremiumAdditions)}\n";

                    // Display the ingredients in a MessageBox
                    MessageBox.Show(ingredients, "Sandwich Ingredients", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a pre-made sandwich.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("This feature is only available for pre-made sandwiches.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update the image when a pre-made sandwich is selected
        private void cboPreMadeSandwiches_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSandwich = cboPreMadeSandwiches.SelectedItem as PreMadeSandwich;
            if (selectedSandwich != null)
            {
                // Update the description
                lblSandwichDescription.Text = selectedSandwich.Description;

                // Load the image (if an image path is provided)
                if (!string.IsNullOrEmpty(selectedSandwich.ImagePath))
                {
                    try
                    {
                        // Construct the full path to the image
                        string imagePath = Path.Combine(Application.StartupPath, selectedSandwich.ImagePath);

                        // Debug: Check if the file exists
                        if (File.Exists(imagePath))
                        {
                            picSandwichImage.Image = Image.FromFile(imagePath);
                        }
                        else
                        {
                            MessageBox.Show($"Image file not found: {imagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            picSandwichImage.Image = null; // Clear the image if the file doesn't exist
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        picSandwichImage.Image = null; // Clear the image if there's an error
                    }
                }
                else
                {
                    picSandwichImage.Image = null; // Clear the image if no path is provided
                }
            }
        }

        // Empty event handlers (required for UI interaction)
        private void txtName_TextChanged(object sender, EventArgs e) { }
        private void txtPhone_TextChanged(object sender, EventArgs e) { }
        private void txtAddress_TextChanged(object sender, EventArgs e) { }
        private void txtcity_TextChanged(object sender, EventArgs e) { }
        private void txtZip_TextChanged(object sender, EventArgs e) { }
        private void grpDeliveryPickup_Enter(object sender, EventArgs e) { }
        private void rdoPickup_CheckedChanged(object sender, EventArgs e) { }
        private void rdoDelivery_CheckedChanged(object sender, EventArgs e) { }
        private void grpSandwichSelection_Enter(object sender, EventArgs e) { }
        private void lblprelist_Click(object sender, EventArgs e) { }
        private void lblSandwichDescription_Click(object sender, EventArgs e) { }
        private void picSandwichImage_Click(object sender, EventArgs e) { }
        private void lblbread_Click(object sender, EventArgs e) { }
        private void cboBreadType_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cboSize_SelectedIndexChanged(object sender, EventArgs e) { }
        private void chkMayo_CheckedChanged(object sender, EventArgs e) { }
        private void chkHoneymustrd_CheckedChanged(object sender, EventArgs e) { }
        private void chkRanch_CheckedChanged(object sender, EventArgs e) { }
        private void chkSIgnature_CheckedChanged(object sender, EventArgs e) { }
        private void chkChicken_CheckedChanged(object sender, EventArgs e) { }
        private void chkHam_CheckedChanged(object sender, EventArgs e) { }
        private void chkRostBeef_CheckedChanged(object sender, EventArgs e) { }
        private void chkBrisket_CheckedChanged(object sender, EventArgs e) { }
        private void chlLettuce_CheckedChanged(object sender, EventArgs e) { }
        private void chkTommato_CheckedChanged(object sender, EventArgs e) { }
        private void chkOnion_CheckedChanged(object sender, EventArgs e) { }
        private void chkSweetPeppers_CheckedChanged(object sender, EventArgs e) { }
        private void txtTips_TextChanged(object sender, EventArgs e) { }
        private void lblTotaldisplay_Click(object sender, EventArgs e) { }
        private void lblCustomerinfo_Click(object sender, EventArgs e) { }
        private void grpPremium_Enter(object sender, EventArgs e) { }
        private void chkExtraChicken_CheckedChanged(object sender, EventArgs e) { }
        private void chkExtraHam_CheckedChanged(object sender, EventArgs e) { }
        private void chkextraRoastbeef_CheckedChanged(object sender, EventArgs e) { }
    }
}