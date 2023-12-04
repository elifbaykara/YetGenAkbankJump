using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetGenAkbankJump.Shared.Services
{
    public class TextService:ITextService
    {
        private readonly string _path;
        public TextService(string path)
        {
            _path = path;
        }
        public void Save(string text)
        {
            File.WriteAllText(_path,text);
        }
       
    }
}
