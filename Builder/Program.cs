using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var loadAccount = new LoanAccountBuilder()
                .AddAccountNumber(123)
                .AddIsLoan(true)
                .AddIsLoanInsured(false)
                .AddLoanAmount(200)
                .AddPassword("password")
                .AddUserName("Gil");
        }
    }
}
