import java.util.Scanner;

public class CareOfPuppy {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int foodKg = Integer.parseInt(scanner.nextLine());
        double foodGr = foodKg * 1000;
        String input = scanner.nextLine();
        int consumeFoodGr = 0;
        int foodPerDay = 0;
        while (!input.equals("Adopted")) {
            foodPerDay = Integer.parseInt(input);
            consumeFoodGr += foodPerDay;
            input = scanner.nextLine();
        }
        if (consumeFoodGr>foodGr){
            System.out.printf("Food is not enough. You need %.0f grams more.", Math.abs(consumeFoodGr - foodGr));
        }else {
        System.out.printf("Food is enough! Leftovers: %.0f grams.", Math.abs(foodGr - consumeFoodGr));
        }


    }
}
