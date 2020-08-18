import java.util.Scanner;

public class NameGame {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String name = scanner.nextLine();
        int points =0;
        int winnerPoints = 0;
        String winner ="";

        while (!name.equals("Stop")) {
            points=0;
            for (int i = 0; i < name.length(); i++) {
                int currentNum = Integer.parseInt(scanner.nextLine());
                int currentChar = name.charAt(i);
                if (currentNum == currentChar) {
                    points+=10;
                }else{
                    points+=2;
                }
            }
            if (points>=winnerPoints){
                winnerPoints=points;
               winner=name;
            }


            name=scanner.nextLine();
        }
        System.out.printf("The winner is %s with %d points!",winner,winnerPoints);

    }


}
