using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Herencia.Core;

public class Square : GeometricFigure
{

    //Fields
    private double _a;

    //Properties
    public double A
    {
        get => _a; 
        set => _a = ValidateA(value);
    }


    //Constructor
    public Square (string name, double area)
    {
        Name = name;
        A = area;
    }


    //Methods
    public override double GetArea()
    {
        return Math.Pow(A, 2);
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }

    private double ValidateA(double a)
    {
        if (a <= 0)
        {
            throw new Exception($"The value {a} must be positive and greater than zero.");
        }
        return a;
    }

}


