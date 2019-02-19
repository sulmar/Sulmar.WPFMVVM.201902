using Bogus;
using OLSA.Breakdowns.IServices;
using OLSA.Breakdowns.Models;
using System.Linq;
using System.Text;

namespace OLSA.Breakdowns.FakeServices
{

    public class FakeWorkplaceService : FakeEntityService<Workplace>, IWorkplaceService
    {
        public FakeWorkplaceService(WorkplaceFaker faker) : base(faker)
        {
        }

        
    }
}
