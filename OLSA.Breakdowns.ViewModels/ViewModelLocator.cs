using CommonServiceLocator;
using OLSA.Breakdowns.FakeServices;
using OLSA.Breakdowns.IServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.ServiceLocation;

namespace OLSA.Breakdowns.ViewModels
{
    public class ViewModelLocator
    {

       



        // Install-Package Unity
        

        public ViewModelLocator()
        {
            UserUnity();
        }

        private void UserUnity()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<UsersViewModel>();

            container.RegisterType<IUserService, FakeUserService>();
            container.RegisterType<UserFaker>();

            container.RegisterType<IWorkplaceService, FakeWorkplaceService>();
            container.RegisterType<WorkplaceFaker>();

            container.RegisterType<IBreakdownService, FakeBreakdownService>();

            // Install-Package CommonServiceLocation
            // Install-Package Unity.ServiceLocation
            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(container));

        }

        // public UsersViewModel UsersViewModel => new UsersViewModel(new FakeUserService(new UserFaker()));

        public ShellViewModel ShellViewModel => ServiceLocator.Current.GetInstance<ShellViewModel>();
        public UsersViewModel UsersViewModel => ServiceLocator.Current.GetInstance<UsersViewModel>();
        public WorkplacesViewModel WorkplacesViewModel => ServiceLocator.Current.GetInstance<WorkplacesViewModel>();

    }
}
