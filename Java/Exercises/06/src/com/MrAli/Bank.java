package com.MrAli;

import java.util.ArrayList;

public class Bank {

    private ArrayList<Branch> branches = new ArrayList<Branch>();

    public void addBranch(String branchName) {
        if (findBranch(branchName)!= -1){
            System.out.println(branchName + " already exists!");
        }else {
            Branch branch = new Branch(branchName);
            branch.addCustomer("Default Customer");
            this.branches.add(branch);
            System.out.println("New branch added name -> " + branchName);
        }
    }

    public void printCustomers(String branchName) {
        if (findBranch(branchName)== -1){
            System.out.println("No branch with name " + branchName + " was found!");
        }else {
            int branchIndex = findBranch(branchName);
            for (int i = 0; i < this.branches.get(branchIndex).getCustomers().size(); i++) {
                System.out.println((i + 1) + ". " + this.branches.get(branchIndex).getCustomers().get(i).getName());
            }
        }
    }

    public void printCustomers(String branchName, int input) {
        if (findBranch(branchName)== -1){
            System.out.println("No branch with name " + branchName + " was found!");
        }else {
            int branchIndex = findBranch(branchName);
            if (input == 1) {
                for (int i = 0; i < this.branches.get(branchIndex).getCustomers().size(); i++) {
                    System.out.println((i + 1) + ". " + this.branches.get(branchIndex).getCustomers().get(i).getName());
                    for (int j = 0; j < this.branches.get(branchIndex).getCustomers().get(i).getTransactions().size(); j++) {
                        System.out.println(this.branches.get(branchIndex).getCustomers().get(i).getTransactions().get(j));
                    }
                }
            }
        }
    }

    public void addCustomerToBranch(String branchName , String customerName){
        if (findBranch(branchName)== -1){
            System.out.println("No branch with name " + branchName + " was found!");
        }else {
           this.branches.get(findBranch(branchName)).addCustomer(customerName);
        }
    }

    public void makeTransaction(String branchName , String customerName , double amount){
        if (findBranch(branchName)== -1){
            System.out.println("No branch with name " + branchName + " was found!");
        }else {
            this.branches.get(findBranch(branchName)).transaction(customerName,amount);
        }
    }

    private int findBranch(String name) {
        for (int i = 0; i < this.branches.size(); i++) {
            if (name.equals(this.branches.get(i).getName())) {
                return i;
            }
        }
        return -1;
    }
}
