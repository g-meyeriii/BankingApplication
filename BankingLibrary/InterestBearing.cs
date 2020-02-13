using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary {
    public class InterestBearing : Account {
        //Properties
        public decimal InterestRate { get; private set; }

        //Constuctor
        public void CalculateInterest(int Months) {
            var interest = this.Balance *(this.InterestRate/12)* Months;
            Deposit(interest);
            Console.WriteLine($"Calculated interest is {interest}");
        }
        public override string ToString() {
            return $"{base.ToString()} IntRate {InterestRate}"; //calling to string from the base class
        }

        public InterestBearing(double interestRate) : this (){
            InterestRate = Convert.ToDecimal (interestRate);
        }
    
        public InterestBearing() : base() { 
            this.Description = "Interest Account";
        }
    }
}
