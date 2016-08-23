﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNR_Manager.Data.Customer.Interfaces
{
    interface IConnectionRepository
    {
        void AddAccount(Account account);
        bool AddPaymentDetails(string PMethod,string AccNo, DateTime Date);
        //ConsumerDetail GetConsumerAccount(string accountNo);
        void updateConnectionStatus(string accNo);
    }
}