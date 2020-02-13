using System;

namespace BankingLibrary {
    public class Account {
        
        //Properties
        public string AcctNbr { get; set; }
        public string Description { get; set; }
        public decimal Balance { get; set; }
        public bool DepositCleared { get; set; }
        public bool TransferCleared { get; set; }



        //Methods
        public void Deposit(decimal amount) {
            if(amount > 0 && DepositCleared == true) {
               Balance += amount;

            }

        }
        public void Withdraw(decimal amount) {
            if (Balance  <= amount) {
                Balance -= amount;
            } else {
                Console.WriteLine("Insufficient Funds");
            }
        }
        public void Transfer(decimal amount, Account toAccount, Account fromAccount) {
            fromAccount.Withdraw(amount);
            toAccount.Deposit(amount);
        }
        //Constructors


        public Account() {

        }

    }
}
