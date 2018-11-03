﻿
using SpeedTest;
using SpeedTest.Models;
using System;
using System.Globalization;
using System.Linq;

using SpeedTestLogger.Models;

namespace SpeedTestLogger
{
    class Program
    {
        static void Main(string[] args)
        {

        //     Console.WriteLine("Hello World!");
           System.Console.WriteLine("Hello SpeedTestLogger");
        //     var client = new SpeedTestClient();
        //     var settings = client.GetSettings();

        //     System.Console.WriteLine("finding test server");
            var config = new LoggerConfiguration();

            // var location = new RegionInfo("nb-NO");
             var runner = new SpeedTestRunner ( config.LoggerLocation );
             runner.RunSpeedTest();

             var testData = runner.RunSpeedTest();
             var results = new TestResult
             {
                 SessionId = new Guid(),
                 User = config.UserId,
                 Device = config.LoggerId,
                 Timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
                 Data = testData

             };
             
        //     var tenLocalServers = settings.Servers 
        //         .Where (s=> s.Country.Equals(location.EnglishName
        //     )).Take(10);

        //     var serversOrdersByLatency = tenLocalServers
        //         .Select ( s => 
        //         {
        //             s.Latency = client.TestServerLatency(s);
        //              return s;
        //         })
        //         .OrderBy(s => s.Latency);
                

        // var server = serversOrdersByLatency.First();

        // Console.WriteLine("Testing download speed");
        // var downloadSpeed = client.TestDownloadSpeed(server, settings.Download.ThreadsPerUrl);
        // Console.WriteLine("Download speed was: {0} Mbps", Math.Round(downloadSpeed / 1024, 2));

        // Console.WriteLine("Testing upload speed");
        // var uploadSpeed = client.TestUploadSpeed(server, settings.Upload.ThreadsPerUrl);
        // Console.WriteLine("Upload speed was: {0} Mbps", Math.Round(uploadSpeed / 1024, 2))// ;

        }
    }
    
}
