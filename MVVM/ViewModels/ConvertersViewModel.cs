using MAUI_MVVM_Pattern.MVVM.Models;

namespace MAUI_MVVM_Pattern.MVVM.ViewModels
{
    public class ConvertersViewModel
    {
        public Data Data { get; set; }
        public ConvertersViewModel()
        {
            Data = new Data
            {
                IsFake = "true"
            };
        }
    }
}
