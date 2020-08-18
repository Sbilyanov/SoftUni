import java.util.Scanner;

public class KartCenter {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        //Въведената в автомата сума - реално число в интервала [0.00…1000.00]
        //Обиколки - текст ("five", за пет обиколи и "ten", за десет обиколки)
        //Фен карта - текст ("yes" или "no")20%
        //Вид Карт - текст (една от възможностите в таблицата)

        //Обиколки/Вид Карт     	Child	      Junior    	Adult	   Profi
        //5 обиколки (five)	           7	        9	         12	        18
        //10 обиколки (ten)	          11	       16	         21	        32

        double budget = Double.parseDouble(scanner.nextLine());
        String laps = scanner.nextLine();
        String fanCard = scanner.nextLine();
        String cardType = scanner.nextLine();
        double ticketPrice = 0;

        switch (cardType) {
            case "Child":
                if (laps.equals("five")) {
                    ticketPrice = 7;
                } else {
                    ticketPrice = 11;
                }
                if (fanCard.equals("yes")) {
                    ticketPrice = ticketPrice * 0.80;
                }
                break;

            case "Junior":
                if (laps.equals("five")) {
                    ticketPrice = 9;
                } else {
                    ticketPrice = 16;
                }
                if (fanCard.equals("yes")) {
                    ticketPrice = ticketPrice * 0.80;
                }
                break;

            case "Adult":
                if (laps.equals("five")) {
                    ticketPrice = 12;
                } else {
                    ticketPrice = 21;
                }
                if (fanCard.equals("yes")) {
                    ticketPrice = ticketPrice * 0.80;
                }
                break;

            case "Profi":
                if (laps.equals("five")) {
                    ticketPrice = 18;
                } else {
                    ticketPrice = 32;
                }
                if (fanCard.equals("yes")) {
                    ticketPrice = ticketPrice * 0.80;
                }
                break;

        }
        if (budget>=ticketPrice){
            System.out.printf("You bought %s ticket for %s laps. Your change is %.2flv.",cardType,laps,(budget-ticketPrice));
        }else{
            System.out.printf("You don't have enough money! You need %.2flv more.",ticketPrice-budget);
        }

    }
}
