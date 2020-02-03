using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using Models;
using Interface;

namespace Services
{
    public class UserService:IUserService
    {
        public bool DoesUserExist(string username, string password, List<User> users)
        {
            return users.Where(u => u.UserName == username && u.Password == password && u.IsActive == true).Any();
        }
        public Models.User GetUser(string username, string password, List<User> users)
        {            
            return users.Where(u => u.UserName == username && u.Password == password && u.IsActive == true).FirstOrDefault();
        }
        public void AddUser(Models.User user,List<User> users)
        {
            users.Add(user);
        }
        public bool IsUserValid(string username, long adharNo, List<User> users)
        {
            return users.Any(u => u.IsActive == true && u.UserName == username && u.AdharNo == adharNo);
        }
        public void ChangePassword(string username, long adharNo, string password, List<User> users)
        {
            users.Where(u => u.IsActive == true && u.UserName == username && u.AdharNo == adharNo).FirstOrDefault().Password=password;
        }
    }
}
