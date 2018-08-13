using System;
using firstdata.Models;
using Newtonsoft.Json;

namespace firstdata

{
    public class TransactionPortal
    {
        private Config config;
        public TransactionPortal(Portal portal)
        {
            config = portal.Config;
        }

        public string Sale(string saleJson){
            Transaction transaction = JsonConvert.DeserializeObject<Transaction>(saleJson);
            transaction.TransactionType = "SALE";
            return Process(transaction);
        }

        public string Sale(Transaction transaction){
            transaction.TransactionType = "SALE";
            return Process(transaction);
        }

        public string Process(TransactionRequest body=null, string path = ""){
            string response =  _Process("/payments" + path, body);
            return response;
        }

        public string _Process(string path, TransactionRequest body=null){
            string response = config.Http.Post(body, path);
            return response;
        }
    }
}
