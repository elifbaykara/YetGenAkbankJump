using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetGenAkbankJump.Shared.Services;

namespace Lecture_4_2.Utilities
{

    public class PasswordGenerator
    {

        private readonly ITextService _textService;
        private readonly IIPService _ipService;
        public int GeneratedPasswordsCount { get; set; }

        private string _lastIp = string.Empty;

        private readonly Random _random;
        private const string Numbers = "0123456789";
        private const string SpecialChars = "!?_-*+";
        private const string LowerCaseChars = "abcdefghijklmnoprstuvwxyz";
        private const string UpperCaseChars = "ABCDEFGHIJKLMNOPRSTUVWXYZ";

        public PasswordGenerator(IIPService ipService, ITextService textService)
        {
            _random = new Random();
            _ipService = ipService;
            _textService = textService;
        }
        public string Generate(int passwordLength, bool includeNumbers, bool includeLowerCase, bool includeUpperCase, bool includeSpeacialChars)
        {
            var charsBuilder = new StringBuilder(); //string inşası yapmamızı sağlıyor. buraya string password verirsek milyonlarca kişi için sürekli değişken vermiş oluruz çok büyük bir performans kaybı. Bu nedenle stringBuilder kullanıyoruz.

            if (includeNumbers)
            {
                charsBuilder.Append(Numbers);
            }
            if (includeLowerCase)
            {
                charsBuilder.Append(LowerCaseChars);
            }
            if (includeUpperCase)
            {
                charsBuilder.Append(UpperCaseChars);
            }
            if (includeSpeacialChars)
            {
                charsBuilder.Append(SpecialChars);
            }

            var acceptedChars = charsBuilder.ToString();
            var passwordBuilder = new StringBuilder();

            for (int i = 0; i < passwordLength; i++)
            {
                var randomIndex = _random.Next(0, acceptedChars.Length);
                passwordBuilder.Append(acceptedChars[randomIndex]);
            }

            GeneratedPasswordsCount++;

            var password = passwordBuilder.ToString();

            _textService.Save(password);

            _lastIp = _ipService.Ip;
           
            return password;
        }


    }
}
