using System;
using System.Collections.Generic;
namespace firstdata
{
    public class Config
    {
        public const String BASE_URL = "api-qa.payeezy.com/globalApi/v1";
        private String apiKey;
        public String ApiKey { get => apiKey; }
        private String apiSecret;
        public String ApiSecret { get => apiSecret; }
        private String appId;
        public String AppId { get => appId; }
        private Http http;
        public Http Http { get => http; }

        public Config(Dictionary<String, String> attrs)
        {
            apiKey = attrs["apiKey"];
            apiSecret = attrs["apiSecret"];
            appId = attrs["appId"];
        }

        public Config(String _apiKey, String _apiSecret, String _appId){
            apiKey = _apiKey;
            apiSecret = _apiSecret;
            appId = _appId;
            http = new Http(this);
        }

        public string BaseUrl()
        {
            return HttpProtocol() + BASE_URL;
        }

        private String HttpProtocol()
        {
            return "https://";
        }

        public String ContentType()
        {
            return "application/json";
        }

        public String UserAgent()
        {
            return "FirstData .NET Global API Client " + typeof(Config).Assembly.GetName().Version;
        }

        public Signature Signature(){
            return new Signature(this.apiKey, this.apiSecret);
        }
    }
}
