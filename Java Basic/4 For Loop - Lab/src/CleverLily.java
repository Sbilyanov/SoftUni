import java.util.Scanner;

public class CleverLily {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int age = Integer.parseInt(scanner.nextLine());
        double priceWashing = Double.parseDouble(scanner.nextLine());
        int toyPrice = Integer.parseInt(scanner.nextLine());
        int birthdayMoney = 0;
        int toyTotalSum = 0;
        double total = 0;
        int brother = 0;

        for (int i = 1; i <= age; i++) {
            if (i % 2 == 0) {
                birthdayMoney += i*5;
                brother+=1;

            }
            if(i%2!=0){
                toyTotalSum += toyPrice;
            }
        }
        total = (birthdayMoney-brother) + toyTotalSum;
        if (total >= priceWashing) {
            System.out.printf("Yes! %.2f", (total - priceWashing));
        } else {
            System.out.printf("No! %.2f", (priceWashing - total));
        }


    }
}
