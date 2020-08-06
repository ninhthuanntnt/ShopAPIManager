using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagerAPI.Services;
using ShopManagerAPI.Helpers;

namespace ShopManagerAPI.Middleware_Filter
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, ServiceAutUser userService)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
                attachUserToContext(context, userService, token);

            await _next(context);
        }

        private void attachUserToContext(HttpContext context, ServiceAutUser ServiceAutUser, string token)
        {
            
            var validatedToken = (SecurityToken) JwtHelper.validateToken(token);

            if(validatedToken != null)
            {
                var jwtToken = (JwtSecurityToken)validatedToken;
                var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "id").Value);
                // attach user to context on successful jwt validation
                context.Items["User"] = ServiceAutUser.getAutUser(userId);
            }
            
        }
    }
}