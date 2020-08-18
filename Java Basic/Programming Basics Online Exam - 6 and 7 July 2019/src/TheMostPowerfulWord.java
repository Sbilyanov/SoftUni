import java.util.Scanner;

public class TheMostPowerfulWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String winennerWord ="";
        double winnerScore =Double.MIN_VALUE;

        String word = scanner.nextLine();

        while (!word.equals("End of words")) {
            double total = 0;
            for (int i = 0; i < word.length(); i++) {
                int currentChar = word.charAt(i);
                total += currentChar;

            }
            String firstLetter = word.toLowerCase();
            switch (firstLetter.charAt(0)) {
                case ('a'):
                case ('e'):
                case ('i'):
                case ('o'):
                case ('u'):
                case ('y'):
                    total = total * word.length();
                    break;
                default:
                    total= total/word.length();
                    break;
            }

            if(total>winnerScore){
                winnerScore=total;
                winennerWord=word;
            }

            word=scanner.nextLine();
        }
        System.out.printf("The most powerful word is %s - %.0f",winennerWord,Math.floor(winnerScore));
    }
}
