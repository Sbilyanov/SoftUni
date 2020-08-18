import java.util.Scanner;

public class TrainTheTrainers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int numberOfPeople = Integer.parseInt(scanner.nextLine());
        String presentation = scanner.nextLine();
        double averageGrade = 0;
        double allGrades = 0;
        double presentationCounter = 0;

        while (!presentation.equals("Finish")) {
            double allGradePerPresentation = 0;
            for (int i = 0; i < numberOfPeople; i++) {
                double currentGrade = Double.parseDouble(scanner.nextLine());
                allGradePerPresentation += currentGrade;
            }
            averageGrade = allGradePerPresentation / numberOfPeople;
            System.out.printf("%s - %.2f.%n", presentation, averageGrade);
            presentationCounter++;
                allGrades += averageGrade;

            presentation = scanner.nextLine();
        }
        System.out.printf("Student's final assessment is %.2f.", allGrades / presentationCounter);
    }
}
