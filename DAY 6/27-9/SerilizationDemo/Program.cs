using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace SerilizationDemo
{
    [Serializable]
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
       // [JsonIgnore]
        public string Email { get; set; }
        public List<Order> Orders { get; set; }
    }
    [Serializable]
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public byte Status { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer
                {
                     Id=1, Email="cust1@mail.com",
                      Name="Cust1",
                      Orders =new List<Order>
                      {
                          new Order{ Id=101, OrderDate=new DateTime(2021,1,10)
                           , Status=1},
                          new Order{ Id=102, OrderDate=new DateTime(2021,4,2)
                           , Status=4},
                          new Order{ Id=105, OrderDate=new DateTime(2022,10,16)
                           , Status=2},
                          new Order{ Id=106, OrderDate=new DateTime(2022,5,12)
                           , Status=1},
                      }
                },
                new Customer
                {
                     Id=2, Email="cust2@mail.com",
                      Name="Cust2",
                      Orders =new List<Order>
                      {
                          new Order{ Id=107, OrderDate=new DateTime(2021,1,10)
                           , Status=1},
                          new Order{ Id=108, OrderDate=new DateTime(2021,4,2)
                           , Status=4}
                      }
                }

            };


            //serilization to JSON
            string json = JsonConvert.SerializeObject(customers);
            Console.WriteLine(json);
            

            //Deserilize to customer list
            List<Customer> customers1 = new List<Customer>();
            customers1 = JsonConvert
                .DeserializeObject<List<Customer>>(json);

            Console.WriteLine(customers1.Count);
            Console.ReadLine();
        }
    }
}
