using System;
namespace MyBank
{
    public class Savings
    {
        public static long Safe_money { get; set; } = 1000000000;
        public Savings() { }

        public static void Deposite(long amount) => Safe_money -= amount;
        public static void Withdraw(long amount) => Safe_money += amount;
        
    }
}
