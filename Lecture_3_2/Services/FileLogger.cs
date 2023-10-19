using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3_2.Services
{
    public class FileLogger : LoggerBase
    {
        private readonly string _filePath;


        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        protected internal override void Log(string message)
        {
            File.AppendAllText(_filePath,message);
        }

        protected internal override void LogError(string message)
        {
            throw new NotImplementedException();
        }

        protected internal override void LogInformation(string message)
        {
            throw new NotImplementedException();
        }

        protected internal override void LogSuccess(string message)
        {
            throw new NotImplementedException();
        }

        protected internal override void LogWarning(string message)
        {
            throw new NotImplementedException();
        }
    }
}
