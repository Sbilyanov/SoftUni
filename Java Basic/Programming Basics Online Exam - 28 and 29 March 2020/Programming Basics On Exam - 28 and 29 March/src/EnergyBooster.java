import java.util.Scanner;

public class EnergyBooster {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        String flavour = scanner.nextLine();
        String size = scanner.nextLine();
        int setNum = Integer.parseInt(scanner.nextLine());
        double total = 0;


        switch (flavour) {
            case "Watermelon":
                if (size.equals("big"))
                    total = setNum * (28.70 * 5);
                else {
                    total = setNum * (56 * 2);
                }
                break;
            case "Mango":
                if (size.equals("big"))
                    total = setNum * (19.60 * 5);
                else {
                    total = setNum * (36.66 * 2);
                }
                break;
            case "Pineapple":
                if (size.equals("big"))
                    total = setNum * (24.80 * 5);
                else {
                    total = setNum * (42.10 * 2);
                }
                break;
            case "Raspberry":
                if (size.equals("big"))
                    total = setNum * (15.20 * 5);
                else {
                    total = setNum * (20 * 2);
                }
                break;
        }

        if (total >= 400 && total <= 1000) {
            total = total * 0.85;
        } else if (total > 1000) {
            total = total * 0.5;
        }

        System.out.printf("%.2f lv.", total);

    }
}