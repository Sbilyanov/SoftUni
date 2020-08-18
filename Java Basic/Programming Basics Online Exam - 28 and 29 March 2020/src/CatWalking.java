import java.util.Scanner;

public class CatWalking {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int minutesWalking = Integer.parseInt(scanner.nextLine());
        int walkingCount = Integer.parseInt(scanner.nextLine());
        int dailyCal = Integer.parseInt(scanner.nextLine());

        int totalCal= (minutesWalking*walkingCount)*5;

        if(totalCal>=(dailyCal/2)){
            System.out.printf("Yes, the walk for your cat is enough. Burned calories per day: %d.",totalCal);
        }else{
            System.out.printf("No, the walk for your cat is not enough. Burned calories per day: %d.",totalCal);
        }
    }
}
