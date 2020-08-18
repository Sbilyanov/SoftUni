import java.util.Scanner;

public class ShopingForSchool {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int pencilsPack = Integer.parseInt(scanner.nextLine());
        int marker = Integer.parseInt(scanner.nextLine());
        int paintBook  = Integer.parseInt(scanner.nextLine());
        int notebook = Integer.parseInt(scanner.nextLine());
        double discount = 0.05;

        double pencil =pencilsPack*4.75;
        double marPrice = marker*1.80;
        double paintPrice = paintBook*6.50;
        double notePrice = notebook*2.50;

        double total =pencil+marPrice+paintPrice+notePrice;
        total=total-(total*discount);
        System.out.printf("Your total is %.2flv",total);

    }
}
