import javax.swing.*;
import java.util.Scanner;

public class AreaofFigures {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String typeOfFigures = scanner.nextLine();
        if (typeOfFigures.equals("square")){
            double a = Double.parseDouble(scanner.nextLine());
            double squareS = a * a;
            System.out.printf("%.3f",squareS);
        }
            else if(typeOfFigures.equals("rectangle")){
            double a = Double.parseDouble(scanner.nextLine());
            double b = Double.parseDouble(scanner.nextLine());
                double rectangleS = a * b;
            System.out.printf("%.3f",rectangleS);
        }
            else if(typeOfFigures.equals("circle")){
            double r = Double.parseDouble(scanner.nextLine());
            double circleS = Math.PI * (r*r);
            System.out.printf("%.3f",circleS);}

            else if(typeOfFigures.equals("triangle")){
            double a = Double.parseDouble(scanner.nextLine());
            double b = Double.parseDouble(scanner.nextLine());
            double triangleS = (a * b) / 2;
            System.out.printf("%.3f",triangleS);;


        }









    }
}
