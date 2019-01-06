using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WorkingDemo.Model;

namespace WorkingDemo.ViewModel
{
    public class ListViewViewModel
    {
        public ObservableCollection<Person> People { get; set; }
            = new ObservableCollection<Person>();

        public ListViewViewModel()
        {
            for (int i = 1; i < 6; i++)
            {
                Person person = new Person();
                person.Name = "Roberto Gamez " + i.ToString();
                person.Address = i.ToString() + " Main Street";
                person.ImageSource = "man" + i.ToString() + ".png";
                People.Add(person);
            }
        }
    }
}
