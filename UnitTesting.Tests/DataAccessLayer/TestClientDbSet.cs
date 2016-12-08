﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.Models;

namespace BankSystem.Tests.DataAccessLayer
{
    class TestClientDbSet : TestDbSet<Client>
    {
        public override Client Find(params object[] keyValues)
        {
            return this.SingleOrDefault(v => v.Id == (int)keyValues.Single());
        }
    }
}
