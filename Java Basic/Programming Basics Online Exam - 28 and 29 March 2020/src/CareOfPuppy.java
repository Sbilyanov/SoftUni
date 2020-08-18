import java.util.Scanner;

public class CareOfPuppy {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int foodKg = Integer.parseInt(scanner.nextLine());
        int foodInG=foodKg*1000;
        int totalEatenFood=0;

        String input =scanner.nextLine();
        while (!input.equals("Adopted")){
            int foodPerDay=Integer.parseInt(input);
            totalEatenFood+=foodPerDay;

            input=scanner.nextLine();
        }
        if(totalEatenFood<=foodInG){
            System.out.printf("Food is enough! Leftovers: %d grams.",Math.abs(totalEatenFood-foodInG));

        }else {
            System.out.printf("Food is not enough. You need %d grams more.",Math.abs(totalEatenFood-foodInG));
        }
    }
}
