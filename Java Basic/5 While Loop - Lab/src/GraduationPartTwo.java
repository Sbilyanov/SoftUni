import java.util.Scanner;

public class GraduationPartTwo {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String name = scanner.nextLine();
        int counter =1;
        int excluded = 0;
        double sum =0;

        while (counter<=12){
        double grade = Double.parseDouble(scanner.nextLine());
            if(grade<4){
                excluded++;
                if (excluded > 1) {
                    System.out.printf("%s has been excluded at %d grade%n",name,counter);
                    return;
                }continue;
            }
            counter++;
            sum += grade;
        }
        double average = sum/12;
        System.out.printf("%s graduated. Average grade: %.2f",name,average);

    }
}
