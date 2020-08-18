import java.util.Scanner;

public class HotelRoom {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String month = scanner.nextLine();
        int nights = Integer.parseInt(scanner.nextLine());

        double studioPrice = 0;
        double apartmentPrice = 0;


        switch (month) {
            case "May":
            case "October":
                if ((7 < nights) && (nights <= 14)) {
                    studioPrice = nights * 50 * 0.95;

                } else if (nights > 14) {
                    studioPrice = nights * 50 * 0.70;
                    apartmentPrice = nights * 65 * 0.90;
                } else {
                    studioPrice = 50 * nights;
                    apartmentPrice = 65 * nights;
                }
                break;
            case "July":
            case "August":
                if (nights > 14) {
                    apartmentPrice = nights * 77 * 0.90;
                    studioPrice = nights * 76;
                } else {
                    studioPrice = nights * 76;
                    apartmentPrice = nights * 77;
                }
                break;
            case "June":
            case "September":
                if (nights > 14) {
                    studioPrice = nights * 75.20 * 0.80;
                    apartmentPrice = nights * 68.70 * 0.90;

                } else {
                    studioPrice = nights * 75.20;
                    apartmentPrice = nights * 68.70;
                }
                break;
        }
        System.out.printf("Apartment: %.2f lv.", apartmentPrice);
        System.out.printf("Studio: %.2f lv.", studioPrice);
    }
}

