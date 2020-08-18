import java.util.Scanner;

public class SumOfTwoNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int startNum = Integer.parseInt(scanner.nextLine());
        int endNum = Integer.parseInt(scanner.nextLine());
        int magicNum = Integer.parseInt(scanner.nextLine());

        int combinationNum = 0;
        boolean flag = false;
        String output ="";

        for (int i = startNum; i <=endNum ; i++) {
            for (int j = startNum; j <= endNum; j++) {
                combinationNum++;
                if (i + j == magicNum) {
                    output =String.format("Combination N:%d (%d + %d = %d)", combinationNum, i, j, magicNum);
                    flag =true;
                    break;
                }
            }

            if(flag){
                break;
            }

        }
        if (flag) {
            System.out.println(output);
        } else {
            System.out.printf("%d combinations - neither equals %d", combinationNum, magicNum);

        }

    }
}
