using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopManagerAPI.Models;
using ShopManagerAPI.Services;

namespace ShopManagerAPI.Controllers
{
    [Route("api/authorization")]
    [ApiController]
    public class TaAutAuthorizationController : ControllerBase
    {
        private readonly shopContext _context;
        private ServiceAutAuthorization svAuthAuthorization;
        public TaAutAuthorizationController(shopContext context)
        {
            _context = context;
            svAuthAuthorization = new ServiceAutAuthorization(context);
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<TaAutAuthorization>> GetTaAutUser(int id)
        {
            
                List<TaAutAuthorization> authorizations = svAuthAuthorization.getAutAuthorization(id);

                if (authorizations != null) return authorizations;
            

            return NotFound(new { message = "User not found" });
        }
    }
}
