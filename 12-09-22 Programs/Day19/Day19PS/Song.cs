using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19PS
{
    public class Song
    {
        //songname,language,lyrics properties
        [StereoDisc("Name", SongName = "Diver")]
        public string SongID { get; set; }
        [StereoDisc("Name", Language = "English")]
        public string LanguageID { get; set; }
        [StereoDisc("Name", Lyrics = "song, song, song....")]
        public string LyricsID { get; set; }
        [StereoDisc("Name", SongName = "Diver")]
        public Song(string id, string lid, string lyrid)
        {
            SongID = id;
            LanguageID = lid;
            LyricsID = lyrid;
        }
    }
}
