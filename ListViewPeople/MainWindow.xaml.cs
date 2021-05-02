using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ListViewPeople
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            People.InitPeople();
            People p = new People();
            DataContext = p;
        }


        private void People_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            People pe = (People)((sender as ListView).SelectedItem);
            // Pro formulář!!
            DataContext = pe;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LVPeople.SelectedIndex = 0;
        }

        private void People_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            People pe = (People)((sender as ListView).SelectedItem);
            PeopleEdit ee = new PeopleEdit(pe);
            ee.ShowDialog();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            PeopleEdit ee = new PeopleEdit();           
            ee.ShowDialog();
        }
    }
}
