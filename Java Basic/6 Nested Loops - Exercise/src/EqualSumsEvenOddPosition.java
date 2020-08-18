import java.util.Scanner;

public class EqualSumsEvenOddPosition {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int startNum = Integer.parseInt(scanner.nextLine());
        int endNum = Integer.parseInt(scanner.nextLine());


        for (int i = startNum; i <= endNum; i++) {
        int evenSum = 0;
        int oddSum = 0;

            String currentNum = ""+i;
            for (int j = 0; j < 6; j++) {

                int currentPositionNum = Integer.parseInt("" + currentNum.charAt(j));
                if (j % 2 == 0) {
                    evenSum += currentPositionNum;
                } else {
                    oddSum += currentPositionNum;
                }
            }
            if (evenSum == oddSum) {
                System.out.print(i+" ");
            }
        }
    }
}
