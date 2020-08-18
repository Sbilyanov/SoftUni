import java.util.Scanner;

public class GodzillavsKong {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double budged = Double.parseDouble(scanner.nextLine());
        int numberPeople = Integer.parseInt(scanner.nextLine());
        double personClothesPrise = Double.parseDouble(scanner.nextLine());

        double sumDecor = budged * 0.10;
        double clothesPrice = numberPeople * personClothesPrise;

        double total = sumDecor + clothesPrice;
        double moneyLeft = budged - total;

        if(numberPeople >= 150){
            double clothePrice = clothesPrice-(clothesPrice*0.10);
        }

        if(total>budged){
            double mLeft = total-budged;
            System.out.println("Not enough money!");
            System.out.printf("Wingard needs %.f leva more.", mLeft);

        }
        else if (total<budged) {
            double mLeft = budged - total;
            System.out.println("Action!");
            System.out.printf("Wingard starts filming with %.f leva left.", mLeft);
        }





    }
}