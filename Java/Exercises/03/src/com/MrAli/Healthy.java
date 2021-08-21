package com.MrAli;

public class Healthy extends Hamburger {

    public Healthy(String meatType) {
        super("Brown rye", meatType);
    }

    public void addOnion(){
        double newPrice=super.getPrice();
        int newAddition=super.getAdditions();
        System.out.println("You have added onion to your healthy burger -> 5.0$");
        newPrice+=5;
        super.setPrice(newPrice);
        super.setAdditions(++newAddition);
    }

    public void addPotato(){
        double newPrice=super.getPrice();
        int newAddition=super.getAdditions();
        System.out.println("You have added potato to your healthy burger -> 6.0$");
        newPrice+=6;
        super.setPrice(newPrice);
        super.setAdditions(++newAddition);
    }
}
