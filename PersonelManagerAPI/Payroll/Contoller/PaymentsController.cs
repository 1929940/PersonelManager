using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Core.DBContext;
using API.Payroll.Models;
using Microsoft.AspNetCore.Authorization;
using API.Payroll.Logic;
using System.Security.Claims;

namespace API.Payroll.Contoller {
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase {
        private readonly Context _context;

        public PaymentsController(Context context) {
            _context = context;
        }

        //[Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Payment>>> GetPayment() {
            return await _context.Payment.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Payment>> GetPayment(int id) {
            var payment = await _context.Payment.FindAsync(id);

            if (payment == null) {
                return NotFound();
            }

            return payment;
        }

        //TODO: Allows changing ContractId
        //[Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayment(int id, Payment payment) {
            if (id != payment.Id) {
                return BadRequest();
            }

            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();
            PaymentManager.WriteUpdateTags(requestAuthor, ref payment);

            _context.Entry(payment).State = EntityState.Modified;
            _context.Entry(payment).Property(x => x.CreatedOn).IsModified = false;
            _context.Entry(payment).Property(x => x.CreatedBy).IsModified = false;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!PaymentExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        //[Authorize]
        [HttpPost]
        public async Task<ActionResult<Payment>> PostPayment(Payment payment) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();
            PaymentManager.WriteCreationTags(requestAuthor, ref payment);

            _context.Payment.Add(payment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPayment", new { id = payment.Id }, payment);
        }

        //[Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Payment>> DeletePayment(int id) {
            var payment = await _context.Payment.FindAsync(id);
            if (payment == null) {
                return NotFound();
            }

            _context.Payment.Remove(payment);
            await _context.SaveChangesAsync();

            return payment;
        }

        private bool PaymentExists(int id) {
            return _context.Payment.Any(e => e.Id == id);
        }
    }
}
