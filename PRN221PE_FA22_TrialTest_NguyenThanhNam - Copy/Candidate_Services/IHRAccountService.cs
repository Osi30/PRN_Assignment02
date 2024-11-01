﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate_BusinessObjects;

namespace Candidate_Services
{
    public interface IHRAccountService
    {
        public Hraccount GetHraccountByEmail(String email);
        public List<Hraccount> GetHraccounts();
    }
}
