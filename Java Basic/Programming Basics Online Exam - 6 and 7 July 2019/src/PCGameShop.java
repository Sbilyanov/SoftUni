import java.util.Scanner;

public class PCGameShop {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int soldGames= Integer.parseInt(scanner.nextLine());
        double hearthstone=0;
        double fornite=0;
        double overwatch=0;
        double others=0;

        for (int i = 0; i <soldGames ; i++) {
            String game = scanner.nextLine();
            switch (game){
                case"Hearthstone":
                    hearthstone++;
                    break;
                case "Fornite":
                    fornite++;
                    break;
                case "Overwatch":
                    overwatch++;
                    break;
                default:
                    others++;
                    break;
            }

        }
        System.out.printf("Hearthstone - %.2f%%%n",(hearthstone/soldGames)*100);
        System.out.printf("Fornite - %.2f%%%n",(fornite/soldGames)*100);
        System.out.printf("Overwatch - %.2f%%%n",(overwatch/soldGames)*100);
        System.out.printf("Others - %.2f%%%n",(others/soldGames)*100);
    }
}
