using System;
using Org.OpenAPITools.Client;

namespace Org.Simple
{
	public class ClientContext
	{
        private const string PRODUCTION_URL = "https://prod.api.firstdata.com/gateway/v2";
        private const string SANDBOX_URL = "https://cert.api.firstdata.com/gateway/v2";

        private Configuration config;
		public Configuration Config 
		{
			get {return config;}
		}
		
		private ApiClient client;
		public ApiClient Client 
		{
			get {return client;}
		}

		private MerchantCredentials credentials;
		public MerchantCredentials Credentials
		{
			get {return credentials;}
		}

		public static ClientContext Create(MerchantCredentials _credentials)
		{
			return new ClientContext(_credentials);
		}

        public ClientContext(MerchantCredentials _credentials)
        {
            config = new Configuration();
            client = new ApiClient();
            credentials = _credentials;
        }

        public ClientContext(MerchantCredentials _credentials, bool _production)
        {
            credentials = _credentials;
            config = _production ? new Configuration(PRODUCTION_URL) : new Configuration(SANDBOX_URL);
            client = new ApiClient();
        }

        public ClientContext(MerchantCredentials _credentials, string _basePath)
        {
            credentials = _credentials;
            config = new Configuration(_basePath);
            client = new ApiClient();
        }
    }
}