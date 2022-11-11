using Api.Data;
using Api.Migrations;
using Api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountsControllerWithMapper : Controller
    {
        private readonly InheritanceMappingContext _context;
        public readonly IMapper _mapper;
        public BankAccountsControllerWithMapper(InheritanceMappingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task AddBankAccount(BankAcountDto account)
        {
            var _mappedAccount = _mapper.Map<BankAccount>(account);
            await _context.Set<BankAccount>().AddAsync(_mappedAccount);
            await _context.SaveChangesAsync();

        }
    }
}
