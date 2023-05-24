using CyclingClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclingClub.Data
{
    internal class LoginUser : ILogin
    {
        public User Login(string emailAddress, string password)
        {
            User user = null;

            using (var dbContext = new ClubMembershipDbContext())
            {
                user = dbContext.Users.FirstOrDefault(u => u.Email.Trim().ToLower() == emailAddress.Trim().ToLower() && u.Password.Equals(password));
            }
            return user;
        }
    }
}
