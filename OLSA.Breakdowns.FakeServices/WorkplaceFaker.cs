using Bogus;
using OLSA.Breakdowns.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OLSA.Breakdowns.FakeServices
{
    public class WorkplaceFaker : Faker<Workplace>
    {
        public WorkplaceFaker()
        {
            StrictMode(true);
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.Name, f => f.Person.FirstName);
            FinishWith((f, w) => Trace.WriteLine($"Created {w.Name}"));
        }
    }
}
