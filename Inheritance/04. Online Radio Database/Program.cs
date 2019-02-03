using System;
using System.Collections.Generic;

namespace _04.Online_Radio_Database
{
	class Program
	{
		static void Main(string[] args)
		{
			int songCount = int.Parse(Console.ReadLine());

			List<Song> songList = new List<Song>();

			for (int i = 0; i < songCount; i++)
			{
				string[] songData = Console.ReadLine().Split(';');
				string artistName = songData[0];
				string songName = songData[1];
				string songLength = songData[2];

				try
				{
					Artist artist = new Artist(artistName);
					Song newSong = new Song(songName, artist, songLength);
					songList.Add(newSong);
					Console.WriteLine("Song added.");

				}
				catch (Exception exception)
				{
					Console.WriteLine(exception.Message);
				}
			}

			int totalSongSeconds = 0;
			int totalSongMinutes = 0;
			foreach (var song in songList)
			{
				totalSongMinutes += song.GetMinutes();
				totalSongSeconds += song.GetSeconds();
			}
			var cumulativeSongsDuration = new TimeSpan(0, totalSongMinutes, totalSongSeconds);

			Console.WriteLine($"Songs added: {songList.Count}");
			Console.WriteLine($"Playlist length: {cumulativeSongsDuration.Hours}h {cumulativeSongsDuration.Minutes}m {cumulativeSongsDuration.Seconds}s");
		}
	}
}
