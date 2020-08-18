import java.util.Scanner;

public class Oscars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);



        String actorName = scanner.nextLine();
        double academyPoints= Double.parseDouble(scanner.nextLine());
        double goal = 1250.5;
        double points=0;
        double total=0;
        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 1; i <=n ; i++) {
            String judgeName = scanner.nextLine();
            double currentPoints = Double.parseDouble(scanner.nextLine());

            points+= (judgeName.length()*currentPoints)/2;
            total = academyPoints+points;
            if(total>=goal){
                System.out.printf("Congratulations, %s got a nominee for leading role with %.1f!",actorName,total);
                return;
            }


        }
            System.out.printf("Sorry, %s you need %.1f more!",actorName,goal-total);


    }
}

