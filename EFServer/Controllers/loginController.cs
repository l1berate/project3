using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFServer.Models.EF;

namespace EFServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        private readonly P3_shoppingDBContext _context = new P3_shoppingDBContext();

        //public loginController(P3_shoppingDBContext context)
        //{
        //    _context = context;
        //}

        // GET: api/login
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AspNetUserLogin>>> GetAspNetUserLogins()
        {
            return await _context.AspNetUserLogins.ToListAsync();
        }

        // GET: api/login/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AspNetUserLogin>> GetAspNetUserLogin(string id)
        {
            var aspNetUserLogin = await _context.AspNetUserLogins.FindAsync(id);

            if (aspNetUserLogin == null)
            {
                return NotFound();
            }

            return aspNetUserLogin;
        }

        // PUT: api/login/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAspNetUserLogin(string id, AspNetUserLogin aspNetUserLogin)
        {
            if (id != aspNetUserLogin.LoginProvider)
            {
                return BadRequest();
            }

            _context.Entry(aspNetUserLogin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AspNetUserLoginExists(id))
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

        // POST: api/login
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AspNetUserLogin>> PostAspNetUserLogin(AspNetUserLogin aspNetUserLogin)
        {
            _context.AspNetUserLogins.Add(aspNetUserLogin);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AspNetUserLoginExists(aspNetUserLogin.LoginProvider))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAspNetUserLogin", new { id = aspNetUserLogin.LoginProvider }, aspNetUserLogin);
        }

        // DELETE: api/login/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAspNetUserLogin(string id)
        {
            var aspNetUserLogin = await _context.AspNetUserLogins.FindAsync(id);
            if (aspNetUserLogin == null)
            {
                return NotFound();
            }

            _context.AspNetUserLogins.Remove(aspNetUserLogin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AspNetUserLoginExists(string id)
        {
            return _context.AspNetUserLogins.Any(e => e.LoginProvider == id);
        }
    }
}
