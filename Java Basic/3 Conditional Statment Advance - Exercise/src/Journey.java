import java.util.Scanner;

public class Journey {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double budget = Double.parseDouble(scanner.nextLine());
        String season = scanner.nextLine();
        double holidaySum = 0;


        if (budget<=100){
            switch (season){
                case "summer":
                    holidaySum = budget*0.30;
                    System.out.println("Somewhere in Bulgaria");
                    System.out.printf("Camp - %.2f",holidaySum);
                    break;
                case "winter":
                    holidaySum = budget*0.70;
                    System.out.println("Somewhere in Bulgaria");
                    System.out.printf("Hotel - %.2f",holidaySum);
                    break;
            }

        }else if (budget<=1000){
            switch (season){
                case "summer":
                    holidaySum = budget*0.40;
                    System.out.println("Somewhere in Balkans");
                    System.out.printf("Camp - %.2f",holidaySum);
                    break;
                case"winter":
                    holidaySum = budget*0.80;
                    System.out.println("Somewhere in Balkans");
                    System.out.printf("Hotel - %.2f",holidaySum);
                    break;
            }

        }else {
            holidaySum = budget*0.90;
            System.out.println("Somewhere in Europe");
            System.out.printf("Hotel - %.2f",holidaySum);


        }


        }
    }
