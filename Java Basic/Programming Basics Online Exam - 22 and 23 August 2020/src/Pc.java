import java.util.Scanner;

public class Pc {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        double procesor = Double.parseDouble(scanner.nextLine());
        double videoCard = Double.parseDouble(scanner.nextLine());
        double ram = Double.parseDouble(scanner.nextLine());
        int ramNum = Integer.parseInt(scanner.nextLine());
        double discount = Double.parseDouble(scanner.nextLine());
        double dollar = 1.57;

        double priceRam =(ram*ramNum)*1.57;
        double pricePro= procesor*1.57-((procesor*1.57)*discount);
        double priceVid= videoCard*1.57-((videoCard*1.57)*discount);
        double total = pricePro+priceRam+priceVid;

        System.out.printf("Money needed - %.2f leva.",total);

    }
}
