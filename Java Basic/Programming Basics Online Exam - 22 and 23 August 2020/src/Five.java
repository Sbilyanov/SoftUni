import java.util.Scanner;

public class Five {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input =scanner.nextLine();
        int goal =8848;
        int start =5364;
        int doyCounter =1;
        int reachedMeters =0;

        while (!input.equals("END")&&(doyCounter<5)){
            int currentMeters = Integer.parseInt(scanner.nextLine());
            if (input.equals("Yes")){
            doyCounter++;
            }
            reachedMeters+=currentMeters;
            if ((goal-start)<=reachedMeters){
                System.out.printf( "Goal reached for %d days!",doyCounter);
                return;
            }


            input=scanner.nextLine();
        }

            System.out.println("Failed!");
            System.out.println(reachedMeters+start);


    }
}
