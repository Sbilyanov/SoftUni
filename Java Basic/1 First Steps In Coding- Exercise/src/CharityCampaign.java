import java.util.Scanner;

public class CharityCampaign {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int days = Integer.parseInt(scanner.nextLine());
        int chefs = Integer.parseInt(scanner.nextLine());
        int cakes = Integer.parseInt(scanner.nextLine()) ;
        int waffles = Integer.parseInt(scanner.nextLine()) ;
        int pancakes = Integer.parseInt(scanner.nextLine()) ;

        double cakePrice = cakes*45;
        double wafflePrice = waffles * 5.80;
        double pancakePrice = pancakes * 3.20;

        double chefincome = (cakePrice+wafflePrice+pancakePrice) * chefs;
        double income = chefincome *days;

        double cost = income * 1 / 8;

        double total = income - cost;

        System.out.printf("%.2f", total);

        //131
        //5
        //9
        //33
        //46

    }

}

