using System;
using System.Collections.Generic;  

Dictionary<string, string> ordbok =new();

ordbok.Add("Dude,", "NEEEEEEEEEJ");
ordbok.Add("WHYYYYYY","YOU ARE SICK MAN");

    
string ord = Console.ReadLine();

Console.WriteLine(ordbok[ord]);

Console.ReadLine();


Queue<int> prductionLine = new Queue<int>();

prductionLine.Enqueue(10);
//Console.WriteLine(prductionLine.Peek());


Random generator = new Random();
//int h = generator.Next();

for (int i =0; i < 10; i++)
{
    prductionLine.Enqueue(generator.Next(10));
}

while (prductionLine.Count > 0)
{
    int h = prductionLine.Dequeue();
    Console.WriteLine(h);
}

Console.ReadLine();
