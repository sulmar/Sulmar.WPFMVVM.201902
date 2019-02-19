using System;
using System.Collections.Generic;
using System.Text;

namespace OLSA.Breakdowns.Models.SearchCriterias
{


    public abstract class SearchCriteria : Base
    {

    }

    public class BreakdownSearchCriteria : SearchCriteria
    {
        public Period Period { get; set; }
        public BreakdownStatus Status { get; set; }
    }

    public struct Period
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
