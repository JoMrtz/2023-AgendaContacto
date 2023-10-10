using AgendaDeContactos.Data.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace AgendaDeContactos.Services
{
    public class UserService
    {
        private readonly AgendaContext _context;
            public UserService(AgendaContext context)
        {
            _context = context;
        }

        public User UserUpdatealgo()
        {
            return _context.Users.LastOrDefault();
        }

    }
}
