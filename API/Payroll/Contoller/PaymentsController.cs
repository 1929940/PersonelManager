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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase {
        private readonly Context _context;

        public PaymentsController(Context context) {
            _context = context;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<PaymentDTO>>> GetPayment() {
            var payments = await _context.Payment.ToListAsync();
            return Ok(payments.Select(x => PaymentManager.CreateDTO(x)));
        }

        [HttpGet("Get/{id}")]
        public async Task<ActionResult<PaymentDTO>> GetPayment(int id) {
            var payment = await _context.Payment.FindAsync(id);

            if (payment == null) {
                return NotFound();
            }

            return PaymentManager.CreateDTO(payment);
        }

        [HttpGet("GetEmployeePayments/{id}")]
        public async Task<ActionResult<AdvanceDTO>> GetEmployeePayments(int id) {
            var contracts = await _context.Contracts.Where(x => x.EmployeeId == id && x.Payment != null).ToListAsync();
            var payments = contracts.Select(x => PaymentManager.CreateDTO(x.Payment));

            return Ok(payments);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> PutPayment(int id, PaymentDTO dto) {
            if (id != dto.Id) {
                return BadRequest();
            }

            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value.ToString();
            var payment = await _context.Payment.FindAsync(id);
            PaymentManager.UpdateWithDTO(dto, ref payment);
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

        [HttpPost("Create")]
        public async Task<ActionResult<PaymentDTO>> PostPayment(PaymentDTO dto) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value.ToString();
            Payment payment = new Payment();
            PaymentManager.UpdateWithDTO(dto, ref payment);
            PaymentManager.WriteCreationTags(requestAuthor, ref payment);

            _context.Payment.Add(payment);
            await _context.SaveChangesAsync();
            await _context.Entry(payment).Reference(x => x.Contract).LoadAsync();

            return CreatedAtAction("GetPayment", new { id = payment.Id }, PaymentManager.CreateDTO(payment));
        }

        [HttpDelete("Delete/{id}")]
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
