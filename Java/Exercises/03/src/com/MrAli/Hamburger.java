package com.MrAli;

public class Hamburger {
    private String breadType;
    private String meatType;
    private double price;
    private int additions = 0;

    // Price of the bread is 5$
    // Price of the meat is 10$

    public Hamburger(String breadType, String meatType) {
        this.breadType = breadType;
        this.meatType = meatType;
        this.price=15;
    }

    public Hamburger() {
        this("Whole Grain", "Lamb");
    }

    public void addLettuce() {
        this.price += 3;
        System.out.println("You have added lettuce to Your Burger -> 3.0$");
        additions++;
    }

    public void addTomato() {
        this.price += 4;
        System.out.println("You have added tomato to Your Burger -> 4.0$");
        additions++;
    }

    public void addCarrot() {
        this.price += 2;
        System.out.println("You have added carrot to Your Burger -> 2.0$");
        additions++;
    }

    public void addCheese() {
        this.price += 7;
        System.out.println("You have added cheese to Your Burger -> 7.0$");
        additions++;
    }

    public double getPrice() {
        return this.price;
    }

    public String getBreadType() {
        return breadType;
    }

    public String getMeatType() {
        return meatType;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public int getAdditions() {
        return this.additions;
    }

    public void setAdditions(int additions) {
        this.additions = additions;
    }
}
