import java.util.Scanner;

public class Building {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int floor = Integer.parseInt(scanner.nextLine());
        int apartment = Integer.parseInt(scanner.nextLine());

        for (int i = floor; i >0 ; i--) {
            for (int j = 0; j <apartment ; j++){
                if(floor==i){
                    System.out.print("L"+i+j+" ");
                }else if(i%2==0){
                    System.out.print("O"+i+j+" ");
                }else {
                    System.out.print("A"+i+j+" ");
                }
            }
            System.out.println();
        }
    }
}
