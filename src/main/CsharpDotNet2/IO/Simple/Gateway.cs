using System;
using IO.Swagger;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Simple
{
	public class Gateway
	{
		const String CONTENT_TYPE = "application/json";

		private ClientContext context;
		public ClientContext Context 
		{
			get {return context;}
		}
		
		private AuthenticationApi authApi;
		public AuthenticationApi AuthApi 
		{
			get {return authApi;}
		}

		private OrderApi orderApi;
		public OrderApi OrderApi
		{
			get {return orderApi;}
		}

		private PaymentApi payApi;
		public PaymentApi PayApi
		{
			get {return payApi;}
		}

		public static Gateway Create(MerchantCredentials _credentials)
		{
			return new Gateway(new ClientContext(_credentials));
		}

		public Gateway(ClientContext _context)
		{
			context = _context;
			authApi = new AuthenticationApi(context.Client);
			orderApi = new OrderApi(context.Client);
			payApi = new PaymentApi(context.Client);
		}

		public AccessTokenResponse RequestAccessToken()
		{
			Signature signatureService = GetSignatureService();
			string messageSignature = signatureService.Sign();
			return authApi.V1AuthenticationAccessTokensPost(
				CONTENT_TYPE,
				signatureService.ClientRequestId,
				GetApiKey(),
				signatureService.TimeStamp,
				messageSignature
			);
		}

		public ApiResponse PrimaryPaymentTransaction(PrimaryTransaction payload)
		{
			Signature signatureService = GetSignatureService();
			string messageSignature = signatureService.Sign(payload.ToJson());
			return payApi.PrimaryPaymentTransaction(
				CONTENT_TYPE,
				signatureService.ClientRequestId,
				GetApiKey(),
				signatureService.TimeStamp,
				messageSignature,
				payload
			);
		}

		public ApiResponse ReturnTransaction(string transactionId, SecondaryTransaction payload, string storeId=null)
		{
			Signature signatureService = GetSignatureService();
			string messageSignature = signatureService.Sign(payload.ToJson());
			return payApi.ReturnTransaction(
				CONTENT_TYPE,
				signatureService.ClientRequestId,
				GetApiKey(),
				signatureService.TimeStamp,
				messageSignature,
				transactionId,
				payload,
				storeId
			);
		}

		public ApiResponse TransactionInquiry (string transactionId, string storeId=null)
		{
			Signature signatureService = GetSignatureService();
			string messageSignature = signatureService.Sign();
			return payApi.TransactionInquiry(
				CONTENT_TYPE,
				signatureService.ClientRequestId,
				GetApiKey(),
				signatureService.TimeStamp,
				messageSignature,
				transactionId,
				storeId
			);
		}

		public ApiResponse VoidTransaction (string transactionId, string storeId=null)
		{
			Signature signatureService = GetSignatureService();
			string messageSignature = signatureService.Sign();
			return payApi.VoidTransaction(
				CONTENT_TYPE,
				signatureService.ClientRequestId,
				GetApiKey(),
				signatureService.TimeStamp,
				messageSignature,
				transactionId,
				storeId
			);
		}

		public ApiResponse PerformPaymentAuthorizationByOrder(string orderId, SecondaryTransaction payload, string storeId=null)
		{
			Signature signatureService = GetSignatureService();
			string messageSignature = signatureService.Sign(payload.ToJson());
			return orderApi.PerformPaymentPostAuthorisation(
				CONTENT_TYPE,
				signatureService.ClientRequestId,
				GetApiKey(),
				signatureService.TimeStamp,
				messageSignature,
				orderId,
				payload,
				storeId
			);			
		}

		public ApiResponse PerformPaymentAuthorizationByTransaction(string transactionId, SecondaryTransaction payload, string storeId=null)
		{
			Signature signatureService = GetSignatureService();
			string messageSignature = signatureService.Sign(payload.ToJson());
			return payApi.PerformPaymentPostAuthorisation(
				CONTENT_TYPE,
				signatureService.ClientRequestId,
				GetApiKey(),
				signatureService.TimeStamp,
				messageSignature,
				transactionId,
				payload,
				storeId
			);
		}

		public ApiResponse ReturnTransactionByOrder(string orderId, SecondaryTransaction payload, string storeId=null)
		{
			Signature signatureService = GetSignatureService();
			string messageSignature = signatureService.Sign(payload.ToJson());
			return orderApi.ReturnTransaction(
				CONTENT_TYPE,
				signatureService.ClientRequestId,
				GetApiKey(),
				signatureService.TimeStamp,
				messageSignature,
				orderId,
				payload,
				storeId
			);			
		}

		private Signature GetSignatureService()
		{
			return new Signature(GetApiKey(), GetApiSecret());
		}

		private String GetApiKey()
		{
			return context.Credentials.ApiKey;
		}

		private String GetApiSecret()
		{
			return context.Credentials.ApiSecret;
		} 

	}
}