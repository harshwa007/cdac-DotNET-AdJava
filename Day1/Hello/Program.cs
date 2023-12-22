using bank; 
using maths;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Account acc = new Account(50000,"Om");
Console.WriteLine(acc);
acc.nam = " vivek";
Console.WriteLine(acc);




Console.WriteLine(acc.getbalance());

acc.Withdraw(10001);
Console.WriteLine(acc.getbalance());

acc.Deposit(122323);
Console.WriteLine(acc.getbalance());


Complex c1 = new Complex(12,52);
Complex c2 = new Complex(20,200);
Complex c3 = c1+c2;
Console.WriteLine(c1+" "+c2+" "+ c3);