import java.util.Scanner;

public class OddEvenPosition {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        double oddSum = 0;
        double oddMim = 1000000000.0;
        double oddMax = -1000000000.0;
        double evenMin = 1000000000.0;
        double evenMax = -1000000000.0;
        double evenSum = 0;
        for (int i = 1; i <= n; i++) {
            double currentNumber = Double.parseDouble(scanner.nextLine());

            if (i % 2 != 0) {
                oddSum = oddSum + currentNumber;
                if (currentNumber > oddMax) {
                    oddMax = currentNumber;
                }
                if (currentNumber < oddMim) {
                    oddMim = currentNumber;
                }
            } else {
                evenSum = evenSum + currentNumber;
                if (currentNumber > evenMax) {
                    evenMax = currentNumber;
                }
                if (currentNumber < evenMin) {
                    evenMin = currentNumber;
                }
            }
        }

        System.out.printf("OddSum=%.2f,%n", oddSum);
        if (oddMim == 1000000000.0) {
            System.out.printf("OddMin=No,%n");
        } else {
            System.out.printf("OddMin=%.2f,%n", oddMim);
        }
        if (oddMax == -1000000000.0) {
            System.out.printf("OddMax=No,%n");
        } else {
            System.out.printf("OddMax=%.2f,%n", oddMax);
        }

        System.out.printf("EvenSum=%.2f,%n", evenSum);

        if (evenMin == 1000000000.0) {
            System.out.printf("EvenMin=No,%n");
        } else {
            System.out.printf("EvenMin=%.2f,%n", evenMin);
        }

        if (evenMax == -1000000000.0) {
            System.out.printf("EvenMax=No");
        } else {
            System.out.printf("EvenMax=%.2f", evenMax);
        }
    }
}
