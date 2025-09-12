using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Herencia.Core;

public class Triangle : Rectangle
{

    //Fields
    private double _c;
    private double _h;

    //Properties

    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }
    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }


    //Constructor
    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        C = c;
        H = h;
    }


    //Methods

    public override double GetArea()
    {
        return (B * H) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C;
    }

    private double ValidateC(double c)
    {
        if (c <= 0)
        {
            throw new Exception($"The value: {c} must be positive and greater than zero.");
        }
        return c;
    }

    private double ValidateH(double h)
    {
        if (h<= 0)
        {
            throw new Exception($"The value: {h} must be positive and greater than zero.");
        }
        return h;
    }


}
