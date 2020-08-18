import java.util.Scanner;

public class FoodForPets {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int days = Integer.parseInt(scanner.nextLine());
        double food = Integer.parseInt(scanner.nextLine());
        double biscuit = 0;
        double totalDogFood=0;
        double totalCatFood =0;


        for (int i = 1; i <= days; i++) {
            int dogFood = Integer.parseInt(scanner.nextLine());
            int catFood = Integer.parseInt(scanner.nextLine());
            totalDogFood+=dogFood;
            totalCatFood+=catFood;
            if (i % 3 == 0) {
                biscuit += (dogFood + catFood) * 0.10;

                dogFood=0;
                catFood=0;
            }
        }
        double totalEatenFood=totalCatFood+totalDogFood;

        System.out.printf("Total eaten biscuits: %.0fgr.%n",biscuit);
        System.out.printf("%.2f%% of the food has been eaten.%n",(totalEatenFood/food)*100);
        System.out.printf("%.2f%% eaten from the dog.%n",(totalDogFood/totalEatenFood)*100);
        System.out.printf("%.2f%% eaten from the cat.%n",(totalCatFood/totalEatenFood)*100);


    }
}
