package com.MrAli;

public class Animal {
    private int weight;
    private String name;

    public Animal(int weight , String name){
        this.weight=weight;
        this.name=name;
    }

    public void move(){
        System.out.println("Animal is moving!");
    }
}
