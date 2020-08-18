import java.util.Scanner;

public class Scholarship {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double income = Double.parseDouble(scanner.nextLine());//300
        double score = Double.parseDouble(scanner.nextLine());//5.65
        double minSalary = Double.parseDouble(scanner.nextLine());//420

        double socialScholarship = 0;
        double gradeScholarship = 0;

        if (income < minSalary && score >= 4.5){
            socialScholarship = Math.floor(minSalary * 0.35);
        }

        if (score>=5.5){
            gradeScholarship = Math.floor(score * 25);
        }

        if(socialScholarship>gradeScholarship) {
            System.out.printf("You get a Social scholarship %.0f BGN", socialScholarship);
        }else if (gradeScholarship>socialScholarship) {
            System.out.printf("You get a scholarship for excellent results %.0f BGN", gradeScholarship);
        }else {
            System.out.println("You cannot get a scholarship!");
        }

    }
}
