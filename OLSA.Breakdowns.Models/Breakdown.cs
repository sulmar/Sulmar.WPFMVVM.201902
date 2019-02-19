using System;

namespace OLSA.Breakdowns.Models
{
    public class Breakdown : Base
    {
        private BreakdownStatus _status;

        public Workplace Workplace { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public User Employee { get; set; }


        // Hint: use https://github.com/Fody/PropertyChanged
        public BreakdownStatus Status
        {
            get { return _status; }
            set { _status = value;
                OnPropertyChanged();
            }
        }

        public Breakdown()
        {
            CreateDate = DateTime.Now;
            Status = BreakdownStatus.Created;
        }
    }
}
