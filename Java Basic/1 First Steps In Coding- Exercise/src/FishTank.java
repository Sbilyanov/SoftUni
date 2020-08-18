import java.util.Scanner;

public class FishTank {
    public static void main(String[] args) {
        Scanner scanner=new Scanner(System.in);


        int length = Integer.parseInt(scanner.nextLine());
        int width = Integer.parseInt(scanner.nextLine());
        int height = Integer.parseInt(scanner.nextLine());
        double percent = Double.parseDouble(scanner.nextLine());

        double volume = length*width*height;
        double littresTotal = volume * 0.001;

        double littreswater = littresTotal-(littresTotal*percent/100);


        System.out.printf("%.2f",littreswater);




    }
}
