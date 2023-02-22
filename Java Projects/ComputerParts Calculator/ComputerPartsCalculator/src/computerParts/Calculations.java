package computerParts;
public abstract class Calculations {
    public abstract double receiptCalculations(double sum,double pcBuilding);
    public double priceCalc(double sum,double pcBuilding)//declaring method called priceCalc with two parameters sum and pcBuilding
    {
        double receiptSum = 0;//declaring variable for final sum of computer building including parts
        receiptSum = sum + pcBuilding;//adding computer parts price and pc building cost
        return receiptSum;//returning final sum of computer building including parts
    }
}