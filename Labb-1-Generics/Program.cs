using Labb_1_Generics.Controllers;
using Labb_1_Generics.Models;
using System.Diagnostics.CodeAnalysis;

Main();

static void Main()
{
    Console.WriteLine("\n---------- Add 5 new boxes in BoxCollection ----------");

    BoxCollection boxCollection = new BoxCollection()
    {
        new Box(25, 25, 25),
        new Box(50, 50, 50),
        new Box(20, 20, 20),
        new Box(25, 25, 30),
        new Box(50, 100, 20)
    };

    PrintCollection(boxCollection);

    Console.WriteLine("\n---------- Add 1 new boxes in BoxCollection with same volume ----------");
    boxCollection.Add(new Box(30, 25, 25));

    Console.WriteLine("\n---------- Remove 1 box in BoxCollection ----------");
    boxCollection.Remove(new Box(25, 25, 30));
    PrintCollection(boxCollection);

    Console.WriteLine("\n---------- Check if contains specific box in BoxCollection ----------");
    var box = new Box(50, 50, 47);
    Console.WriteLine("Box with Dimensions: Width = {0}, Height = {1}, Length = {2} {3} exists in the collection!",
        box.width, box.height, box.length, boxCollection.Contains(box) ? "does already" : "does NOT"); // Ternary for the win!

    Console.WriteLine("\n---------- Display the current BoxCollection ----------");
    PrintCollection(boxCollection);

    Console.ReadKey();
}

static void PrintCollection(BoxCollection boxCollection)
{
    foreach (var box in boxCollection)
    {
        Console.WriteLine("The box dimensions are: Width = {0}, Height = {1}, Length = {2}, Hash = {3}", box.width, box.height, box.length, box.GetHashCode());
    }
}