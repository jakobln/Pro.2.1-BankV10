namespace BankV10
{
    public class BankAccount
    {
        #region Instance fields
        private double _balance;
        #endregion

        #region Constructor
        public BankAccount()
        {
            _balance = 0.0;
        }
        #endregion

        #region Properties
        public double Balance
        {
            get { return _balance; }
        }
        #endregion

        #region Methods
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance = _balance + amount;
            }

            else if (amount < 0)
            {
                System.Console.WriteLine("You cannot deposit a negative amount");
            }

            else if (amount == 0)
            {
                System.Console.WriteLine("You cannot deposit 0");
            }
        }

        public void Withdraw(double amount)
        {
            if (_balance > 0 && amount > 0 && amount < _balance)
            {
                _balance = _balance - amount;
            }

            else if (amount > _balance)
            {
                System.Console.WriteLine("You do not have enough money on your account");
            }

            else if (amount < 0)
            {
                System.Console.WriteLine("You cannot withdraw a negative amount");
            }

            else if (amount == 0)
            {
                System.Console.WriteLine("You cannot withdraw 0");
            }
        } 
        #endregion
    }
}