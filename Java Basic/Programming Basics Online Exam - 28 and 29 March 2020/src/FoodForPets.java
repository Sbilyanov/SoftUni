import java.util.Scanner;

import static java.lang.Integer.parseInt;

public class FoodForPets {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int daysCount = parseInt(scanner.nextLine());
        double food = Double.parseDouble(scanner.nextLine());

        int eatenDogFood = 0;
        int eatenCatFood = 0;
        double biscuit = 0;
        double eatenFood = 0;

        for (int i = 1; i <= daysCount; i++) {
            int dogFood = parseInt(scanner.nextLine());
            int catFood = parseInt(scanner.nextLine());
            eatenDogFood += dogFood;
            eatenCatFood += catFood;
            if (i%3==0) {
                biscuit += ((dogFood + catFood) *0.1);
            }
        }
        eatenFood = eatenCatFood + eatenDogFood;


        System.out.printf("Total eaten biscuits: %dgr.%n", Math.round(biscuit));
        System.out.printf("%.2f%% of the food has been eaten.%n", (eatenFood / food) * 100);
        System.out.printf("%.2f%% eaten from the dog.%n", (eatenDogFood / eatenFood) * 100);
        System.out.printf("%.2f%% eaten from the cat.%n", (eatenCatFood / eatenFood) * 100);


    }
}
