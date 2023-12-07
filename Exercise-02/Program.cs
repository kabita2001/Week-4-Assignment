namespace ASSIGNMENT_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bankaccount balance = new Bankaccount("220160560",0);
            balance.Deposit(1000);
            balance.Withdraw(500);
            balance.Output();
        }
    }
}