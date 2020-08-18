import java.util.Scanner;

public class SpecialNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 1; i <= 9; i++) {
            if (n % i == 0) {
                for (int j = 1; j <= 9; j++) {
                    if (n % j == 0) {
                        for (int k = 1; k <= 9; k++) {
                            if (n % k == 0) {
                                for (int l = 1; l <=9; l++) {
                                    if (n % l == 0) {
                                        System.out.printf("%d%d%d%d ", i, j, k, l);

                                    }

                                }
                            }

                        }
                    }

                }
            }


        }
    }
}
