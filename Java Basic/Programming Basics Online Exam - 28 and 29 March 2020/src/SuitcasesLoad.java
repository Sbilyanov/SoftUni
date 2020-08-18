import java.util.Scanner;

public class SuitcasesLoad {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double totalCaseVolume = 0;
        int caseNum = 0;
        int caseLoaded = 0;

        double totalSpaceAvailable = Double.parseDouble(scanner.nextLine());
        ;
        String input = scanner.nextLine();
        boolean flag = false;


        while (!input.equals("End")) {

            caseNum += 1;
            double currentCaseVolume = Double.parseDouble(input);
            if (caseNum % 3 == 0) {
                currentCaseVolume = currentCaseVolume + (currentCaseVolume * 0.10);
            }
            totalCaseVolume += currentCaseVolume;
            if (totalCaseVolume > totalSpaceAvailable) {
                flag = true;
                break;
            }
            caseLoaded += 1;
            input = scanner.nextLine();
            if (flag) {
                break;
            }
        }
        if (flag) {
            System.out.println("No more space!");
        } else {
            System.out.println("Congratulations! All suitcases are loaded!");
        }

        System.out.printf("Statistic: %d suitcases loaded.", caseLoaded);
    }
}
