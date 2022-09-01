using Xunit;
using API_and_XUnit_Test.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_and_XUnit_Test.Models;

namespace API_and_XUnit_Test.Controllers.Tests
{
    public class BankControllersTests
    {

        readonly Account sut = new(100);




        [Fact()]
        public void ShowTheCurrentlyBalance()
        {
            var expected = 100M;
            var result = sut.Balance;

            Assert.Equal(expected, result);
        }

        [Fact()]
        public void Withdraw()
        {

            var expected = 45.5M;
            var result = new BankControllers(sut).Withdraw(54.5M);

            Assert.Equal(expected, result);
        }

        [Fact()]
        public void Insert()
        {

            var expected = 155M;
            var result = new BankControllers(sut).Insert(55M);

            Assert.Equal(expected, result);
        }
    }
}