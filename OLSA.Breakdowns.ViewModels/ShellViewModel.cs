using OLSA.Breakdowns.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OLSA.Breakdowns.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        public ICommand ShowUsersCommand { get; }
        public ICommand AddBreakdownCommand { get; }

        private readonly INavigationService navigationService;

        public ShellViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            ShowUsersCommand = new RelayCommand(ShowUsers, ()=>CanShowUsers);
            AddBreakdownCommand = new RelayCommand(AddBreakdown);
        }


        public void AddBreakdown()
        {
            navigationService.Navigate("AddBreakdownView");
        }

        public void ShowWorkplaces()
        {
                
        }

        public void ShowUsers()
        {

        }

        public bool CanShowUsers => true;
    }
}
