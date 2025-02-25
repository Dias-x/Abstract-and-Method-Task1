﻿namespace Aufgabe_1;

//Abgeleitete Klasse, braucht kein public davor
class Rectangle : Shape
{
    //Eigenschaften
    public double Width { get; set; }
    public double Height { get; set; }
    
    //Konstruktor "Nachfragen!!"
    public Rectangle(double wight, double height)
    {
        Width = wight;
        Height = height;
    }
    
    //Abstrakte Methode abrufen und überschreiben
    public override double GetArea()
    {
        return Width * Height;
    }
    
}