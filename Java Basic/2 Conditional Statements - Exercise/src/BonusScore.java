import org.w3c.dom.ls.LSOutput;

import java.util.Scanner;

public class BonusScore {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int points = Integer.parseInt(scanner.nextLine());
        double bonus = 0;

        if (points <= 100) {
            bonus = 5;
        } else if(points<= 1000) {
            bonus = points * 0.2;
        } else if (points > 1000) {
            bonus = points * 0.10;
        }
        //намиране на четно число "==" и за не четно е "!="
        if(points % 2 == 0) {
            bonus = bonus + 1;
        } else if(points % 10 == 5) {
            bonus = bonus + 2; }
        //⦁	За число, което завършва на 8 - 238 / 10 = 23.8 ; 238 % 10 == 8
        //⦁	За число, което завършва на 55 - 155 / 100 = 1.55 ; 238 % 10 == 55
        System.out.println(bonus);
        System.out.print(points+bonus);




    }
}
