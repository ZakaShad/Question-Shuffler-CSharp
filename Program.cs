using System;
using TestShuffler;
using static TestShuffler.Utils;

Console.WriteLine("Hello, World!");
Question q = new Question("Why did the chicken cross the road?", "To get to the other side", false);
Console.WriteLine(q.Text);
Console.WriteLine(q.Ans);
//Cat c = new Cat("./data.txt");
string a = "asdfadfasdfds***dadf";
Console.WriteLine(startCount(a, '*'));
Cat c = new Cat("./data.txt");