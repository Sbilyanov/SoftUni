import java.util.Scanner;

public class Rate {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double money = Double.parseDouble(scanner.nextLine());
        int months = Integer.parseInt(scanner.nextLine());

        double simpleRate= money;
        double complexrate = money;

        for (int i = 0; i < months; i++) {
            simpleRate +=money*0.03;
            complexrate*=1.027;

        }
        System.out.printf("Simple interest rate: %.2f lv.%n",simpleRate);
        System.out.printf("Complex interest rate: %.2f lv.%n",complexrate);

        if(simpleRate>complexrate){
            System.out.printf("Choose a simple interest rate. You will win %.2f lv.",Math.abs(simpleRate-complexrate));
        }else {
            System.out.printf("Choose a complex interest rate. You will win %.2f lv.",Math.abs(simpleRate-complexrate));
        }

    }
}
