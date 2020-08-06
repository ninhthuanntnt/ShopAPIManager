using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopManagerAPI.Services;
using ShopManagerAPI.Models;

namespace ShopManagerAPI.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class TaAutUsersController : ControllerBase
    {
        private readonly shopContext _context;
        private ServiceAutUser svAuthUser;

        public TaAutUsersController(shopContext context)
        {
            _context = context;
            svAuthUser = new ServiceAutUser(context);
        }

        [HttpGet("Test")]
        public ActionResult<TaPerPerson> Test()
        {
            return _context.PerPerson.Include(per => per.ManagerSorOrders).First(per => per.Id != 0);
        } 

        // GET: api/user
        [HttpGet]
        public ActionResult<TaAutUser> GetTaAutUsers()
        {
            TaAutUser userById = svAuthUser.getAutUser(1);

            return userById;
        }

        // GET: api/user/5
        [HttpGet("{id}")]
        public ActionResult<TaAutUser> GetTaAutUser(int id)
        {
            try
            {
                TaAutUser userById = svAuthUser.getAutUser(id);
                
                if (userById != null) return userById;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return NotFound(new { message = "User not found" });
        }

        [HttpGet("{id}/{roleId}")]
        public ActionResult<TaAutUser> GetTaAutUser(int id,int roleId)
        {
            TaAutUser userByIdAndRoleId = svAuthUser.getAutUserIncludeRoleIdLt(id, roleId);

            return userByIdAndRoleId;
            
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaAutUser(int id, TaAutUser taAutUser)
        {
            if (id != taAutUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(taAutUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaAutUserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        
        // POST: api/user
        [HttpPost]
        public async Task<ActionResult<TaAutUser>> PostTaAutUser(TaAutUser taAutUser)
        {
            _context.TaAutUser.Add(taAutUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaAutUser", new { id = taAutUser.Id }, taAutUser);
        }

        // DELETE: api/user/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TaAutUser>> DeleteTaAutUser(int id)
        {
            var taAutUser = await _context.TaAutUser.FindAsync(id);
            if (taAutUser == null)
            {
                return NotFound();
            }

            _context.TaAutUser.Remove(taAutUser);
            await _context.SaveChangesAsync();

            return taAutUser;
        }

        private bool TaAutUserExists(int id)
        {
            return _context.TaAutUser.Any(e => e.Id == id);
        }
    }
}
