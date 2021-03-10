using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
   public  interface IFriendService
    {
     void AddFriend(string userID,string email);
        bool CheckFriend(string email);
        string GetUserID(string email);
    }
}
