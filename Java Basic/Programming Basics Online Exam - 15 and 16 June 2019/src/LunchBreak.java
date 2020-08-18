import java.util.Scanner;

public class LunchBreak {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        String name =scanner.nextLine();
        int episodeTime= Integer.parseInt(scanner.nextLine());
        int breakTime= Integer.parseInt(scanner.nextLine());

        double lunchTime =breakTime*0.125;
        double restTime = breakTime*0.25;
        double freeTime = breakTime-(lunchTime+restTime);
        if(episodeTime<=freeTime){
            System.out.printf("You have enough time to watch %s and left with %.0f minutes free time.",name,Math.ceil(freeTime-episodeTime));
        }else{
            System.out.printf("You don't have enough time to watch %s, you need %.0f more minutes.",name,Math.ceil(episodeTime-freeTime));
        }
    }
}
