package com.MrAli;


import java.util.ArrayList;
import java.util.LinkedList;

public class MusicApp {
    private ArrayList<Album> albums = new ArrayList<Album>();
    private LinkedList<Playlist> playlists = new LinkedList<Playlist>();

    public void printAlbumSongs(String albumName) {
        if (findAlbum(albumName).equals(null)) {
            System.out.println("No album with name " + albumName + " was found!");
        } else {
            System.out.println(albumName + ": ");
            findAlbum(albumName).printSongs();
        }
    }

    public void printPlaylistSongs(String playlistName) {
        if (findPlaylist(playlistName).equals(null)) {
            System.out.println("No album with name " + playlistName + " was found!");
        } else {
            System.out.println(playlistName + ": ");
            findPlaylist(playlistName).printSongs();
        }
    }

    public void createAlbum(String albumName) {
        Album album = new Album(albumName);
        albums.add(album);
        System.out.println("Album " + albumName + " created successfully!");
    }

    public void addSongsToAlbum(Song song, String albumName) {
        if (findAlbum(albumName).equals(null)) {
            System.out.println("No album with name " + albumName + " was found!");
        } else {
            findAlbum(albumName).addSongs(song);
            System.out.println("Song " + song.getName() + " was added to album " + albumName);
        }
    }

    public void createPlaylist(String name) {
        Playlist playlist = new Playlist(name);
        playlists.add(playlist);
        System.out.println("Playlist " + playlist.getName() + " was created Successfully!");
    }

    public void addSongsToPlaylist(String playlistName, Song song) {
        if (findPlaylist(playlistName).equals(null)) {
            System.out.println("No playlist with name " + playlistName + " was found!");
        } else {
            findPlaylist(playlistName).addSongs(song);
            System.out.println("Song " + song.getName() + " was added to playlist " + playlistName);
        }
    }

    private Album findAlbum(String name) {
        for (int i = 0; i < albums.size(); i++) {
            if (albums.get(i).getName().equals(name)) {
                return albums.get(i);
            }
        }
        return null;
    }

    public Playlist findPlaylist(String name) {
        for (int i = 0; i < playlists.size(); i++) {
            if (playlists.get(i).getName().equals(name)) {
                return playlists.get(i);
            }
        }
        return null;
    }

    public Song findSongInAlbum(String songName) {
        for (int i = 0; i < albums.size(); i++) {
            for (int j = 0; j < albums.get(i).getSongs().size(); j++) {
                if (albums.get(i).getSongs().get(j).getName().equals(songName)) {
                    return albums.get(i).getSongs().get(j);
                }
            }
        }
        return null;
    }
}
