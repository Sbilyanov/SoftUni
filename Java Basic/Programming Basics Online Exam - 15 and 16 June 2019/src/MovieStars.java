import java.util.Scanner;

public class MovieStars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double budget = Double.parseDouble(scanner.nextLine());
        String input = scanner.nextLine();
        double salary = 0;


        while (!input.equals("ACTION")&&budget>=0){

            if(input.length()>15){
                salary=budget*0.20;
            }else {
                salary = Double.parseDouble(scanner.nextLine());
            }


            budget-=salary;

            input=scanner.nextLine();

        }
        if(budget>=0){
            System.out.printf("We are left with %.2f leva.",Math.abs(budget));
        }else {
            System.out.printf("We need %.2f leva for our actors.",Math.abs(budget));
        }
    }
}
