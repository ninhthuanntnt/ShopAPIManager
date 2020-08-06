using ShopManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopManagerAPI.Services
{
    public class ServiceAutAuthorization
    {
        private readonly shopContext _context;
        public ServiceAutAuthorization(shopContext context)
        {
            _context = context;
        }
        public List<TaAutAuthorization> getAutAuthorization(int id)
        {
            return _context.TaAutAuthorization.Where(auth => auth.AutUser.Id == id).ToList<TaAutAuthorization>();
        }

    }
}
