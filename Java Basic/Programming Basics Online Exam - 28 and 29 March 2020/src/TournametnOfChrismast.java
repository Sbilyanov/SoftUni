import java.util.Scanner;

public class TournametnOfChrismast {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int daysNum = Integer.parseInt(scanner.nextLine());
       double money = 0;
        int totalWinsCounter = 0;
        int totalLostCounter = 0;
        double moneyPerDay = 0;
        double totalMoney = 0;
        int winPerDay = 0;
        int lostPerDay = 0;

        for (int i = 0; i < daysNum; i++) {
            String sport = scanner.nextLine();
            winPerDay = 0;
            lostPerDay = 0;



            while (!sport.equals("Finish")) {
                String results = scanner.nextLine();
                if(results.equals("win")){
                    winPerDay++;
                    money+=20;
                }else{
                    lostPerDay++;
                }
                sport=scanner.nextLine();
            }
            if (winPerDay>lostPerDay){
                totalWinsCounter++;
                moneyPerDay=money+(money*0.10);
            }else {
                totalLostCounter++;
                moneyPerDay+=money;
            }
            totalMoney+=moneyPerDay;
            money=0;
            moneyPerDay=0;



        }if(totalWinsCounter>totalLostCounter){
            totalMoney=totalMoney+(totalMoney*0.20);
            System.out.printf("You won the tournament! Total raised money: %.2f",totalMoney);
        }if(totalLostCounter>totalWinsCounter) {
           // totalMoney=moneyPerDay;
            System.out.printf("You lost the tournament! Total raised money: %.2f",totalMoney);
        }



    }
}
