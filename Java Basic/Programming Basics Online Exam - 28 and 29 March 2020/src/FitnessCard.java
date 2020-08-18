import java.util.Scanner;

public class FitnessCard {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        double moneyAvailable = Integer.parseInt(scanner.nextLine());
        String gender = scanner.nextLine();
        int age = Integer.parseInt(scanner.nextLine());
        String sport = scanner.nextLine();
        double cardCost=0;

        //Пол	Gym	Boxing	Yoga	Zumba	Dances	Pilates
        //мъж	$42	 $41	$45	    $34	     $51      $39
        //жена	$35	 $37	$42	    $31	     $53      $37
        //
        //Всички цени на карти за ученици (възраст под 19 години вкл.) са с 20% намаление.
        switch (sport){
            case"Gym":
                if(gender.equals("m")){
                    cardCost=42;
                }else if (gender.equals("f")){
                    cardCost=35;
                }
                break;
            case"Boxing":
                if(gender.equals("m")){
                    cardCost=41;
                }else if (gender.equals("f")){
                    cardCost=37;
                }
                break;
            case"Yoga":
                if(gender.equals("m")){
                    cardCost=45;
                }else if (gender.equals("f")){
                    cardCost=42;
                }
                break;
            case"Zumba":
                if(gender.equals("m")){
                    cardCost=34;
                }else if (gender.equals("f")){
                    cardCost=31;
                }
                break;
            case"Dances":
                if(gender.equals("m")){
                    cardCost=51;
                }else if (gender.equals("f")){
                    cardCost=53;
                }
                break;
            case"Pilates":
                if(gender.equals("m")){
                    cardCost=39;
                }else if (gender.equals("f")){
                    cardCost=37;
                }
                break;

        }
        if(age<=19){
           cardCost= cardCost*0.80;
        }

        if (moneyAvailable>=cardCost){
            System.out.printf("You purchased a 1 month pass for %s.",sport);
        }else {
            System.out.printf("You don't have enough money! You need $%.2f more.",Math.abs(moneyAvailable-cardCost));
        }


    }
}
