import java.util.Scanner;

public class Illian {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int count= Integer.parseInt(scanner.nextLine());
        int force = Integer.parseInt(scanner.nextLine());
        int illian= Integer.parseInt(scanner.nextLine());

        if ((count*force)>=illian){
            System.out.printf("Illidan has been slain! You defeated him with %d points.",Math.abs((count*force)-illian));
        }else
            System.out.printf("You are not prepared! You need %d more points.",Math.abs((count*force)-illian));
    }
}
