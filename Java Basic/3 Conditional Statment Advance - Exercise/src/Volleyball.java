import java.util.Scanner;

public class Volleyball {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String year = scanner.nextLine();
        int festival = Integer.parseInt(scanner.nextLine());
        int holiday = Integer.parseInt(scanner.nextLine());



        double sofiaGames = ((48-holiday)*3)/4.00;
        double festivalGames = (festival*2)/3.00;
        double totalGames = sofiaGames+holiday+festivalGames;
        if(year.equals("leap")){
            totalGames =totalGames+(totalGames*0.15);
            System.out.printf("%.0f",Math.floor(totalGames));
        }else if(year.equals("normal")){
            System.out.printf("%.0f",Math.floor(totalGames));
        }

    }
}
