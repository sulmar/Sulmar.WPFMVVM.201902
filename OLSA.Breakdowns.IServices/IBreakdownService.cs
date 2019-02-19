using OLSA.Breakdowns.Models;
using OLSA.Breakdowns.Models.SearchCriterias;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OLSA.Breakdowns.IServices
{

    public interface IBreakdownService : IEntityService<Breakdown>
    {

        IEnumerable<Breakdown> Get(BreakdownSearchCriteria criteria);

    }

    
}
