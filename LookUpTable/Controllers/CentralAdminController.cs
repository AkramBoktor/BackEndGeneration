using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LookUpTable.DAL;
using LookUpTable.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LookUpTable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CentralAdminController : ControllerBase
    {
        private readonly CentralAdminDbContext _context;
        public CentralAdminController(CentralAdminDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<CentralAdministration>> GetAll()
        {
            return await _context.CentralAdministrations.ToListAsync();
        }
        [HttpGet("{Id}")]
        public async Task<CentralAdministration> GetById([FromRoute] int Id)
        {
            return await _context.CentralAdministrations.FirstOrDefaultAsync(a => a.Id == Id);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CentralAdministration centralAdministration)
        {
            await _context.AddAsync(centralAdministration);
            var res = await _context.SaveChangesAsync();
            if (res > 0)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] CentralAdministration centralAdministration)
        {
            _context.Entry(centralAdministration).State = EntityState.Modified;
            var res = await _context.SaveChangesAsync();
            if (res > 0)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}