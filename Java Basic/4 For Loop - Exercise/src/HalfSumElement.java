import java.util.Scanner;

public class HalfSumElement {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int number = Integer.parseInt(scanner.nextLine());
        int sum =0;
        int maxNumber = Integer.MIN_VALUE;

        for (int i = 0; i < number; i++) {
            int currentNum = Integer.parseInt(scanner.nextLine());
            sum = sum + currentNum;

            if (currentNum > maxNumber) {
                maxNumber = currentNum;

            }
        }
        int totalSum = sum - maxNumber;

        if (totalSum == maxNumber) {
            System.out.printf("Yes%nSum = %d ",maxNumber);

        }else {
            int diff = Math.abs(totalSum-maxNumber);
            System.out.printf("No%nDiff = %d", diff);
        }


    }
}
