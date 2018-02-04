using practice_c_web_net_01.dto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_c_web_net_01.dao
{
    interface IDaoUser
    {
        List<User> GetListUsers();
        bool InsertUser(User user);
        User GetUserById(int id);
        bool UpdateUser(User user);
        bool DeleteUser(int id);
    }
}
