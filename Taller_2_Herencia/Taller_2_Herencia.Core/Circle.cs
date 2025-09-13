using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Herencia.Core;

public class Circle : GeometricFigure
{

    private double _r;

    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    public Circle(string name, double rad)
    {
        Name = name;
        R = rad;
    }

    public override double GetArea() 
    { 
        return Math.PI * Math.Pow(R,2); 
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * R;
    }

    private double ValidateR(double rad)
    {
        if (rad <= 0)
        {
            throw new Exception($"The value {rad} must be positive and greater than zero.");
        }
        return rad;
    }

}
