package com.MrAli;

import java.util.ArrayList;

public class Customer {

    private String name;
    private ArrayList<Double> transactions = new ArrayList<Double>();

    public Customer(String name) {
        this.name = name;
        this.transactions.add(0.0);
    }

    public static Customer createCustomer(String name){
        return new Customer(name);
    }

    public String getName() {
        return name;
    }

    public ArrayList<Double> getTransactions() {
        return transactions;
    }
}
