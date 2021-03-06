﻿using OLSA.Breakdowns.IServices;
using OLSA.Breakdowns.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OLSA.Breakdowns.FakeServices
{
    public class FakeUserService : IUserService
    {
        private readonly IList<User> users;
        private readonly UserFaker userFaker;

        public FakeUserService(UserFaker userFaker)
        {
            this.userFaker = userFaker;

            users = userFaker.Generate(100);

        }

        public void Add(User entity) => users.Add(entity);
        public User Get(int id) => users.SingleOrDefault(u => u.Id == id);
        public IEnumerable<User> Get() => users;
        public void Remove(int id) => users.Remove(Get(id));

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        private void Find(string name)
        {  
            if (users.Any(u => u.LastName == name))
            {
                Console.WriteLine("--users--");
                foreach (var user in users.Where(u => u.LastName == name))
                {

                }
            }
            else
            {
                Console.WriteLine("--no records found--");
            }
        }

        private decimal Calculate(decimal amount, decimal tax)
        {
            if (amount<=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            if (amount > 10000)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            var result = amount * tax;

            throw new NotImplementedException();
        }
    }
}
