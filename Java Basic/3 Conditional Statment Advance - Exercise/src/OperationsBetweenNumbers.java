import java.util.Scanner;

public class OperationsBetweenNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int a = Integer.parseInt(scanner.nextLine());
        int b = Integer.parseInt(scanner.nextLine());
        String symbol = scanner.nextLine();
        double result = 0;

        switch (symbol) {
            case "+":
                result = a+b;
                break;
            case "-":
                result = a-b;
                break;
            case "*":

                result = a* b;
                break;

            case "/":
                if (b==0){
                    System.out.printf("Cannot divide %d by zero",a);
            }else {
                    result = (1.0*a )/ b;
                    System.out.printf("%d %s %d = %.2f",a,symbol,b,result);
                }
                break;
            case "%":
                if (b ==0)
                    System.out.printf("Cannot divide %d by zero",a);
                else {
                    result = a%b;
                    System.out.printf("%d %s %d = %.0f",a,symbol,b,result);
                }
                break;
        }

        if (!symbol.equals("%") && !symbol.equals("/")){
            if (result % 2 == 0){
                System.out.printf("%d %s %d = %.0f - even",a,symbol,b,result);
            }else {
                System.out.printf("%d %s %d = %.0f - odd",a,symbol,b,result);
            }

        }
    }
}
