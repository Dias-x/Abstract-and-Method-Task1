using System;
using Aufgabe_1;


class Program
{
    static void Main(string[] args)
    {
        //Objekt erstellen mit den Parameter
        Rectangle rectangle = new Rectangle(50, 23);
        
        Circle circle = new Circle(5);

        //Ausgabe mit der zugewiesener Methode
        Console.WriteLine(rectangle.GetArea());
        Console.WriteLine(circle.GetArea());
    }
}