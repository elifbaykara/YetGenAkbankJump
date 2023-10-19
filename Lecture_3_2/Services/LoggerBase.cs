using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3_2.Services
{
    public abstract class LoggerBase  //abstract classlar new lenemezler
    {
        protected LoggerBase(string name)
        {
            Name = name;
        }
        protected internal LoggerBase()
        {
            
        }
        protected internal string Name { get; set; }
        protected internal abstract void Log(string message); //protected sayesinde loggerbase classından türeyen arkadaşlar bu metodu görebilecekler.
        //neden süslü parantez açmadık ? direkt böyle yazdık ? Bu metod türetilen yerde implemente edilecek yaani içi orada doldurulacak.
        //diyelim ki bir console logger oluşturduk bunu da loger baseden türettik o zaman diyecek ki oradaki loglama metodunun içini doldur
        protected internal abstract void LogSuccess(string message);
        protected internal abstract void LogError(string message);
        protected internal abstract void LogInformation(string message);
        protected internal abstract void LogWarning(string message);
    }
}
