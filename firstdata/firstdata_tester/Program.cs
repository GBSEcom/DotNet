using System;
using System.Collections.Generic;
using firstdata;
using firstdata.Models;
using Newtonsoft.Json;

namespace firstdata_tester
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String apiKey = "pG3wO316dzWA4SapZeME1Qmxc9N3Kokp";
            String apiSecret = "3AqcUwvjSeG5GRAw";
            String appId = "Eric's App";

            var config = new Config(apiKey, apiSecret, appId);
            var portal = new Portal(config);

            Transaction t = new Transaction
            {
                Amount = new Amount
                {
                    Total = "13.25",
                    Currency = "COP"
                },
                PaymentCard = new PaymentCard
                {
                    Number = "2223000048400011",
                    Expiration = "1222",
                    SecurityCode = "999"
                }
            };

            string sale = portal.Transaction.Sale(t);

            Console.WriteLine(sale);
        }
    }
}
