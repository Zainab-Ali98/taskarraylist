// See https://aka.ms/new-console-template for more information
using System.Collections;


ArrayList groceryList = new ArrayList();

groceryList.Add("apple");
groceryList.Add("banana");
groceryList.Add("cherry");

Console.WriteLine("grocery List :");

foreach (string item in groceryList)
{
    Console.WriteLine(item);
}

groceryList.Insert(2, "orange");
groceryList.Remove("banana");
Console.WriteLine("------------------");
foreach (string item in groceryList)
{
    Console.WriteLine(item);
}

Console.WriteLine("------------------");
Console.WriteLine("enter fruit name :");
string term = Console.ReadLine();
if(groceryList.Contains(term) == true)
{
    Console.WriteLine($"Yes Contain: {term}");
}
else
{
    Console.WriteLine("doesnt contain");

}
string term2 = Console.ReadLine();
int indexOf = groceryList.IndexOf(term2);
Console.WriteLine($"index : {indexOf}");

Console.WriteLine("------------------");
Console.WriteLine($"number of element in array list {groceryList.Count}");


