using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewPeople
{
    public class People : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        public string Name
        {
            get => name;
            set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); }
        }

        private string surname;
        public string Surname
        {
            get => surname;
            set { surname = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Surname")); }
        }

        private DateTime birth;
        public DateTime Birth
        {
            get => birth;
            set { birth = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Birth")); }
        }

        
        public static ObservableCollection<People> AllPeople { get; set; } = new ObservableCollection<People>();

        public static void InitPeople()
        {
            AllPeople.Add(new People
            {
                Name = "Roman",
                Surname = "Krof",
                Birth = new DateTime (2002, 12, 17),
            });

            AllPeople.Add(new People
            {
                Name = "Jan",
                Surname = "Nepomucký",
                Birth = new DateTime(1345, 1, 1),
            });

            AllPeople.Add(new People
            {
                Name = "Josef",
                Surname = "Wohin",
                Birth = new DateTime(1999, 9, 9),
            });

            AllPeople.Add(new People
            {
                Name = "Martin",
                Surname = "Goffa",
                Birth = new DateTime(2002, 12, 17),
            });

            AllPeople.Add(new People
            {
                Name = "Jakub",
                Surname = "Mihalovič",
                Birth = new DateTime(2002, 12, 17),
            });
        }
    }
}
