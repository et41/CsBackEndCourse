using Api.Data;
using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountsController : ControllerBase
    {
        private readonly InheritanceMappingContext _context;
        public BankAccountsController(InheritanceMappingContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IQueryable<BankAcountDto> GetBook()
        {
            var accounts = from b in _context.BankAccounts
                           select new BankAcountDto()
                           {
                               BillingDetailId = b.BillingDetailId,
                               Owner = b.Owner,
                               Number = b.Number
                           };
            return accounts;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            var account = await _context.BankAccounts.Select(b =>
                new BankAccountDetailsDto()
                {
                    BillingDetailId = b.BillingDetailId,
                    Owner = b.Owner,
                    Number = b.Number,
                    BankName = b.BankName,
                    Swift = b.Swift
                }).SingleOrDefaultAsync(b => b.BillingDetailId == id);
            if (account == null)
                return NotFound();
            return Ok(account);
        }
    }
}
