import java.util.Scanner;

public class PaintingEggs {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        //Първи ред – размер на яйцата – текст с възможности "Large", "Medium" или "Small"
        //Втори ред – цвят на яйцата – текст  с възможности "Red", "Green" или "Yellow"
        //Трети ред – брой партиди – цяло число в интервала [1… 350]

        String size =scanner.nextLine();
        String color= scanner.nextLine();
        int pack=Integer.parseInt(scanner.nextLine());
        int sales=0;

        double profit=0;

        //	        (Red)	 (Green)	  (Yellow)
        // (Large)	16 лв.	  12 лв.	     9 лв.
        // (Medium)	13 лв.  	9 лв.	     7 лв.
        // (Small)	9 лв.   	8 лв.	     5 лв.

        switch (size){
            case "Large":
                if(color.equals("Red")){
                    sales=pack*16;
                }else if(color.equals("Green")){
                    sales=pack*12;
                }else {
                    sales=pack*9;
                }
                break;
            case "Medium":
                if(color.equals("Red")){
                    sales=pack*13;
                }else if(color.equals("Green")){
                    sales=pack*9;
                }else {
                    sales=pack*7;
                }
                break;
            case"Small":
                if(color.equals("Red")){
                    sales=pack*9;
                }else if(color.equals("Green")){
                    sales=pack*8;
                }else {
                    sales=pack*5;
                }
                break;
        }

        profit=sales-(sales*0.35);
        System.out.printf("%.2f leva.",profit);

    }
}
