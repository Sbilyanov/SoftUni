import java.util.Scanner;

public class Cake {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int width = Integer.parseInt(scanner.nextLine());
        int height = Integer.parseInt(scanner.nextLine());

        String input = scanner.nextLine();
        int cake = width * height;


        while (!input.equals("STOP")) {;
        int slices= Integer.parseInt(input);
        cake -= slices;
        if(cake<0) {
            break;
        }

        input=scanner.nextLine();
        }
        if (cake<0){
            System.out.printf("No more cake left! You need %d pieces more.",Math.abs(cake));
        }else{
            System.out.printf("%d pieces are left.",cake);
        }




    }
}
