import java.util.Scanner;

public class ProjectCreation {
    public static void main(String[] args) {
        Scanner scanner=new Scanner(System.in);

        String architectName = scanner.nextLine();
        int projectnumber = Integer.parseInt(scanner.nextLine());
        int totalhours = projectnumber * 3;

        System.out.printf("The architect %s will need %d hours to complete %d project/s.",architectName,totalhours,projectnumber );

    }
}
