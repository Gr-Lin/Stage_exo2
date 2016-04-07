using System.Windows.Input;
using Storm.Mvvm;
using Storm.Mvvm.Commands;

namespace ViewModelPCL.ViewModel
{
    public class SunViewModel : ViewModelBase
    {

        public ICommand ButtonChange { get; private set; }

        public SunViewModel()
        {
            ButtonChange = new DelegateCommand(ButtonClicked);
        }

        private void ButtonClicked()
        {
            NavigationService.Navigate("Moon");
        }
    }
}
