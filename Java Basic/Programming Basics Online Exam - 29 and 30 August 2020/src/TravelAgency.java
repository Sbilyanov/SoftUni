import java.util.Scanner;

public class TravelAgency {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        //Брой билети - цяло число в интервала [1...10]
        //Бюджет на клиента- цяло число в интервала [0…10000]
        //Цена на един билет - цяло число в интервала [10…1000]

        int ticketCount = Integer.parseInt(scanner.nextLine());
        int budget = Integer.parseInt(scanner.nextLine());
        int ticketPrice  = Integer.parseInt(scanner.nextLine());

        int total = ticketCount*ticketPrice;
        if(budget>=total){
            System.out.printf("You can sell your client %d tickets for the price of %d$!%n",ticketCount,total);
            System.out.printf("Your client should become a change of %d$!",budget-total);
        }else {
            System.out.printf("The budget of %d$ is not enough. Your client can't buy %d tickets with this budget!",budget,ticketCount);
        }

    }
}
