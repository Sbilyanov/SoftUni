import java.util.Scanner;

public class TradeCommissions {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String town = scanner.nextLine();
        double sales  =Double.parseDouble(scanner.nextLine());

        //Град	0 ≤ s ≤ 500	500 < s ≤ 1 000	1 000 < s ≤ 10 000	s > 10 000
        //Sofia	    5%	          7%	            8%	       12%
        //Varna	   4.5%        	7.5%	            10%	       13%
        //Plovdiv	5.5%	      8%	            12%	      14.5%
        double commissions = 0;
         if (town.equals("Sofia")){
             if (0<= sales&& sales <= 500) {
                 commissions = sales * 0.05;
                 System.out.printf("%.2f", commissions);
             } else if(500< sales&& sales <= 1000) {
                 commissions = sales * 0.07;
                 System.out.printf("%.2f", commissions);
             }else if (1000<sales && sales <= 10000){
                commissions = sales *0.08;
                 System.out.printf("%.2f", commissions);
             }else if(10000<sales){
                 commissions = sales * 0.12;
                 System.out.printf("%.2f", commissions);
             }else {
                 System.out.println("error");
             }
         }else if (town.equals("Varna")){
             if (0<= sales&& sales <= 500) {
                 commissions = sales * 0.045;
                 System.out.printf("%.2f", commissions);
             } else if(500< sales&& sales <= 1000) {
                 commissions = sales * 0.075;
                 System.out.printf("%.2f", commissions);
             }else if (1000<sales && sales <= 10000){
                 commissions = sales *0.1;
                 System.out.printf("%.2f", commissions);
             }else if(10000<sales){
                 commissions = sales * 0.13;
                 System.out.printf("%.2f", commissions);
             }else {
                 System.out.println("error");
             }
         }else if (town.equals("Plovdiv")){
             if (0<= sales&& sales <= 500) {
                 commissions = sales * 0.055;
                 System.out.printf("%.2f", commissions);
             } else if(500< sales&& sales <= 1000) {
                 commissions = sales * 0.08;
                 System.out.printf("%.2f", commissions);
             }else if (1000<sales && sales <= 10000){
                 commissions = sales *0.12;
                 System.out.printf("%.2f", commissions);
             }else if(10000<sales){
                 commissions = sales * 0.145;
                 System.out.printf("%.2f", commissions);
             }else {
                 System.out.println("error");
             }
         }else {
             System.out.println("error");
         }
    }
}
