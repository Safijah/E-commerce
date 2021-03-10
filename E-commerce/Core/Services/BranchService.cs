using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
   public class BranchService : IBranchService
    {
        private E_commerceDB _context;
        public BranchService(E_commerceDB context)
        {
            _context = context;
        }
     
       public List<Branch> GetAll()
       {
         return _context.Branch.ToList();
       }
       
    }
}
