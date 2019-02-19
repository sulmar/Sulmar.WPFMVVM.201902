using OLSA.Breakdowns.IServices;
using OLSA.Breakdowns.Models;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLSA.Breakdowns.ViewModels
{

    public class WorkplacesViewModel : EntitiesViewModel<Workplace>
    {
        public WorkplacesViewModel(IWorkplaceService entityService) 
            : base(entityService)
        {
        }
    }
}
