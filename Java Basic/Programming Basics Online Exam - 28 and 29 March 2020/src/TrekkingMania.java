import java.util.Scanner;

public class TrekkingMania {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);



        int groupCount = Integer.parseInt(scanner.nextLine());
        double totalPeople = 0;
        double musalaCount=0;
        double montBalCount=0;
        double kilimanjaroCount=0;
        double k2Count=0;
        double everestCount =0;
        //Група до 5 човека– Мусала
        //Група от 6 до 12 – Монблан
        //Група от 13 до 25 – Килиманджаро
        //Група от 26 до 40 – К2
        //Група от 41 или повече – Еверест

        for (int i = 0; i < groupCount; i++) {
            int peopleCount = Integer.parseInt(scanner.nextLine());
            totalPeople += peopleCount;
            if(peopleCount<=5){
                musalaCount+=peopleCount;
            }else if (peopleCount<=12){
                montBalCount+=peopleCount;
            }else if(peopleCount<=25){
                kilimanjaroCount+=peopleCount;
            }else if(peopleCount<=40){
             k2Count+=peopleCount;
            }else {
                everestCount+=peopleCount;
            }
        }
        System.out.printf("%.2f%%%n",((musalaCount/totalPeople)*100));
        System.out.printf("%.2f%%%n",((montBalCount/totalPeople)*100));
        System.out.printf("%.2f%%%n",((kilimanjaroCount/totalPeople)*100));
        System.out.printf("%.2f%%%n",((k2Count/totalPeople)*100));
        System.out.printf("%.2f%%",((everestCount/totalPeople)*100));


    }
}
