using System;

namespace inheritanceRealationship.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*CheckingAccount check1 = new CheckingAccount();
            check1.CoustomerName = "Fahad";
            check1.AccountNo = "12323323";
            check1.ServiceCharge = 678;
            check1.Deposite(1000);
            check1.Withdraw(100);
            double balance = check1.Balance;

            SavingAccount SavAc1 = new SavingAccount();
            SavAc1.CoustomerName = "Rahat";
            SavAc1.AccountNo = "53553366";
            SavAc1.Deposite(3000);
            SavAc1.Withdraw(100);
            SavAc1.InterestAmount(10);*/
            SavingAccount sav1 = new SavingAccount();
            double depoAmount = 5000;
            sav1.Deposite(depoAmount);
            double withDraw = 6000;
            sav1.Withdraw(withDraw);
        }
    }
}
