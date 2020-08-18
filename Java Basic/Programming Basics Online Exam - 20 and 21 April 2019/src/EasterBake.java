import java.util.Scanner;

public class EasterBake {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int cake = Integer.parseInt(scanner.nextLine());
        int sugarMax = Integer.MIN_VALUE;
        int flourMax = Integer.MIN_VALUE;
        double totalSugar = 0;
        double totalflour = 0;
        double sugarPacks=0;
        double flourPacks=0;

        for (int i = 0; i < cake; i++) {
            int sugar = Integer.parseInt(scanner.nextLine());
            int flour = Integer.parseInt(scanner.nextLine());

            totalSugar += sugar;
            totalflour += flour;

            if (sugar > sugarMax) {
                sugarMax = sugar;

            }
            if (flour > flourMax) {
                flourMax = flour;
            }

        }
         sugarPacks = totalSugar/950;
        flourPacks = totalflour/750;


        System.out.printf("Sugar: %.0f%n",Math.ceil(sugarPacks));
        System.out.printf("Flour: %.0f%n",Math.ceil(flourPacks));
        System.out.printf("Max used flour is %d grams, max used sugar is %d grams.", flourMax, sugarMax);
    }
}
