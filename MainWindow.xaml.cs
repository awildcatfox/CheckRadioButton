using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CheckRadioButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            // We will keep appending to this string before we display it to our rich text box.
            string formattedString = "";


            // Grabbing Check Box Information
            bool isRaining = chkRaining.IsChecked.Value;
            bool isTimeSensitive = chkSocial.IsChecked.Value;
            bool useMailingAddress = chkSocial.IsChecked.Value;

            // Here we are appending the results from our check box
            formattedString += $"Is Raining : {isRaining}\n\n";
            formattedString += $"Is Time Sensitive : {isTimeSensitive}\n\n";
            formattedString += $"Use Mailing Address : {useMailingAddress}\n\n";

            // Which Color
            bool isRed = rbRed.IsChecked.Value;
            bool isGreen = rbGreen.IsChecked.Value;
            bool isBlue = rbBlue.IsChecked.Value;

            formattedString += "Your favorite color is ";

            // Using an If Else statement, we display which color is the users favorite
            if (isRed) { formattedString += "red\n"; }
            else if (isGreen) { formattedString += "green\n"; }
            else { formattedString += "blue\n"; }

            // Replace this wil your code
            // Which Size
            bool zoner = rbZoner.IsChecked.Value;
            bool grappler = rbGrappler.IsChecked.Value;
            bool rushdown = rbRushDown.IsChecked.Value;

            formattedString += "\nYour Fighting Style is ";

            if (zoner) { formattedString += "zoner\n"; }
            else if (grappler) { formattedString += "grappler\n"; }
            else { formattedString += "rush down\n"; }

            // Here we assign our formattedString string to our rich text box
            rtbDisplay.Text = formattedString;
        }
    }
}
