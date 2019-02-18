using Bogus;
using OLSA.Breakdowns.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OLSA.Breakdowns.FakeServices
{
    // PM> Install-Package Bogus
    public class UserFaker : Faker<User>
    {
        public UserFaker()
        {
            StrictMode(true);
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.FirstName, f => f.Person.FirstName);
            RuleFor(p => p.LastName, f => f.Person.LastName);
            RuleFor(p => p.IsRemoved, f => f.Random.Bool(0.8f));
            RuleFor(p => p.Photo, f => f.Person.Avatar);
            // Ignore(p => p.Photo);
        }
    }
}
