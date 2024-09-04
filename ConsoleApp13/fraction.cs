using System.ComponentModel.DataAnnotations;

class Fraction
{
    private int numerator;
    private int denominator;

    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }
    }

    public int Denominator
    {
        get { return denominator; }
        set { denominator = value; }
    }

    public  Fraction()
    {

        this.numerator = 0;
        this.denominator = 1;
    }
    public   Fraction (int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
        Simplify();
    }
    static int  GCD(int a, int b)
    {
        if (b == 0) 
                return a;
        return GCD(b, a % b);

    }

    public  void Simplify()
    {
        int uocsochunglonnhat =GCD(this.numerator, this.denominator);
        this.numerator = numerator /  uocsochunglonnhat;
        this.denominator = denominator /  uocsochunglonnhat;
    }
    

    public virtual string ToString()
    {
        return String.Format($"tu so:{this.numerator} \nphan so:{this.denominator}");
    }
    public double ToDecimal()
    {
        return (this.numerator / this.denominator); 
    }
     public   Fraction Add(Fraction f)
    {
        Fraction ketqua = new Fraction();
        ketqua.numerator = this.numerator * f.denominator + this.denominator * f.numerator;
        ketqua.denominator = this.denominator * f.denominator;
        ketqua.Simplify();
        return ketqua;  
    }
    public Fraction Subtract(Fraction f)
    {
        Fraction ketqua = new Fraction();
        ketqua.numerator = this.numerator * f.numerator - this.denominator * f.numerator; 
        ketqua.denominator= this.denominator * f.denominator; 
        ketqua.Simplify();
        return ketqua;
    }
    public Fraction Muiltiply(Fraction f)
    {
        Fraction ketqua = new Fraction();
        ketqua.numerator = this.numerator * f.numerator;
        ketqua.denominator = this.denominator * f.denominator;
        ketqua.Simplify();
        return ketqua; 
    }
    public Fraction Divide(Fraction f)
    {
        Fraction ketqua = new Fraction();
        ketqua.numerator = this.numerator * f.denominator;
        ketqua.denominator = this.denominator * f.numerator;
        ketqua.Simplify();
        return ketqua;
    }

   
}

 class MixedFraction : Fraction
{

    public MixedFraction(int wholePart , int numerator , int denominator)
    {
        this.Numerator = wholePart * denominator + numerator; 
        this.Denominator = denominator; 
        this.Simplify(); 
    }
    public MixedFraction(Fraction f)
    {
        this.Numerator= f.Numerator;
        this.Denominator= f.Denominator;
        this.Simplify(); 
    }
    public override string ToString()
    {
        int PhepTinh = this.Denominator / this.Numerator;
        return (PhepTinh + "[" + this.Numerator % this.Denominator + "/" + this.Denominator);
    }
}



    

    

