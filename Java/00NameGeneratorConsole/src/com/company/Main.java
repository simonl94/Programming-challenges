package com.company;
import java.util.*;

public class Main {

   public static void main(String[] args) {
      //Scanner input = new Scanner(System.in);
      Random rnd = new Random();
      String[] mfname = {"Simon", "John", "Aaron", "Paul"}; // Creates a string array of male first names
      String[] mlname = {"Smith", "Lee", "Hill", "Tucker"}; //Creates a string array of male last names
      String[] ffname = {"Kelly", "Jess", "Helen", "Caitlyn"}; // Creates a string array of female first names
      String[] flname = {"Smith", "Lee", "Parker", "Hill"}; // Creates a string array of female last names


      System.out.println("Are you male or female? (M / F)"); //Prints a console question asking for a user input
      Scanner scanner = new Scanner (System.in); // Parses the user input into a Scanner variable
      String gender = scanner.next();
      if (gender.equals("M")) { // If the input is equal to 'M' then execute the following
         System.out.println("Your random name is " + mfname[rnd.nextInt(4)] + " " + mlname[rnd.nextInt(4)] + ".");
      }
      else { //Otherwise execute the following
         System.out.println("Your random name is " + ffname[rnd.nextInt(4)] + " " + flname[rnd.nextInt(4)] + ".");

      }
      scanner.close(); //Closes the scanner
   }
}