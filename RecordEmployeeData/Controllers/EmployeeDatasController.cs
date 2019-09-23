using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordEmployeeData.Models;

namespace RecordEmployeeData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDatasController : ControllerBase
    {
        private readonly RecordEmployeeDataContext _context;

        public EmployeeDatasController(RecordEmployeeDataContext context)
        {
            _context = context;
        }

        // GET: api/EmployeeDatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeData>>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        // GET: api/EmployeeDatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeData>> GetEmployeeData(int id)
        {
            var employeeData = await _context.Employees.FindAsync(id);

            if (employeeData == null)
            {
                return NotFound();
            }

            return employeeData;
        }

        // PUT: api/EmployeeDatas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeData(int id, EmployeeData employeeData)
        {
            if (id != employeeData.Id)
            {
                return BadRequest();
            }

            _context.Entry(employeeData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeDataExists(id))
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

        // POST: api/EmployeeDatas
        [HttpPost]
        public async Task<ActionResult<EmployeeData>> PostEmployeeData(EmployeeData employeeData)
        {
            _context.Employees.Add(employeeData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployeeData", new { id = employeeData.Id }, employeeData);
        }

        // DELETE: api/EmployeeDatas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmployeeData>> DeleteEmployeeData(int id)
        {
            var employeeData = await _context.Employees.FindAsync(id);
            if (employeeData == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employeeData);
            await _context.SaveChangesAsync();

            return employeeData;
        }

        private bool EmployeeDataExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
