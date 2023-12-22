namespace maths;
public class Complex
{
    private int real;
    private int img;
    public Complex()
    {
        this.real = 0;
        this.img = 0;
    }
    public Complex(int r, int i)
    {
        this.real = r;
        this.img = i;
    }
    public int Real
    {
        get { return this.real; }
        set { this.real = value; }
    }
    public int Img
    {
        get { return this.img; }
        set { this.img = value; }
    }
    ~Complex()
    {

    }
    public static Complex operator +(Complex c1, Complex c2)
    {
        Complex temp = new Complex();
        temp.real = c1.real + c2.real;
        temp.img = c1.img + c2.img;
        return temp;
    }
    public override string ToString()
    {
        return this.real + " +i " + this.img;
    }
}