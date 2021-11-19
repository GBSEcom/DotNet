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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Request to create pre-auth transaction using credit card.
    /// </summary>
    [DataContract(Name = "PaymentCardPreAuthTransaction")]
    [JsonConverter(typeof(JsonSubtypes), "RequestType")]
    public partial class PaymentCardPreAuthTransaction : PrimaryTransaction, IEquatable<PaymentCardPreAuthTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardPreAuthTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentCardPreAuthTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardPreAuthTransaction" /> class.
        /// </summary>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="storedCredentials">storedCredentials.</param>
        /// <param name="createToken">createToken.</param>
        /// <param name="splitShipment">splitShipment.</param>
        /// <param name="settlementSplit">Settle with multiple sub-merchants, sale and preAuth only..</param>
        /// <param name="authenticationRequest">authenticationRequest.</param>
        /// <param name="authenticationResult">authenticationResult.</param>
        /// <param name="decrementalFlag">This flag can only be used in a preAuth transaction that updates the amount of a previous preAuth transaction to either increase the preAuth amount (DecrementalPreAuthFlag &#x3D; false) or decrease the preAuth amount (DecrementalPreAuthFlag &#x3D; true). (default to false).</param>
        /// <param name="requestType">Object name of the primary transaction request. (required) (default to &quot;PaymentCardPreAuthTransaction&quot;).</param>
        /// <param name="transactionAmount">transactionAmount (required).</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same app..</param>
        /// <param name="merchantTransactionId">The unique merchant transaction ID from the request header, if supplied..</param>
        /// <param name="transactionOrigin">transactionOrigin.</param>
        /// <param name="order">order.</param>
        /// <param name="ipgTransactionId">The IPG transactionId to reference a payerauth for example..</param>
        /// <param name="allowPartialApproval">Indicates if the particular transaction is a partial approval transaction, if supplied..</param>
        public PaymentCardPreAuthTransaction(PaymentCardPaymentMethod paymentMethod = default(PaymentCardPaymentMethod), StoredCredential storedCredentials = default(StoredCredential), CreatePaymentToken createToken = default(CreatePaymentToken), SplitShipment splitShipment = default(SplitShipment), List<SubMerchantSplit> settlementSplit = default(List<SubMerchantSplit>), AuthenticationRequest authenticationRequest = default(AuthenticationRequest), AuthenticationResult authenticationResult = default(AuthenticationResult), bool decrementalFlag = false, string requestType = "PaymentCardPreAuthTransaction", Amount transactionAmount = default(Amount), string storeId = default(string), string merchantTransactionId = default(string), TransactionOrigin? transactionOrigin = default(TransactionOrigin?), Order order = default(Order), long? ipgTransactionId = default(long?), bool allowPartialApproval = default(bool)) : base(requestType, transactionAmount, storeId, merchantTransactionId, transactionOrigin, order, ipgTransactionId, allowPartialApproval)
        {
            this.PaymentMethod = paymentMethod;
            this.StoredCredentials = storedCredentials;
            this.CreateToken = createToken;
            this.SplitShipment = splitShipment;
            this.SettlementSplit = settlementSplit;
            this.AuthenticationRequest = authenticationRequest;
            this.AuthenticationResult = authenticationResult;
            this.DecrementalFlag = decrementalFlag;
        }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        public PaymentCardPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets StoredCredentials
        /// </summary>
        [DataMember(Name = "storedCredentials", EmitDefaultValue = false)]
        public StoredCredential StoredCredentials { get; set; }

        /// <summary>
        /// Gets or Sets CreateToken
        /// </summary>
        [DataMember(Name = "createToken", EmitDefaultValue = false)]
        public CreatePaymentToken CreateToken { get; set; }

        /// <summary>
        /// Gets or Sets SplitShipment
        /// </summary>
        [DataMember(Name = "splitShipment", EmitDefaultValue = false)]
        public SplitShipment SplitShipment { get; set; }

        /// <summary>
        /// Settle with multiple sub-merchants, sale and preAuth only.
        /// </summary>
        /// <value>Settle with multiple sub-merchants, sale and preAuth only.</value>
        [DataMember(Name = "settlementSplit", EmitDefaultValue = false)]
        public List<SubMerchantSplit> SettlementSplit { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationRequest
        /// </summary>
        [DataMember(Name = "authenticationRequest", EmitDefaultValue = false)]
        public AuthenticationRequest AuthenticationRequest { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationResult
        /// </summary>
        [DataMember(Name = "authenticationResult", EmitDefaultValue = false)]
        public AuthenticationResult AuthenticationResult { get; set; }

        /// <summary>
        /// This flag can only be used in a preAuth transaction that updates the amount of a previous preAuth transaction to either increase the preAuth amount (DecrementalPreAuthFlag &#x3D; false) or decrease the preAuth amount (DecrementalPreAuthFlag &#x3D; true).
        /// </summary>
        /// <value>This flag can only be used in a preAuth transaction that updates the amount of a previous preAuth transaction to either increase the preAuth amount (DecrementalPreAuthFlag &#x3D; false) or decrease the preAuth amount (DecrementalPreAuthFlag &#x3D; true).</value>
        [DataMember(Name = "decrementalFlag", EmitDefaultValue = true)]
        public bool DecrementalFlag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCardPreAuthTransaction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  StoredCredentials: ").Append(StoredCredentials).Append("\n");
            sb.Append("  CreateToken: ").Append(CreateToken).Append("\n");
            sb.Append("  SplitShipment: ").Append(SplitShipment).Append("\n");
            sb.Append("  SettlementSplit: ").Append(SettlementSplit).Append("\n");
            sb.Append("  AuthenticationRequest: ").Append(AuthenticationRequest).Append("\n");
            sb.Append("  AuthenticationResult: ").Append(AuthenticationResult).Append("\n");
            sb.Append("  DecrementalFlag: ").Append(DecrementalFlag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as PaymentCardPreAuthTransaction);
        }

        /// <summary>
        /// Returns true if PaymentCardPreAuthTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentCardPreAuthTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCardPreAuthTransaction input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && base.Equals(input) && 
                (
                    this.StoredCredentials == input.StoredCredentials ||
                    (this.StoredCredentials != null &&
                    this.StoredCredentials.Equals(input.StoredCredentials))
                ) && base.Equals(input) && 
                (
                    this.CreateToken == input.CreateToken ||
                    (this.CreateToken != null &&
                    this.CreateToken.Equals(input.CreateToken))
                ) && base.Equals(input) && 
                (
                    this.SplitShipment == input.SplitShipment ||
                    (this.SplitShipment != null &&
                    this.SplitShipment.Equals(input.SplitShipment))
                ) && base.Equals(input) && 
                (
                    this.SettlementSplit == input.SettlementSplit ||
                    this.SettlementSplit != null &&
                    input.SettlementSplit != null &&
                    this.SettlementSplit.SequenceEqual(input.SettlementSplit)
                ) && base.Equals(input) && 
                (
                    this.AuthenticationRequest == input.AuthenticationRequest ||
                    (this.AuthenticationRequest != null &&
                    this.AuthenticationRequest.Equals(input.AuthenticationRequest))
                ) && base.Equals(input) && 
                (
                    this.AuthenticationResult == input.AuthenticationResult ||
                    (this.AuthenticationResult != null &&
                    this.AuthenticationResult.Equals(input.AuthenticationResult))
                ) && base.Equals(input) && 
                (
                    this.DecrementalFlag == input.DecrementalFlag ||
                    this.DecrementalFlag.Equals(input.DecrementalFlag)
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
                int hashCode = base.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.StoredCredentials != null)
                    hashCode = hashCode * 59 + this.StoredCredentials.GetHashCode();
                if (this.CreateToken != null)
                    hashCode = hashCode * 59 + this.CreateToken.GetHashCode();
                if (this.SplitShipment != null)
                    hashCode = hashCode * 59 + this.SplitShipment.GetHashCode();
                if (this.SettlementSplit != null)
                    hashCode = hashCode * 59 + this.SettlementSplit.GetHashCode();
                if (this.AuthenticationRequest != null)
                    hashCode = hashCode * 59 + this.AuthenticationRequest.GetHashCode();
                if (this.AuthenticationResult != null)
                    hashCode = hashCode * 59 + this.AuthenticationResult.GetHashCode();
                hashCode = hashCode * 59 + this.DecrementalFlag.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }
}
