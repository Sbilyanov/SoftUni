import java.util.Scanner;

public class InchesToCentimeters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        double a =Double.parseDouble(input);
        double b = a * 2.54;
        System.out.println(b);
    }
}
