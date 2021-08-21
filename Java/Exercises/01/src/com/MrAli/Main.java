package com.MrAli;

public class Main {

    public static void main(String[] args) {
        Benz sls= new Benz("SLS","VIP");
        sls.accelerate(10,0);
        System.out.println(sls.getSpeed());
        sls.accelerate(80,0);
        System.out.println(sls.getSpeed());
        sls.accelerate(100,0);
        System.out.println(sls.getSpeed());
        sls.accelerate(150,0);
        System.out.println(sls.getSpeed());
    }
}
