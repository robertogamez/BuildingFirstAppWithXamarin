namespace WorkingDemo.ViewModel
{
    public class MainPageViewModel
    {
        public string Prompt { get; set; }
        public string Name { get; set; }

        public MainPageViewModel()
        {
            Prompt = "Full name: ";
            Name = "Robert G.";
        }
    }
}
