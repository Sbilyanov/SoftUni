import java.util.Scanner;

public class ToyShop {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double holidayPrice = Double.parseDouble(scanner.nextLine());
        int puzzleNumber = Integer.parseInt(scanner.nextLine());
        int dollsNumber = Integer.parseInt(scanner.nextLine());
        int bearsNumber = Integer.parseInt(scanner.nextLine());
        int minionNumber = Integer.parseInt(scanner.nextLine());
        int truckNumber = Integer.parseInt(scanner.nextLine());


        double puzzels = puzzleNumber * 2.60;
        double dolls = dollsNumber * 3.00;
        double bears = bearsNumber * 4.10;
        double minions = minionNumber * 8.20;
        double trucks = truckNumber * 2.00;

        int numberOfToys = puzzleNumber + dollsNumber + bearsNumber + minionNumber + truckNumber;
        double totalPrice = puzzels + dolls + bears + minions + trucks;

        if (numberOfToys >= 50) {
            totalPrice = totalPrice - totalPrice * 0.25;// double не се пише защото променливата(totalPrice)
            // се преизчислчва
            //totalPrice = totalPrice * 0.75
        }
        totalPrice = totalPrice - totalPrice * 0.1;//totalprice = totalPrice * 0.9
        if (totalPrice >= holidayPrice) {
            System.out.printf("Yes! %.2f lv left.", Math.abs(holidayPrice - totalPrice));
        } else {
            System.out.printf("Not enough money! %.2f lv needed", Math.abs(holidayPrice - totalPrice));
        }
    }


}
