import java.util.Scanner;

public class CatWalking {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int dailyMinWalk = Integer.parseInt(scanner.nextLine());
        int dailyWalkCount = Integer.parseInt(scanner.nextLine());
        int dailyCalTaken = Integer.parseInt(scanner.nextLine());

        double totalDailyCal= (dailyWalkCount*dailyMinWalk)*5;
        if (totalDailyCal>=(dailyCalTaken/2)){
            System.out.printf("Yes, the walk for your cat is enough. Burned calories per day: %.0f.",totalDailyCal);
        }else {
            System.out.printf("No, the walk for your cat is not enough. Burned calories per day: %.0f.",totalDailyCal);
        }

    }
}
