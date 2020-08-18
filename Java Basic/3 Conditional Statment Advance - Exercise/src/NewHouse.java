import java.util.Scanner;

public class NewHouse {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String flower = scanner.nextLine();
        int countFlower = Integer.parseInt(scanner.nextLine());
        double budget = Double.parseDouble(scanner.nextLine());

        double result = 0;
        double difference = 0.0;
        double roses = countFlower * 5;
        double dahlia = countFlower * 3.8;
        double tulips = countFlower*2.8;
        double narcissus = countFlower*3;
        double gladiolus = countFlower*2.5;



        if (flower.equalsIgnoreCase("Roses")) {
            if (countFlower>80) {
                result = roses-(roses*0.1);
            }else if(countFlower<=80){
                result = roses;
            }
        }
        if (flower.equalsIgnoreCase("Dahlias")) {
            if(countFlower>90){
                result = dahlia-(dahlia*0.15);
            } else if (countFlower<=90) {
                result = dahlia;
            }
        }
        if (flower.equalsIgnoreCase("Tulips")) {
            if(countFlower>80){
                result = tulips-(tulips*0.15);
            } else if (countFlower<=80) {
                result = tulips;
            }
        }
        if (flower.equalsIgnoreCase("Narcissus")) {
            if(countFlower<120){
                result = narcissus+(narcissus*0.15);
            } else if (countFlower>=120) {
                result = narcissus;
            }
        }
        if (flower.equalsIgnoreCase("Gladiolus")) {
            if (countFlower<80) {
                result=gladiolus+(gladiolus*0.2);
            }else if(countFlower>=80){
                result=gladiolus;
            }
        }
        if(budget>=result){
            difference = budget-result;
            System.out.printf("Hey, you have a great garden with %d %s and %.2f leva left.", countFlower, flower, difference);

        }else{
            System.out.printf("Not enough money, you need %.2f leva more.", result-budget);
        }

    }
}