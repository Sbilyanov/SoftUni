import java.util.Scanner;

public class TimeMinutes {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int hours = Integer.parseInt(scanner.nextLine());
        int minutes = Integer.parseInt(scanner.nextLine());
        int hourToMinutes = hours * 60;
        int total = hourToMinutes + minutes + 15;
        int resultHour = total / 60;
        int resultMinutes = total % 60;
        if(resultHour > 23) {
            System.out.printf("0:%02d",resultMinutes);// %02d означаба че до 10 щсе принтира 0 ако е над (12) ще се принтира 12
        }else if(resultMinutes > 59){
            System.out.printf("%2d:00",resultHour);
        }else if(resultMinutes < 10 ){
           System.out.printf("%d:0%d",resultHour,resultMinutes);
        }else{
            System.out.printf("%d:%d",resultHour,resultMinutes);
        }


    }
}
