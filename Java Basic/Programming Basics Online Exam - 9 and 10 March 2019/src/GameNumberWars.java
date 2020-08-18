import java.util.Scanner;

public class GameNumberWars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String firstName=scanner.nextLine();
        String secondName=scanner.nextLine();
        String input =scanner.nextLine();
        int firstPoints=0;
        int secondPoints =0;

        while (!input.equals("End of game")){
            int firstCurrentPoints = Integer.parseInt(input);
            int secondCurrentPoints = Integer.parseInt(scanner.nextLine());
            if(firstCurrentPoints>secondCurrentPoints){
                firstPoints+=firstCurrentPoints-secondCurrentPoints;
            }else if (secondCurrentPoints>firstCurrentPoints){
                secondPoints += secondCurrentPoints-firstCurrentPoints;

            }else{
                System.out.println("Number wars!");
                firstCurrentPoints= Integer.parseInt(scanner.nextLine());
                secondCurrentPoints= Integer.parseInt(scanner.nextLine());
                if(firstCurrentPoints>secondCurrentPoints){

                    System.out.printf("%s is winner with %d points",firstName,firstPoints);
                }else if (secondCurrentPoints>firstCurrentPoints) {

                    System.out.printf("%s is winner with %d points", secondName, secondPoints);
                }
                return;
            }
            input=scanner.nextLine();
        }
        System.out.printf("%s has %d points%n",firstName,firstPoints);
        System.out.printf("%s has %d points",secondName,secondPoints);


    }
}
