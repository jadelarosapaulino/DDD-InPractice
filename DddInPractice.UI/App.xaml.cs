using System.Windows;
using  DddInPractice.Logics;

namespace DddInPractice.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Initer.Init(@"Server=.;Database=DddInPractice;Trusted_Connection=true");
        }
    }
}
