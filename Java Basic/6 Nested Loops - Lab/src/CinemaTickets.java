import java.util.Scanner;

public class CinemaTickets {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String movieName = scanner.nextLine();
        int free = 0;
        double totalTickets = 0;

        int student = 0;
        int kid = 0;
        int standard = 0;
        double soldTicket = 0;
        double percent = 0;


        while (!movieName.equals("Finish")) {
            free = Integer.parseInt(scanner.nextLine());
            soldTicket = 0;

            for (int i = 1; i <= free; i++) {

                String type = scanner.nextLine();
                if (type.equals("student")) {
                    student++;
                }
                if (type.equals("standard")) {
                    standard++;
                }
                if (type.equals("kid")) {
                    kid++;
                }
                if (type.equals("End")) {
                    break;
                }
                soldTicket++;
                totalTickets++;
            }
            percent = soldTicket / free * 100;

            System.out.printf("%s - %.2f%% full.%n", movieName, percent);
            movieName = scanner.nextLine();
        }


        double studentPercent = student / totalTickets * 100;
        double standardPercent = standard / totalTickets * 100;
        double kidPercent = kid / totalTickets * 100;

        System.out.printf("Total tickets: %.0f%n", totalTickets);
        System.out.printf("%.2f%% student tickets.%n", studentPercent);
        System.out.printf("%.2f%% standard tickets.%n", standardPercent);
        System.out.printf("%.2f%% kids tickets.", kidPercent);
    }
}
