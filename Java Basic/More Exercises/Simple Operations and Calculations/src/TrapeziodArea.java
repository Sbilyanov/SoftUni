    import java.util.Scanner;

    public class TrapeziodArea {
        public static void main(String[] args) {
            Scanner scanner = new Scanner(System.in);

            double b1 =Double.parseDouble(scanner.nextLine());
            double b2 =Double.parseDouble(scanner.nextLine());
            double h =Double.parseDouble(scanner.nextLine());

            double c = b1+b2;

            double face = (c*h)/2;

            System.out.printf("%.2f",face);


        }
    }
