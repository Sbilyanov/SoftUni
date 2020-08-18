import java.util.Scanner;

public class ChangeBureau {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int bitcoin = Integer.parseInt(scanner.nextLine());
        double yuan = Double.parseDouble(scanner.nextLine());
        double commission = Double.parseDouble(scanner.nextLine());
        double leva = 0;
        double dollarleva = 0;


        leva = bitcoin * 1168;
        dollarleva = (yuan * 0.15) * 1.76;

        double euro = (leva + dollarleva) / 1.95;
        double total = euro - ((euro * commission) / 100);

        System.out.printf("%.2f", total);


    }
}
