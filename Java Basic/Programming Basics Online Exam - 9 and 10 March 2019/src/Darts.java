import java.util.Scanner;

public class Darts {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String name = scanner.nextLine();
        int points = 301;
        int failCounter = 0;
        int winCounter = 0;
        int goal = 301;

        while (points != 0) {
            String sector = scanner.nextLine();
            if (sector.equals("Retire")) {
                System.out.printf("%s retired after %d unsuccessful shots.", name, failCounter);
                return;
            }

            int currentPoints = Integer.parseInt(scanner.nextLine());
            switch (sector) {
                case "Triple":
                    currentPoints *= 3;
                    break;
                case "Double":
                    currentPoints *= 2;
                    break;

            }

            points -= currentPoints;
            if (points < 0) {
                failCounter++;
                points += currentPoints;
                currentPoints = 0;
            } else {
                winCounter++;
            }


        }
        System.out.printf("%s won the leg with %d shots.", name, winCounter);

    }
}
