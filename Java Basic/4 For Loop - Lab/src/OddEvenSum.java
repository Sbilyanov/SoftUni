import java.util.Scanner;

public class OddEvenSum {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int number = Integer.parseInt(scanner.nextLine());

        int odd = 0;
        int even=0;

        for (int i = 1; i <=number ; i++) {
            int num = Integer.parseInt(scanner.nextLine());
            if(i%2==0){
                even+=num;
            }else {
                odd+=num;
            }
        }
        if (odd==even){
            System.out.println("Yes");
            System.out.printf("Sum = %d",even);
        }else {
            System.out.println("No");
            System.out.printf("Diff = %d",Math.abs(even-odd));
        }
    }
}

