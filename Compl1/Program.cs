using System.Numerics;
using System.Text;

Complex z1 = new Complex() { Re = 2, Im = 3 };
Console.WriteLine(z1);
Complex z2 = new Complex() { Im = 3 };
Console.WriteLine(z2);
Complex z3 = new Complex() { Im = -3 };
Console.WriteLine(z3);
Complex z4 = new Complex() { Im = -1 };
Console.WriteLine(z4);
Complex z5 = new Complex() {Re = -1};
Console.WriteLine(z5);
Complex z6 = new Complex();
Console.WriteLine(z6);

Complex z7 = z5 + z3;
Console.WriteLine(z7);
class Complex
{
    private double re;
    private double im;
    public double Re
    { get { return re; } set { re = value; } }
    public double Im
    {
        get => im;
        set => im = value;
    }
    public double Abs => Math.Sqrt(re*re + im*im);

    public static Complex operator +(Complex z1, Complex z2)
    {
        return new Complex() { Re = z1.re + z2.Re, Im = z1.im + z2.Im };
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        if (re != 0 || im == 0) sb.Append(re);
        if (im != 0)
        {
            if (im > 0) { 
                if (re != 0)
                    sb.Append("+");
            }
            else sb.Append("-");
            if (im != 1 && im != -1) sb.Append(Math.Abs(im));
            sb.Append("i");
        }
        return sb.ToString();
    }

}