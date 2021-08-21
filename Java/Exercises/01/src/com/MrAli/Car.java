package com.MrAli;

public class Car extends Vehicle {
    private int doors;
    private String model;
    private boolean isManual;

    public Car(int enginePower, int doors, String model, boolean isManual) {
        super(enginePower);
        this.doors = doors;
        this.model = model;
        this.isManual = isManual;
    }

    public void changeGear(int gear){
        System.out.println("Your gear has been changed to " + gear);
    }
}
