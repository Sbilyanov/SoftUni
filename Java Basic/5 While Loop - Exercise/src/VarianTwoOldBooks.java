import java.util.Scanner;

public class VarianTwoOldBooks {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);




        String book = scanner.nextLine();
        String input = scanner.nextLine();
        int counter = 0;
        boolean isFound = false;

        while (!input.equals("No More Books")) {

            if (input.equals(book)) {

                System.out.printf("You checked %d books and found it.",counter);
                isFound=true;
                        break;


            }
            counter++;

            input = scanner.nextLine();

        }
        if(isFound){
            System.out.printf("The book you search is not here!%n");
            System.out.printf("You checked %d books.",counter);


        }
    }
}
