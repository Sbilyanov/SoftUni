import java.util.Scanner;

public class FruitMarket {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        //⦁	Цена на ягодите в лева – реално число в интервала [0.00 … 10000.00]
        //⦁	Количеството бананите в килограми – реално число в интервала [0.00 … 10000.00]
        //⦁	Количеството портокалите в килограми – реално число в интервала [0.00 … 10000.00]
        //⦁	Количеството малините в килограми – реално число в интервала [0.00 … 10000.00]
        //⦁	Количеството ягодите в килограми – реално число в интервала [0.00 … 10000.00]

        double priceStrawberry = Double.parseDouble(scanner.nextLine());
        double bananasKG = Double.parseDouble(scanner.nextLine());
        double orangesKG = Double.parseDouble(scanner.nextLine());
        double raspberryKG = Double.parseDouble(scanner.nextLine());
        double strawberryKG = Double.parseDouble(scanner.nextLine());

        //⦁	цената на малините е с 50% по-ниска от тази на ягодите;
        //⦁	цената на портокалите е с 40% по-ниска от цената на малините;
        //⦁	цената на бананите е с 80% по-ниска от цената на малините.

        double priceRaspberry = priceStrawberry - (priceStrawberry * 50 / 100);
        double priceOranges = priceRaspberry - (priceRaspberry * 40 / 100);
        double priceBananas = priceRaspberry - (priceRaspberry * 80 / 100);

        double total = strawberryKG*priceStrawberry + raspberryKG*priceRaspberry + bananasKG*priceBananas + orangesKG*priceOranges;

        System.out.printf("%.2f", total);


    }
}
