import java.util.Scanner;

public class EasterBakery {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);




        double flourPricePerKilo = Double.parseDouble(scanner.nextLine());
        double flourKg = Double.parseDouble(scanner.nextLine());
        double sugarKg = Double.parseDouble(scanner.nextLine());
        int eggPacks = Integer.parseInt(scanner.nextLine());
        int yeastPacks = Integer.parseInt(scanner.nextLine());
        double total =0;
        double sugarPrice=flourPricePerKilo*0.75;
        double eggPrice=flourPricePerKilo+(flourPricePerKilo*0.10);
        double yeastPrice= sugarPrice*0.20;

        total=flourKg*flourPricePerKilo+sugarKg*sugarPrice+eggPacks*eggPrice+yeastPacks*yeastPrice;

        System.out.printf("%.2f",total);

    }
}
