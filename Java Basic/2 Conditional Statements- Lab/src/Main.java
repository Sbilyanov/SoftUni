import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sacnner = new Scanner(System.in);

        String firstString = "Svetlin";
        String secondString = sacnner.nextLine();


        System.out.println(firstString==secondString);

        System.out.println(firstString.equals(secondString));
    }
}
