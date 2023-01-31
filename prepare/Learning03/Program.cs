using System;

class Program
{
    static void Main(string[] args)
    {
//        Fractions fraction1 = new Fractions();
//        Fractions fraction2 = new Fractions(6);
//        Fractions fraction3 = new Fractions(6,7);
  
        Fractions f1 = new Fractions();
        f1.GetFractionString(1,1);
        f1.GetDecimalValue(1,1);

        Fractions f2 = new Fractions();
        f2.GetFractionString(5,1);
        f2.GetDecimalValue(5,1);

        Fractions f3 = new Fractions();
        f3.GetFractionString(3,4);
        f3.GetDecimalValue(3,4);

        Fractions f4 = new Fractions();
        f4.GetFractionString(1,3);
        f4.GetDecimalValue(1,3);
    {

    };
    }
}