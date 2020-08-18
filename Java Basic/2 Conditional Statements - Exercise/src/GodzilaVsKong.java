import java.util.Scanner;

public class GodzilaVsKong {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double budget = Double.parseDouble(scanner.nextLine());
        int statist = Integer.parseInt(scanner.nextLine());
        double priceOfClothing = Double.parseDouble(scanner.nextLine());


        double priceCloths = statist * priceOfClothing;
        double priceDecor = budget * 0.1;



        if (statist > 150) {
            double discount = priceCloths * 0.1;
            priceCloths -= discount;

        }
        double totalSum = priceCloths + priceDecor;
        if (totalSum > budget) {
            double result = totalSum - budget;

            System.out.println("Not enough money!");
            System.out.printf("Wingard needs %.2f leva more.", result);
        }
        if (budget >= totalSum) {

            double result = budget - totalSum;

            System.out.println("Action!");
            System.out.printf("Wingard starts filming with %.2f leva left.", result);
        }


    }
}