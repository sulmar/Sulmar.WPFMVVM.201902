﻿using System;

namespace OLSA.Breakdowns.Models
{
    public class Breakdown : Base
    {
        public Workplace Workplace { get; set; }
        public DateTime CreateDate { get; set; }
        public User Employee { get; set; }
        public BreakdownStatus Status { get; set; }
    }
}
