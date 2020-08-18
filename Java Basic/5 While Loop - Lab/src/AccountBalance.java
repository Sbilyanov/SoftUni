import java.util.Scanner;

public class AccountBalance {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        double total = 0;

        while (!input.equals("NoMoreMoney")) {

            double n = Double.parseDouble(input);

            if (n < 0) {
                System.out.println("Invalid operation!");
                break;

            }

            total += n;
            System.out.printf("Increase: %.2f%n", n);
            input = scanner.nextLine();


        }
        System.out.printf("Total: %.2f",total);
    }
}
