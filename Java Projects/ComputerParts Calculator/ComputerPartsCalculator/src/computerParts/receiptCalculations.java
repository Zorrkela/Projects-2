package computerParts;

public class receiptCalculations extends Calculations
{
    @Override
    public double receiptCalculations(double sum, double pcBuilding) //declaring method named receiptCalculations with two parameters sum and pcBuilding
    {
        return priceCalc(sum,pcBuilding);//calling method priceCalc and passing parameters sum and pcBuilding
    }
}
