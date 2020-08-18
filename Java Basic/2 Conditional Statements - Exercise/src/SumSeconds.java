import java.util.Scanner;

public class SumSeconds {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int timeFirst = Integer.parseInt(scanner.nextLine());
        int timeSecond = Integer.parseInt(scanner.nextLine());
        int timeThird = Integer.parseInt(scanner.nextLine());

        int timeTotal = timeFirst + timeSecond + timeThird;
        int minutes = timeTotal / 60;
        int seconds = timeTotal % 60;
        // за да се намерят оставащите 6 секунди от 66 се използва модулно делене
        if (seconds < 10 ) {
            System.out.printf("%d:0%d",minutes,seconds);
        }
            else {
                System.out.printf("%d:%d",minutes , seconds);
            }


//35
//45
//44
    }

}
