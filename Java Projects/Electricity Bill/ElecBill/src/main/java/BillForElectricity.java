public class BillForElectricity  extends Calculations{
    @Override
    public double billCalculations(double numberOfKiloWats, double StaticPrice)
    {
        return billCalc(numberOfKiloWats,StaticPrice);
    }
}
