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
using System.Windows.Shapes;

namespace ListViewPeople
{
    public partial class PeopleEdit : Window
    {
        bool IsUpdating { get; set; }

        public PeopleEdit()
        {
            InitializeComponent();
            DataContext = new People();
            IsUpdating = false;
        }

        public PeopleEdit(People p)
        {
            InitializeComponent();
            DataContext = p;
            IsUpdating = true;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsUpdating == false)
            {
                People.AllPeople.Add((People)DataContext);
            }
            this.Close();
        }
    }
}
