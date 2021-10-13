using System;
using System.Collections.Generic;
using System.Text;

namespace AppCsHerencia
{
    class Punto2D
    { 
    protected double y;

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    public Punto2D() : base()
    {
        y = 0;
    }
    public Punto2D(double x, double y) : base(x)
    {
        this.y = y;
    }
    public double Distancia(Punto2D p)
    {
        double d = 0;
        double dx = x - p.x;
        double dy = y - p.y;
        double cdx = Math.Pow(dx, 2);
        double cdy = Math.Pow(dy, 2);
        d = Math.Sqrt(cdx + cdy);

        return d;
    }
    public override string ToString()
    {
        return base.ToString() + " Y=" + y;
    }
}
}