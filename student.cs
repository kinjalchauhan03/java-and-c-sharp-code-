using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marksheet.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int html, coa, ds, dbms, net, total=0;
            int count = 0;
            float per=0;
            Console.WriteLine("Enter marks of html:-");
            html = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of coa:-");
            coa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of ds:-");
            ds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of dbms:-");
            dbms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of net:-");
            net = Convert.ToInt32(Console.ReadLine());
            
            total=html+coa+ds+dbms+net;
            Console.WriteLine("total is:=" + total);
           // total = Convert.ToInt32(Console.ReadLine());
            per = total / 5;
            Console.WriteLine("percentage is:=" + per);
            //avg = Convert.ToDouble(Console.ReadLine());
            if (html < 40) count++;
            if (coa < 40) count++;
            if (ds < 40) count++;
            if (dbms < 40) count++;
            if (net < 40) count++;
            if (count >= 2)
            {
                Console.WriteLine("fail");
            }
            else if (count == 1)
            {
                Console.WriteLine("you have ATKT");
            }

            else
            {
                Console.WriteLine("pass class");
                if (per >= 70)
                {
                    Console.WriteLine("first distantion");
                }
                else if (per < 70 && per >= 60)
                {
                    Console.WriteLine("first class");
                }
                else if (per <= 60 && per > 55)
                {
                    Console.WriteLine("second class");
                }
                else{      
                    Console.WriteLine("pass class");
                }
            }
            Console.ReadLine();
        }
    }
}
