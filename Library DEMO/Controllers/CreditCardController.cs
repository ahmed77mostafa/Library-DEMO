using Library_DEMO.DTOs.CreditCardFolder;
using Library_DEMO.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_DEMO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController : ControllerBase
    {
        private protected ICreditCardRepo _creditCardRepo;

        public CreditCardController(ICreditCardRepo creditCardRepo)
        {
            _creditCardRepo = creditCardRepo;
        }
        [HttpPost("Add-Credit-Author")]
        public IActionResult AddCreditAuthor(CreditCardDto creditCardDto)
        {
            _creditCardRepo.AddCreditCardAuthor(creditCardDto);
            return Ok();
        }
    }
}
