using CyclingClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclingClub.Data
{
    public interface ILogin
    {
        User Login(string emailAddress, string password);
    }
}
