package com.MrAli;

public class Room {
    private int bed;
    private int windows;
    private String Chair;

    public Room(int bed, int windows, String chair) {
        this.bed = bed;
        this.windows = windows;
        Chair = chair;
    }

    public void cleanRoom(int number){
        System.out.println("The room number " + number + " has been cleaned");
    }

    public int getBed() {
        return bed;
    }

    public int getWindows() {
        return windows;
    }

    public String getChair() {
        return Chair;
    }
}
