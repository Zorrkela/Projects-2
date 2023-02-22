import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        Scanner cs = new Scanner(System.in);
        String usrname="";
        String passw="";
        String conti = "";
        do
        {
            usrname = "";
            passw = "";
            System.out.println("Welcome to Electricity Bill creator!!!\n");
            System.out.println("Please enter your Login details!\n Username:");
            usrname = cs.next();
            System.out.println("\nPassword:");
            passw = cs.next();
        }
        while(!(usrname.equals("Nikola") && passw.equals("nikola")));
        do
        {
            Scanner cs1 = new Scanner(System.in);
            String cont = "Y";
            String customerInfo = "";
            double consumptionKW = 0;
            final double electricityPricePerKW = 5.108;
            do
            {
                System.out.println("Please enter Customer information(Name,City,Address): ");
                customerInfo = cs1.next();
            }
            while(!customerInfo.matches("[A-Z][a-z]+,[A-Za-z0-9]+,[A-Za-z0-9]+"));
            do{
                System.out.println("Enter Electricity Consumption in KW: ");
                consumptionKW = cs1.nextDouble();
            }
            while(consumptionKW <= 0);

            BillForElectricity b = new BillForElectricity();
            b.billCalc(consumptionKW, electricityPricePerKW);
            FileUtil.appendLine("src\\Bill.txt",customerInfo + " " + b.billCalc(consumptionKW, electricityPricePerKW) + " dinara");
            System.out.println("Done,Do you wish to continue? Y/N");
            cont = cs1.next().toUpperCase();
            conti=cont;
            if(!cont.equals("N"))
            {
                System.out.println("Please repeat your choice Y/N: ");
                cont = cs1.next().toUpperCase();
            }
            else
            {
                conti=cont;
            }
        }
        while(!conti.equals("N"));
        System.out.println("Thank you for using Electricity Bill creator!!!");
    }
}
