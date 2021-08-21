package com.MrAli;

import java.util.LinkedList;
import java.util.ListIterator;
import java.util.Scanner;

public class Playlist {
    private LinkedList<Song> songs = new LinkedList<Song>();
    private String name;
    private Scanner scanner = new Scanner(System.in);


    public Playlist(String name) {
        this.name = name;
    }

    public void addSongs(Song song) {
        songs.add(song);
    }


    public String getName() {
        return name;
    }

    public void printSongs() {
        int i = 1;
        ListIterator<Song> iterator = songs.listIterator();
        while (iterator.hasNext()) {
            System.out.println(i + ". " + iterator.next().getName());
            i++;
        }
    }

    public void movement() {
        boolean playlistQuit = false;
        ListIterator<Song> iterator = songs.listIterator();
        boolean direction = true;
        while (!playlistQuit) {
            System.out.println("Choose Your Option: ");
            int input = scanner.nextInt();
            switch (input) {
                case 1:
                    if (!direction) {
                        iterator.next();
                        direction = true;
                    }
                    if (iterator.hasNext()) {
                        System.out.println("Now Playing " + iterator.next().getName());
                    } else {
                        System.out.println("End of the playlist!");
                    }
                    break;

                case 2:
                    if (direction) {
                        iterator.previous();
                        direction = false;
                    }
                    if (iterator.hasPrevious()) {
                        System.out.println("Now Playing " + iterator.previous().getName());
                    } else {
                        System.out.println("Start of the playlist!");
                    }
                    break;

                case 3:
                    System.out.println("Now Playing " + iterator.previous().getName());
                    iterator.next();
                    break;

                case 4:
                    System.out.println("Quitting Playlist Options...");
                    playlistQuit = true;
                    break;
            }
        }
    }

}
