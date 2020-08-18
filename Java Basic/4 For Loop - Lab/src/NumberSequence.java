import java.util.Scanner;

public class NumberSequence {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int number = Integer.parseInt(scanner.nextLine());

        int min = Integer.MAX_VALUE;
        int max = Integer.MIN_VALUE;

        for (int i = 1; i <= number; i++) {

            int currentNumber = Integer.parseInt(scanner.nextLine());
            if(currentNumber<min){
                min=currentNumber;
            }
            if(currentNumber>max){
                max = currentNumber;
            }

        }
        System.out.printf("Max number: %d%n",max);
        System.out.printf("Min number: %d",min);
    }
}
