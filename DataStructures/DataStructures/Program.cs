// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System.Collections;


ArrayList a1 = new ArrayList();

a1.Add(10);
a1.Add(20);
a1.Add(30);

foreach (Object obj in a1)
    Console.WriteLine(obj);

Console.WriteLine(a1.Capacity);
Console.WriteLine(a1.Contains(10));
Console.WriteLine(a1.Count);

Console.WriteLine("To remove element 20");

a1.Remove(20);

foreach (Object obj in a1)
    Console.WriteLine(obj);

Console.WriteLine("Element added - 40");


a1.Add(40);
foreach (Object obj in a1)
    Console.WriteLine(obj);

Console.WriteLine("Element removed at index 1");

a1.RemoveAt(1);
foreach (Object obj in a1)
    Console.WriteLine(obj);


Console.WriteLine("------------------------------ Stack ------------------------------");

Stack s1 = new Stack();

s1.Push(10);
s1.Push(20);
s1.Push(30);

foreach (Object obj in s1)
    Console.WriteLine(obj);

Console.WriteLine("Element revmoved from the top - 30");

s1.Pop();

foreach (Object obj in s1)
    Console.WriteLine(obj);

Console.WriteLine("Elements present - " + s1.Count);
Console.WriteLine("Does it contain 40 - " + s1.Contains(40));

Console.WriteLine("Stack cleared !!!");

s1.Clear();

foreach (Object obj in s1)
    Console.WriteLine(obj);


Console.WriteLine("------------------------------ Queue ------------------------------");

Queue q = new Queue();

q.Enqueue("Java");
q.Enqueue("Python");
q.Enqueue("Javascript");


foreach (Object obj in q)
    Console.WriteLine(obj);

Console.WriteLine("Elements present - " + q.Count);
Console.WriteLine("Does it contain SQL - " + s1.Contains("SQL"));


Console.WriteLine("Elements removed - JAVA");
q.Dequeue();
foreach (Object obj in q)
    Console.WriteLine(obj);


Console.WriteLine("------------------------------ Hash Table ------------------------------");

Hashtable h = new Hashtable();

h.Add(1, "MS Dhoni");
h.Add(2, "Viv Richards");
h.Add(3, "Mitch Johnson");


















