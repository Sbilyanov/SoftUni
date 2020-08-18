import java.util.Scanner;

public class YardsGreening {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Double Squaremeters =Double.parseDouble(scanner.nextLine());
        Double Price = Squaremeters * 7.61;
        Double discount = Price * 0.18;
        Double FinalPrice = Price - discount;

        System.out.println(FinalPrice);
        System.out.println(discount);


    }
}
