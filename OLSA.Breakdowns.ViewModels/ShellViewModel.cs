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

        public ShellViewModel()
        {
            ShowUsersCommand = new RelayCommand(ShowUsers, ()=>CanShowUsers);
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
