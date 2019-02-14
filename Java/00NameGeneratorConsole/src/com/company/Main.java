package com.company;
import java.util.*;

public class Main {

   public static void main(String[] args) {
      //Scanner input = new Scanner(System.in);
      Random rnd = new Random();
      String[] mfname = {"Simon", "John", "Aaron", "Paul"};
      String[] mlname = {"Smith", "Lee", "Hill", "Tucker"};
      String[] ffname = {"Kelly", "Jess", "Helen", "Caitlyn"};
      String[] flname = {"Smith", "Lee", "Parker", "Hill"};


      System.out.println("Are you male or female? (M / F)");
      Scanner scanner = new Scanner (System.in);
      String gender = scanner.next();
      if (gender.equals("M")) {
         System.out.println("Your random name is " + mfname[rnd.nextInt(4)] + " " + mlname[rnd.nextInt(4)] + ".");
      }
      else {
         System.out.println("Your random name is " + ffname[rnd.nextInt(4)] + " " + flname[rnd.nextInt(4)] + ".");

      }
   }
}