using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WorkshopForms.BaseObjects;
using WorkshopForms.Models;
using WorkshopForms.Services;
using Xamarin.Forms;

namespace WorkshopForms.ViewModels
{
    public class BranchesViewModel : BaseViewModel
    {
        public BranchesViewModel()
        {
            Title = "Sucursales";
            RefreshCommand = new Command(async () => await Init());
            Init();
        }


        async Task Init()
        {
            if (!IsBusy)
            {
                IsBusy = IsRefreshing = true;
                var apiClient = new BranchApiClient();

                var branches = await apiClient.GetBranches();

                Branches.Clear();
                foreach (var branch in branches)
                {
                    Branches.Add(branch);
                    await Task.Delay(200);
                }

                IsBusy = IsRefreshing = false;
            }
        }

        private ObservableCollection<Branch> branches
            = new ObservableCollection<Branch>();
        //ObservableCollection notifica a la vista cuando se agregan
        // o eliminan elementos de la colección
        public ObservableCollection<Branch> Branches
        {
            get => branches;
            set => SetProperty(ref branches, value);
        }

        public Command RefreshCommand { get; set; }

        private bool isRefreshing;
        //Agregamos una propiedad adicional para evitar errores
        //por enlazar IsBusy a RefreshView 
        public bool IsRefreshing
        {
            get => isRefreshing;
            set => SetProperty(ref isRefreshing, value);
        }

    }
}
