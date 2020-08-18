import java.util.Scanner;

public class EasterEggsBattle {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int eggPlayerOne = Integer.parseInt(scanner.nextLine());
        int eggPlayerTwo = Integer.parseInt(scanner.nextLine());

        String command = scanner.nextLine();

        while (!command.equals("End of battle")) {

            if (command.equals("one")) {
                eggPlayerTwo--;
                if (eggPlayerTwo <= 0) {
                    System.out.printf("Player two is out of eggs. Player one has %d eggs left.", eggPlayerOne);
                    return;
                }
            } else if (command.equals("two")) {
                eggPlayerOne--;
                if (eggPlayerOne <= 0) {
                    System.out.printf("Player one is out of eggs. Player two has %d eggs left.", eggPlayerTwo);
                    return;
                }
            }

            command = scanner.nextLine();

        }
        System.out.printf("Player one has %d eggs left.%n", eggPlayerOne);
        System.out.printf("Player two has %d eggs left.", eggPlayerTwo);


    }
}
