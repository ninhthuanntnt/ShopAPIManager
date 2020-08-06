using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagerAPI.Models
{
  
    public class JwtResponse
    {
        public string Prefix = "Bearer";

        public string Token { get; set; }

        public JwtResponse(string token)
        {
            Token = token;
        }
    }
}
