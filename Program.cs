class Program
{
    public class SavingAccount{
        public Double currBalance;
        public static Double currInterestRate = 0.04;
    }
    public static void Main(string[] args)
    {
        SavingAccount account1 = new SavingAccount();
        SavingAccount account2 = new SavingAccount();
        SavingAccount account3 = new SavingAccount();

        Console.WriteLine(SavingAccount.currInterestRate);
        Console.WriteLine(SavingAccount.currInterestRate);
        Console.WriteLine(SavingAccount.currInterestRate);

        Console.WriteLine(account1.currBalance);
    }
}