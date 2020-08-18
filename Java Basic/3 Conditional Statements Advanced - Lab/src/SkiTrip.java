import java.util.Scanner;

public class SkiTrip {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int days = Integer.parseInt(scanner.nextLine());
        String roomType = scanner.nextLine();
        String comment = scanner.nextLine();

        double totalPrice = 0;
        double nights = days - 1;

        if (roomType.equals("apartment") && 0 < days && days <= 10) {
            if (comment.equals("positive")) {
                double priceForStay = 25 * nights;
                double discountPrice = priceForStay - priceForStay * 0.30;
                totalPrice = discountPrice + discountPrice * 0.25;
                System.out.printf("%.2f", totalPrice);
            } else {
                double priceForStay = 25 * nights;
                double discountPrice = priceForStay - priceForStay * 0.30;
                totalPrice = discountPrice- discountPrice * 0.10;
                System.out.printf("%.2f", totalPrice);
            }

        } else if (roomType.equals("apartment") && 10 < days && days <= 15) {
            if (comment.equals("positive")) {
                double priceForStay = 25 * nights;
                double discountPrice = priceForStay - priceForStay * 0.35;
                totalPrice = discountPrice + discountPrice * 0.25;
                System.out.printf("%.2f", totalPrice);
            } else {
                double priceForStay = 25 * nights;
                double discountPrice = priceForStay - priceForStay * 0.35;
                totalPrice = discountPrice- discountPrice * 0.10;
                System.out.printf("%.2f", totalPrice);
            }
        } else if (roomType.equals("apartment") && 15 < days) {
            if (comment.equals("positive")) {
                double priceForStay = 25 * nights;
                double discountPrice = priceForStay - priceForStay * 0.50;
                totalPrice = discountPrice + discountPrice * 0.25;
                System.out.printf("%.2f", totalPrice);
            } else {
                double priceForStay = 25 * nights;
                double discountPrice = priceForStay - priceForStay * 0.50;
                totalPrice = discountPrice- discountPrice * 0.10;
                System.out.printf("%.2f", totalPrice);
            }
        }        else if(roomType.equals("president apartment") &&  days <= 10) {
            if (comment.equals("positive")) {
                double priceForStay = 35 * nights;
                double discountPrice = priceForStay - priceForStay * 0.10;
                totalPrice = discountPrice + discountPrice * 0.25;
                System.out.printf("%.2f", totalPrice);
            } else {
                double priceForStay = 35 * nights;
                double discountPrice = priceForStay - priceForStay * 0.10;
                totalPrice = discountPrice- discountPrice * 0.10;

                System.out.printf("%.2f", totalPrice);
            }
        }       else if(roomType.equals("president apartment") && 10< days && days <= 15) {
            if (comment.equals("positive")) {
                double priceForStay = 35 * nights;
                double discountPrice = priceForStay - priceForStay * 0.15;
                totalPrice = discountPrice + discountPrice * 0.25;
                System.out.printf("%.2f", totalPrice);
            } else {
                double priceForStay = 35 * nights;
                double discountPrice = priceForStay - priceForStay * 0.15;
                totalPrice = discountPrice- discountPrice * 0.10;
                System.out.printf("%.2f", totalPrice);
            }
        }       else if(roomType.equals("president apartment") && 15< days) {
            if (comment.equals("positive")) {
                double priceForStay = 35* nights;
                double discountPrice = priceForStay - priceForStay * 0.20;
                totalPrice = discountPrice + discountPrice * 0.25;
                System.out.printf("%.2f", totalPrice);
            } else {
                double priceForStay = 35 * nights;
                double discountPrice = priceForStay - priceForStay * 0.20;
                totalPrice = discountPrice- discountPrice * 0.10;
                System.out.printf("%.2f", totalPrice);
            }
        }else {
            if (comment.equals("positive")) {
                double priceForStay = 18 * nights;
                totalPrice = priceForStay + priceForStay * 0.25;
                System.out.printf("%.2f", totalPrice);
            } else {
                double priceForStay = 18 * nights;
                totalPrice = priceForStay- priceForStay* 0.10;
                System.out.printf("%.2f", totalPrice);
            }
        }

    }
}
