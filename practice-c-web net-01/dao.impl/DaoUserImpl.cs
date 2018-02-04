using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using practice_c_web_net_01.database;
using practice_c_web_net_01.dto;

namespace practice_c_web_net_01.dao.impl
{
    public class DaoUserImpl : IDaoUser
    {
        private Connect con;

        public DaoUserImpl()
        {
            con = new Connect();
        }

        public bool DeleteUser(int id)
        {
            string sql = $"UPDATE users SET use_status = 2 WHERE use_id = {id}";
            return con.UpdateData(sql);
        }

        public User GetUserById(int id)
        {
            User user = new User();
            string sql = $"SELECT * FROM users WHERE use_id = {id}";
            DataTable dt = con.GetData(sql);
            user.use_id = (int)dt.Rows[0]["use_id"];
            user.use_name = dt.Rows[0]["use_name"].ToString();
            user.use_email = dt.Rows[0]["use_email"].ToString();
            user.use_status = (int)dt.Rows[0]["use_status"];
            return user;
        }

        public List<User> GetListUsers()
        {
            List<User> list = new List<User>();
            //ArrayList list = new ArrayList();
            string sql = "SELECT * FROM users WHERE use_status = 1";
            DataTable dt = con.GetData(sql);
            foreach (DataRow dr in dt.Rows)
            {
                User user = new User();
                user.use_id = (int)dr.ItemArray[0];
                user.use_name = dr.ItemArray[1].ToString();
                user.use_email = dr.ItemArray[2].ToString();
                user.use_status = (int)dr.ItemArray[3];
                //list.Add(dr.ItemArray);
                list.Add(user);
            }
            return list;
        }

        public bool InsertUser(User user)
        {
            string sql = $"INSERT INTO users (use_name, use_email, use_status) VALUES ('{user.use_name}', '{user.use_email}', 1)";
            return con.UpdateData(sql);
        }

        public bool UpdateUser(User user)
        {
            string sql = $"UPDATE users SET use_name = '{user.use_name}', use_email = '{user.use_email}' WHERE use_id = {user.use_id}";
            return con.UpdateData(sql);
        }
    }
}