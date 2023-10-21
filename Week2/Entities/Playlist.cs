using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Entities
{
    public class Playlist
    {
        public Guid Id { get; set; }
        private List<Song> Songs { get; set; }
        private Random random;


        public Playlist(Song firstSong)
        {
            Id = Guid.NewGuid();
            Songs = new List<Song>();
            random = new();
            AddSong(firstSong);
        }

        //public void AddSong(string Song) //tüm metotlar sadece bir işi yapmalı solid ==> single responsibility
        //{
        //    if(!string.IsNullOrWhiteSpace(Song))
        //    {
        //       Songs.Add(Song);
        //    }

        //}  BU NEDENLE BU FONKSİYONU AŞAĞIDAKİ GİBİ DEĞİŞTİRİYORUM 
        public void AddSong(Song song)
        {
            if(song is not null)
                Songs.Add(song);
        }

        public string GetSongs()
        {
            return string.Join("\n", Songs.Select(x=> $"{x.Title} - {x.Composer} "));
        }

        public void ShuffleSong()
        {
            int songCount = Songs.Count;

            
            while (songCount > 0)
            {
                songCount--;

                Song song = Songs[songCount];
                int randomIndex = random.Next(songCount);
                Song swapSong = Songs[randomIndex];
                Songs[songCount]=swapSong;
                Songs[randomIndex] = song;
            }
        }
    }
   
}
