package com.MrAli;

public class House {
    private Room room1;
    private Room room2;
    private Room room3;
    private String type;

    public House(Room room1, Room room2, Room room3, String type) {
        this.room1 = room1;
        this.room2 = room2;
        this.room3 = room3;
        this.type = type;
    }

    public House(){
    }

    public void price(int money){
        System.out.println("The price of the house is " + money +" $");
    }

    public void roomRestricted(){
        getRoom1().cleanRoom(1);
    }

    private Room getRoom1() {
        return room1;
    }

    private Room getRoom2() {
        return room2;
    }

    private Room getRoom3() {
        return room3;
    }

    public String getType() {
        return type;
    }
}
