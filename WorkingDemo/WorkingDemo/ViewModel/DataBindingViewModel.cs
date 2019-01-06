using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace WorkingDemo.ViewModel
{
    public class DataBindingViewModel : INotifyPropertyChanged
    {
        private string labelText = "Hello";

        public string LabelText
        {
            get { return labelText; }
            set {
                labelText = value;
                RaisePropertyChanged();
            }
        }

        private Command changeTextCommand;
        public Command ChangeTextCommand
        {
            get
            {
                return changeTextCommand ?? (changeTextCommand = new Command(
                    () =>
                    {
                        LabelText = "Goodbye";
                    }
                ));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(
            [CallerMemberName]string caller = ""
        )
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
