import java.util.Scanner;

public class TennisRanklist {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int tournamentCount = Integer.parseInt(scanner.nextLine());
        int startingPoints = Integer.parseInt(scanner.nextLine());
        int points = 0;
        int counter =0;


        for (int i = 0; i <tournamentCount ; i++) {
            String result  =scanner.nextLine();

            switch (result){
                case"W":
                    points+=2000;
                    counter++;
                    break;
                case"F":
                    points+=1200;
                    break;
                case"SF":
                    points+=720;
                    break;

            }

        }
        double percent=(1.0*counter/tournamentCount)*100;
        System.out.printf("Final points: %d%n",points+startingPoints);
        System.out.printf("Average points: %d%n",(points/tournamentCount));
        System.out.printf("%.2f%%",percent);
    }
}
