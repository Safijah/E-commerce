using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
   public  class FriendService :IFriendService
    {
       private E_commerceDB _context;
        public FriendService(E_commerceDB context)
        {
            _context = context;
        }
        public void AddFriend(string userID, string email)
        {
            Friend friend = new Friend() {

            E_mailFriends = email,
            CustomerID=userID
            };
            
            _context.Add(friend);
            _context.SaveChanges();
        }
       public  bool CheckFriend(string email)
        {
            var friend = _context.Friend.Where(a => a.E_mailFriends == email).FirstOrDefault();
            if (friend == null)
                return false;
            else
                return true;
        }
       public  string GetUserID(string email)
        {
            return _context.Friend.Where(a => a.E_mailFriends == email).FirstOrDefault().CustomerID;
        }

    }
}
