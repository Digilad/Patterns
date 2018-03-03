using System;

namespace Patterns.Behavioural
{
    /// <summary>
    /// ChainOfResponsibility
    /// Цепочка обязанностей
    /// https://proglib.io/p/behavioral-patterns/
    /// </summary>

    public class ChainOfResponsibility
    {
        public void Using()
        {
            var bank = new Bank(100);
            var paypal = new Paypal(200);
            var bitcoin = new Bitcoin(300);
            bank.SetNext(paypal);
            paypal.SetNext(bitcoin);
            bank.Pay(259);
        }
    }

    public abstract class Account
    {
        protected Account successor;
        protected float balance;

        public void SetNext(Account account)
        {
            successor = account;
        }
        
        public void Pay(float amountToPay)
        {
            if (CanPay(amountToPay))
            {
                Console.WriteLine($"Paid {amountToPay} using {this.GetType()}");
            }
            else if (successor != null)
            {
                Console.WriteLine($"Not enough money in {this.GetType()}. In use...");
                successor.Pay(amountToPay);
            }
            else
            {
                Console.WriteLine($"No money in all accounts ({this.GetType()})");
            }
        }

        private bool CanPay(float amount)
        {
            return balance >= amount;
        }
    }

    public class Bank : Account
    {
        public Bank(float b)
        {
            balance = b;
        }
    }

    public class Paypal : Account
    {
        public Paypal(float b)
        {
            balance = b;
        }
    }

    public class Bitcoin : Account
    {
        public Bitcoin(float b)
        {
            balance = b;
        }
    }
}
