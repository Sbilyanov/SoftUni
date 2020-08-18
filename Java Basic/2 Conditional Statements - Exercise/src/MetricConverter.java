import java.util.Scanner;

public class MetricConverter {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        //⦁	Първи ред: число за преобразуване - реално число
        //⦁	Втори ред: входна мерна единица - текст
        //⦁	Трети ред: изходна мерна единица (за резултата) - текст
        double number = Double.parseDouble(scanner.nextLine());
        String inputMetric = scanner.nextLine();
        String outputMetric = scanner.nextLine();
        // преобразуваме началното число в метри

         if (inputMetric.equals("mm")){
             number= number / 1000;
         } else if(inputMetric.equals("cm")){
             number = number / 100;
         }
         if(outputMetric.equals("mm")){
             number = number * 1000;
         } else if(outputMetric.equals("cm")){
             number = number * 100;
         }
        System.out.printf("%.3f",number);

    }
}
