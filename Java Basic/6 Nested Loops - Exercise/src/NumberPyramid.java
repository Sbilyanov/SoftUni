import java.util.Scanner;

public class NumberPyramid {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        int number = 0;


        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= i; j++) {
                number++;

                System.out.printf("%d ", number);
                if (number == n) {
                    break;
                }

            }

            System.out.println();
            if (number == n) {
                break;
            }
        }
    }
}
