using Lecture_4_1.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_4_1.Infrasructure.Services
{
    public class NotepadService
    {
        public void SaveToNotepad(ISaveable saveable)
        {
            File.AppendAllText("C:\\Users\\elif\\Documents\\GitHub\\YetGenAkbankJump\\Lecture_4_1.Console\\Database\\Save.txt", saveable.GetInfo());
        }
    }
}
