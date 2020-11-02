using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Likvido.API;
using Likvido.API.Models;
using Likvido.API.Models.Inputs;
using Likvido.API.Services;
using Microsoft.Extensions.Configuration;

namespace LithumKvido.TestsConsole
{
    class Program
    {

        public const string API_KEY = "6Z3Ab8PAxmnpIUfYAdvQqWQbsY0zbijfVp2gXNXFmvs=";
        
        static async Task Main(string[] args)
        {
            
            // Build configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();

            var likvidoConf = configuration.GetSection("likvido").Get<LikvidoConfiguration>();

            // AuthentificationService service = new AuthentificationService(likvidoConf);
            // service.AuthenticateWith(API_KEY);
            // var response = await service.Authentificate();
            
            InvoicesService service = new InvoicesService(likvidoConf);
            // service.AuthenticateWith(API_KEY);
            // var res = await service.GetAll();
            
            CreditorsService cservice = new CreditorsService(likvidoConf);
            cservice.AuthenticateWith(API_KEY);
            var creditor = await cservice.Get(3157);

            
            Console.WriteLine("Hello World!");
        }
    }
}