import java.util.Scanner;

public class PasswordGenerator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        int m = Integer.parseInt(scanner.nextLine());

        for (int i = 1; i < n ; i++) {

            for (int j = 1; j < n; j++) {

                for (char k = 'a'; k <'a'+m ; k++) {

                    for (char l = 'a'; l <'a' +m; l++) {

                        for (int o = 2; o <=n ; o++) {
                            if(o>i && o>j){
                                System.out.printf("%d%d%c%c%d ",i,j,k,l,o);
                            }

                        }

                    }

                }

            }

        }
    }
}
