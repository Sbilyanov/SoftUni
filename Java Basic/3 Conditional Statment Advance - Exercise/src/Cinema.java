import java.util.Scanner;

public class Cinema {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String type = scanner.nextLine();
        int row = Integer.parseInt(scanner.nextLine());
        int columns = Integer.parseInt(scanner.nextLine());

        double totalPrice = 0;

        switch (type) {
            case "Premiere":
                totalPrice = row * columns * 12.00;
                break;
            case "Normal":
                totalPrice = row * columns * 7.50;
                break;
            case "Discount":
                totalPrice = row * columns * 5.00;
                break;
        }System.out.printf("%.2f leva",totalPrice);

    }
}

