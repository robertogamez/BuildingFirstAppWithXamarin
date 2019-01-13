using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WorkingDemo.Model;
using static System.Math;

namespace WorkingDemo.ViewModel
{
    public class ListViewViewModel
    {
        public ObservableCollection<Person> People { get; set; }
            = new ObservableCollection<Person>();

        public ListViewViewModel()
        {
            Random rand = new Random();
            for (int i = 1; i < 6; i++)
            {
                Person person = new Person();
                person.FirstName = "Roberto";
                person.LastName = "Gamez " + i.ToString();
                person.Address = i.ToString() + " Main Street";
                person.ImageSource = "man" + i.ToString() + ".png";
                person.Age = (decimal)(35 + rand.NextDouble());
                People.Add(person);
            }
        }
    }
}
