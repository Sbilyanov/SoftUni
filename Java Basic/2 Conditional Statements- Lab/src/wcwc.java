import java.util.Scanner;

public class wcwc {
    public static void main(String[] args) {
        Scanner scanner= new Scanner(System.in);

        double price = Double.parseDouble(scanner.nextLine());
        int puzzles = Integer.parseInt(scanner.nextLine());
        int dolls = Integer.parseInt(scanner.nextLine());
        int bears = Integer.parseInt(scanner.nextLine());
        int minions = Integer.parseInt(scanner.nextLine());
        int trucks = Integer.parseInt(scanner.nextLine());

        double sum = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;
        int toys = puzzles + dolls + bears + minions + trucks;

        if (toys >= 50) {
            double discount = 0.25 * sum;
            double finalPrice = sum - discount;
            double rent = 0.10 * finalPrice;
            double profit = finalPrice - rent;
            if (profit >= price) {
                double moneyLeft = profit - price;
                System.out.printf("Yes! %.2f lv left.", moneyLeft);
            } else if (profit < price) {
                double moneyInNeed = price - profit;
                System.out.printf("Not enough money! %.2f lv needed.", moneyInNeed);}

        }if (toys < 50) {
            double rent = 0.10 * sum;
            double profit = sum - rent;
            if (profit >= price) {
                double money = profit - price;
                System.out.printf("Yes! %.2f lv left.", money);
            } else if (profit < price) {
                double moneyInNeed = price - profit;
                System.out.printf("Not enough money! %.2f lv needed.", moneyInNeed);}
        }
    }
}


