import java.util.Scanner;

public class WorldSwimmingRecord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double timeRecord = Double.parseDouble(scanner.nextLine());
        double distance = Double.parseDouble(scanner.nextLine());
        double swimmingTimePerMeter = Double.parseDouble(scanner.nextLine());

        double allDisstance = distance * swimmingTimePerMeter;
        double slowDistance = Math.floor(distance/15);
        double  slowTime =slowDistance * 12.5;
        double swimmingIvanTime = allDisstance +slowTime;

        if(swimmingIvanTime >= timeRecord){

            double result = swimmingIvanTime - timeRecord;
            System.out.printf("No, he failed! He was %.2f seconds slower.", result);

        }else{
            System.out.printf("Yes, he succeeded! The new world record is %.2f seconds.", swimmingIvanTime);
        }


    }
}
