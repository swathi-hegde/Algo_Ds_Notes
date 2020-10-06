/*
 * Simple_Interest
S.I. = (principal* year * rate) / 100
*/

using System;
namespace Interest
{
 class SimpleInterest
 {
 static void Main(string[] args)
 {
	 //number of years
     int year;
     double princamt,rate, interest, total_amt;
     
	//read data 
     Console.Write("Enter Principal: ");
     princamt = Convert.ToDouble(Console.ReadLine());
     Console.Write("Enter Time: ");
     year = Convert.ToInt16(Console.ReadLine());
     Console.Write("Enter Rate: ");
     rate = Convert.ToDouble(Console.ReadLine());
     
	//calculte the interest
     interest = princamt * year * rate / 100;
     
	//add the interest to the principal
     total_amt = princamt + interest;
     
	//display the results
     Console.WriteLine("Simple Interest is: {0}", interest);
     Console.ReadLine();
 }
 }
}


/*
INPUT : principal= 1000, rate = 8, year = 2
OUTPUT : Simple Interest is: 160.00
*/
