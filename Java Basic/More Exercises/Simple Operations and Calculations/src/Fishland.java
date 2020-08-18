import java.util.Scanner;

public class Fishland {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        double mackerelPrice = Double.parseDouble(scanner.nextLine());
        double cacaPrice = Double.parseDouble(scanner.nextLine());
        double palamudKilo = Double.parseDouble(scanner.nextLine());
        double safridKilo = Double.parseDouble(scanner.nextLine());
        int musselsKilo = Integer.parseInt(scanner.nextLine());

        double palamudPrice = (mackerelPrice + mackerelPrice * 0.60) * palamudKilo;
        double safridPrice = (cacaPrice + cacaPrice * 80 / 100) * safridKilo;
        double musselsPrice = musselsKilo * 7.50;
        double total = palamudPrice + safridPrice + musselsPrice;

        System.out.printf("%.2f", total);


    }
}
