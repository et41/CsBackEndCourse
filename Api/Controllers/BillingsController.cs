using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Data;
using Api.Models;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BillingsController : ControllerBase
    {

        private readonly InheritanceMappingContext _context;
        public BillingsController(InheritanceMappingContext context)
        {
            _context = context;
        }


        [HttpGet("{type}")]
        public async Task<ActionResult<CreditCard>> GetCard(string type)
        {
            if (type == "creditcard")
                return Ok(await _context.BillingDetails.OfType<CreditCard>().ToListAsync());
            else if (type == "bankaccount")
                return Ok(await _context.BankAccounts.ToListAsync());
            else
                return BadRequest("No data found");
        }
    }
}