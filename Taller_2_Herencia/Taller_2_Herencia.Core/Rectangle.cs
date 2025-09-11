using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Herencia.Core;

public class Rectangle : Square
{

    //Fields
    private double _b;

    //Properties
    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }


    // Fix: Call base constructor with required parameters 'name' and 'a' (side length for Square).
    public Rectangle(string name, double a, double b) : base(name, a)
    {
        B = b;
    }


    //Methods
    public override double GetArea()
    {
        return A * B;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private double ValidateB(double b)
    {
        if (b <= 0)
        {
            throw new Exception($"The value {b} must be positive and greater than zero.");
        }
        return b;
    }












}

