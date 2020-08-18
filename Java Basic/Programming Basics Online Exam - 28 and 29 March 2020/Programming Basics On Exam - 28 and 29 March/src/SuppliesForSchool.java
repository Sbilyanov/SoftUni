import java.util.Scanner;

public class SuppliesForSchool {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int pens = Integer.parseInt(scanner.nextLine());
        int markers = Integer.parseInt(scanner.nextLine());
        double liquid = Double.parseDouble(scanner.nextLine());
        int discount = Integer.parseInt(scanner.nextLine());
        double total = (pens*5.80)+(markers*7.20)+(liquid*1.20);
        total=total-((total*discount)/100);

        System.out.printf("%.3f",total);
    }
}
