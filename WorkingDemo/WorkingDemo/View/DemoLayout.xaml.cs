using WorkingDemo.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DemoLayout : ContentPage
	{
        MainPageViewModel vm;

        public DemoLayout ()
		{
			InitializeComponent();
            vm = new MainPageViewModel();
            BindingContext = vm;
        }
	}
}