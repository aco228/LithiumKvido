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
            service.AuthenticateWith(API_KEY);
            // var res = await service.Create(new InvoiceCreateModel()
            // {
            //     Date = DateTime.Now,
            //     CampaignInitialRequest = Schemas.CampaignType.Invoice,
            //     Currency = "EUR",
            //     DueDate = DateTime.Now.AddDays(1),
            //     Debtor = new InvoiceCreateModel.DebtorModel()
            //     {
            //         Address = "address",
            //         City = "city",
            //         Email = "email",
            //         Phone = "phone",
            //         DebtorType = Schemas.LegalEntityType.Private,
            //         FirstName = "firstName",
            //         LastName = "lastName",
            //         ZipCode = "zipi"
            //     },
            //     Lines = new List<InvoiceCreateModel.LineModel>()
            //     {
            //         new InvoiceCreateModel.LineModel()
            //         {
            //             Description = "descriptio",
            //             Quantity = 15,
            //             DiscountType = Schemas.DiscountType.Cash,
            //             DiscountValue = 15,
            //             VatRate = 15,
            //             UnitNetPrice = 15
            //         }
            //     }
            // });
            //var res = await service.GetAll();

            
            Console.WriteLine("Hello World!");
        }
    }
}