import java.util.Scanner;

public class EasterParty {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int guestNum = Integer.parseInt(scanner.nextLine());
        double pricePerGuest = Double.parseDouble(scanner.nextLine());
        double budget = Double.parseDouble(scanner.nextLine());
        double cake =0;
        double totalMoneyNeeded=0;

        if (guestNum >= 10 && guestNum <= 15) {
            pricePerGuest=pricePerGuest-pricePerGuest*0.15;

        }else if(guestNum >15 && guestNum <= 20){
            pricePerGuest = pricePerGuest-pricePerGuest*0.20;

        }else if (guestNum>20){
            pricePerGuest=pricePerGuest-pricePerGuest*0.25;

        }
        cake=budget*0.10;
        totalMoneyNeeded = pricePerGuest*guestNum+cake;
        if(budget>totalMoneyNeeded){
            System.out.printf("It is party time! %.2f leva left.",budget-totalMoneyNeeded);
        }else {
            System.out.printf("No party! %.2f leva needed.",Math.abs(budget-totalMoneyNeeded));
        }

    }
}
