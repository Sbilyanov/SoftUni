import java.util.Scanner;

public class GreetingsByName {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();
        System.out.println("Hello, "+ input+"!");

    }
}
