import java.util.Scanner;

public class SuppliesForSchool {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        //Пакет химикали - 5.80 лв
        //Пакет маркери - 7.20 лв
        //Препарат - 1.20 лв (за литър)


        int pensNum = Integer.parseInt(scanner.nextLine());
        int markerNum = Integer.parseInt(scanner.nextLine());
        double liquid = Double.parseDouble(scanner.nextLine());
        int discount = Integer.parseInt(scanner.nextLine());

        double all = pensNum*5.80+markerNum*7.20+liquid*1.20;
        double total = all-((all*discount/100));
        System.out.printf("%.3f",total);
    }
}
