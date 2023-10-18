using AgendaDeContactos.Data.Implementations;
using AgendaDeContactos.Data.Models;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace AgendaDeContactos.Services
{
    public class UserService
    {
        private readonly AgendaContext _context;
            public UserService(AgendaContext context)
        {
            _context = context;
        }

        public User UserUpdatealgo(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }
        public int Create(User user)
        {

        int id = Int32.Parse(_context.Users.Add(user).Entity.Id.ToString());
            _context.SaveChanges();
            return user.Id;
        }
       
    }
}
