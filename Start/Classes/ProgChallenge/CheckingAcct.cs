namespace ProgChallenge
{
    public class CheckingAcct
    {
        private string _name;
        private string _surname;
        private decimal _balance;
        private const decimal OVERDRAW_CHARGE = 35.0m;

        public CheckingAcct(string name, string surname, decimal balance)
        {
            _name = name;
            _surname = surname;
            _balance = balance;
        }

        public virtual decimal Balance
        {
            get => _balance;
        }

        public virtual string AccountOwner
        {
            get => $"{_name} {_surname}";
        }

        public virtual void Deposit(decimal deposit)
        {
            _balance += deposit;
        }

        public virtual void Withdraw(decimal withdraw, bool isChecking = true)
        {
            _balance -= withdraw;
            if (isChecking && withdraw > _balance)
            {
                _balance -= OVERDRAW_CHARGE;
            }
        }


    }
}
