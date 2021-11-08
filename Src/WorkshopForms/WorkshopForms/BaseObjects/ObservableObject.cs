using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WorkshopForms.BaseObjects
{
    //Todos los objetos que se conectan a la vista
    //deben ser capaces de notificar de sus cambios
    public class ObservableObject : INotifyPropertyChanged
    {


        //Este método se encarga de asignar el nuevo valor que el usuario introdujo
        //E invoca al método encargado de lanzar el evento PropertyChanged
        //CallerMemberName obtiene el automático el nombre de la propiedad que cambio
        protected virtual void SetProperty<T>(ref T field, T newValue
            ,[CallerMemberName] string propertyName = "")
        {
            field = newValue;
            OnPropertyChanged(propertyName);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Este evento notifica a la vista de que una propiedad cambio
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
