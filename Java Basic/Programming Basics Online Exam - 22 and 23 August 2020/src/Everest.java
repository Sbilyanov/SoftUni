import java.util.Scanner;

public class Everest {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input =scanner.nextLine();
        int start = 5364;
        int daysCounter=1;
        int goal= 8848;
        int total=0;

        while (!input.equals("END")&&(daysCounter<5)){
            int currentClim= Integer.parseInt(scanner.nextLine());
            if (input.equals("Yes")){
                daysCounter++;

            }
            total+=currentClim;
            if(total+start>=goal){
                System.out.printf("Goal reached for %d days!",daysCounter);
                return;
            }
            input=scanner.nextLine();

        }
        System.out.println("Failed!");
        System.out.printf("%d",total+start);
    }
}
