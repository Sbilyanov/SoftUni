import java.util.Scanner;

public class EasterCompetition {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int cakesNum = Integer.parseInt(scanner.nextLine());
        int result = 0;
        boolean flag = false;
        int maxPoints=Integer.MIN_VALUE;
        String winner  ="";




        for (int i = 0; i < cakesNum; i++) {
            String name = scanner.nextLine();
            String input = scanner.nextLine();
            result = 0;
            while (!input.equals("Stop")) {
                int points = Integer.parseInt(input);
                result += points;
                input = scanner.nextLine();
            }
            System.out.printf("%s has %d points.%n", name, result);
            if(result>maxPoints){
                System.out.printf("%s is the new number 1!%n",name);
                winner=name;
                maxPoints=result;

            }

        }
        System.out.printf("%s won competition with %d points!",winner,maxPoints);
    }
}
