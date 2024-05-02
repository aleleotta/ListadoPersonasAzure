using ListadoPersonasAzureMAUI.Views;

namespace ListadoPersonasAzureMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
