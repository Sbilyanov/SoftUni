import java.util.Scanner;

public class HighJump {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int goal = Integer.parseInt(scanner.nextLine());
        int failedCounter = 0;
        int counter = 0;
        int currentHigh = goal - 30;
        int currentJump  =0;

        while (currentHigh <= goal) {
             currentJump = Integer.parseInt(scanner.nextLine());
            if(currentJump>currentHigh){
                currentHigh+=5;
                failedCounter=0;
            }else{
                failedCounter++;
            }
            counter++;
            if(failedCounter==3){
                System.out.printf("Tihomir failed at %dcm after %d jumps.", currentHigh, counter);
                return;
            }

        }
        System.out.printf("Tihomir succeeded, he jumped over %dcm after %d jumps.",goal , counter);

    }
}
