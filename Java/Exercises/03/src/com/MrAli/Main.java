package com.MrAli;

public class Main {

    public static void main(String[] args) {
        Hamburger bigMac = new Healthy("Goat");
        System.out.println("Bread Type is: " + bigMac.getBreadType());
        System.out.println("Meat Type is: " + bigMac.getMeatType());
        bigMac.addCheese();
        bigMac.addCarrot();
        ((Healthy) bigMac).addPotato();
        ((Healthy) bigMac).addOnion();
        bigMac.addTomato();
        bigMac.addLettuce();
        System.out.println("Number of additions: " + bigMac.getAdditions());
        System.out.println("Bread + Meat: 15.0$");
        System.out.println("Additions: " + (bigMac.getPrice()-15) + "$");
        System.out.println("Total Price is: " + bigMac.getPrice() + "$");
    }
}
