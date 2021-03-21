using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class LoanAccountBuilder
    {
        private long AccountNumber { get; set; }
        private string UserName { get; set; }
        private string Password { get; set; }
        private bool IsLoan { get; set; }
        private bool IsLoanInsured { get; set; }
        double LoanAmount { get; set; }

        public LoanAccountBuilder AddAccountNumber(long accountNumber)
        {
            AccountNumber = accountNumber;
            return this;
        }

        public LoanAccountBuilder AddUserName(string userName)
        {
            UserName = userName;
            return this;
        }

        public LoanAccountBuilder AddPassword(string password)
        {
            Password = password;
            return this;
        }

        public LoanAccountBuilder AddIsLoan(bool isLoan)
        {
            IsLoan = isLoan;
            return this;
        }

        public LoanAccountBuilder AddIsLoanInsured(bool isLoanInsured)
        {
            IsLoanInsured = isLoanInsured;
            return this;
        }

        public LoanAccountBuilder AddLoanAmount(double loanAmount)
        {
            LoanAmount = loanAmount;
            return this;
        }
    }
}
