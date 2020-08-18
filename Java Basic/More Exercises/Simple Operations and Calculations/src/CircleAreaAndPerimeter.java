import java.util.Scanner;

public class CircleAreaAndPerimeter {
    public static void main(String[] args) {
        Scanner scanner= new Scanner(System.in);

        double r = Double.parseDouble(scanner.nextLine());

        double A = Math.PI *(r*r);
        double C = 2*Math.PI * r;

        System.out.printf("%.2f\n",A);
        System.out.printf("%.2f",C);

    }
}
