using System;

namespace Org.Simple
{
	public class MerchantCredentials
	{
		private String apiKey="";
		public String ApiKey 
		{ 
			get {return apiKey;}
		} 
		private String apiSecret="";
		public String ApiSecret
		{
			get {return apiSecret;}
		}

		public MerchantCredentials(String _apiKey, String _apiSecret)
		{
			apiKey = _apiKey;
			apiSecret = _apiSecret;
		}
	}
}