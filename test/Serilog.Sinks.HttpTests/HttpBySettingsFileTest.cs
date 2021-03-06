﻿using Microsoft.Extensions.Configuration;
using Serilog.LogServer;

namespace Serilog
{
    public class HttpBySettingsFileTest : SinkFixture
    {
        public HttpBySettingsFileTest()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings_http.json")
                .Build();

            Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            TestServerHttpClient.Instance.Client = Server.CreateClient();
        }
    }
}
