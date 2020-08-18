import java.util.Scanner;

public class VacationBooksList {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);



        int CurrentBookPages = Integer.parseInt(scanner.nextLine());
        int PagesForOneHour = Integer.parseInt(scanner.nextLine());
        int Days = Integer.parseInt(scanner.nextLine());

        int ReadingHours =(CurrentBookPages / PagesForOneHour)/Days;

        System.out.println(ReadingHours);



    }
}
