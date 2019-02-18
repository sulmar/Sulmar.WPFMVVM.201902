using OLSA.Breakdowns.FakeServices;
using OLSA.Breakdowns.IServices;
using OLSA.Breakdowns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLSA.Breakdowns.ViewModels
{
    public class UsersViewModel : ViewModelBase
    {
        public IEnumerable<User> Users { get; set; }

        public User SelectedUser { get; set; }

        private readonly IUserService userService;

        //public UsersViewModel()
        //    : this(new FakeUserService(new UserFaker()))
        //{

        //}

        public UsersViewModel(IUserService userService)
        {
            this.userService = userService;

            Load();        
        }

        private void Load()
        {
            Users = userService.Get();
        }
    }
}
