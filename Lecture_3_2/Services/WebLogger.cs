using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3_2.Services
{
    public class WebLogger : LoggerBase
    {
        private readonly HttpClient _httpClient;

        public WebLogger()
        {
            _httpClient = new HttpClient();
        }
        protected internal override void Log(string message)
        {
            _httpClient.PutAsJsonAsync("/YetGen/Api/Logs", message);
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
