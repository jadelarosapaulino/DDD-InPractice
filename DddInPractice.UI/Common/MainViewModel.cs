namespace DddInPractice.UI.Common
{
    using DddInPractice.Logics;

    public class MainViewModel : ViewModel
    {
        public MainViewModel()
        {
            var viewModel = new SnackMachineViewModel(new SnackMachine());
            _dialogService.ShowDialog(viewModel);
        }
    }
}
