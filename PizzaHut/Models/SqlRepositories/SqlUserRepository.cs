using PizzaHut.Models.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaHut.Models.SqlRepositories
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly AppDbContext _db;
        public SqlUserRepository(AppDbContext context)
        {
            _db = context;
        }
        public User Add(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
            return user;
        }

        public User Delete(int id)
        {
            User user = _db.Users.Find(id);
            _db.Users.Remove(user);
            _db.SaveChanges();
            return user;
        }

        public User Get(int id)
        {
            return _db.Users.Find(id);

        }

        public IEnumerable<User> GetAll()
        {
            return _db.Users;
        }

        public User Update(User userChanges)
        {

            var user = _db.Users.Attach(userChanges);
            user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
            return userChanges;
        }
    }
}
