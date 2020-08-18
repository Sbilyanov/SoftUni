import java.util.Scanner;

public class OnTimeForTheExam {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int examHour = Integer.parseInt(scanner.nextLine());
        int examMinutes = Integer.parseInt(scanner.nextLine());
        int arrivalHour = Integer.parseInt(scanner.nextLine());
        int arrivalMinutes = Integer.parseInt(scanner.nextLine());

        int arrivalTime = arrivalHour * 60 + arrivalMinutes;
        int examTime = examHour * 60 + examMinutes;
        int hours = 0;
        int minutes = 0;
        int total = 0;

        if (arrivalTime == examTime) {
            System.out.println("On time");
        } else if (arrivalTime < examTime) {
            if (examTime - arrivalTime <= 30) {
                minutes = examTime - arrivalTime;
                System.out.println("On time");
                System.out.printf("%d minutes before the start", minutes);
            } else if (examTime - arrivalTime < 60) {
                minutes = (examTime - arrivalTime) % 60;
                System.out.println("Early");
                System.out.printf("%02d minutes before the start", minutes);
            } else {
                minutes = (examTime - arrivalTime) % 60;
                hours = (examTime - arrivalTime) / 60;
                System.out.println("Early");
                System.out.printf("%d:%02d hours before the start", hours, minutes);
            }

        } else {
            if (arrivalTime - examTime < 60) {
                minutes = arrivalTime - examTime;
                System.out.println("Late");
                System.out.printf("%d minutes after the start", minutes);
            } else {
                minutes = (arrivalTime - examTime) % 60;
                hours = (arrivalTime - examTime) / 60;
                System.out.println("Late");
                System.out.printf("%d:%02d hours after the start", hours, minutes);
            }
        }


    }
}
