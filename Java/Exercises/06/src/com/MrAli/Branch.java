package com.MrAli;

import java.util.ArrayList;

public class Branch {

    private ArrayList<Customer> customers = new ArrayList<Customer>();
    private String name;

    public Branch(String name) {
        this.name = name;
    }

    public void addCustomer(String name){
        if (findCustomer(name)){
            Customer newCustomer = Customer.createCustomer(name);
            customers.add(newCustomer);
            System.out.println("New customer " + name + " joined the branch");
        }else{
            System.out.println(name + " already exists!");
        }
    }

    public void transaction(String name , double amount){
        if (findCustomerIndex(name) == -1){
            System.out.println("Customer not found!");
        }else{
            double lastAmount = this.customers.get(findCustomerIndex(name)).getTransactions().get(this.customers.get(findCustomerIndex(name)).getTransactions().size()-1);
            if (lastAmount+amount>=0) {
                this.customers.get(findCustomerIndex(name)).getTransactions().add(lastAmount + amount);
                System.out.println("The amount was added successfully");
            }else{
                System.out.println("The amount is not valid!");
            }
        }
    }

    private int findCustomerIndex(String name){
        for (int i=0 ; i<this.customers.size() ; i++){
            if (name.equals(this.customers.get(i).getName())){
                return i;
            }
        }
        return -1;
    }

    private boolean findCustomer(String name){
        for (int i=0 ; i<this.customers.size() ; i++){
            if (name.equals(this.customers.get(i).getName())){
                return false;
            }
        }
        return true;
    }

    public ArrayList<Customer> getCustomers() {
        return customers;
    }

    public String getName() {
        return name;
    }
}
