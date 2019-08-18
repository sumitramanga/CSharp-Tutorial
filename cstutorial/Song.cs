using System;
namespace cstutorial
{
    class Song
    {
        public string songTitle;
        public string songArtist;
        public int songDuration;
        // how mnay songs have been created. a variable which belongs to the class not the object
        // static belongs to the class
        public static int songCount = 0;

        public Song(string aSongTitle, string aSongArtist, int aSongDuration)
        {
            songTitle = aSongTitle;
            songArtist = aSongArtist;
            songDuration = aSongDuration;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }
    }
}
