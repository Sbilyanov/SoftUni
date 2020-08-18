import java.util.Scanner;

public class Four {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        double sum = Double.parseDouble(scanner.nextLine());
        int months = Integer.parseInt(scanner.nextLine());

        double simpleRate = sum;
        double complexRate = sum;

        for (int i = 0; i < months; i++) {

            simpleRate += sum * 0.03;
            complexRate *= 1.027;
        }
        System.out.printf("Simple interest rate: %.2f lv.%n", simpleRate);
        System.out.printf("Complex interest rate: %.2f lv.%n", complexRate);

        if (simpleRate > complexRate) {
            System.out.printf("Choose a simple interest rate. You will win %.2f lv.", Math.abs(simpleRate - complexRate));
        } else {
            System.out.printf("Choose a complex interest rate. You will win %.2f lv.", Math.abs(simpleRate - complexRate));
        }

    }
}