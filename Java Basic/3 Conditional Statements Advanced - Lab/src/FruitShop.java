import java.util.Scanner;

public class FruitShop {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String fruit = scanner.nextLine();
        String day = scanner.nextLine();
        double quantity = Double.parseDouble(scanner.nextLine());
        double totalPrice = 0;


        if (day.equals("Monday") || day.equals("Tuesday") || day.equals("Wednesday") || day.equals("Thursday") || day.equals("Friday")) {
            switch (fruit) {
                case "banana":
                    totalPrice = 2.50 * quantity;
                    System.out.printf("%.2f",totalPrice);
                    break;
                case "apple":
                    totalPrice = 1.20 * quantity;
                    System.out.printf("%.2f",totalPrice);
                    break;
                case "orange":
                    totalPrice = 0.85 * quantity;
                    System.out.printf("%.2f",totalPrice);
                    break;
                case "grapefruit":
                    totalPrice = 1.45 * quantity;
                    System.out.printf("%.2f",totalPrice);
                    break;
                case "kiwi":
                    totalPrice = 2.70 * quantity;
                    System.out.printf("%.2f",totalPrice);
                    break;
                case "pineapple":
                    totalPrice = 5.50 * quantity;
                    System.out.printf("%.2f",totalPrice);
                    break;
                case "grapes":
                    totalPrice = 3.85 * quantity;
                    System.out.printf("%.2f",totalPrice);
                    break;
                default:
                    System.out.println("error");
            }


        } else if (day.equals("Sunday") || day.equals("Saturday")) {
            switch (fruit) {
                case "banana":
                    totalPrice = 2.70 * quantity;
                    System.out.printf("%.2f",totalPrice);
                    break;
                case "apple":
                    totalPrice = 1.25 * quantity;
                    System.out.printf("%.2f",totalPrice);
                    break;
                case "orange":
                    totalPrice = 0.90 * quantity;
                    System.out.printf("%.2f",totalPrice);
                    break;
                case "grapefruit":
                    totalPrice = 1.60 * quantity;
                    System.out.printf("%.2f",totalPrice);
                    break;
                case "kiwi":
                    totalPrice = 3.00 * quantity;
                    System.out.printf("%.2f",totalPrice);
                    break;
                case "pineapple":
                    totalPrice = 5.60 * quantity;
                    System.out.printf("%.2f",totalPrice);;
                    break;
                case "grapes":
                    totalPrice = 4.20 * quantity;
                    System.out.printf("%.2f",totalPrice);
                    break;
                default:
                    System.out.println("error");
            }
        } else {
            System.out.println("error");
        }

    }

}
