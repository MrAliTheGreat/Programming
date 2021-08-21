package com.MrAli;

import java.util.LinkedList;
import java.util.ListIterator;

public class Album {
    private LinkedList<Song> songs = new LinkedList<Song>();
    private String name;
    public Album(String name) {
        this.name = name;
    }

    public void addSongs(Song song) {
        songs.add(song);
    }

    public void printSongs() {
        int i = 1;
        ListIterator<Song> iterator = songs.listIterator();
        while (iterator.hasNext()) {
            System.out.println(i + ". " + iterator.next().getName());
            i++;
        }
    }

    public String getName() {
        return name;
    }

    public LinkedList<Song> getSongs() {
        return songs;
    }
}
