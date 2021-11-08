using System;
using System.Threading.Tasks;
using WorkshopForms.BaseObjects;
using WorkshopForms.Views;
using Xamarin.Forms;

namespace WorkshopForms.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {
            Title = "Iniciar Sesión";

            //El primer parametro del comando define la acción a ejecutar
            //El segundo es una función que debe devolver un bool
            //Sirve para definir si es posible ejecutar el comando
            LoginCommand = new Command(
                async () => await Login(),
                () => !string.IsNullOrWhiteSpace(Name)
                && !string.IsNullOrWhiteSpace(password)
                );

#if DEBUG
            Name = "Humberto";
            Password = "Password";
#endif

        }

        private async Task Login()
        {
            //Evaluamos IsBusy para evitar que se mande más de una transacción
            //si el usuario presiona varias veces el botón
            if (!IsBusy)
            {
                IsBusy = true;
                await Task.Delay(3000);
                //await Application.Current.MainPage.Navigation.PushAsync(new BranchesPage());
                Name = string.Empty;
                Password = string.Empty;
                //Podemos sobreescribir la MainPage si queremos tener una sola
                //página en la navegación
                Application.Current.MainPage = new NavigationPage(new BranchesPage());

                IsBusy = false;
            }
        }

        private string name;

        public string Name
        {
            get => name;
            set
            {
                SetProperty(ref name, value);
                //Es necesario ejecutar este método
                //para volver a evaluar la condición del comando
                LoginCommand.ChangeCanExecute();
            }
        }

        private string password;

        public string Password
        {
            get => password;
            set
            {
                SetProperty(ref password, value);
                LoginCommand.ChangeCanExecute();
            }
        }


        public Command LoginCommand { get; set; }

    }
}
