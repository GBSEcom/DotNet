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
    /// Request to generate an embedded payment link.
    /// </summary>
    [DataContract(Name = "PaymentUrlRequest")]
    public partial class PaymentUrlRequest : IEquatable<PaymentUrlRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TransactionType
        /// </summary>
        [DataMember(Name = "transactionType", IsRequired = true, EmitDefaultValue = false)]
        public TransactionType TransactionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentUrlRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentUrlRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentUrlRequest" /> class.
        /// </summary>
        /// <param name="storeId">An optional Outlet ID for clients that support multiple stores in the same developer app..</param>
        /// <param name="clientLocale">clientLocale.</param>
        /// <param name="transactionAmount">transactionAmount (required).</param>
        /// <param name="transactionType">transactionType (required).</param>
        /// <param name="orderId">Note - Client Order ID if supplied by client. If not supplied by client, IPG will generate. The first 12 alphanumeric digits are passed down to Fiserv Enterprise reporting tool, Clientline and Data File Manager (DFM)..</param>
        /// <param name="billing">billing.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="transactionNotificationURL">URL for notifying merchant of payment result..</param>
        /// <param name="expiration">Time until payment URL expires..</param>
        /// <param name="authenticateTransaction">If 3D secure should be applied..</param>
        /// <param name="dynamicMerchantName">Dynamic merchant name for the cardholder&#39;s statement..</param>
        /// <param name="invoiceNumber">Invoice number..</param>
        /// <param name="purchaseOrderNumber">Purchase order number..</param>
        /// <param name="hostedPaymentPageText">The text to be displayed to the payer on the hosted payment page..</param>
        /// <param name="ip">IPv4 or IPv6 network address..</param>
        /// <param name="revolvingOptions">revolvingOptions.</param>
        /// <param name="installmentOptions">installmentOptions.</param>
        /// <param name="basket">basket.</param>
        public PaymentUrlRequest(string storeId = default(string), ClientLocale clientLocale = default(ClientLocale), Amount transactionAmount = default(Amount), TransactionType transactionType = default(TransactionType), string orderId = default(string), Billing billing = default(Billing), Shipping shipping = default(Shipping), string transactionNotificationURL = default(string), long expiration = default(long), bool authenticateTransaction = default(bool), string dynamicMerchantName = default(string), string invoiceNumber = default(string), string purchaseOrderNumber = default(string), string hostedPaymentPageText = default(string), string ip = default(string), RevolvingOptions revolvingOptions = default(RevolvingOptions), InstallmentOptions installmentOptions = default(InstallmentOptions), Basket basket = default(Basket))
        {
            // to ensure "transactionAmount" is required (not null)
            this.TransactionAmount = transactionAmount ?? throw new ArgumentNullException("transactionAmount is a required property for PaymentUrlRequest and cannot be null");
            this.TransactionType = transactionType;
            this.StoreId = storeId;
            this.ClientLocale = clientLocale;
            this.OrderId = orderId;
            this.Billing = billing;
            this.Shipping = shipping;
            this.TransactionNotificationURL = transactionNotificationURL;
            this.Expiration = expiration;
            this.AuthenticateTransaction = authenticateTransaction;
            this.DynamicMerchantName = dynamicMerchantName;
            this.InvoiceNumber = invoiceNumber;
            this.PurchaseOrderNumber = purchaseOrderNumber;
            this.HostedPaymentPageText = hostedPaymentPageText;
            this.Ip = ip;
            this.RevolvingOptions = revolvingOptions;
            this.InstallmentOptions = installmentOptions;
            this.Basket = basket;
        }

        /// <summary>
        /// An optional Outlet ID for clients that support multiple stores in the same developer app.
        /// </summary>
        /// <value>An optional Outlet ID for clients that support multiple stores in the same developer app.</value>
        [DataMember(Name = "storeId", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Gets or Sets ClientLocale
        /// </summary>
        [DataMember(Name = "clientLocale", EmitDefaultValue = false)]
        public ClientLocale ClientLocale { get; set; }

        /// <summary>
        /// Gets or Sets TransactionAmount
        /// </summary>
        [DataMember(Name = "transactionAmount", IsRequired = true, EmitDefaultValue = false)]
        public Amount TransactionAmount { get; set; }

        /// <summary>
        /// Note - Client Order ID if supplied by client. If not supplied by client, IPG will generate. The first 12 alphanumeric digits are passed down to Fiserv Enterprise reporting tool, Clientline and Data File Manager (DFM).
        /// </summary>
        /// <value>Note - Client Order ID if supplied by client. If not supplied by client, IPG will generate. The first 12 alphanumeric digits are passed down to Fiserv Enterprise reporting tool, Clientline and Data File Manager (DFM).</value>
        [DataMember(Name = "orderId", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets Billing
        /// </summary>
        [DataMember(Name = "billing", EmitDefaultValue = false)]
        public Billing Billing { get; set; }

        /// <summary>
        /// Gets or Sets Shipping
        /// </summary>
        [DataMember(Name = "shipping", EmitDefaultValue = false)]
        public Shipping Shipping { get; set; }

        /// <summary>
        /// URL for notifying merchant of payment result.
        /// </summary>
        /// <value>URL for notifying merchant of payment result.</value>
        [DataMember(Name = "transactionNotificationURL", EmitDefaultValue = false)]
        public string TransactionNotificationURL { get; set; }

        /// <summary>
        /// Time until payment URL expires.
        /// </summary>
        /// <value>Time until payment URL expires.</value>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        public long Expiration { get; set; }

        /// <summary>
        /// If 3D secure should be applied.
        /// </summary>
        /// <value>If 3D secure should be applied.</value>
        [DataMember(Name = "authenticateTransaction", EmitDefaultValue = true)]
        public bool? AuthenticateTransaction { get; set; }

        /// <summary>
        /// Dynamic merchant name for the cardholder&#39;s statement.
        /// </summary>
        /// <value>Dynamic merchant name for the cardholder&#39;s statement.</value>
        [DataMember(Name = "dynamicMerchantName", EmitDefaultValue = false)]
        public string DynamicMerchantName { get; set; }

        /// <summary>
        /// Invoice number.
        /// </summary>
        /// <value>Invoice number.</value>
        [DataMember(Name = "invoiceNumber", EmitDefaultValue = false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Purchase order number.
        /// </summary>
        /// <value>Purchase order number.</value>
        [DataMember(Name = "purchaseOrderNumber", EmitDefaultValue = false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// The text to be displayed to the payer on the hosted payment page.
        /// </summary>
        /// <value>The text to be displayed to the payer on the hosted payment page.</value>
        [DataMember(Name = "hostedPaymentPageText", EmitDefaultValue = false)]
        public string HostedPaymentPageText { get; set; }

        /// <summary>
        /// IPv4 or IPv6 network address.
        /// </summary>
        /// <value>IPv4 or IPv6 network address.</value>
        [DataMember(Name = "ip", EmitDefaultValue = false)]
        public string Ip { get; set; }

        /// <summary>
        /// Gets or Sets RevolvingOptions
        /// </summary>
        [DataMember(Name = "revolvingOptions", EmitDefaultValue = false)]
        public RevolvingOptions RevolvingOptions { get; set; }

        /// <summary>
        /// Gets or Sets InstallmentOptions
        /// </summary>
        [DataMember(Name = "installmentOptions", EmitDefaultValue = false)]
        public InstallmentOptions InstallmentOptions { get; set; }

        /// <summary>
        /// Gets or Sets Basket
        /// </summary>
        [DataMember(Name = "basket", EmitDefaultValue = false)]
        public Basket Basket { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentUrlRequest {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  ClientLocale: ").Append(ClientLocale).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Billing: ").Append(Billing).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  TransactionNotificationURL: ").Append(TransactionNotificationURL).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  AuthenticateTransaction: ").Append(AuthenticateTransaction).Append("\n");
            sb.Append("  DynamicMerchantName: ").Append(DynamicMerchantName).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  HostedPaymentPageText: ").Append(HostedPaymentPageText).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  RevolvingOptions: ").Append(RevolvingOptions).Append("\n");
            sb.Append("  InstallmentOptions: ").Append(InstallmentOptions).Append("\n");
            sb.Append("  Basket: ").Append(Basket).Append("\n");
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
            return this.Equals(input as PaymentUrlRequest);
        }

        /// <summary>
        /// Returns true if PaymentUrlRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentUrlRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentUrlRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.ClientLocale == input.ClientLocale ||
                    (this.ClientLocale != null &&
                    this.ClientLocale.Equals(input.ClientLocale))
                ) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    this.TransactionType.Equals(input.TransactionType)
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Billing == input.Billing ||
                    (this.Billing != null &&
                    this.Billing.Equals(input.Billing))
                ) && 
                (
                    this.Shipping == input.Shipping ||
                    (this.Shipping != null &&
                    this.Shipping.Equals(input.Shipping))
                ) && 
                (
                    this.TransactionNotificationURL == input.TransactionNotificationURL ||
                    (this.TransactionNotificationURL != null &&
                    this.TransactionNotificationURL.Equals(input.TransactionNotificationURL))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    this.Expiration.Equals(input.Expiration)
                ) && 
                (
                    this.AuthenticateTransaction == input.AuthenticateTransaction ||
                    this.AuthenticateTransaction.Equals(input.AuthenticateTransaction)
                ) && 
                (
                    this.DynamicMerchantName == input.DynamicMerchantName ||
                    (this.DynamicMerchantName != null &&
                    this.DynamicMerchantName.Equals(input.DynamicMerchantName))
                ) && 
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) && 
                (
                    this.PurchaseOrderNumber == input.PurchaseOrderNumber ||
                    (this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(input.PurchaseOrderNumber))
                ) && 
                (
                    this.HostedPaymentPageText == input.HostedPaymentPageText ||
                    (this.HostedPaymentPageText != null &&
                    this.HostedPaymentPageText.Equals(input.HostedPaymentPageText))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.RevolvingOptions == input.RevolvingOptions ||
                    (this.RevolvingOptions != null &&
                    this.RevolvingOptions.Equals(input.RevolvingOptions))
                ) && 
                (
                    this.InstallmentOptions == input.InstallmentOptions ||
                    (this.InstallmentOptions != null &&
                    this.InstallmentOptions.Equals(input.InstallmentOptions))
                ) && 
                (
                    this.Basket == input.Basket ||
                    (this.Basket != null &&
                    this.Basket.Equals(input.Basket))
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
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.ClientLocale != null)
                    hashCode = hashCode * 59 + this.ClientLocale.GetHashCode();
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Billing != null)
                    hashCode = hashCode * 59 + this.Billing.GetHashCode();
                if (this.Shipping != null)
                    hashCode = hashCode * 59 + this.Shipping.GetHashCode();
                if (this.TransactionNotificationURL != null)
                    hashCode = hashCode * 59 + this.TransactionNotificationURL.GetHashCode();
                hashCode = hashCode * 59 + this.Expiration.GetHashCode();
                hashCode = hashCode * 59 + this.AuthenticateTransaction.GetHashCode();
                if (this.DynamicMerchantName != null)
                    hashCode = hashCode * 59 + this.DynamicMerchantName.GetHashCode();
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                if (this.PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderNumber.GetHashCode();
                if (this.HostedPaymentPageText != null)
                    hashCode = hashCode * 59 + this.HostedPaymentPageText.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.RevolvingOptions != null)
                    hashCode = hashCode * 59 + this.RevolvingOptions.GetHashCode();
                if (this.InstallmentOptions != null)
                    hashCode = hashCode * 59 + this.InstallmentOptions.GetHashCode();
                if (this.Basket != null)
                    hashCode = hashCode * 59 + this.Basket.GetHashCode();
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
            // StoreId (string) maxLength
            if(this.StoreId != null && this.StoreId.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StoreId, length must be less than 20.", new [] { "StoreId" });
            }

            // HostedPaymentPageText (string) maxLength
            if(this.HostedPaymentPageText != null && this.HostedPaymentPageText.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HostedPaymentPageText, length must be less than 255.", new [] { "HostedPaymentPageText" });
            }

            yield break;
        }
    }
}
