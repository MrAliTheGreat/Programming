package com.MrAli;

public class Deluxe extends Hamburger {

    public Deluxe(String breadType, String meatType) {
        super(breadType, meatType);
        double newPrice = super.getPrice();
        int newAddition = super.getAdditions();
        System.out.println("Deluxe Burger: Burger: 15$ + Chips: 8$ + Drinks: 5$");
        newPrice+=13;
        newAddition+=2;
        super.setPrice(newPrice);
        super.setAdditions(newAddition);
    }

    @Override
    public void addLettuce() {
        System.out.println("You can't add any additions to deluxe burger!");
    }

    @Override
    public void addTomato() {
        System.out.println("You can't add any additions to deluxe burger!");
    }

    @Override
    public void addCarrot() {
        System.out.println("You can't add any additions to deluxe burger!");
    }

    @Override
    public void addCheese() {
        System.out.println("You can't add any additions to deluxe burger!");
    }
}
