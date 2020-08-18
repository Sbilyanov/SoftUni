import org.w3c.dom.ls.LSOutput;

import java.util.Scanner;

public class EasterEggs {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Броят на боядисаните яйца – цяло число в интервала [1 ... 100]
        //За всяко яйце се чете:
        //Цветът на яйцето – текст с възможности: "red", "orange", "blue", "green"

        int eggNum = Integer.parseInt(scanner.nextLine());
        int red = 0;
        int orange = 0;
        int blue = 0;
        int green = 0;
        int max = Integer.MIN_VALUE;
        String output="";

        for (int i = 0; i < eggNum; i++) {
            String color = scanner.nextLine();
            if (color.equals("red")) {
                red++;
                if (red > max) {
                    max = red;
                   output = String.format("Max eggs: %d -> %s", max,color);
                }
            }
            if (color.equals("orange")) {
                orange++;
                if (orange > max) {
                    max = orange;
                    output = String.format("Max eggs: %d -> %s", max,color);
                }
            }
            if (color.equals("blue")) {
                blue++;
                if (blue > max) ;
                max = blue;
                output = String.format("Max eggs: %d -> %s", max,color);
            }
            if (color.equals("green")) {
                green++;
                if (green > max) {
                    max = green;
                    output = String.format("Max eggs: %d -> %s", max,color);
                }


            }

        }
        System.out.println("Red eggs: "+red);
        System.out.println("Orange eggs: "+orange);
        System.out.println("Blue eggs: "+blue);
        System.out.println("Green eggs: "+green);
        System.out.println(output);

    }


}

