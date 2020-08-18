import java.util.Scanner;

public class EasterTrip {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);




        String destination = scanner.nextLine();
        String  dates = scanner.nextLine();
        int nights= Integer.parseInt(scanner.nextLine());
        double moneyNeeded = 0;

        switch (destination){
            case "France":
                if(dates.equals("21-23")){
                    moneyNeeded=30*nights;
                }else if(dates.equals("24-27")){
                    moneyNeeded=35*nights;
                }else if(dates.equals("28-31")){
                    moneyNeeded=40*nights;
                }
                break;
            case "Italy":
                if(dates.equals("21-23")){
                    moneyNeeded=28*nights;
                }else if(dates.equals("24-27")){
                    moneyNeeded=32*nights;
                }else if(dates.equals("28-31")){
                    moneyNeeded=39*nights;
                }
                break;
            case "Germany":
                if(dates.equals("21-23")){
                    moneyNeeded=32*nights;
                }else if(dates.equals("24-27")){
                    moneyNeeded=37*nights;
                }else if(dates.equals("28-31")){
                    moneyNeeded=43*nights;
                }
                break;


        }
        System.out.printf("Easter trip to %s : %.2f leva.",destination,moneyNeeded);
    }
}
