package com.MrAli;

import java.util.Scanner;

public class Main {

    private static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        printOptions();
        Bank melli = new Bank();
        String name;
        String customerName;
        boolean quit = false;
        while (!quit) {
            System.out.println("Choose Your Option:");
            int option = scanner.nextInt();
            switch (option) {
                case 1:
                    printOptions();
                    break;
                case 2:
                    scanner.nextLine();
                    System.out.println("What is the name of the branch?");
                    name = scanner.nextLine();
                    melli.addBranch(name);
                    break;
                case 3:
                    scanner.nextLine();
                    System.out.println("Which branch?");
                    name = scanner.nextLine();
                    melli.printCustomers(name);
                    System.out.println("Do you Want the transactions too? (0 = NO , 1 = YES)");
                    int input = scanner.nextInt();
                    melli.printCustomers(name,input);
                    break;
                case 4:
                    scanner.nextLine();
                    System.out.println("Which branch?");
                    name = scanner.nextLine();
                    System.out.println("Name of the customer?");
                    customerName = scanner.nextLine();
                    melli.addCustomerToBranch(name , customerName);
                    break;
                case 5:
                    scanner.nextLine();
                    System.out.println("Which branch?");
                    name = scanner.nextLine();
                    System.out.println("Name of the customer?");
                    customerName = scanner.nextLine();
                    System.out.println("amount?");
                    double amount = scanner.nextDouble();
                    melli.makeTransaction(name,customerName,amount);
                    break;
                case 6:
                    quit=true;
                    System.out.println("Quitting Program...");
                    break;
            }
        }
    }

    public static void printOptions() {
        System.out.println("Options: ");
        System.out.println("\t1. Print Options");
        System.out.println("\t2. Create Branch");
        System.out.println("\t3. Print Customers");
        System.out.println("\t4. Add Customer");
        System.out.println("\t5. make Transaction");
        System.out.println("\t6. Quit");
    }
}
