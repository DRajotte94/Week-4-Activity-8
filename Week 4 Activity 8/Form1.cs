using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_4_Activity_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e) // event handler for submit button
        {
            double fat, carbs; // variables for user input

            // attempts to parse both inputs to double values
            if (double.TryParse(fatInput.Text, out fat) && double.TryParse(carbInput.Text, out carbs))
            {
                fatOutput.Text = "Fat:  " + FatCalories(fat); // calls the method to convert fat grams to calories and displays result
                carbOutput.Text = "Carbs:  " + CarbCalories(carbs); // calls the method to convert carb grams to calories and displays result
            }
            else
            {
                MessageBox.Show("Please enter a valid number"); // if inputs are not valid display error message
            }
        }

        private double FatCalories(double fat) // method for converting fat grams to calories
        {
            fat = fat * 9; // grams to calories conversion

            return fat; // returns new value
        }

        private double CarbCalories(double carbs) // method for converting carb grams to calories
        {
            carbs = carbs * 4; // grams to calories conversion

            return carbs; // returns new value
        }
    }
}
