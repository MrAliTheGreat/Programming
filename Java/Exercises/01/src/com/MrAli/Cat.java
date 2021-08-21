package com.MrAli;

public class Cat extends Animal {

    private int legs;
    private int nose;

    public Cat(int weight , String name , int legs , int nose){
        super(weight,name);
        this.legs=legs;
        this.nose=nose;
    }

    @Override
    public void move() {
        System.out.println("Cat is moving!");
        super.move();
    }
}
