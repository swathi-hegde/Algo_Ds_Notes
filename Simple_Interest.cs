using System;
namespace Interest
{
 class SimpleInterest
 {
 static void Main(string[] args)
 {
     int year;
     double princamt,rate, interest, total_amt;
     Console.Write("Enter Principal: ");
     princamt = Convert.ToDouble(Console.ReadLine());
     Console.Write("Enter Time: ");
     year = Convert.ToInt16(Console.ReadLine());
     Console.Write("Enter Rate: ");
     rate = Convert.ToDouble(Console.ReadLine());
     interest = princamt * year * rate / 100;
     total_amt = princamt + interest;
     Console.WriteLine("Simple Interest is: {0}", total_amt);
     Console.ReadLine();
 }
 }
}


