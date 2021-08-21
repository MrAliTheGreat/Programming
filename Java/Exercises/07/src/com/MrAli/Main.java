package com.MrAli;

import java.util.Scanner;

public class Main {

    private static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        boolean quit = false;
        MusicApp soundcloud = new MusicApp();
        String name;
        String duration;
        printOptions();

        while (!quit) {
            System.out.println("Choose Your Option: ");
            int option = scanner.nextInt();
            scanner.nextLine();
            switch (option) {
                case 1:
                    System.out.println("Enter name of the album you want to create: ");
                    soundcloud.createAlbum(scanner.nextLine());
                    break;

                case 2:
                    System.out.println("Enter name of the playlist you want to create: ");
                    soundcloud.createPlaylist(scanner.nextLine());
                    break;

                case 3:
                    System.out.println("Enter name of the album: ");
                    soundcloud.printAlbumSongs(scanner.nextLine());
                    break;

                case 4:
                    System.out.println("Enter name of the playlist: ");
                    soundcloud.printPlaylistSongs(scanner.nextLine());
                    break;

                case 5:
                    System.out.println("Enter name of the Album: ");
                    String albumName = scanner.nextLine();
                    System.out.println("Enter name of the song: ");
                    name = scanner.nextLine();
                    System.out.println("Enter duration of the song: ");
                    duration = scanner.nextLine();

                    Song song = new Song(name, duration);
                    soundcloud.addSongsToAlbum(song, albumName);
                    break;

                case 6:
                    System.out.println("Enter name of the playlist: ");
                    String playlistName = scanner.nextLine();
                    System.out.println("Enter name of the song: ");
                    name = scanner.nextLine();

                    soundcloud.addSongsToPlaylist(playlistName, soundcloud.findSongInAlbum(name));
                    break;

                case 7:
                    printOptions();
                    break;

                case 8:
                    System.out.println("Enter name of the playlist: ");
                    String optionPlaylistName = scanner.nextLine();
                    printPlaylistOptions();
                    soundcloud.findPlaylist(optionPlaylistName).movement();
                    break;

                case 9:
                    System.out.println("Quitting Music App...");
                    quit = true;
                    break;
            }
        }
    }

    private static void printOptions() {
        System.out.println("Options: ");
        System.out.println("\t1. Create Album");
        System.out.println("\t2. Create Playlist");
        System.out.println("\t3. Print Album Songs");
        System.out.println("\t4. Print Playlist Songs");
        System.out.println("\t5. Add Songs to Album");
        System.out.println("\t6. Add Songs to Playlist");
        System.out.println("\t7. Print Options");
        System.out.println("\t8. Playlist Options");
        System.out.println("\t9. Quit");
    }

    private static void printPlaylistOptions() {
        System.out.println("Playlist Options: ");
        System.out.println("\t1. Next Song");
        System.out.println("\t2. Previous Song");
        System.out.println("\t3. Replay Song");
        System.out.println("\t4. Quit");
    }
}