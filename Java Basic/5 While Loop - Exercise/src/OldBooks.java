import java.util.Scanner;

public class OldBooks {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String book = scanner.nextLine();
        String input = scanner.nextLine();
        int counter = 0;

        while (!input.equals(book)) {

            if (input.equals("No More Books")) {

                System.out.printf("The book you search is not here!%n");
                System.out.printf("You checked %d books.",counter);
                return;
            }
            counter++;

            input = scanner.nextLine();

        }
        System.out.printf("You checked %d books and found it.",counter);

    }
}
