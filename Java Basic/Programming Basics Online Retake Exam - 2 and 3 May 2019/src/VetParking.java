import java.util.Scanner;

public class VetParking {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int days = Integer.parseInt(scanner.nextLine());
            int hours = Integer.parseInt(scanner.nextLine());
        double pricePerHour = 0;
        double pricePerDay=0;
        double total=0;

        for (int i = 1; i <= days; i++) {

            pricePerHour=0;
            pricePerDay=0;


            for (int j = 1; j <=hours; j++) {

                if (i % 2 == 0) {
                    if (j % 2 == 0) {
                        pricePerHour += 1;
                    } else {
                        pricePerHour += 2.50;
                    }
                }else {
                    if (j % 2 == 0) {
                        pricePerHour+=1.25;
                    }else{
                        pricePerHour+=1;
                    }
                }

            }
            pricePerDay+=pricePerHour;
            total+=pricePerDay;

            System.out.printf("Day: %d - %.2f leva%n",i,pricePerDay);
        }

        System.out.printf("Total: %.2f leva",total);

    }


}

