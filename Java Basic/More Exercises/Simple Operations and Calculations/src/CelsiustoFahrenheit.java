import java.util.Scanner;

public class CelsiustoFahrenheit {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double C =Double.parseDouble(scanner.nextLine());
        double F = C*1.8000+32;

        System.out.printf("%.2f",F);



    }
}
