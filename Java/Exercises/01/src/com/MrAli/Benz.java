package com.MrAli;

public class Benz extends Car{

    private String service;
    private int maxGear;

    public Benz(String model, String service) {
        super( 16000, 4, model, true);
        this.service = service;
        this.maxGear = 6;
    }

    public void accelerate(int speed,int direction){
        if (currentSpeed(speed)==0){
            changeSpeedAndDirection(speed,direction);
            changeGear(1);
        }else if (currentSpeed(speed)>0 && currentSpeed(speed)<=40){
            changeSpeedAndDirection(speed,direction);
            changeGear(2);
        }else if (currentSpeed(speed)>40 && currentSpeed(speed)<=80){
            changeSpeedAndDirection(speed,direction);
            changeGear(3);
        }else if (currentSpeed(speed)>80 && currentSpeed(speed)<=120){
            changeSpeedAndDirection(speed,direction);
            changeGear(4);
        }else if (currentSpeed(speed)>120 && currentSpeed(speed)<=160){
            changeSpeedAndDirection(speed,direction);
            changeGear(5);
        }else if (currentSpeed(speed)>160 && currentSpeed(speed)<=200){
            changeSpeedAndDirection(speed,direction);
            changeGear(6);
        }else{
            System.out.println("Can't go higher than gear 6");
        }
    }
}
