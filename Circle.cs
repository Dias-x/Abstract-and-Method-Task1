namespace Aufgabe_1;

//Abgeleitete Klasse, braucht kein public davor
class Circle : Shape
{
    //Eigenschaften
    public double Radius { get; set; }

    
    //MKonstruktor "Nachfragen!!"
    public Circle(double radius)
    {
        Radius = radius;
    }
    
    //Abstrakte Methode arufen und überschreiben
    public override double GetArea()
    {
        return Radius * Radius * Math.PI;
    }
}