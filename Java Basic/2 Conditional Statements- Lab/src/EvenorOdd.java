import java.util.Scanner;

public class EvenorOdd {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int number  = Integer.parseInt(scanner.nextLine());
        //10 % 2 -> 0
        //11 % 2 -> !=0
        if (number % 2 ==0){
            System.out.println("even");

        } else{
            System.out.println("odd");
        }
    }
}
