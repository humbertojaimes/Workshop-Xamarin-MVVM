using System;
namespace WorkshopForms.BaseObjects
{
    //Contiene las propiedades comunes para todas los ViewModel
    public class BaseViewModel : ObservableObject
    {
        public BaseViewModel()
        {
        }


        private string title;
        //Titulo de la página
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        private bool isBusy;
        //Sirve para evitar que se envie más de una vez
        //la misma transacción
        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }

    }
}
