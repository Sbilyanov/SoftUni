import java.util.Scanner;

public class Renovation {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        //Височина на стената - цяло число [0… 100]
        //Ширина на стената - цяло число [0… 100]
        //Процент от общата площ на стените, който няма да бъде боядисан - цяло число [5… 95]
        //На следващите редове до получаване на командата "Tired!" или докато не бъдат боядисани всички стени, се чете по едно число:
        //Литри боя – цяло число [0…100]:

        int height = Integer.parseInt(scanner.nextLine());
        int wight = Integer.parseInt(scanner.nextLine());
        int percentage = Integer.parseInt(scanner.nextLine());
        double surface = (wight*height*4);
        surface=surface-((surface*percentage)/100);
        String input = scanner.nextLine();
        while (!input.equals("Tired!")){
            int currentPaint =Integer.parseInt(input);
            surface-=currentPaint;
            if(surface<0){
                System.out.printf("All walls are painted and you have %.0f l paint left!",Math.abs(surface));
                return;
            }else if(surface==0){
                System.out.println("All walls are painted! Great job, Pesho!");
                return;
            }


            input=scanner.nextLine();
        }
        System.out.printf("%.0f quadratic m left.",Math.abs(surface));
    }
}
