import java.util.Scanner;

public class SeriesCalculator {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String name = scanner.nextLine();
        int seasonCount= Integer.parseInt(scanner.nextLine());
        int episodeCount = Integer.parseInt(scanner.nextLine());
        double time = Double.parseDouble(scanner.nextLine());


        double totalTime = (((time*0.20+time)*episodeCount)*seasonCount)+(seasonCount*10);

        System.out.printf("Total time needed to watch the %s series is %.0f minutes.",name,Math.floor(totalTime));

    }
}
