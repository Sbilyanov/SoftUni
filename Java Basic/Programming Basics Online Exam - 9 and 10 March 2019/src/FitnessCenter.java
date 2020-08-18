import java.util.Scanner;

public class FitnessCenter {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int visitors= Integer.parseInt(scanner.nextLine());
            int backCounter =0;
            int chestCounter =0;
            int legsCounter =0;
            int absCounter =0;
            int shakeCounter =0;
            int barCounter =0;

        for (int i = 0; i <visitors ; i++) {
            String input = scanner.nextLine();
//текст ("Back", "Chest", "Legs", "Abs", "Protein shake"
            switch (input){
                case "Back":
                    backCounter++;
                    break;
                case"Chest":
                    chestCounter++;
                    break;
                case"Legs":
                    legsCounter++;
                    break;
                case"Abs":
                    absCounter++;
                    break;
                case"Protein shake":
                    shakeCounter++;
                    break;
                case"Protein bar":
                    barCounter++;
                    break;

            }

        }
        double  workoutCount=((1.0*backCounter+chestCounter+legsCounter+absCounter)/visitors)*100;
        double proteinCount = ((1.0*shakeCounter+barCounter)/visitors)*100;

        System.out.printf("%d - back%n",backCounter);
        System.out.printf("%d - chest%n",chestCounter);
        System.out.printf("%d - legs%n",legsCounter);
        System.out.printf("%d - abs%n",absCounter);
        System.out.printf("%d - protein shake%n",shakeCounter);
        System.out.printf("%d - protein bar%n",barCounter);
        System.out.printf("%.2f%% - work out%n",workoutCount);
        System.out.printf("%.2f%% - protein%n",proteinCount);

    }

}
