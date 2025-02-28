using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUI_MVVM_Pattern.MVVM.ViewModels
{
    public class CommandsViewModel
    {
        public ICommand SaveBtnClickedCommand { get; }
        public ICommand SearchCommand { get; }
        public CommandsViewModel()
        {
            SaveBtnClickedCommand = new Command(ExecuteSaveCommand);
            SearchCommand = new Command<string>(ExecuteSearch);
        }

        private void ExecuteSaveCommand()
        {
            App.Current.MainPage.DisplayAlert("title", "message", "ok");
        }

        private void ExecuteSearch(string searchText)
        {
            App.Current.MainPage.DisplayAlert("ricerca", "ricerca", "ok");
        }


    }
}
