using MAUI_MVVM_Pattern.MVVM.Views;

namespace MAUI_MVVM_Pattern
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PeopleView();
        }
    }
}
