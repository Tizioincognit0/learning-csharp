using System;

namespace ProgChallenge
{
    public class SavingsAcct : CheckingAcct
    {
        private decimal _interest;
        private int _withdrawsCount;
        private const decimal WITHDRAW_CHARGE = 2.0m;
        private const int WITHDRAW_LIMIT = 3;


        public SavingsAcct(string name, string surname, decimal interest, decimal balance) : base(name, surname, balance)
        {
            _interest = interest;
        }

        public virtual void ApplyInterest()
        {
            base.Deposit(Balance * _interest);
        }

        public void Withdraw(decimal withdrawl)
        {
            if (withdrawl > Balance)
            {
                Console.WriteLine("Attempt to overdraw savings - denied");
            }
            else if (_withdrawsCount >= WITHDRAW_LIMIT)
            {
                Console.WriteLine($"More than {WITHDRAW_LIMIT} withdrawais - extra charge");
                base.Withdraw(withdrawl + WITHDRAW_CHARGE, false);
            }
            else
            {
                base.Withdraw(withdrawl, false);
            }
            _withdrawsCount++;

        }

    }
}
