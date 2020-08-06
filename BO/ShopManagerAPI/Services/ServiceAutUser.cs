using Microsoft.EntityFrameworkCore;
using ShopManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopManagerAPI.Services
{
    public class ServiceAutUser
    {

        private readonly shopContext _context;

        public ServiceAutUser(shopContext context)
        {
            _context = context;
        }

        public TaAutUser getAutUser(int id)
        {
            return _context.TaAutUser.Include(user => user.Authorizations).First(user => user.Id == id);
        }

        public TaAutUser getAutUserIncludeRoleIdLt(int id, int roleId)
        {
            var user = _context.TaAutUser.Where(user => user.Id == id).Select(user => new
            {
                u = user,
                Authorizations = user.Authorizations.Where(auth => auth.RoleId < roleId)
                                                    .ToList<TaAutAuthorization>()
            }).First();

            //user.u.Authorizations = user.Authorizations;

            return user.u;
        }

        public TaAutUser getAutUserByUsername(string username)
        {
            TaAutUser user = _context.TaAutUser.First(u => u.Login == username);
            return user;
        }
    }
}
