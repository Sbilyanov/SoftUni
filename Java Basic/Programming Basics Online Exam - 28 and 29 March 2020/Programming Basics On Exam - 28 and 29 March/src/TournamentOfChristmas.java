import java.util.Scanner;

public class TournamentOfChristmas {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int days = Integer.parseInt(scanner.nextLine());
        int money = 0;
        int winsCounter = 0;
        int lossesCounter = 0;
        double moneyPerDay = 0;
        int winDays = 0;
        int lossesDays = 0;
        double totalMoney = 0;

        for (int i = 0; i < days; i++) {
            String sport = scanner.nextLine();
            winsCounter = 0;
            lossesCounter = 0;
            //money = 0;
            moneyPerDay = 0;
            while (!sport.equals("Finish")) {
                String result = scanner.nextLine();

                if (result.equals("win")) {
                    money += 20;
                    winsCounter++;

                } else {
                    lossesCounter++;
                }
                moneyPerDay += money;


                sport = scanner.nextLine();
                money = 0;
            }
            if (winsCounter > lossesCounter) {
                winDays++;
                moneyPerDay = moneyPerDay + (moneyPerDay * 0.10);
            } else {
                lossesDays++;
            }
            totalMoney += moneyPerDay;

        }
        if (winDays > lossesDays) {
            totalMoney = totalMoney + (totalMoney * 0.20);
            System.out.printf("You won the tournament! Total raised money: %.2f", totalMoney);
        } else {

            System.out.printf("You lost the tournament! Total raised money: %.2f", totalMoney);
        }


    }
}
