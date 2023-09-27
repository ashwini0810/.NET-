using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DelegateDemo
{
    internal delegate long MyDelegate(int n1, int n2);
    internal delegate void MCDelegate();

    class MathClass
    {
        public long Add(int n1,int n2)
        {
            Thread.Sleep(5000);
            return n1 + n2;
        }

        public static long Multiply(int n1,int n2)
        {
            return n1 * n2;
        }
        public void M1()
        {
            Console.WriteLine("M1 called");
        }
        public static void M2()
        {
            Console.WriteLine("M2 called");
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            MathClass math = new MathClass();

            //   Console.WriteLine(  math.Add(222,333));
            // Console.WriteLine(MathClass.Multiply(222,333));

            MyDelegate del1, del2;
            Console.WriteLine("functions are invoked");
            del1 = new MyDelegate(math.Add);

            del2 = new MyDelegate(MathClass.Multiply);

            //Async invokation
            string msg = "hello";
            AsyncCallback callback = new AsyncCallback(MyCallback);

            IAsyncResult iar = del1.BeginInvoke(122, 333, callback, del1);

            // Console.WriteLine(del1.Invoke(232, 333));//synchronous invokation
            long result = del2.Invoke(232, 333);
            Console.WriteLine(result);

            //MCDelegate del;
            //del = new MCDelegate(math.M1);
            //del += new MCDelegate(MathClass.M2);
            //del += new MCDelegate(MathClass.M2);

            //del.Invoke();

            //del -= new MCDelegate(MathClass.M2);

            //del.Invoke();


            Console.WriteLine("Main finished..");
            Console.ReadLine();
        }

        static void MyCallback(IAsyncResult ar)
        {
            MyDelegate del = ar.AsyncState as MyDelegate;
            long result = del.EndInvoke(ar);
            Console.WriteLine("Long running add result {0}", result);
        }
    }
}
