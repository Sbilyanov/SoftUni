import java.util.Scanner;

public class KartRankList {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);



        String name = scanner.nextLine();

        String winner="";
        int winnerTime=Integer.MAX_VALUE;
        int goldCounter=0;
        int silverCounter =0;
        int bronzeCounter =0;
        int time = 0;



        while (!name.equals("Finish")){
            int minutes = Integer.parseInt(scanner.nextLine());
            int seconds = Integer.parseInt(scanner.nextLine());
            time= minutes*60+seconds;
            if(time<55){
                goldCounter++;
            }else if(time<=85){
                silverCounter++;
            }else if (time<=120){
                bronzeCounter++;
            }

            if(time<winnerTime){
                winner=name;
                winnerTime=time;
            }

            name=scanner.nextLine();
        }

        System.out.printf("With %d minutes and %d seconds %s is the winner of the day!%n",(winnerTime/60),(winnerTime%60),winner);
        System.out.printf("Today's prizes are %d Gold %d Silver and %d Bronze cards!",goldCounter,silverCounter,bronzeCounter);
    }
}
