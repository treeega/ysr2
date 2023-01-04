using LAB2.DB;
using LAB2.DB.DBCONTEXT;
using LAB2.Pages;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace LAB2.Method
{
    internal class WorkBD
    {
        public string Get()
        {
            using (UserContext db=new UserContext())
            {
                string ret=JsonSerializer.Serialize(db.Users);
                return ret;
            }
        }
        public void GetDelId(Edit edit,int id)
        {
            using (UserContext db = new UserContext())
            {
                User del = db.Users.Where(c => c.Id == id).First();
                db.Users.Remove(del);
                db.SaveChanges();
                edit.Refresh();
           }
        }
        public string ISearch(string item)
        {
            using (UserContext db = new UserContext())
            {
                string ret = JsonSerializer.Serialize(db.Users.Where(c => c.UserName == item||c.Password==item||c.Status==item));
                return ret;
            }
        }
        public User ISearch(int id)
        {
            using (UserContext db = new UserContext())
            {
                User user = db.Users.Find(id) ;
                return user;
            }
        }
        public void Save(User user,bool a)
        {
            using (UserContext db = new UserContext())
            {
                if (a==true)
                {
                    db.Users.Add(user);
                   
                }
                else
                {
                   User user1= db.Users.Find(user.Id);
                   user1.UserName=user.UserName;
                    user1.Password=user.Password;
                    user1.Status=user.Status;
                    db.Entry(user1).State = EntityState.Modified;
                }
                db.SaveChanges();


            }
        }
       
    }
}
