package com.MrAli;

import java.util.Scanner;

public class Main {

    private static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        System.out.println("Options: ");
        System.out.println("\t 1. Print Options");
        System.out.println("\t 2. Print Contacts");
        System.out.println("\t 3. Add new contact");
        System.out.println("\t 4. Update existing contact");
        System.out.println("\t 5. Remove contact");
        System.out.println("\t 6. Search for a contact");
        System.out.println("\t 7. Quit");

        MobilePhone apple = new MobilePhone();
        boolean flag = true;
        while (flag) {
            System.out.println("\nChoose your option: ");
            int input = scanner.nextInt();
            switch (input) {
                case 1:
                    System.out.println("Options: ");
                    System.out.println("\t 1. Print Options");
                    System.out.println("\t 2. Print Contacts");
                    System.out.println("\t 3. Add new contact");
                    System.out.println("\t 4. Update existing contact");
                    System.out.println("\t 5. Remove contact");
                    System.out.println("\t 6. Search for a contact");
                    System.out.println("\t 7. Quit");
                    break;
                case 2:
                    apple.printContacts();
                    break;
                case 3:
                    System.out.print("Enter contact name: ");
                    scanner.nextLine();
                    String contactName = scanner.nextLine();
                    System.out.print("Enter phone number: ");
                    String contactNumber = scanner.nextLine();
                    apple.addContact(contactName, contactNumber);
                    break;
                case 4:
                    System.out.print("Enter contact name you want to change: ");
                    scanner.nextLine();
                    String currentName = scanner.nextLine();
                    System.out.print("Enter new name: ");
                    String newName = scanner.nextLine();
                    System.out.print("Enter new number: ");
                    String newNumber = scanner.nextLine();
                    apple.modifyContact(currentName, newName, newNumber);
                    break;
                case 5:
                    System.out.print("Enter the contact name you want to remove: ");
                    scanner.nextLine();
                    String removeName = scanner.nextLine();
                    apple.removeContact(removeName);
                    break;
                case 6:
                    System.out.print("Enter the contact name you want to find: ");
                    scanner.nextLine();
                    String searchName = scanner.nextLine();
                    apple.SearchContact(searchName);
                    break;
                case 7:
                    flag=false;
                    System.out.println("Quitting Contacts...");
                    break;
            }
        }

    }
}
