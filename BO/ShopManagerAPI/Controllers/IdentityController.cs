using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopManagerAPI.Services;
using ShopManagerAPI.Models;
using ShopManagerAPI.Helpers;

namespace ShopManagerAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly shopContext _context;
        private ServiceAutUser svAuthUser;

        public IdentityController(shopContext context)
        {
            _context = context;
            svAuthUser = new ServiceAutUser(context);
        }

        [HttpPost("login")]
        public ActionResult<JwtResponse> Login(TaAutUser user)
        {
            try
            {
                TaAutUser autUser = svAuthUser.getAutUserByUsername(user.Login);

                JwtResponse jwtRes = JwtHelper.generateToken(autUser);

                return jwtRes;
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.ToString() });
            }
        }
    }
}
