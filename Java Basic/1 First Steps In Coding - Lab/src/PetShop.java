import java.util.Scanner;

public class PetShop {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int Dogs = Integer.parseInt(scanner.nextLine());
        int Animals = Integer.parseInt(scanner.nextLine());
        double DogFood = Dogs * 2.50;
        int AnimalFood = Animals * 4;


       System.out.println(DogFood + AnimalFood + " lv.");


    }
}
