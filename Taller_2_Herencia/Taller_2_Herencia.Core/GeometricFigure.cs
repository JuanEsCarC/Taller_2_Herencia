namespace Taller_2_Herencia.Core;

public abstract class GeometricFigure
{

    //Properties
    public string Name { get; set; } = null!;


    //Methods

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return
            $"{Name}          => Area.....: {GetArea(),16:N5}\t Perimeter: {GetPerimeter(),16:N5}"; 
    }

}
