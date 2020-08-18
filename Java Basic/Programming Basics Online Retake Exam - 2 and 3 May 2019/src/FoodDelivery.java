import java.util.Scanner;

public class FoodDelivery {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        
        double chickenMenu = Double.parseDouble(scanner.nextLine());
        double fishMenu = Double.parseDouble(scanner.nextLine());
        double vegetarianMenu = Double.parseDouble(scanner.nextLine());

        double sum =chickenMenu*10.35+fishMenu*12.40+vegetarianMenu*8.15;
        double desert = sum*0.20;
        double total =sum+desert+2.50;
        System.out.printf("Total: %.2f",total);

    }
}
