import java.util.Scanner;

public class DepositCalculator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        //сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)

        double deposit = Double.parseDouble(scanner.nextLine());
        int time = Integer.parseInt(scanner.nextLine());
        double intrest = Double.parseDouble(scanner.nextLine());
        double total = deposit + time * ((deposit * intrest/100) / 12);

        System.out.println(total);


    }
}
