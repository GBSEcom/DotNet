using System;
using System.IO;
using System.Net;
using firstdata.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace firstdata
{
    public class Http
    {
        private Config config;
        private enum httpVerb {
            GET,
            POST,
            PUT,
            DELETE
        }

        public Http(Config _config)
        {
            config = _config;
        }

        public string Post(TransactionRequest body, string path){
            string response = MakeHttpCall(path, httpVerb.POST, body);
            return response;
        }

        public string Get(string path){
            string response = MakeHttpCall(path, httpVerb.GET);
            return response;
        }

        private string MakeHttpCall(string path, httpVerb verb, TransactionRequest body = null){
            string response = string.Empty;
            string bodystring = body is TransactionRequest ? body.ToJson() : string.Empty;

            HttpWebRequest request = CreateHttpRequest(bodystring, httpVerb.POST, path);
            response = SendHttpRequest(request, bodystring);

            return response;
        }

        private HttpWebRequest CreateHttpRequest(string body, httpVerb verb, string path){
            Signature sig = config.Signature();
            Console.WriteLine("Path: " + config.BaseUrl() + path);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(config.BaseUrl() + path);

            WebHeaderCollection httpHeaders = new WebHeaderCollection();
            httpHeaders.Add("Api-Key", config.ApiKey);
            httpHeaders.Add("Client-Request-Id", sig.Nonce);
            httpHeaders.Add("Timestamp", sig.TimeStamp);
            httpHeaders.Add("Message-Signature", sig.Sign(body));
            req.Headers = httpHeaders;

            Console.WriteLine("Body: " + body);
            Console.WriteLine("Api-Key: " + config.ApiKey);
            Console.WriteLine("Client-Request-Id: " + sig.Nonce);
            Console.WriteLine("Timestamp: " + sig.TimeStamp);

            req.ContentType = config.ContentType();
            req.Method = verb.ToString();

            return req;
        }

        private string SendHttpRequest(HttpWebRequest request, string body){
            string responseValue = string.Empty;

            try
            {
                if (request.Method == "POST" && body != string.Empty)
                {
                    using (StreamWriter swPayload = new StreamWriter(request.GetRequestStream()))
                    {
                        swPayload.Write(body);
                        swPayload.Close();
                    }
                }

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new ApplicationException("FirstData HTTP request failed with: " + response.StatusCode);

                    using (Stream responseStream =  response.GetResponseStream())
                        using (StreamReader reader = new StreamReader(responseStream))
                            responseValue = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                responseValue = ex.Message;
            }

            return responseValue;
        }
    }
}
