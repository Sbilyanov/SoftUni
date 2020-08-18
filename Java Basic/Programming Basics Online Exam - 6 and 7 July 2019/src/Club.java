import java.util.Scanner;

public class Club {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);



        double goal= Double.parseDouble(scanner.nextLine());
        String input = scanner.nextLine();
        double income =0;
        double total=0;

        while (!input.equals("Party!")){
            int cocktailCount = Integer.parseInt(scanner.nextLine());
            income = input.length()*cocktailCount;
            if (income%2!=0) {
                income *= 0.75;
            }

            total+=income;
            if(goal<=total){
                System.out.println("Target acquired.");
                System.out.printf("Club income - %.2f leva.",total);
                return;
            }

            input=scanner.nextLine();
        }

        System.out.printf( "We need %.2f leva more.%n",Math.abs(goal-total));
        System.out.printf("Club income - %.2f leva.",total);


    }
}

