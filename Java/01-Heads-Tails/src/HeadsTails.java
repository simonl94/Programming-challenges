import java.util.Random;

public class HeadsTails {

    public static void main(String[] args) {
        Random rnd = new Random();
        int result = rnd.nextInt(2);

        if(result == 1)
            System.out.println("It's heads!");

        else
            System.out.print("It's tails!");
    }
}
