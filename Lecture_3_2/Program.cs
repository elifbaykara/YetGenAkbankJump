﻿using Lecture_2_2.Entities;
using Lecture_3_2.Services;
using Microsoft.Extensions.Logging;
using System.Text.Json;

ILogger logger = new Logger<string>(new LoggerFactory());

const string logFilePath = "C:\\Users\\elif\\Desktop\\AccessControlLogs (1).txt";
var consoleLogger = new ConsoleLogger();
var fileLogger = new FileLogger(logFilePath);

try { 
var filePath = "C:\\Users\\elif\\Desktop\\AccessControlLogs (1).txt";

var textFile = File.ReadAllText(filePath); //şu an dümdüz bir text olarak okudu yani id,created on vs şeklinde değil, dümdüz metin olarak okudu.
//Fakat biz satır satır okumasını istiyoruz o zaman ne yapacağız ?
var splittedLines = textFile.Split("\r\n", StringSplitOptions.RemoveEmptyEntries); //textFile'i böl diyoruz, neye göre ? \n'e göre yani her bir alt satıra geçtiğinde :)

//6---FRNS9821145C---FACE---2023-08-09T10:18:12+00:00 neye göre bölmeliyim ? aralarındaki ---'ye göre :)
consoleLogger.Log("Text file imported");

List<AccessControlLog> logs = new();

foreach (var splittedLine in splittedLines)
{
    var values = splittedLine.Split("---", StringSplitOptions.RemoveEmptyEntries);

    var AccessControlLog = new AccessControlLog
    {
        Id = Guid.NewGuid(),
        CreatedOn = DateTimeOffset.Now,
        PersonId = Convert.ToInt64(values[0]), //personid long olduğu için dönüştürdük
        DeviceSerialNo = values[1],
        //stringi nasıl enuma çevirebilirim ? accesscontrollog üzerinde static bir metod kodlayacağım sonrasında ise:
        //AccessType = AccessControlLog.ConvertStringToAccessType(values[2]),
        LogTime = Convert.ToDateTime(values[3]),
    };
    logs.Add(AccessControlLog);
}
File.WriteAllText("C:\\Users\\elif\\Desktop\\AccessControlLogsJson (1).txt", JsonSerializer.Serialize(logs));
consoleLogger.Log("The operation was successfully completed.");
Console.ReadLine();
}
catch(Exception ex)
{
    consoleLogger.Log(ex.Message );
}
