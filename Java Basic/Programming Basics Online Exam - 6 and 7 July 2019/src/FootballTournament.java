import java.util.Scanner;

public class FootballTournament {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        //Името на футболния отбор, за който водим статистика - текст
        //Броя изиграни срещи през настоящия сезон - цяло число в интервала [0… 100]
        // За всяка изиграна среща се прочита отделен ред:
        //Резултатът от изиграната среща в един от горепосочените формати – символ с възможности 'W', 'D' и 'L'

        String name = scanner.nextLine();
        int gamesCount = Integer.parseInt(scanner.nextLine());
        int winCounter = 0;
        int looseCounter = 0;
        int drawCounter = 0;
        int points = 0;
        if (gamesCount == 0) {
            System.out.println(name + " hasn't played any games during this season.");
            return;
        }

        for (int i = 0; i < gamesCount; i++) {
            String result = scanner.nextLine();
            switch (result) {
                case "W":
                    winCounter++;
                    points += 3;
                    break;
                case "D":
                    drawCounter++;
                    points += 1;
                    break;
                case "L":
                    looseCounter++;
                    break;
            }

        }
        System.out.printf("%s has won %d points during this season.%n",name,points);
        System.out.println("Total stats:");
        System.out.printf("## W: %d%n",winCounter);
        System.out.printf("## D: %d%n",drawCounter);
        System.out.printf("## L: %d%n",looseCounter);
        System.out.printf("Win rate: %.2f%%",(1.0*winCounter/gamesCount)*100);

    }
}
