using System;
using Org.OpenAPITools;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Newtonsoft.Json;

namespace Org.Simple
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

        private CardVerificationApi cardApi;
        public CardVerificationApi CardApi
        {
            get { return cardApi; }
        }

        private CurrencyConversionApi currencyApi;
        public CurrencyConversionApi CurrencyApi
        {
            get { return currencyApi; }
        }

        private FraudDetectApi fraudApi;
        public FraudDetectApi FraudApi
        {
            get { return fraudApi; }
        }

        private PaymentSchedulesApi paySchedulesApi;
        public PaymentSchedulesApi PaySchedulesApi
        {
            get { return paySchedulesApi; }
        }

        private PaymentTokenApi payTokenApi;
        public PaymentTokenApi PayTokenApi
        {
            get { return payTokenApi; }
        }

        private PaymentURLApi payUrlApi;
        public PaymentURLApi PayUrlApi
        {
            get { return payUrlApi; }
        }

        private CardInfoLookupApi cardInfoApi;
        public CardInfoLookupApi CardInfoApi
        {
            get { return cardInfoApi; }
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
            cardApi = new CardVerificationApi(context.Client);
            currencyApi = new CurrencyConversionApi(context.Client);
            fraudApi = new FraudDetectApi(context.Client);
            paySchedulesApi = new PaymentSchedulesApi(context.Client);
            payTokenApi = new PaymentTokenApi(context.Client);
            payUrlApi = new PaymentURLApi(context.Client);
            cardInfoApi = new CardInfoLookupApi(context.Client);
        }

        public ApiResponse RequestAccessToken()
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

		public ApiResponse PrimaryPaymentTransaction(PrimaryTransaction payload, string region=null)
		{
			Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return payApi.PrimaryPaymentTransaction(
				CONTENT_TYPE,
				signatureService.ClientRequestId,
				GetApiKey(),
				signatureService.TimeStamp,
				payload,
                messageSignature,
                region
			);
		}

		public ApiResponse ReturnTransaction(string transactionId, SecondaryTransaction payload, string storeId=null, string region=null)
		{
			Signature signatureService = GetSignatureService();
			string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
			return payApi.ReturnTransaction(
				CONTENT_TYPE,
				signatureService.ClientRequestId,
				GetApiKey(),
				signatureService.TimeStamp,
				transactionId,
				payload,
                messageSignature,
                region,
                storeId
			);
		}

		public ApiResponse TransactionInquiry (string transactionId, string storeId=null, string region=null)
		{
			Signature signatureService = GetSignatureService();
			string messageSignature = signatureService.Sign();
            return payApi.TransactionInquiry(
				CONTENT_TYPE,
				signatureService.ClientRequestId,
				GetApiKey(),
				signatureService.TimeStamp,
                transactionId,
                messageSignature,
                region,
                storeId
			);
		}

		public ApiResponse VoidTransaction (string transactionId, string storeId=null, string region=null)
		{
			Signature signatureService = GetSignatureService();
			string messageSignature = signatureService.Sign();
			return payApi.VoidTransaction(
				CONTENT_TYPE,
				signatureService.ClientRequestId,
				GetApiKey(),
				signatureService.TimeStamp,
                transactionId,
				messageSignature,
                region,
                storeId
			);
		}

        public ApiResponse UpdateTransaction (string transactionId, AuthenticationResponseVerificationRequest payload, string region=null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return payApi.FinalizeSecureTransaction(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                transactionId,
                payload,
                messageSignature,
                region
            );
        }

        public ApiResponse PerformPaymentAuthorizationByTransaction(string transactionId, SecondaryTransaction payload, string storeId=null, string region=null)
		{
			Signature signatureService = GetSignatureService();
			string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
			return payApi.PerformPaymentPostAuthorisation(
				CONTENT_TYPE,
				signatureService.ClientRequestId,
				GetApiKey(),
				signatureService.TimeStamp,
				transactionId,
				payload,
                messageSignature,
                region,
                storeId
			);
		}

        public ApiResponse PerformPaymentAuthorizationByOrder(string orderId, SecondaryTransaction payload, string storeId = null, string region = null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return orderApi.OrderPostAuth(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                orderId,
                payload,
                messageSignature,
                region,
                storeId
            );
        }

        public ApiResponse ReturnTransactionByOrder(string orderId, SecondaryTransaction payload, string storeId=null, string region=null)
		{
			Signature signatureService = GetSignatureService();
			string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
			return orderApi.OrderReturnTransaction(
				CONTENT_TYPE,
				signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
				orderId,
				payload,
                messageSignature,
                region,
				storeId
			);			
		}

        public ApiResponse OrderInquiry (string orderId, string storeId=null, string region=null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign();
            return orderApi.OrderInquiry(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                orderId,
                messageSignature,
                region,
                storeId
            );
        }

        public ApiResponse VerifyCard(CardVerificationRequest payload, string region=null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return cardApi.VerifyCard(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                payload,
                messageSignature,
                region
            );  
        }

        public ApiResponse GetExchangeRate(ExchangeRateRequest payload, string region=null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return currencyApi.GetExchangeRate(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                payload,
                messageSignature,
                region
            );
        }

        public ApiResponse GetFraudScore(ScoreOnlyRequest payload, string region=null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return fraudApi.ScoreOnly(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                payload,
                messageSignature,
                region
            );
        }

        public ApiResponse CreatePaymentSchedule(PaymentSchedulesRequest payload, string region=null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return paySchedulesApi.CreatePaymentSchedule(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                payload,
                messageSignature,
                region
            );
        }

        public ApiResponse CancelPaymentSchedule(string orderId, string storeId=null, string region=null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign();
            return paySchedulesApi.CancelPaymentSchedule(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                orderId,
                messageSignature,
                region,
                storeId
            );
        }

        public ApiResponse UpdatePaymentSchedule(PaymentSchedulesRequest payload, string orderId, string storeId=null, string region=null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return paySchedulesApi.UpdatePaymentSchedule(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                orderId,
                payload,
                messageSignature,
                region,
                storeId
            );
        }

        public ApiResponse PaymentScheduleInquiry(string orderId, string storeId=null, string region=null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign();
            return paySchedulesApi.InquiryPaymentSchedule(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                orderId,
                messageSignature,
                region,
                storeId
            );
        }

        public ApiResponse CreatePaymentToken(PaymentTokenizationRequest payload, string authorization=null, string region=null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return payTokenApi.CreatePaymentToken(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                payload,
                messageSignature,
                authorization,
                region
            );
        }

        public ApiResponse DeletePaymentToken(string tokenId, string authorization = null, string storeId=null, string region=null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign();
            return payTokenApi.DeletePaymentToken(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                tokenId,
                messageSignature,
                authorization,
                region,
                storeId
            );
        }
        public ApiResponse CreatePaymentUrl(PaymentUrlRequest payload, string region=null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return payUrlApi.CreatePaymentUrl(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                payload,
                messageSignature,
                region
            );
        }

        public ApiResponse CardInfoLookup(CardInfoLookupRequest payload, string region=null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return cardInfoApi.CardInfoLookup(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                payload,
                messageSignature,
                region
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