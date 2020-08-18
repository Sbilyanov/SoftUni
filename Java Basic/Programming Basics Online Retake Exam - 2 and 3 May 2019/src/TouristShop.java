import java.util.Scanner;

public class TouristShop {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        double budget = Double.parseDouble(scanner.nextLine());

        double totalPrice =0;
        int counter=0;
        String input =scanner.nextLine();

        while (!input.equals("Stop")){
            String item = input;
            double price= Double.parseDouble(scanner.nextLine());
            counter++;
            if(counter%3==0){
                budget-=price/2;
                totalPrice+=price/2;
            }else {
                budget-=price;
                totalPrice+=price;
            }
            if(budget<0){

                System.out.println("You don't have enough money!");
                System.out.printf("You need %.2f leva!",Math.abs(budget));
                return;
            }

            input=scanner.nextLine();


        }
        System.out.printf("You bought %d products for %.2f leva.",counter,totalPrice);


    }
}
