//Create a music player list using appropriate linked list structure in which user can
// Add songs
// Play song backward and forward
// Delete any song from the list 
using System;
namespace Doublezack
{
    // Node class for song
    public class Song
    {
        public string title;
        public Song next;
        public Song prev;
        public Song(string name)
        {title = name;}
    }
    // Music Playlist using Doubly Linked List
    public class MusicPlaylist
    {public Song head;
        public void AddSong(string songName)
        {Song newSong = new Song(songName);
            if (head == null)
            {head = newSong;
                Console.WriteLine($"Song '{songName}' added as the first song.");
                return;}
            Song temp = head;
            while (temp.next != null)
            {temp = temp.next;
            }temp.next = newSong;
            newSong.prev = temp;
            Console.WriteLine($"Song '{songName}' added to playlist.");
        }
        // Play songs forward
        public void PlayForward()
        {if (head == null)
            {Console.WriteLine("Playlist is empty!");
                return;}
            Console.WriteLine("\nPlaying songs forward:");
            Song temp = head;
            while (temp != null)
            {Console.WriteLine($"Playing: {temp.title}");
                temp = temp.next;}
        }
        // Play songs backward
        public void PlayBackward()
        {if (head == null)
            {Console.WriteLine("Playlist is empty!");
                return;}
        Song temp = head;
            while (temp.next != null)
            {temp = temp.next;}
            Console.WriteLine("\nPlaying songs backward:");
            while (temp != null){
                Console.WriteLine($"Playing: {temp.title}");
                temp = temp.prev;}
        }
        // Delete a song by name
        public void DeleteSong(string songName)
        {if (head == null)
            {Console.WriteLine("Playlist is empty!");
                return;}
        Song temp = head;
        // If head song is to be deleted
            if (temp.title == songName)
            {head = temp.next;
                if (head != null){
                    head.prev = null;
                }
                Console.WriteLine($"Song '{songName}' deleted from playlist.");
                return;
            }
            while (temp != null && temp.title != songName)
            {temp = temp.next;}
            if (temp == null)
            {Console.WriteLine($"Song '{songName}' not found in playlist.");
                return;}
            if (temp.next != null){
                temp.next.prev = temp.prev;
            }
            if (temp.prev != null)
            {temp.prev.next = temp.next;}
            Console.WriteLine($"Song '{songName}' deleted from playlist.");
        }
    }
    // Main Program
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicPlaylist playlist = new MusicPlaylist();

            playlist.AddSong("Shape of You");
            playlist.AddSong("Believer");
            playlist.AddSong("Perfect");
            playlist.AddSong("Senorita");
            playlist.PlayForward();
            playlist.PlayBackward();
            Console.WriteLine("\nDeleting 'Perfect'...");
            playlist.DeleteSong("Perfect");
            playlist.PlayForward();
            Console.WriteLine("\nDeleting 'Shape of You'...");
            playlist.DeleteSong("Shape of You");
            playlist.PlayForward();
        }
    }
}
