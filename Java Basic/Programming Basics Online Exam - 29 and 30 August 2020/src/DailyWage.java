import java.util.Scanner;

public class DailyWage {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        //Купичка ягоди: 3.50 лв.
        //Купичка боровинки: 5.00 лв


        int rows = Integer.parseInt(scanner.nextLine());//5
        int position = Integer.parseInt(scanner.nextLine());//7
        int strawberryCount = 0;
        int berryCount =0;

        for (int i = 1; i <=rows ; i++) {
            if(i%2!=0){
                strawberryCount++;
            }else {
                for (int j = 1; j <= position; j++) {
                    if (j % 3 != 0) {
                        berryCount++;
                    }
                }
            }
        }
        double total = ((position*strawberryCount)*3.50)+(berryCount*5.00);
        total=total*0.80;

        System.out.printf("Total: %.2f lv.",total);
    }
}
