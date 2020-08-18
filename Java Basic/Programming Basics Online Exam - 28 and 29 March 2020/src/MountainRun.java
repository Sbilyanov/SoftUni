import java.util.Scanner;

public class MountainRun {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
//50 м. с 30 секунди.

        double timeRecord = Double.parseDouble(scanner.nextLine());
        double distanceMeters= Double.parseDouble(scanner.nextLine());
        double timePerMeter = Double.parseDouble(scanner.nextLine());


        double time = (distanceMeters)*timePerMeter;
         double slowerTime=(distanceMeters/50);
         double mathTime= Math.floor(slowerTime);
        double totalTime =time+(mathTime*30);

        if (totalTime<timeRecord){
            System.out.printf("Yes! The new record is %.2f seconds.",totalTime);
        }else{
            System.out.printf("No! He was %.2f seconds slower.",Math.abs(timeRecord-totalTime));

        }
    }
}
