using System;
using Org.OpenAPITools.Client;

namespace Org.Simple
{
	public class ClientContext
	{
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
            client = new ApiClient(config.BasePath);
			credentials = _credentials;
		}
	}
}