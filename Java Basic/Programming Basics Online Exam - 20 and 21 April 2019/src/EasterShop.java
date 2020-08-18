import java.util.Scanner;

public class EasterShop {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int eggStock = Integer.parseInt(scanner.nextLine());
        String command  =scanner.nextLine();
        int eggSold=0;

        while (!command.equals("Close")) {
            int currentEgg = Integer.parseInt(scanner.nextLine());

            if (command.equals("Buy")) {
                eggSold+=currentEgg;
                if(eggStock<currentEgg){
                    System.out.println("Not enough eggs in store!");
                    System.out.printf("You can buy only %d.",eggStock);
                    return;
                }
                eggStock -= currentEgg;

            }
            if (command.equals("Fill")) {
                eggStock += currentEgg;}

                command = scanner.nextLine();
        }
        System.out.println("Store is closed!");
        System.out.printf("%d eggs sold.",eggSold);

    }
}
