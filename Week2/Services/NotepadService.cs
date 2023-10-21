using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Entities;

namespace Week2.Services
{
    public class NotepadService
    {
        public void WriteToNotepad(Playlist playlist)
        {
            string directory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string saveFile = Path.Combine(directory, $"{playlist.Id}.txt");
            File.WriteAllText(saveFile, playlist.GetSongs());
        }
    }
}
