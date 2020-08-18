import java.util.Scanner;

public class RadianiToDegrees {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

      //  градус = радиан * 180 / π.Числото π в Java програми е достъпно чрез Math.PI.

        double radian = Double.parseDouble(scanner.nextLine());
        double degrees = radian * 180 / Math.PI;

        System.out.printf("%,1f", degrees);

        }
    }

