using Core.Interfaces;
using Data.DbContext;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
    public class HistoryOfPaymentsService : IHistoryOfPaymentsService
    {

        private E_commerceDB _context;
        public HistoryOfPaymentsService(E_commerceDB context)
        {
            _context = context;
        }
        public List<HistoryOfPaymentsVM> GetHistoryOfPayments(string CustomerID)
        {
            var History = _context.HistoryOfPayments.Where(a => a.CustomerID == CustomerID).
                Select(a => new HistoryOfPaymentsVM
                {
                    Date = a.Date.ToString("f"),
                    TotalPrice = a.Price
                }).ToList(); ;
            
            var vm = new List<HistoryOfPaymentsVM>();
            vm = History;
           
            return vm;
        }

    }
}
