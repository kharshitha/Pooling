using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Interface
{
    public interface IUserService
    {
        public bool DoesUserExist(string username, string password, List<User> users);
        public Models.User GetUser(string username, string password, List<User> users);
        public void AddUser(Models.User user, List<User> users);
        public bool IsUserValid(string username, long adharNo, List<User> users);
        public void ChangePassword(string username, long adharNo, string password, List<User> users);
    }
}
