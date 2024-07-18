namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");
            string input =Console.ReadLine();

            double amount;
            if (double.TryParse(input, out amount))
            {
                account.Deposit(amount);
            }

        Console.WriteLine("Your balance is " + account.GetBalance());

        }
    }
}
