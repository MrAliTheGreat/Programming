package com.MrAli;

public class Test {
    private int size;
    private String name;

    public Test(int size, String name) {
        this.size = size;
        this.name = name;
    }

    public Test(){
        this(10,"Default");
    }

    public int getSize() {
        return size;
    }

    public String getName() {
        return name;
    }
}
