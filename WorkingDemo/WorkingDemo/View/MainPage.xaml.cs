using System;
using Xamarin.Forms;

namespace WorkingDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void DemoLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DemoLayout());
        }

        private void DataBinding_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DataBinding());
        }

        private void DemoListView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewDemo());
        }
    }
}
