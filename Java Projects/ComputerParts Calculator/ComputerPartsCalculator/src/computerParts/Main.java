package computerParts;

import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
            Scanner sc = new Scanner(System.in);//declaring scanner named sc
            String username = "";//declaring variable for storing username
            String password = "";//declaring variable for storing password
            String cont = "";//declaring variable for continuing the program
            do {
                username = "";//reseting variable
                password = "";//reseting variable
                System.out.println("Welcome to computer parts calculator!!!\n");//printing to user
                System.out.println("Please enter your Login details!\n Username:");//printing to user
                username = sc.next();//scanning user input
                System.out.println("\nPassword:");//printing to user
                password = sc.next();//scanning user input
            }
            while (!(username.equals("Nikola") && password.equals("nikola")));//repeat till username is equal to Nikola and password is equal to nikola


            do {
                Scanner sc1 = new Scanner(System.in);//declaring scanner
                String conti = "YES";//continuing
                String customerInfo = "";//declaring variable for storing customer info
                final int cpuPrice = 10000;//declaring variable for storing processor price
                final int ramPrice = 5000;//declaring variable for storing ram price
                final int gpuPrice = 20000;//declaring variable for storing graphics card price
                final int mbPrice = 4000;//declaring variable for storing motherboard price
                final int psPrice = 6000;//declaring variable for storing powersupply price
                final int hddPrice = 3000;//declaring variable for storing hard disk price
                final int nothingChosen = 0;//declaring variable if user said no to everything
                final int pcBuilding = 4000;//declaring cost of pc building (applies to all builds)
                int sum = 0;//declaring variable for storing sum of all expenses
                int temp = 0;//declaring variable for storing if user said no to all pc parts
                String temp1 = "YES";//declaring variable for checking if user said yes to install computer part

                do {
                    System.out.println("Please enter Customer information(Name,Adress): ");//printing to user
                    customerInfo = sc1.next();//scanning user input
                }
                while (!customerInfo.matches("[A-Z][a-z]+,[A-Za-z0-9]+"));//do till this expression is true
                String cpuOpt = "NO";//declaring variable for opting to buy
                String ramOpt = "NO";//declaring variable for opting to buy
                String gpuOpt = "NO";//declaring variable for opting to buy
                String mbOpt = "NO";//declaring variable for opting to buy
                String psOpt = "NO";//declaring variable for opting to buy
                String hddOpt = "NO";//declaring variable for opting to buy

                System.out.println("Do you wish to buy a CPU ?");//printing to user
                cpuOpt = sc1.next().toUpperCase();//scanning user input and making it high capitalization
                if (cpuOpt.equals(temp1))//checking if user said yes
                {
                    sum = sum + cpuPrice;//addition of computer parts price
                    temp += 1;//adding one if user said yes
                }
                System.out.println("Do you wish to buy a RAM ?");//printing to user
                ramOpt = sc1.next().toUpperCase();//scanning user input and making it high capitalization
                if (ramOpt == "YES")//checking if user said yes
                {
                    sum = sum + ramPrice;//addition of computer parts price
                    temp += 1;//adding one if user said yes
                }

                System.out.println("Do you wish to buy a GPU ?");//printing to user
                gpuOpt = sc1.next().toUpperCase();//scanning user input and making it high capitalization
                if (gpuOpt.equals(temp1))//checking if user said yes
                {
                    sum = sum + gpuPrice;//addition of computer parts price
                    temp += 1;//adding one if user said yes
                }

                System.out.println("Do you wish to buy a MB (Motherboard) ?");//printing to user
                mbOpt = sc1.next().toUpperCase();//scanning user input and making it high capitalization
                if (mbOpt.equals(temp1))//checking if user said yes
                {
                    sum = sum + mbPrice;//addition of computer parts price
                    temp += 1;//adding one if user said yes
                }

                System.out.println("Do you wish to buy a PS (Power Supply) ?");//printing to user
                psOpt = sc1.next().toUpperCase();//scanning user input and making it high capitalization
                if (psOpt.equals(temp1))//checking if user said yes
                {
                    sum = sum + psPrice;//addition of computer parts price
                    temp += 1;//adding one if user said yes
                }

                System.out.println("Do you wish to buy a HDD (Hard Disk) ?");//printing to user
                hddOpt = sc1.next().toUpperCase();//scanning user input and making it high capitalization
                if (hddOpt.equals(temp1))//checking if user said yes
                {
                    sum = sum + hddPrice;//addition of computer parts price
                    temp += 1;//adding one if user said yes
                }
                if (temp >= 1)//checking if user said yes to installin atleast one part
                {
                    receiptCalculations rc = new receiptCalculations();//declaring method as object named rc
                    rc.priceCalc(sum, pcBuilding);//passing parameters sum and pcBuilding to method priceCalc
                    FileUtil.appendLine("src\\receipt.txt", customerInfo + " " + rc.priceCalc(sum, pcBuilding) + " din.");//writing new line to file
                } else//if user said no to every offered part
                {
                    receiptCalculations rc = new receiptCalculations();//declaring method as object named rc
                    rc.priceCalc(nothingChosen, pcBuilding);//passing parameters nothingChosen and pcBuilding to method priceCalc
                    FileUtil.appendLine("src\\receipt.txt", customerInfo + " " + rc.priceCalc(nothingChosen, pcBuilding) + " din.");//writing new line to file
                }
                System.out.println("Done,do you wish to enter another user ? YES/NO");//printing to user
                cont = sc1.next();//scanning what user typed
                cont = cont.toUpperCase();//making all letters high capitalization


                if (!cont.equals("NO") && !cont.equals("YES")) //if user did not say yes or no ask him again
                {
                    System.out.println("Please repeat your choice YES or NO: "); // printing to user
                    cont = sc1.next();//scanning user input
                    cont = cont.toUpperCase();//making variable cont high capitalization
                }


            }
            while (!cont.equals("NO"));//do this till user does not enter no
            System.out.println("Thank you for using Computer Price Calculator!!!");//printing to user
    }
}
