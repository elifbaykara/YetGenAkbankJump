using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lecture_3_2.Services
{
    public class ConsoleLogger : LoggerBase
    {
        //burada log metodunu implemente ettik control . tıklayıp
        protected internal override void Log(string message) => Console.WriteLine($"{message}-{DateTime.Now:g}");

        protected internal override void LogError(string message)
        {
            Console.WriteLine($" Error => {message}-{DateTime.Now:g}");
        }

        protected internal override void LogInformation(string message)
        {
            Console.WriteLine($" Information => {message}-{DateTime.Now:g}");
        }

        protected internal override void LogSuccess(string message)
        {
            Console.WriteLine($" Success => {message}-{DateTime.Now:g}");
        }

        protected internal override void LogWarning(string message)
        {
            Console.WriteLine($" Warning => {message}-{DateTime.Now:g}");
        }
        public ConsoleLogger(string name):base(name)
        {
            
        }
        public ConsoleLogger()
        {
            
        }
    }
    }