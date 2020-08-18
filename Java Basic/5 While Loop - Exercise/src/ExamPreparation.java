import java.util.Scanner;

public class ExamPreparation {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int lowGradeCount = Integer.parseInt(scanner.nextLine());
        String taskName = scanner.nextLine();
        int currentGrade =0;
        String lastTaskName = "";
        int lowGrade =0;
        int problemSum = 0;
        int sumAllGrade =0;

        while (!taskName.equals("Enough")){
            currentGrade= Integer.parseInt(scanner.nextLine());
            lastTaskName=taskName;
            if(currentGrade<=4){
                lowGrade++;
                if (lowGrade==lowGradeCount){
                    System.out.printf("You need a break, %d poor grades.",lowGradeCount);
                    return;
                }

            }

            problemSum++;
            sumAllGrade+=currentGrade;
            taskName = scanner.nextLine();
        }
        double averageScore=1.0*sumAllGrade/problemSum;
        System.out.printf("Average score: %.2f%n",averageScore) ;
        System.out.printf("Number of problems: %d%n",problemSum);
        System.out.printf("Last problem: %s",lastTaskName) ;

    }
}
