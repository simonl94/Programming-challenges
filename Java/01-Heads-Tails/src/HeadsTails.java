public class HeadsTails {

    public static void main(String[] args) {

        int result = (Math.random() <= 0.5) ? 1 : 2;

        if(result == 1)
            System.out.println("It's heads!");

        else
            System.out.print("It's tails!");
    }
}
