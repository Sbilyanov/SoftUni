import java.util.Scanner;

public class Walking {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int steps = 0;
        int target = 10000;


        while (steps < target) {
            String input = scanner.nextLine();
            if (input.equals("Going home")) {
                int currentSteps = Integer.parseInt(scanner.nextLine());
                steps += currentSteps;
                break;
            }

            steps += Integer.parseInt(input);
        }
        if (steps >= target) {
            System.out.println("Goal reached! Good job!");
            System.out.printf("%d steps over the goal!", Math.abs(steps - target));

        } else {

            System.out.printf("%d more steps to reach goal.", Math.abs(steps - target));
        }


    }
}
