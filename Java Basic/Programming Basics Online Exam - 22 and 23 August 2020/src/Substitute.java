import java.util.Scanner;

public class Substitute {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int K = Integer.parseInt(scanner.nextLine());
        int L = Integer.parseInt(scanner.nextLine());
        int M = Integer.parseInt(scanner.nextLine());
        int N = Integer.parseInt(scanner.nextLine());
        int first = 0;
        int second = 0;
        int third = 0;
        int fourth = 0;
        int counter = 0;

        for (int i = K; i <= 8; i++) {
            first = i;
            for (int j = 9; j >= L; j--) {
                second = j;
                for (int k = M; k <= 8; k++) {
                    third = k;
                    for (int l = 9; l >= N; l--) {
                        fourth = l;
                        if ((first % 2 == 0) && (second % 2 != 0) && (third % 2 == 0) && (fourth % 2 != 0)) {
                            if ((first == third) && (second == fourth)) {
                                System.out.println("Cannot change the same player.");
                            } else {
                                System.out.printf("%d%d - %d%d%n", first, second, third, fourth);
                                counter++;
                                if (counter == 6){
                                    return;
                                }

                            }

                        }
                    }
                }
            }
        }
    }
}
