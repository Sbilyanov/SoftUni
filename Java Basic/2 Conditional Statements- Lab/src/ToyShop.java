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
        double bears = bearsNumber *4.10;
        double minions = minionNumber * 8.20;
        double trucks = truckNumber * 2.00;

        int numberOfToys = puzzleNumber+dollsNumber+bearsNumber+minionNumber+truckNumber;
        double money = puzzels+dolls + bears + minions + trucks;

        if(numberOfToys>= 50) {
            double moneyDiscount = money - (money * 0.25);// moneyDiscount = moneyDiscount *0.75
        }
            double rent = moneyDiscount * 0.10;
            double profit = moneyDiscount - rent;
            if (profit >= holidayPrice) {
                double moneyLeft = profit- holidayPrice;
                System.out.printf("Yes! %.2f lv left.", moneyLeft);
            } else if (holidayPrice> profit) {
                double moneyNeeded = holidayPrice - profit;
                System.out.printf("Not enough money! %.2f lv needed.", profit);
            }

             }if(numberOfToys< 50){
            double profit= money-(money * 0.10);
            if (profit >= holidayPrice) {
                double moneyLeft = profit - holidayPrice;
                System.out.printf("Yes! %.2f lv left.", moneyLeft);
            } else if (holidayPrice > profit) {
                double moneyNeeded = holidayPrice - profit;
                System.out.printf("Not enough money! %.2f lv needed.", moneyNeeded);}

        }
        }


    }

