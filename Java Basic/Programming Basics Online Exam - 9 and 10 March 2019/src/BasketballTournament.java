import java.util.Scanner;

public class BasketballTournament {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String name = scanner.nextLine();
        int winsCounter = 0;
        int losesCounter = 0;
        double totalCounter = 0;

        while (!name.equals("End of tournaments")){
            int tournamentNum= Integer.parseInt(scanner.nextLine());
            for (int i = 1; i <=tournamentNum ; i++) {
                int firstTeam = Integer.parseInt(scanner.nextLine());
                int secondTeam= Integer.parseInt(scanner.nextLine());
                if(firstTeam>secondTeam){
                    winsCounter++;
                    System.out.printf("Game %d of tournament %s: win with %d points.%n",i,name,(firstTeam-secondTeam));
                }else {
                    losesCounter++;
                    System.out.printf("Game %d of tournament %s: lost with %d points.%n",i,name,(secondTeam-firstTeam));
                }
                totalCounter++;

            }

            name=scanner.nextLine();
        }
        System.out.printf("%.2f%% matches win%n",(winsCounter/totalCounter)*100);
        System.out.printf("%.2f%% matches lost",(losesCounter/totalCounter*100));
    }
}
