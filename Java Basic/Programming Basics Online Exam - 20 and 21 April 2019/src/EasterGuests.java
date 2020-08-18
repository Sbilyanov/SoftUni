import java.util.Scanner;

public class EasterGuests {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int guestNum = Integer.parseInt(scanner.nextLine());
        int budget = Integer.parseInt(scanner.nextLine());

        //Един козунак струва 4лв.
        //Едно яйце струва 0.45лв.
        double cakeNumNeeded =guestNum/3.0;
        double roundCakesNum = Math.ceil(cakeNumNeeded);
        int eggs= guestNum*2;
        double moneyNeed = roundCakesNum*4+eggs*0.45;

        if(moneyNeed<=budget){
            System.out.printf("Lyubo bought %.0f Easter bread and %d eggs.%n",roundCakesNum,eggs);
            System.out.printf("He has %.2f lv. left.",budget-moneyNeed);
        }else{
            System.out.printf("Lyubo doesn't have enough money.%n");
            System.out.printf("He needs %.2f lv. more.",moneyNeed-budget);

        }



    }
}
