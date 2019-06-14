using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Util.Enum;


namespace Util.Helper
{
    public class ConfigurationModel
    {
        public static IConfiguration Configuration { get; private set; }

        public ConfigurationModel()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json");
            Configuration = builder.Build();
        }

        public static T ConfigModelProvider<T>(ConfigSettingSession type)
        {
            try
            {
                var sessionName = System.Enum.GetName(typeof(ConfigSettingSession), type);
                return Configuration.GetSection(sessionName).Get<T>();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

    }
}