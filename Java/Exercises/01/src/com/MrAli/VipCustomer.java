package com.MrAli;

public class VipCustomer {
    private String name;
    private double creditLimit;
    private String email;

    public VipCustomer(String name , double creditLimit , String email){
        System.out.println("Thank You! " + name + " for purchasing VIP account.");
        this.name=name;
        this.creditLimit=creditLimit;
        this.email=email;
    }
    public VipCustomer(){
        this("Admin" , 12 , "EmptyAdmin@email.com");
    }
    public VipCustomer(String name , double creditLimit){
        this(name,creditLimit,"2Admin@email.com");
    }

    public String getName() {
        return this.name;
    }

    public double getCreditLimit() {
        return this.creditLimit;
    }

    public String getEmail() {
        return this.email;
    }
}
