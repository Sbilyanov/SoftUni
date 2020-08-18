import java.util.Scanner;

public class EasterDecoration {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int clients = Integer.parseInt(scanner.nextLine());
        double basket = 0;
        double wreath = 0;
        double chocolateBunny = 0;
        int counter = 0;
        double averageSpent = 0;
        double totalSpendPerClient = 0;
        double totalSpend = 0;
        for (int i = 0; i < clients; i++) {
            String item = scanner.nextLine();
            counter = 0;
            totalSpendPerClient = 0;
            basket = 0;
            wreath = 0;
            chocolateBunny = 0;

            while (!item.equals("Finish")) {

                if (item.equals("basket")) {
                    basket += 1.50;
                    counter++;
                } else if (item.equals("wreath")) {
                    wreath += 3.80;
                    counter++;
                } else if (item.equals("chocolate bunny")) {
                    chocolateBunny += 7;
                    counter++;
                }

                item = scanner.nextLine();

            }
            totalSpendPerClient = basket + wreath + chocolateBunny;

            if (counter % 2 == 0) {
                totalSpendPerClient = totalSpendPerClient * 0.80;
            }

            totalSpend += totalSpendPerClient;
            System.out.printf("You purchased %d items for %.2f leva.%n", counter, totalSpendPerClient);
        }

        averageSpent = totalSpend / clients;
        System.out.printf("Average bill per client is: %.2f leva.", averageSpent);
    }
}
