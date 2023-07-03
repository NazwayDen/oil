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

namespace oil
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Person
    {
        public string Name { get; set; } = "";


        public override string ToString()
        {
            return Name;
        }
    }
    public partial class MainWindow : Window
    {
        public Person selectedPerson;
        List<Person> people = new List<Person>()
        {
             new Person{Name="Tom" },
            new Person {Name="Bob"},
            new Person{Name="Sam"}
        };
        List<Person> whiteList = new List<Person>()
        {
    
        };
        List<Person> blackList = new List<Person>()
        {

        };
        public MainWindow()
        {
            InitializeComponent();
            AllList.ItemsSource = people;
            BlackList.ItemsSource = blackList;
            WhiteList.ItemsSource = whiteList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            whiteList.Add(selectedPerson);
            WhiteList.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            whiteList.Clear();
            WhiteList.Items.Refresh();
        }

        private void WhiteText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            blackList.Add(selectedPerson);
            BlackList.Items.Refresh();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            blackList.Clear();
            BlackList.Items.Refresh();
        }
        private void AllList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedPerson = AllList.SelectedItem as Person;
        }
    }
}