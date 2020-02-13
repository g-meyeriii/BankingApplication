using System;
using BankingLibrary;

namespace BankingApplication {
    public class Program {
        static void Main(string[] args) {


            var chk = new BankingLibrary.Account();
            chk.Deposit(100);
            chk.Withdraw(75);




        }




    }
}
