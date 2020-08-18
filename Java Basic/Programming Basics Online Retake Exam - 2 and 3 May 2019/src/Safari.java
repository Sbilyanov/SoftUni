import java.util.Scanner;

public class Safari {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        double budget = Double.parseDouble(scanner.nextLine());
        double gasL = Double.parseDouble(scanner.nextLine());
        String day = scanner.nextLine();
        int gidPrice = 100;
        double total = 0;
        double pricePerLitter = 2.10;


        if (day.equals("Saturday")) {
            total = gidPrice + (pricePerLitter * gasL);
            total = total * 0.90;
        }else if (day.equals("Sunday")) {
            total = gidPrice + (pricePerLitter * gasL);
            total = total * 0.80;
        }


        if (budget >= total) {
            System.out.printf("Safari time! Money left: %.2f lv.", budget - total);
        } else {
            System.out.printf("Not enough money! Money needed: %.2f lv.", Math.abs(budget - total));
        }


    }
}
