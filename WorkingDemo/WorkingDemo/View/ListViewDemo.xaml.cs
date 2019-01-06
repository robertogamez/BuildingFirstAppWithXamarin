using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingDemo.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewDemo : ContentPage
	{
		public ListViewDemo ()
		{
			InitializeComponent();
            BindingContext = new ListViewViewModel();
		}
	}
}