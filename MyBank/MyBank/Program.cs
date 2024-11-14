using System;
namespace  MyBank
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Accounts account = new Accounts();
            account.Login();
            Console.ReadKey();

        }

    }
}