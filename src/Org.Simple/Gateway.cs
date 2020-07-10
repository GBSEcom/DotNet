using System;
using Org.OpenAPITools;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using Newtonsoft.Json;

namespace Org.Simple
{
    public class Gateway
    {
        const String CONTENT_TYPE = "application/json";

        private ClientContext context;
        public ClientContext Context
        {
            get { return context; }
        }

        private AuthenticationApi authApi;
        public AuthenticationApi AuthApi
        {
            get { return authApi; }
        }

        private OrderApi orderApi;
        public OrderApi OrderApi
        {
            get { return orderApi; }
        }

        private PaymentApi payApi;
        public PaymentApi PayApi
        {
            get { return payApi; }
        }

        private VerificationApi verifyApi;
        public VerificationApi VerifyApi
        {
            get { return verifyApi; }
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

        private InformationLookupApi infoApi;
        public InformationLookupApi InfoApi
        {
            get { return infoApi; }
        }

        public static Gateway Create(MerchantCredentials _credentials)
        {
            return new Gateway(new ClientContext(_credentials));
        }

        public static Gateway Create(MerchantCredentials _credentials, bool _production)
        {
            return new Gateway(new ClientContext(_credentials, _production));
        }

        public static Gateway Create(MerchantCredentials _credentials, string _basePath)
        {
            return new Gateway(new ClientContext(_credentials, _basePath));
        }

        public Gateway(ClientContext _context)
        {
            context = _context;
            authApi = new AuthenticationApi(context.Config);
            orderApi = new OrderApi(context.Config);
            payApi = new PaymentApi(context.Config);
            verifyApi = new VerificationApi(context.Config);
            currencyApi = new CurrencyConversionApi(context.Config);
            fraudApi = new FraudDetectApi(context.Config);
            paySchedulesApi = new PaymentSchedulesApi(context.Config);
            payTokenApi = new PaymentTokenApi(context.Config);
            payUrlApi = new PaymentURLApi(context.Config);
            infoApi = new InformationLookupApi(context.Config);
        }

        public AccessTokenResponse RequestAccessToken(AccessTokenRequest payload)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return authApi.AuthenticationAccessTokensPost(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                payload,
                messageSignature
            );
        }

        public TransactionResponse SubmitPrimaryTransaction(PrimaryTransaction payload, string region = null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return payApi.SubmitPrimaryTransaction(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                payload,
                messageSignature,
                region
            );
        }

        public TransactionResponse SubmitSecondaryTransaction(string transactionId, SecondaryTransaction payload, string storeId = null, string region = null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return payApi.SubmitSecondaryTransaction(
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

        public TransactionResponse TransactionInquiry(string transactionId, string storeId = null, string region = null)
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

        public TransactionResponse FinalizeSecureTransaction(string transactionId, AuthenticationUpdateRequest payload, string region = null)
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

        public TransactionResponse SubmitSecondaryTransactionFromOrder(string orderId, SecondaryTransaction payload, string region = null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return orderApi.SubmitSecondaryTransactionFromOrder(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                orderId,
                payload,
                messageSignature,
                region
            );
        }

        public OrderResponse OrderInquiry(string orderId, string storeId = null, string region = null)
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

        public TransactionResponse VerifyCard(CardVerificationRequest payload, string region = null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return verifyApi.VerifyCard(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                payload,
                messageSignature,
                region
            );
        }

        public TransactionResponse VerifyAccount(AccountVerificationRequest payload, string region = null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return verifyApi.VerifyAccount(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                payload,
                messageSignature,
                region
            );
        }

        public ExchangeRateResponse GetExchangeRate(ExchangeRateRequest payload, string region = null)
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

        public ScoreOnlyResponse GetFraudScore(ScoreOnlyRequest payload, string region = null)
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

        public FraudRegistrationResponse FraudClientRegistrationPost(ClientRegistration payload, string region = null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return fraudApi.FraudClientRegistrationPost(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                payload,
                messageSignature,
                region
            );
        }

        public FraudRegistrationResponse FraudPaymentRegistrationPost(PaymentRegistration payload, string region = null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return fraudApi.FraudPaymentRegistrationPost(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                payload,
                messageSignature,
                region
            );
        }

        public PaymentSchedulesResponse CreatePaymentSchedule(PaymentSchedulesRequest payload, string region = null)
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

        public PaymentSchedulesResponse CancelPaymentSchedule(string orderId, string storeId = null, string region = null)
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

        public PaymentSchedulesResponse UpdatePaymentSchedule(PaymentSchedulesRequest payload, string orderId, string region = null)
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
                region
            );
        }

        public RecurringPaymentDetailsResponse PaymentScheduleInquiry(string orderId, string storeId = null, string region = null)
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

        public PaymentTokenizationResponse CreatePaymentToken(PaymentTokenizationRequest payload, string authorization = null, string region = null)
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

        public PaymentTokenUpdateResponse UpdatePaymentToken(PaymentCardPaymentTokenUpdateRequest payload, string authorization = null, string region = null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return payTokenApi.UpdatePaymentToken(
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

        public PaymentTokenizationResponse PaymentTokenInquiry(string tokenId, string authorization = null, string storeId = null, string region = null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign();
            return payTokenApi.GetPaymentTokenDetails(
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

        public PaymentTokenizationResponse DeletePaymentToken(string tokenId, string authorization = null, string storeId = null, string region = null)
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

        public PaymentUrlResponse CreatePaymentUrl(PaymentUrlRequest payload, string region = null)
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

        public PaymentUrlResponse DeletePaymentUrl(string region = null, string storeId = null, string transactionId = null, string orderId = null, string paymentUrlId = null, string transactionTime = null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign();
            return payUrlApi.DeletePaymentUrl(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                messageSignature,
                region,
                storeId,
                transactionId,
                orderId,
                paymentUrlId,
                transactionTime
            );
        }

        public PaymentUrlDetailResponse DetailPaymentUrl(string fromDate, string toDate, string region = null, string storeId = null, string transactionId = null, string orderId = null, string status = null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign();
            return payUrlApi.PaymentUrlDetail(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                fromDate,
                toDate,
                messageSignature,
                region,
                storeId,
                orderId,
                transactionId,
                status
            );
        }

        public CardInfoLookupResponse CardInfoLookup(CardInfoLookupRequest payload, string region = null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return infoApi.CardInfoLookup(
                CONTENT_TYPE,
                signatureService.ClientRequestId,
                GetApiKey(),
                signatureService.TimeStamp,
                payload,
                messageSignature,
                region
            );
        }

        public CardInfoLookupResponse AccountInfoLookup(AccountInfoLookupRequest payload, string region = null)
        {
            Signature signatureService = GetSignatureService();
            string messageSignature = signatureService.Sign(JsonConvert.SerializeObject(payload));
            return infoApi.LookupAccount(
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