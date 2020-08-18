import java.util.Scanner;

public class Vacation {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        double moneyNeeded = Double.parseDouble(scanner.nextLine());
        double ownedMoney = Double.parseDouble(scanner.nextLine());
        int daysCounter = 0;
        int spendCounter = 0;

        while (ownedMoney < moneyNeeded && spendCounter < 5) {
            String command = scanner.nextLine();
            double money = Double.parseDouble(scanner.nextLine());
            daysCounter++;
            if (command.equals("save")) {
                ownedMoney += money;
                spendCounter = 0;


            } else if (command.equals("spend")) {
                ownedMoney -= money;
                spendCounter++;
                if (ownedMoney < 0) {
                    ownedMoney = 0;

                }

            }

        }
        if (spendCounter == 5) {
            System.out.println("You can't save the money.");
            System.out.println(daysCounter);
        }
        if (ownedMoney >= moneyNeeded) {
            System.out.printf("You saved the money for %d days.", daysCounter);
        }
    }
}
