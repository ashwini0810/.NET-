using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacrDemo
{
    class Account
    {
        private int acno;

        public int AccountNumber
        {
            get { return acno; }
            set { acno = value; }
        }

    }

    interface IAccount
    {
        void Deposit(double amt);
        void Withdraw(double amt);
        double Balance { get; set; }
    }

    interface IOverdraft :IAccount
    {
        void Overdraft(double amt);
    }
    
    class SbAccount : Account, IAccount,IDisposable
    {
        private double m_dblBal;
        public double Balance
        {
            get
            {
                return m_dblBal;
            }
            set
            {
                m_dblBal = value;
            }
        }

        public void Deposit(double amt)
        {
            Console
       .WriteLine($"Depositing {amt} into account {AccountNumber}");
            Balance += amt;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Withdraw(double amt)
        {
            Console
     .WriteLine($"Withdrawing  {amt} from account {AccountNumber}");
            Balance -= amt;
        }
    }

    class SalaryAccount : Account, IOverdraft
    {
        private double m_dblBal;
        public double Balance
        {
            get
            {
                return m_dblBal;
            }
            set
            {
                m_dblBal = value;
            }
        }

        public void Deposit(double amt)
        {
            Console
       .WriteLine($"Depositing {amt} into Salary account {AccountNumber}");
            Balance += amt;
        }

        public void Overdraft(double amt)
        {
            Console
    .WriteLine($"Overdrafting  {amt} from Salary account {AccountNumber}");
            Balance -= amt;
        }

        public void Withdraw(double amt)
        {
            Console
     .WriteLine($"Withdrawing  {amt} from Salary account {AccountNumber}");
            Balance -= amt;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount sb = new SbAccount();

            IAccount salary = new SalaryAccount();
            IOverdraft od = (IOverdraft)salary;
         
        }
    }
}
