using System.Windows.Input;
using Storm.Mvvm;
using Storm.Mvvm.Commands;

namespace ViewModelPCL.ViewModel
{
    public class MoonViewModel : ViewModelBase
    {
        public ICommand ButtonBack { get; private set; }

        public MoonViewModel()
        {
            ButtonBack = new DelegateCommand(ButtonClicked);
        }

        private void ButtonClicked()
        {
            NavigationService.GoBack();
        }
    }
}
