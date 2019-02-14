import java.util.*;

public class NameGenerator {
    static Scanner wars = new Scanner(System.in);

    public static void main(String[] args) {


        //Prompt for User's Name
        String first, last, mother, city, car,Starwarsname;
        //int end=0;


        System.out.printf("Please state your First Name");
        first = wars.nextLine();//wars.Line(0, 2);

        System.out.printf("Please state your Last name");
        last = wars.nextLine();
//        last1 = wars.nextLine();

        System.out.printf("Please state your mothers maiden name");
        mother = wars.nextLine();

        System.out.printf("Please state the city you were born in ");
        city = wars.nextLine();

        System.out.printf("Please state your first car");
        car = wars.nextLine();

        Starwarsname = first +" "+ last +" "+ mother +" "+ city + " of " + last +" "+ car;
        System.out.println("In a galaxy far, far away you are known as " + Starwarsname +
                "        MAY THE FORCE be with you!");
    }
}