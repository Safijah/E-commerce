using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
   public  interface IHistoryOfPaymentsService
    {
        public List<HistoryOfPaymentsVM> GetHistoryOfPayments(string CustomerID);
    }
}
