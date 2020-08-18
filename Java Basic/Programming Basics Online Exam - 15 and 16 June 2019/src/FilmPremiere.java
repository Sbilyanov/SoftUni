import java.util.Scanner;

public class FilmPremiere {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        String name = scanner.nextLine();
        String pack = scanner.nextLine();
        int ticketsNum = Integer.parseInt(scanner.nextLine());


        double totalPrice = 0;
        switch (name) {
            case "John Wick":
                if (pack.equals("Drink")) {
                    totalPrice = ticketsNum * 12;
                } else if (pack.equals("Popcorn")) {
                    totalPrice = ticketsNum * 15;
                } else if (pack.equals("Menu")) {
                    totalPrice = ticketsNum * 19;
                }
                break;
            case "Star Wars":
                if (pack.equals("Drink")) {
                    totalPrice = ticketsNum * 18;
                } else if (pack.equals("Popcorn")) {
                    totalPrice = ticketsNum * 25;
                } else if (pack.equals("Menu")) {
                    totalPrice = ticketsNum * 30;
                }
                if (ticketsNum >= 4) {
                    totalPrice = totalPrice * 0.70;
                }

                break;
            case "Jumanji":
                if (pack.equals("Drink")) {
                    totalPrice = ticketsNum * 9;
                } else if (pack.equals("Popcorn")) {
                    totalPrice = ticketsNum * 11;
                } else if (pack.equals("Menu")) {
                    totalPrice = ticketsNum * 14;
                }
                if (ticketsNum == 2) {
                    totalPrice = totalPrice * 0.85;
                }
                break;
        }
        System.out.printf("Your bill is %.2f leva.",totalPrice);


    }
}
