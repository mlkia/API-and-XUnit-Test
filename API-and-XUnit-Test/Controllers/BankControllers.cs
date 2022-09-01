using API_and_XUnit_Test.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_and_XUnit_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankControllers : ControllerBase
    {
        private readonly Account account;

        public BankControllers (Account acc)
        {
            this.account = acc;
        }


        // GET: api/<BankControllers>
        [HttpGet]
        public decimal ShowTheCurrentlyBalance()
        {
            return account.Balance;
        }



        // PUT api/<BankControllers>/5
        [HttpPut("withdraw/{amount}")]
        public decimal Withdraw(decimal amount)
        {
            return account.Balance -= amount;
        }

        // PUT api/<BankControllers>/5
        [HttpPut("insert/{amount}")]
        public decimal Insert(decimal amount)
        {
            return account.Balance += amount;
        }
       


    }
}
