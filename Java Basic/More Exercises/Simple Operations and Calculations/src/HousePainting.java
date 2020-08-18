import java.util.Scanner;

public class HousePainting {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        //⦁	x – височината на къщата – реално число в интервала [2...100]
        //⦁	y – дължината на страничната стена – реално число в интервала [2...100]
        //⦁	h – височината на триъгълната стена на прокрива – реално число в интервала

        double x = Double.parseDouble(scanner.nextLine());
        double y = Double.parseDouble(scanner.nextLine());
        double h = Double.parseDouble(scanner.nextLine());

        double side = (2 * (x * y)) - (2 * (1.5 * 1.5));
        double front = 2 * (x * x) - (2 * 1.2);
        double greenPaint = (side + front) / 3.4;

        double roof = 2 * (y * x) + 2 * (x * h / 2);
        double redPaint = roof / 4.3;

        System.out.printf("%.2f\n",greenPaint);

        System.out.printf("%.2f",redPaint);

    }
}
