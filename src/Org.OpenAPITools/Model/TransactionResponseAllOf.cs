/*
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.5.0.20211029.001
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// TransactionResponseAllOf
    /// </summary>
    [DataContract(Name = "TransactionResponse_allOf")]
    public partial class TransactionResponseAllOf : IEquatable<TransactionResponseAllOf>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TransactionType
        /// </summary>
        [DataMember(Name = "transactionType", EmitDefaultValue = false)]
        public TransactionType? TransactionType { get; set; }

        /// <summary>
        /// Gets or Sets TransactionOrigin
        /// </summary>
        [DataMember(Name = "transactionOrigin", EmitDefaultValue = false)]
        public TransactionOrigin? TransactionOrigin { get; set; }
        /// <summary>
        /// Represents the status of a transaction immediately following the original processing request. This value is not stored for the transaction and is only available in the response when the transaction is processed. TransactionStatus is not returned on either the transaction inquiry or on the order inquiry.
        /// </summary>
        /// <value>Represents the status of a transaction immediately following the original processing request. This value is not stored for the transaction and is only available in the response when the transaction is processed. TransactionStatus is not returned on either the transaction inquiry or on the order inquiry.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionStatusEnum
        {
            /// <summary>
            /// Enum APPROVED for value: APPROVED
            /// </summary>
            [EnumMember(Value = "APPROVED")]
            APPROVED = 1,

            /// <summary>
            /// Enum WAITING for value: WAITING
            /// </summary>
            [EnumMember(Value = "WAITING")]
            WAITING = 2,

            /// <summary>
            /// Enum PARTIAL for value: PARTIAL
            /// </summary>
            [EnumMember(Value = "PARTIAL")]
            PARTIAL = 3,

            /// <summary>
            /// Enum VALIDATIONFAILED for value: VALIDATION_FAILED
            /// </summary>
            [EnumMember(Value = "VALIDATION_FAILED")]
            VALIDATIONFAILED = 4,

            /// <summary>
            /// Enum PROCESSINGFAILED for value: PROCESSING_FAILED
            /// </summary>
            [EnumMember(Value = "PROCESSING_FAILED")]
            PROCESSINGFAILED = 5,

            /// <summary>
            /// Enum DECLINED for value: DECLINED
            /// </summary>
            [EnumMember(Value = "DECLINED")]
            DECLINED = 6

        }


        /// <summary>
        /// Represents the status of a transaction immediately following the original processing request. This value is not stored for the transaction and is only available in the response when the transaction is processed. TransactionStatus is not returned on either the transaction inquiry or on the order inquiry.
        /// </summary>
        /// <value>Represents the status of a transaction immediately following the original processing request. This value is not stored for the transaction and is only available in the response when the transaction is processed. TransactionStatus is not returned on either the transaction inquiry or on the order inquiry.</value>
        [DataMember(Name = "transactionStatus", EmitDefaultValue = false)]
        public TransactionStatusEnum? TransactionStatus { get; set; }
        /// <summary>
        /// Shows the state of the current transaction.
        /// </summary>
        /// <value>Shows the state of the current transaction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionStateEnum
        {
            /// <summary>
            /// Enum AUTHORIZED for value: AUTHORIZED
            /// </summary>
            [EnumMember(Value = "AUTHORIZED")]
            AUTHORIZED = 1,

            /// <summary>
            /// Enum CAPTURED for value: CAPTURED
            /// </summary>
            [EnumMember(Value = "CAPTURED")]
            CAPTURED = 2,

            /// <summary>
            /// Enum DECLINED for value: DECLINED
            /// </summary>
            [EnumMember(Value = "DECLINED")]
            DECLINED = 3,

            /// <summary>
            /// Enum CHECKED for value: CHECKED
            /// </summary>
            [EnumMember(Value = "CHECKED")]
            CHECKED = 4,

            /// <summary>
            /// Enum COMPLETEDGET for value: COMPLETED_GET
            /// </summary>
            [EnumMember(Value = "COMPLETED_GET")]
            COMPLETEDGET = 5,

            /// <summary>
            /// Enum INITIALIZED for value: INITIALIZED
            /// </summary>
            [EnumMember(Value = "INITIALIZED")]
            INITIALIZED = 6,

            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 7,

            /// <summary>
            /// Enum READY for value: READY
            /// </summary>
            [EnumMember(Value = "READY")]
            READY = 8,

            /// <summary>
            /// Enum TEMPLATE for value: TEMPLATE
            /// </summary>
            [EnumMember(Value = "TEMPLATE")]
            TEMPLATE = 9,

            /// <summary>
            /// Enum SETTLED for value: SETTLED
            /// </summary>
            [EnumMember(Value = "SETTLED")]
            SETTLED = 10,

            /// <summary>
            /// Enum VOIDED for value: VOIDED
            /// </summary>
            [EnumMember(Value = "VOIDED")]
            VOIDED = 11,

            /// <summary>
            /// Enum WAITING for value: WAITING
            /// </summary>
            [EnumMember(Value = "WAITING")]
            WAITING = 12

        }


        /// <summary>
        /// Shows the state of the current transaction.
        /// </summary>
        /// <value>Shows the state of the current transaction.</value>
        [DataMember(Name = "transactionState", EmitDefaultValue = false)]
        public TransactionStateEnum? TransactionState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionResponseAllOf" /> class.
        /// </summary>
        /// <param name="ipgTransactionId">The response transaction ID..</param>
        /// <param name="orderId">Note - Client Order ID if supplied by client. If not supplied by client, IPG will generate. The first 12 alphanumeric digits are passed down to Fiserv Enterprise reporting tool, Clientline and Data File Manager (DFM)..</param>
        /// <param name="transactionType">transactionType.</param>
        /// <param name="paymentToken">paymentToken.</param>
        /// <param name="transactionOrigin">transactionOrigin.</param>
        /// <param name="paymentMethodDetails">paymentMethodDetails.</param>
        /// <param name="country">Country of the card issuer..</param>
        /// <param name="terminalId">The terminal that is processing the transaction..</param>
        /// <param name="merchantId">The unique (on Acquirer level) mechant ID. Usually this value has been chosen from the merchant itself and will be used in communication with the endpoint..</param>
        /// <param name="merchantTransactionId">The unique merchant transaction ID from the request header, if supplied..</param>
        /// <param name="transactionTime">The transaction time in seconds since epoch..</param>
        /// <param name="approvedAmount">approvedAmount.</param>
        /// <param name="transactionStatus">Represents the status of a transaction immediately following the original processing request. This value is not stored for the transaction and is only available in the response when the transaction is processed. TransactionStatus is not returned on either the transaction inquiry or on the order inquiry..</param>
        /// <param name="transactionState">Shows the state of the current transaction..</param>
        /// <param name="paymentAccountReferenceNumber">Payment Account Reference Number from response, if supplied..</param>
        /// <param name="secure3dResponse">secure3dResponse.</param>
        /// <param name="standinResponseDetails">standinResponseDetails.</param>
        /// <param name="redirectURL">The endpoint redirection URL..</param>
        /// <param name="authenticationResponse">authenticationResponse.</param>
        /// <param name="schemeTransactionId">The transaction ID received from schemes for the initial transaction of card on file flows..</param>
        /// <param name="processor">processor.</param>
        /// <param name="additionalDetails">additionalDetails.</param>
        /// <param name="accountUpdaterResponse">accountUpdaterResponse.</param>
        /// <param name="achResponse">achResponse.</param>
        /// <param name="currencyConversionResponse">currencyConversionResponse.</param>
        /// <param name="steps">Steps to be performed by the payer..</param>
        public TransactionResponseAllOf(string ipgTransactionId = default(string), string orderId = default(string), TransactionType? transactionType = default(TransactionType?), PaymentTokenDetails paymentToken = default(PaymentTokenDetails), TransactionOrigin? transactionOrigin = default(TransactionOrigin?), PaymentMethodDetails paymentMethodDetails = default(PaymentMethodDetails), string country = default(string), string terminalId = default(string), string merchantId = default(string), string merchantTransactionId = default(string), long transactionTime = default(long), Amount approvedAmount = default(Amount), TransactionStatusEnum? transactionStatus = default(TransactionStatusEnum?), TransactionStateEnum? transactionState = default(TransactionStateEnum?), string paymentAccountReferenceNumber = default(string), Secure3dResponse secure3dResponse = default(Secure3dResponse), StandinResponseDetails standinResponseDetails = default(StandinResponseDetails), string redirectURL = default(string), Secure3DAuthenticationResponse authenticationResponse = default(Secure3DAuthenticationResponse), string schemeTransactionId = default(string), ProcessorData processor = default(ProcessorData), AdditionalTransactionDetails additionalDetails = default(AdditionalTransactionDetails), AccountUpdaterResponse accountUpdaterResponse = default(AccountUpdaterResponse), AchResponse achResponse = default(AchResponse), CurrencyConversionResponse currencyConversionResponse = default(CurrencyConversionResponse), List<PaymentStepRequest> steps = default(List<PaymentStepRequest>))
        {
            this.IpgTransactionId = ipgTransactionId;
            this.OrderId = orderId;
            this.TransactionType = transactionType;
            this.PaymentToken = paymentToken;
            this.TransactionOrigin = transactionOrigin;
            this.PaymentMethodDetails = paymentMethodDetails;
            this.Country = country;
            this.TerminalId = terminalId;
            this.MerchantId = merchantId;
            this.MerchantTransactionId = merchantTransactionId;
            this.TransactionTime = transactionTime;
            this.ApprovedAmount = approvedAmount;
            this.TransactionStatus = transactionStatus;
            this.TransactionState = transactionState;
            this.PaymentAccountReferenceNumber = paymentAccountReferenceNumber;
            this.Secure3dResponse = secure3dResponse;
            this.StandinResponseDetails = standinResponseDetails;
            this.RedirectURL = redirectURL;
            this.AuthenticationResponse = authenticationResponse;
            this.SchemeTransactionId = schemeTransactionId;
            this.Processor = processor;
            this.AdditionalDetails = additionalDetails;
            this.AccountUpdaterResponse = accountUpdaterResponse;
            this.AchResponse = achResponse;
            this.CurrencyConversionResponse = currencyConversionResponse;
            this.Steps = steps;
        }

        /// <summary>
        /// The response transaction ID.
        /// </summary>
        /// <value>The response transaction ID.</value>
        [DataMember(Name = "ipgTransactionId", EmitDefaultValue = false)]
        public string IpgTransactionId { get; set; }

        /// <summary>
        /// Note - Client Order ID if supplied by client. If not supplied by client, IPG will generate. The first 12 alphanumeric digits are passed down to Fiserv Enterprise reporting tool, Clientline and Data File Manager (DFM).
        /// </summary>
        /// <value>Note - Client Order ID if supplied by client. If not supplied by client, IPG will generate. The first 12 alphanumeric digits are passed down to Fiserv Enterprise reporting tool, Clientline and Data File Manager (DFM).</value>
        [DataMember(Name = "orderId", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets PaymentToken
        /// </summary>
        [DataMember(Name = "paymentToken", EmitDefaultValue = false)]
        public PaymentTokenDetails PaymentToken { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethodDetails
        /// </summary>
        [DataMember(Name = "paymentMethodDetails", EmitDefaultValue = false)]
        public PaymentMethodDetails PaymentMethodDetails { get; set; }

        /// <summary>
        /// Country of the card issuer.
        /// </summary>
        /// <value>Country of the card issuer.</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// The terminal that is processing the transaction.
        /// </summary>
        /// <value>The terminal that is processing the transaction.</value>
        [DataMember(Name = "terminalId", EmitDefaultValue = false)]
        public string TerminalId { get; set; }

        /// <summary>
        /// The unique (on Acquirer level) mechant ID. Usually this value has been chosen from the merchant itself and will be used in communication with the endpoint.
        /// </summary>
        /// <value>The unique (on Acquirer level) mechant ID. Usually this value has been chosen from the merchant itself and will be used in communication with the endpoint.</value>
        [DataMember(Name = "merchantId", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// The unique merchant transaction ID from the request header, if supplied.
        /// </summary>
        /// <value>The unique merchant transaction ID from the request header, if supplied.</value>
        [DataMember(Name = "merchantTransactionId", EmitDefaultValue = false)]
        public string MerchantTransactionId { get; set; }

        /// <summary>
        /// The transaction time in seconds since epoch.
        /// </summary>
        /// <value>The transaction time in seconds since epoch.</value>
        [DataMember(Name = "transactionTime", EmitDefaultValue = false)]
        public long TransactionTime { get; set; }

        /// <summary>
        /// Gets or Sets ApprovedAmount
        /// </summary>
        [DataMember(Name = "approvedAmount", EmitDefaultValue = false)]
        public Amount ApprovedAmount { get; set; }

        /// <summary>
        /// Payment Account Reference Number from response, if supplied.
        /// </summary>
        /// <value>Payment Account Reference Number from response, if supplied.</value>
        [DataMember(Name = "paymentAccountReferenceNumber", EmitDefaultValue = false)]
        public string PaymentAccountReferenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets Secure3dResponse
        /// </summary>
        [DataMember(Name = "secure3dResponse", EmitDefaultValue = false)]
        public Secure3dResponse Secure3dResponse { get; set; }

        /// <summary>
        /// Gets or Sets StandinResponseDetails
        /// </summary>
        [DataMember(Name = "standinResponseDetails", EmitDefaultValue = false)]
        public StandinResponseDetails StandinResponseDetails { get; set; }

        /// <summary>
        /// The endpoint redirection URL.
        /// </summary>
        /// <value>The endpoint redirection URL.</value>
        [DataMember(Name = "redirectURL", EmitDefaultValue = false)]
        public string RedirectURL { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationResponse
        /// </summary>
        [DataMember(Name = "authenticationResponse", EmitDefaultValue = false)]
        public Secure3DAuthenticationResponse AuthenticationResponse { get; set; }

        /// <summary>
        /// The transaction ID received from schemes for the initial transaction of card on file flows.
        /// </summary>
        /// <value>The transaction ID received from schemes for the initial transaction of card on file flows.</value>
        [DataMember(Name = "schemeTransactionId", EmitDefaultValue = false)]
        public string SchemeTransactionId { get; set; }

        /// <summary>
        /// Gets or Sets Processor
        /// </summary>
        [DataMember(Name = "processor", EmitDefaultValue = false)]
        public ProcessorData Processor { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalDetails
        /// </summary>
        [DataMember(Name = "additionalDetails", EmitDefaultValue = false)]
        public AdditionalTransactionDetails AdditionalDetails { get; set; }

        /// <summary>
        /// Gets or Sets AccountUpdaterResponse
        /// </summary>
        [DataMember(Name = "accountUpdaterResponse", EmitDefaultValue = false)]
        public AccountUpdaterResponse AccountUpdaterResponse { get; set; }

        /// <summary>
        /// Gets or Sets AchResponse
        /// </summary>
        [DataMember(Name = "achResponse", EmitDefaultValue = false)]
        public AchResponse AchResponse { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyConversionResponse
        /// </summary>
        [DataMember(Name = "currencyConversionResponse", EmitDefaultValue = false)]
        public CurrencyConversionResponse CurrencyConversionResponse { get; set; }

        /// <summary>
        /// Steps to be performed by the payer.
        /// </summary>
        /// <value>Steps to be performed by the payer.</value>
        [DataMember(Name = "steps", EmitDefaultValue = false)]
        public List<PaymentStepRequest> Steps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionResponseAllOf {\n");
            sb.Append("  IpgTransactionId: ").Append(IpgTransactionId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  PaymentToken: ").Append(PaymentToken).Append("\n");
            sb.Append("  TransactionOrigin: ").Append(TransactionOrigin).Append("\n");
            sb.Append("  PaymentMethodDetails: ").Append(PaymentMethodDetails).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  MerchantTransactionId: ").Append(MerchantTransactionId).Append("\n");
            sb.Append("  TransactionTime: ").Append(TransactionTime).Append("\n");
            sb.Append("  ApprovedAmount: ").Append(ApprovedAmount).Append("\n");
            sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
            sb.Append("  TransactionState: ").Append(TransactionState).Append("\n");
            sb.Append("  PaymentAccountReferenceNumber: ").Append(PaymentAccountReferenceNumber).Append("\n");
            sb.Append("  Secure3dResponse: ").Append(Secure3dResponse).Append("\n");
            sb.Append("  StandinResponseDetails: ").Append(StandinResponseDetails).Append("\n");
            sb.Append("  RedirectURL: ").Append(RedirectURL).Append("\n");
            sb.Append("  AuthenticationResponse: ").Append(AuthenticationResponse).Append("\n");
            sb.Append("  SchemeTransactionId: ").Append(SchemeTransactionId).Append("\n");
            sb.Append("  Processor: ").Append(Processor).Append("\n");
            sb.Append("  AdditionalDetails: ").Append(AdditionalDetails).Append("\n");
            sb.Append("  AccountUpdaterResponse: ").Append(AccountUpdaterResponse).Append("\n");
            sb.Append("  AchResponse: ").Append(AchResponse).Append("\n");
            sb.Append("  CurrencyConversionResponse: ").Append(CurrencyConversionResponse).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransactionResponseAllOf);
        }

        /// <summary>
        /// Returns true if TransactionResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpgTransactionId == input.IpgTransactionId ||
                    (this.IpgTransactionId != null &&
                    this.IpgTransactionId.Equals(input.IpgTransactionId))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    this.TransactionType.Equals(input.TransactionType)
                ) && 
                (
                    this.PaymentToken == input.PaymentToken ||
                    (this.PaymentToken != null &&
                    this.PaymentToken.Equals(input.PaymentToken))
                ) && 
                (
                    this.TransactionOrigin == input.TransactionOrigin ||
                    this.TransactionOrigin.Equals(input.TransactionOrigin)
                ) && 
                (
                    this.PaymentMethodDetails == input.PaymentMethodDetails ||
                    (this.PaymentMethodDetails != null &&
                    this.PaymentMethodDetails.Equals(input.PaymentMethodDetails))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.TerminalId == input.TerminalId ||
                    (this.TerminalId != null &&
                    this.TerminalId.Equals(input.TerminalId))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.MerchantTransactionId == input.MerchantTransactionId ||
                    (this.MerchantTransactionId != null &&
                    this.MerchantTransactionId.Equals(input.MerchantTransactionId))
                ) && 
                (
                    this.TransactionTime == input.TransactionTime ||
                    this.TransactionTime.Equals(input.TransactionTime)
                ) && 
                (
                    this.ApprovedAmount == input.ApprovedAmount ||
                    (this.ApprovedAmount != null &&
                    this.ApprovedAmount.Equals(input.ApprovedAmount))
                ) && 
                (
                    this.TransactionStatus == input.TransactionStatus ||
                    this.TransactionStatus.Equals(input.TransactionStatus)
                ) && 
                (
                    this.TransactionState == input.TransactionState ||
                    this.TransactionState.Equals(input.TransactionState)
                ) && 
                (
                    this.PaymentAccountReferenceNumber == input.PaymentAccountReferenceNumber ||
                    (this.PaymentAccountReferenceNumber != null &&
                    this.PaymentAccountReferenceNumber.Equals(input.PaymentAccountReferenceNumber))
                ) && 
                (
                    this.Secure3dResponse == input.Secure3dResponse ||
                    (this.Secure3dResponse != null &&
                    this.Secure3dResponse.Equals(input.Secure3dResponse))
                ) && 
                (
                    this.StandinResponseDetails == input.StandinResponseDetails ||
                    (this.StandinResponseDetails != null &&
                    this.StandinResponseDetails.Equals(input.StandinResponseDetails))
                ) && 
                (
                    this.RedirectURL == input.RedirectURL ||
                    (this.RedirectURL != null &&
                    this.RedirectURL.Equals(input.RedirectURL))
                ) && 
                (
                    this.AuthenticationResponse == input.AuthenticationResponse ||
                    (this.AuthenticationResponse != null &&
                    this.AuthenticationResponse.Equals(input.AuthenticationResponse))
                ) && 
                (
                    this.SchemeTransactionId == input.SchemeTransactionId ||
                    (this.SchemeTransactionId != null &&
                    this.SchemeTransactionId.Equals(input.SchemeTransactionId))
                ) && 
                (
                    this.Processor == input.Processor ||
                    (this.Processor != null &&
                    this.Processor.Equals(input.Processor))
                ) && 
                (
                    this.AdditionalDetails == input.AdditionalDetails ||
                    (this.AdditionalDetails != null &&
                    this.AdditionalDetails.Equals(input.AdditionalDetails))
                ) && 
                (
                    this.AccountUpdaterResponse == input.AccountUpdaterResponse ||
                    (this.AccountUpdaterResponse != null &&
                    this.AccountUpdaterResponse.Equals(input.AccountUpdaterResponse))
                ) && 
                (
                    this.AchResponse == input.AchResponse ||
                    (this.AchResponse != null &&
                    this.AchResponse.Equals(input.AchResponse))
                ) && 
                (
                    this.CurrencyConversionResponse == input.CurrencyConversionResponse ||
                    (this.CurrencyConversionResponse != null &&
                    this.CurrencyConversionResponse.Equals(input.CurrencyConversionResponse))
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.IpgTransactionId != null)
                    hashCode = hashCode * 59 + this.IpgTransactionId.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                if (this.PaymentToken != null)
                    hashCode = hashCode * 59 + this.PaymentToken.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionOrigin.GetHashCode();
                if (this.PaymentMethodDetails != null)
                    hashCode = hashCode * 59 + this.PaymentMethodDetails.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.TerminalId != null)
                    hashCode = hashCode * 59 + this.TerminalId.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.MerchantTransactionId != null)
                    hashCode = hashCode * 59 + this.MerchantTransactionId.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionTime.GetHashCode();
                if (this.ApprovedAmount != null)
                    hashCode = hashCode * 59 + this.ApprovedAmount.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionStatus.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionState.GetHashCode();
                if (this.PaymentAccountReferenceNumber != null)
                    hashCode = hashCode * 59 + this.PaymentAccountReferenceNumber.GetHashCode();
                if (this.Secure3dResponse != null)
                    hashCode = hashCode * 59 + this.Secure3dResponse.GetHashCode();
                if (this.StandinResponseDetails != null)
                    hashCode = hashCode * 59 + this.StandinResponseDetails.GetHashCode();
                if (this.RedirectURL != null)
                    hashCode = hashCode * 59 + this.RedirectURL.GetHashCode();
                if (this.AuthenticationResponse != null)
                    hashCode = hashCode * 59 + this.AuthenticationResponse.GetHashCode();
                if (this.SchemeTransactionId != null)
                    hashCode = hashCode * 59 + this.SchemeTransactionId.GetHashCode();
                if (this.Processor != null)
                    hashCode = hashCode * 59 + this.Processor.GetHashCode();
                if (this.AdditionalDetails != null)
                    hashCode = hashCode * 59 + this.AdditionalDetails.GetHashCode();
                if (this.AccountUpdaterResponse != null)
                    hashCode = hashCode * 59 + this.AccountUpdaterResponse.GetHashCode();
                if (this.AchResponse != null)
                    hashCode = hashCode * 59 + this.AchResponse.GetHashCode();
                if (this.CurrencyConversionResponse != null)
                    hashCode = hashCode * 59 + this.CurrencyConversionResponse.GetHashCode();
                if (this.Steps != null)
                    hashCode = hashCode * 59 + this.Steps.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // MerchantId (string) maxLength
            if(this.MerchantId != null && this.MerchantId.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantId, length must be less than 30.", new [] { "MerchantId" });
            }

            // MerchantTransactionId (string) maxLength
            if(this.MerchantTransactionId != null && this.MerchantTransactionId.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantTransactionId, length must be less than 40.", new [] { "MerchantTransactionId" });
            }

            // PaymentAccountReferenceNumber (string) maxLength
            if(this.PaymentAccountReferenceNumber != null && this.PaymentAccountReferenceNumber.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentAccountReferenceNumber, length must be less than 30.", new [] { "PaymentAccountReferenceNumber" });
            }

            // SchemeTransactionId (string) maxLength
            if(this.SchemeTransactionId != null && this.SchemeTransactionId.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SchemeTransactionId, length must be less than 40.", new [] { "SchemeTransactionId" });
            }

            yield break;
        }
    }
}
