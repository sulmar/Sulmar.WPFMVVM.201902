using OLSA.Breakdowns.IServices;
using OLSA.Breakdowns.Models;
using OLSA.Breakdowns.Models.SearchCriterias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OLSA.Breakdowns.FakeServices
{
    public class FakeBreakdownService : IBreakdownService
    {
        private IList<Breakdown> breakdowns;

        public FakeBreakdownService()
        {
            breakdowns = new List<Breakdown>();
        }

        public void Add(Breakdown entity) => breakdowns.Add(entity);

        public Breakdown Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Breakdown> Get()
        {
            return breakdowns;
        }

        public IEnumerable<Breakdown> Get(BreakdownSearchCriteria criteria)
        {
            //if (criteria.Period.From.HasValue)
            //{
            //    breakdowns = breakdowns.Where(d => d.CreateDate > criteria.Period.From);
            //}


            return breakdowns;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Breakdown entity)
        {
            throw new NotImplementedException();
        }
    }
}
