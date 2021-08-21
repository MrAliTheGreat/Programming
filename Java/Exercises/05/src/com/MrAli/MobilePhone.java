package com.MrAli;

import java.util.ArrayList;

public class MobilePhone {
    private ArrayList<Contacts> phoneContacts = new ArrayList<Contacts>();

    public void addContact(String name, String number) {
        Contacts newContact = new Contacts(name, number);
        phoneContacts.add(newContact);
        System.out.println("New Contact Created");
    }

    public void modifyContact(String currentName, String newName, String newNumber) {
        Contacts newContact = new Contacts(newName, newNumber);
        if (findContact(currentName) >= 0) {
            phoneContacts.set(findContact(currentName), newContact);
            System.out.println("Contact of " + currentName + " Changed");
        } else {
            System.out.println("Contact with this name wasn't found!");
        }
    }

    public void removeContact(String name) {
        if (findContact(name) >= 0) {
            phoneContacts.remove(findContact(name));
            System.out.println(name + " is removed from contacts");
        } else {
            System.out.println("Contact with this name wasn't found!");
        }
    }

    public boolean SearchContact(String name) {
        if (findContact(name) >= 0){
            System.out.println(name + " found in contacts");
            return true;
        }
        System.out.println(name + " not found in contacts");
        return false;
    }

    public void printContacts() {
        if (phoneContacts.size() == 0) {
            System.out.println("No contact has yet been created!");
        } else {
            for (int i = 0; i < phoneContacts.size(); i++) {
                System.out.println((i + 1) + ". " + phoneContacts.get(i).getName() + " -> " + phoneContacts.get(i).getPhoneNumber());
            }
        }
    }

    private int findContact(String name) {
        for (int i = 0; i < phoneContacts.size(); i++) {
            if (name.equals(phoneContacts.get(i).getName())){
                return i;
            }
        }
        return -1;
    }
}
