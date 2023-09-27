using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SubjectLib;
using SubjectLib.ExceptionLayer;
namespace SubjectClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subjects subjects = new Subjects();
            try
            {
                //prodid:
                //    try
                //    {
                //        Console.WriteLine("Enter Date");
                //        m.PurDate=Convert.ToDateTime()
                //    }catch(FormatException ex)
                //    {
                //        Console.WriteLine();
                //        goto prodid
                //    }
                Theory theory = new Theory();
                theory.Id = 10;
                theory.Name = "Theory1";
                theory.Lecturer = "Lecturer1";

                subjects.Add(theory);
                Lab lab = new Lab();
                Console.WriteLine("Enter Id");
                lab.Id = Convert.ToInt32(Console.ReadLine());
                lab.Name = "Lab1";
                lab.InternalMarks = 30;

                subjects.Add(lab);

                foreach (var item in subjects.GetAllSubjects())
                {
                    Console.WriteLine(item.Name);
                }
                int n1=10, n2=20;
                Swap<int>(ref n1, ref n2);
                Console.WriteLine($"{n1}    {n2}");
                string s1 = "hello", s2 = "world";
                Swap<string>(ref s1, ref s2);

                MyGenricWrapping<int, Subject> myGenricWrapping
                    = new MyGenricWrapping<int, Subject>();
            }
            catch(DuplicateKeyException ex)
            {
                Console.WriteLine( ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine( ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }finally
            {
                Console.WriteLine("always executed");
                Console.ReadLine();
            }
        }
        public static void Swap<Tin>(ref Tin n1,ref Tin n2) 
            //where Tin : class
        {
            Tin temp = n1;
            n1 = n2;
            n2 = temp;
        }

        public static TIn GetMax<TIn>(TIn val1,TIn val2) 
            where TIn : struct, IComparable
        {
            if (val1.CompareTo(val2) > 0)
                return val1;
            else
                return val2;
        }
    }


    interface IGenericAccount<TAmt,TId>
    {
        TId AccountId { get; set; }
        void Deposit(TAmt amount);
        void Withdraw(TAmt amount);
    }

    class MyShortAccount : IGenericAccount<decimal, long>
    {
        public long AccountId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
