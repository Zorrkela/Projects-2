
public abstract class Calculations {
    public abstract double billCalculations(double numberOfKiloWats,double StaticPrice);
    public static double billCalc(double numberOfKiloWats, double StaticPrice)
    {
        double billSum = 0;
        billSum = numberOfKiloWats * StaticPrice;
        return billSum;
    }
}
