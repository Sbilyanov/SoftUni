import java.util.Scanner;

public class TrainingLab {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double h = Double.parseDouble(scanner.nextLine());//15
        double w = Double.parseDouble(scanner.nextLine());//8.9

        //Залата е широка 890 cm. От тях 100 cm отиват за коридора в средата. В останалите 790 cm могат да се разположат по 11 бюра на ред (11 * 70 cm = 770 cm + 20 cm остатък).
        //Залата е дълга 1500 cm. В тях могат да бъдат разположени 12 реда (12 * 120 cm = 1440 + 60 cm остатък).
        //Брой места = 12 * 11 - 3 =  132 - 3 = 129 (имаме 12 реда по 11 места = 132 минус 3 места за катедра и входна врата).

        int desksWide = 70;
        int desksLength = 120;
        int catedra = 3;
        int corridor = 100;
        double desksNumberWide = Math.floor((w * 100 - corridor) / desksWide);
        double desksNumberLength = Math.floor(h * 100 / desksLength);
        double seatCount = desksNumberWide * desksNumberLength - catedra;
        System.out.printf("%.0f", seatCount);


    }
}

