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
using System.Globalization;

namespace WpfApp2
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



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Toy toy = new Toy();

            string manu = Manufacturer.Text;
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            manu = textInfo.ToTitleCase(manu);
            toy.manufacturer = manu;

            string name = Toy_Name.Text;
            name = textInfo.ToTitleCase(name);
            toy.name = name;

            string price = Toy_Price.Text;
            if (double.TryParse(price, out var p))
            {
                toy.price = double.Parse(Toy_Price.Text);
            }
            else
            {
                MessageBox.Show("Enter a number");
            }



            ListBox.Items.Add(toy);



        }


        private void Double_Click(object sender, RoutedEventArgs e)
        {

            if (ListBox.SelectedItem != null)
            {
                Toy selectedToy = (Toy)ListBox.SelectedItem;
                MessageBox.Show($"This toy is located on aisle: {selectedToy.GetAisle()} ");
            }


        }


    }
}
