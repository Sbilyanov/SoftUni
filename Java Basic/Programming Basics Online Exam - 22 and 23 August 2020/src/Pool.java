import java.util.Scanner;

public class Pool {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        String month = scanner.nextLine();
        int hours = Integer.parseInt(scanner.nextLine());
        int peopleNum = Integer.parseInt(scanner.nextLine());
        String time = scanner.nextLine();
        double pricePerPerson = 0;
        double total = 0;



        switch (month) {
            case "march":
            case "april":
            case "may":
                if (time.equals("day")) {
                    pricePerPerson = 10.50;
                    if (peopleNum >= 4) {
                        pricePerPerson = pricePerPerson * 0.90;
                    }
                    if (hours >= 5) {
                        pricePerPerson = pricePerPerson * 0.50;
                    }
                    total=(pricePerPerson*peopleNum)*hours;

                } else {
                    pricePerPerson = 8.40;
                    if (peopleNum >= 4) {
                        pricePerPerson = pricePerPerson * 0.90;
                    }
                    if (hours >= 5) {
                        pricePerPerson= pricePerPerson * 0.50;
                    }
                    total=(pricePerPerson*peopleNum)*hours;
                }
                break;
            case "june":
            case "july":
            case "august":
                if (time.equals("day")) {
                    pricePerPerson = 12.60;

                    if (peopleNum >= 4) {
                        pricePerPerson = pricePerPerson * 0.90;
                    }
                    if (hours >= 5) {
                        pricePerPerson  = pricePerPerson * 0.50;
                    }
                    total=(pricePerPerson*peopleNum)*hours;
                } else {
                    pricePerPerson = 10.20;
                    if (peopleNum >= 4) {
                        pricePerPerson= pricePerPerson * 0.90;
                    }
                    if (hours >= 5) {
                        pricePerPerson = pricePerPerson * 0.50;
                    }
                    total=(pricePerPerson*peopleNum)*hours;
                }
                break;
        }
        System.out.printf("Price per person for one hour: %.2f%n", pricePerPerson);
        System.out.printf("Total cost of the visit: %.2f", total);
    }

}
