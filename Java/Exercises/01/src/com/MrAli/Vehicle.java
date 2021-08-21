package com.MrAli;

public class Vehicle {

    private int enginePower;
    private int speed;
    private int direction;

    public Vehicle(int enginePower) {
        this.enginePower = enginePower;
        this.speed = 0;
        this.direction = 0;
    }

    public void changeSpeedAndDirection(int speed , int direction){
        this.speed+=speed;
        this.direction+=direction;
        System.out.println("The Vehicle is moving " + this.speed + " km/h in " + this.direction + " degree");

    }

    public int currentSpeed(int speed){
        int speed2 = this.speed+speed;
        return speed2;
    }

    public int getSpeed() {
        return this.speed;
    }

    public int getDirection() {
        return direction;
    }
}
