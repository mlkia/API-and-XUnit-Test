namespace API_and_XUnit_Test.Models
{
    public class Account
    {
        public decimal Balance { get; set; }
       
        public Account (decimal balance)
        {
            if (balance < 0) balance = 0;
            
           Balance = balance;
        }
    }
    
}
