using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class UserRepo : IRepo<User, string, User>, IAuth
    {
        BIRTHEntities db;


        internal UserRepo()
        {
            db = new BIRTHEntities();
        }
        public bool Add(User obj)
        {
            db.Users.Add(obj); ;
            return db.SaveChanges() > 0;
        }

        public User Authenticate(string uname, string password)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var ext = db.Users.Find(id);
            db.Users.Remove(ext);
            return db.SaveChanges() > 0;
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(string id)
        {
            return db.Users.Find(id);
        }

        public bool Update(User obj)
        {
            var ext = db.Users.Find(obj.Username);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;


        }

        User IRepo<User, string, User>.Add(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
