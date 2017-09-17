using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wrox.Interfaces;

namespace Wrox.chaptor5
{
    public class Account : IAccount
    {
        public decimal Balance { get; set; }
        public string Name { get; private set; }

        public Account(string name,decimal balance)
        {
            this.Balance = balance;
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format("{0}-{1:C2}", Name, Balance);
        }

    }

    public class Algorithm
    {
        public static List<Account> lists = new List<Account>()
            {
                new Account("jack",15000),
                new Account("jane",2000),
                new Account("Jone",34.8m)
            };

        public static decimal Accumulate<T>(IEnumerable<T> source) where T:IAccount
        {
            decimal sum = 0.0m;
            foreach(T a in source)
            {
                sum += a.Balance;
            }
            return sum;
        }

        public static T2 Accumulate<T1,T2>(IEnumerable<T1> source,Func<T1,T2,T2> action) where T1:IAccount
        {
            T2 sum = default(T2);
            foreach(T1 a in source)
            {
                sum = action(a, sum);
            }

            return sum;
        }

        public static void Start()
        {
            decimal result = Algorithm.Accumulate(lists);
            Console.WriteLine("result is {0}", result);
        }

        public static void Start2()
        {
            decimal result = Accumulate<Account, decimal>(lists, (item, sum) => sum += item.Balance);
            Console.WriteLine("result is {0}", result);
        }

    }
}
