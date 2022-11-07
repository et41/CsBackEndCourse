using Api.GenericRepository;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreditCardsController : ControllerBase
    {
        private IGenericRepository<CreditCard> _repository;
        public CreditCardsController(IGenericRepository<CreditCard> repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<CreditCard>> Get()
        {
            var data = _repository.GetAll();
            return Ok(data);
        }
        [HttpPost]
        public async Task<ActionResult<CreditCard>> Add(CreditCard creditcard)
        {
            await _repository.Create(creditcard);
            return Ok(_repository.GetAll());
        }
    }
}
