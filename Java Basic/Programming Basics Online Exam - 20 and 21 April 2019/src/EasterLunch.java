import java.util.Scanner;

public class EasterLunch {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);



        int cakeNum = Integer.parseInt(scanner.nextLine());
        int eggPack = Integer.parseInt(scanner.nextLine());
        int cookiesKg = Integer.parseInt(scanner.nextLine());

        double price =(cakeNum*3.20)+(eggPack*4.35)+(cookiesKg*5.40)+((eggPack* 12)  * 0.15);
        System.out.printf("%.2f",price);
    }
}
