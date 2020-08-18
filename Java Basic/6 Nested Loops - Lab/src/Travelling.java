import java.util.Scanner;

public class Travelling {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String destination = scanner.nextLine();

        double moneyNeeded=0;

        while (!destination.equals("End")){
        double budgetNeeded = Double.parseDouble(scanner.nextLine());
            moneyNeeded=0;
            while (moneyNeeded<budgetNeeded){
                double savedMoney= Double.parseDouble(scanner.nextLine());
                moneyNeeded+=savedMoney;
            }
            System.out.printf("Going to %s!%n",destination);

            destination=scanner.nextLine();
        }
    }
}
