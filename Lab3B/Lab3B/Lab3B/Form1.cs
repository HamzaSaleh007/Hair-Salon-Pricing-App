using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3B
{
    /// <summary>
    ///  I Hamza Saleh, 000887384 certify that this material is my original work. No other person copied from it nor I copied it from anyone.
    ///  this is the form class that contains the event handlers for the buttons and other controls
    /// </summary>
    public partial class Form1 : Form
    {
        decimal total;
        public Form1()
        {
            InitializeComponent();
            // disable the add service button until user selects a service
           addServiceButton.Enabled = false;
            // disable the calculate button until user adds a service
            CalculateButton.Enabled = false;
            // add the event handler for the selected index changed event of the services list box
            ServiceslistBox.SelectedIndexChanged += ServiceslistBox_SelectedIndexChanged;
           
            //the default value of the hairdresser combo box is the first item
            hairDresserComboBox.SelectedIndex = 0;
        }


        /// <summary>
        /// exit the application when the user clicks the exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }


        /// <summary>
        /// calculate the total price of the services and display it in the price label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            total = 0;
            // calculate the total price
            foreach (string price in PriceListBox.Items)
            {
                total += decimal.Parse(price);
            }

            // display the total price
            Pricelabel.Text = "Total Price :" + total.ToString("c");
        }

        /// <summary>
        /// add the selected service to the charged item list box and add the price to the price list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addServiceButton_Click(object sender, EventArgs e)
        {
            // enable the calculate button once the add service button is clicked
            CalculateButton.Enabled = true;

            // check the selected hairdresser and add the hairdresser to the charged item list box and add the price to the price list box and disable the hairdresser combo box
     

            if (hairDresserComboBox.SelectedItem.ToString() == "Jane" && hairDresserComboBox.Enabled == true)
            {
               
                ChargedlistBox.Items.Add("Jane");
                PriceListBox.Items.Add("30.00");
                hairDresserComboBox.Enabled = false;
            }
            else if (hairDresserComboBox.SelectedItem.ToString() == "Pat" && hairDresserComboBox.Enabled == true) {
                ChargedlistBox.Items.Add("Pat");
                PriceListBox.Items.Add("45.00");
                hairDresserComboBox.Enabled = false;

            }  else if (hairDresserComboBox.SelectedItem.ToString() == "Ron" && hairDresserComboBox.Enabled == true) {
                ChargedlistBox.Items.Add("Ron");
                PriceListBox.Items.Add("40.00");
                hairDresserComboBox.Enabled = false;

            }  else if (hairDresserComboBox.SelectedItem.ToString() == "Sue" && hairDresserComboBox.Enabled == true) {
                ChargedlistBox.Items.Add("Sue");
                PriceListBox.Items.Add("50.00");
                hairDresserComboBox.Enabled = false;

            }else if (hairDresserComboBox.SelectedItem.ToString() == "Laurie" && hairDresserComboBox.Enabled == true) {
                ChargedlistBox.Items.Add("laurie");
                PriceListBox.Items.Add("55.00");
                hairDresserComboBox.Enabled = false;

            }

            // check the selected service and add the service to the charged item list box and add the price to the price list box


            if (ServiceslistBox.SelectedIndex == 0)
            {
               
                ChargedlistBox.Items.Add("Cut");
                PriceListBox.Items.Add("30.00");

            }
            else if (ServiceslistBox.SelectedIndex == 1) {
            ChargedlistBox.Items.Add("Wash, blow-dry, and style");
                PriceListBox.Items.Add("20.00");
               

            }  else if (ServiceslistBox.SelectedIndex == 2)
            {
                ChargedlistBox.Items.Add("Colour");
                PriceListBox.Items.Add("40.00");
               

            }  else if (ServiceslistBox.SelectedIndex == 3) {
                ChargedlistBox.Items.Add("Highlights");
                PriceListBox.Items.Add("50.00");
            
            } else if (ServiceslistBox.SelectedIndex == 4) {
                ChargedlistBox.Items.Add("Extension");
                PriceListBox.Items.Add("200.00");
            
            } else if (ServiceslistBox.SelectedIndex == 5) {
                ChargedlistBox.Items.Add("Up-do");
                PriceListBox.Items.Add("60.00");
            
            } 
           

        }


        /// <summary>
        /// enable the add service button once the user selects a service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServiceslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addServiceButton.Enabled = ServiceslistBox.SelectedItems.Count > 0;
        }


        /// <summary>
        /// reset the form when the user clicks the reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            // clear the list boxes and reset the form
            hairDresserComboBox.Enabled = true;
            hairDresserComboBox.SelectedIndex = 0;
            ServiceslistBox.SelectedIndex = -1;
            ChargedlistBox.Items.Clear();
            Pricelabel.Text = "Total Price :";
            PriceListBox.Items.Clear();
            CalculateButton.Enabled = false;
            addServiceButton.Enabled = false;
        }
    }
}
