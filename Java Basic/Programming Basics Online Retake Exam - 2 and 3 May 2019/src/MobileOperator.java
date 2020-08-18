import java.util.Scanner;

public class MobileOperator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String timeOfContract=scanner.nextLine();
        String typeOfContract =scanner.nextLine();
        String internet =scanner.nextLine();
        int monthCount= Integer.parseInt(scanner.nextLine());
        double tax =0;
        double total =0;



        switch (typeOfContract){
            case "Small":
                if(timeOfContract.equals("one")){
                  tax =9.98;
                }else {
                    tax=8.58;
                }
                break;
            case"Middle":
                if(timeOfContract.equals("one")){
                    tax =18.99;
                }else {
                    tax=17.09;
                }
                break;
            case"Large":
                if(timeOfContract.equals("one")){
                    tax =25.98;
                }else {
                    tax=23.59;
                }
                break;
            case "ExtraLarge":
                if(timeOfContract.equals("one")){
                    tax =35.99;
                }else {
                    tax=31.79;
                }
                break;

        }
        if(tax<=10.00&&internet.equals("yes")){
            tax+=5.50;
        }else if(tax<=30.00&&internet.equals("yes")){
            tax+=4.35;
        }else if(tax>30.00 && internet.equals("yes")){
            tax+=3.85;
        }

        if(timeOfContract.equals("two")){
            total =(tax*monthCount)-((tax*monthCount)*3.75)/100;
        }else {
            total=tax*monthCount;
        }
        System.out.printf("%.2f lv.",total);

    }
}
