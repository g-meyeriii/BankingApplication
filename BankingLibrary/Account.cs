using System;

namespace BankingLibrary {
    public abstract class Account {

        //Properties

        private static int NextAcctNbr = 1;
        private static int AcctNbrInc = 9;

        public int AcctNbr { get; private set; }
        public string Description { get; set; } = "Account";
        public decimal Balance { get; set; }

        private int AttemptsToOverdraw = 0;

        private bool CheckAmountGTZero(decimal amount) {
            return (amount <= 0) ? false : true;
        }
        //left is the ternary operator way to solve this problem. If only true or false.

        //if (amount <= 0) { //use the if statement to find the problem, what you don't wan                    to happen
        // return false;
        //} else {   else statement can do the same thing also 
        // return true;

        private bool IsSufficientFunds(decimal amount) {
            if (Balance >= amount) {
                return true;
            }
            AttemptsToOverdraw++;
            return false;
        }
        //Methods
        public void Deposit(decimal amount) {
            if (CheckAmountGTZero(amount))
                Balance += amount;

        }
        public bool Withdraw(decimal amount) {
            if (CheckAmountGTZero(amount) && IsSufficientFunds(amount)) {
                Balance -= amount;
                return true;
            }
            return false;
        }
        public void Transfer(decimal amount, Account toAccount) {
            if (this.Withdraw(amount)) {
                toAccount.Deposit(amount);
            }

        }
        public void Debug() {
            Console.WriteLine(this);
        }

        public override string ToString() {
            return($"AcctNbr={AcctNbr},Desc = {Description}, Bal= {Balance}");
        }
        //Constructors
        public Account() {
            this.AcctNbr = NextAcctNbr;
            NextAcctNbr += AcctNbrInc;
            AcctNbrInc = 1;
        }

    }
}
