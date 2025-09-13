namespace Taller_2_Herencia.Core;

public abstract class GeometricFigure
{

    public string Name { get; set; } = null!;


    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return
            $"{Name,-13}   => Area.....:{GetArea(),16:N5}\t Perimeter:{GetPerimeter(),16:N5}"; 
    }

}
