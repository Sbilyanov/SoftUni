import java.util.Scanner;

public class WeatherForecastPartTwo {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double input = Double.parseDouble(scanner.nextLine());

        if (26 <= input &&input <= 35.00) {
            System.out.println("Hot");
        } else if (20.1 <= input &&input <= 25.90) {
            System.out.println("Warm");
        } else if (15 <= input &&input <= 20.00) {
            System.out.println("Mild");
        } else if (12 <= input &&input <= 14.90) {
            System.out.println("Cool");
        } else if (5 <= input && input <= 11.90) {
            System.out.println("Cold");
        } else {
            System.out.println("unknown");
        }


    }
}
