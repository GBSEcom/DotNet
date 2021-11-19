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
    /// Request to create preAuth primary transaction using digital wallet.
    /// </summary>
    [DataContract(Name = "WalletPreAuthTransaction")]
    [JsonConverter(typeof(JsonSubtypes), "RequestType")]
    public partial class WalletPreAuthTransaction : PrimaryTransaction, IEquatable<WalletPreAuthTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletPreAuthTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WalletPreAuthTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletPreAuthTransaction" /> class.
        /// </summary>
        /// <param name="walletPaymentMethod">walletPaymentMethod (required).</param>
        /// <param name="splitShipment">splitShipment.</param>
        /// <param name="paymentFacilitator">paymentFacilitator.</param>
        /// <param name="decrementalFlag">This flag can only be used in a preAuth transaction that updates the amount of a previous preAuth transaction to either increase the preAuth amount (DecrementalPreAuthFlag &#x3D; false) or decrease the preAuth amount (DecrementalPreAuthFlag &#x3D; true). (default to false).</param>
        /// <param name="requestType">Object name of the primary transaction request. (required) (default to &quot;WalletPreAuthTransaction&quot;).</param>
        /// <param name="transactionAmount">transactionAmount (required).</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same app..</param>
        /// <param name="merchantTransactionId">The unique merchant transaction ID from the request header, if supplied..</param>
        /// <param name="transactionOrigin">transactionOrigin.</param>
        /// <param name="order">order.</param>
        /// <param name="ipgTransactionId">The IPG transactionId to reference a payerauth for example..</param>
        /// <param name="allowPartialApproval">Indicates if the particular transaction is a partial approval transaction, if supplied..</param>
        public WalletPreAuthTransaction(WalletPaymentMethod walletPaymentMethod = default(WalletPaymentMethod), SplitShipment splitShipment = default(SplitShipment), PaymentFacilitator paymentFacilitator = default(PaymentFacilitator), bool decrementalFlag = false, string requestType = "WalletPreAuthTransaction", Amount transactionAmount = default(Amount), string storeId = default(string), string merchantTransactionId = default(string), TransactionOrigin? transactionOrigin = default(TransactionOrigin?), Order order = default(Order), long? ipgTransactionId = default(long?), bool allowPartialApproval = default(bool)) : base(requestType, transactionAmount, storeId, merchantTransactionId, transactionOrigin, order, ipgTransactionId, allowPartialApproval)
        {
            // to ensure "walletPaymentMethod" is required (not null)
            this.WalletPaymentMethod = walletPaymentMethod ?? throw new ArgumentNullException("walletPaymentMethod is a required property for WalletPreAuthTransaction and cannot be null");
            this.SplitShipment = splitShipment;
            this.PaymentFacilitator = paymentFacilitator;
            this.DecrementalFlag = decrementalFlag;
        }

        /// <summary>
        /// Gets or Sets WalletPaymentMethod
        /// </summary>
        [DataMember(Name = "walletPaymentMethod", IsRequired = true, EmitDefaultValue = false)]
        public WalletPaymentMethod WalletPaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets SplitShipment
        /// </summary>
        [DataMember(Name = "splitShipment", EmitDefaultValue = false)]
        public SplitShipment SplitShipment { get; set; }

        /// <summary>
        /// Gets or Sets PaymentFacilitator
        /// </summary>
        [DataMember(Name = "paymentFacilitator", EmitDefaultValue = false)]
        public PaymentFacilitator PaymentFacilitator { get; set; }

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
            sb.Append("class WalletPreAuthTransaction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  WalletPaymentMethod: ").Append(WalletPaymentMethod).Append("\n");
            sb.Append("  SplitShipment: ").Append(SplitShipment).Append("\n");
            sb.Append("  PaymentFacilitator: ").Append(PaymentFacilitator).Append("\n");
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
            return this.Equals(input as WalletPreAuthTransaction);
        }

        /// <summary>
        /// Returns true if WalletPreAuthTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletPreAuthTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletPreAuthTransaction input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.WalletPaymentMethod == input.WalletPaymentMethod ||
                    (this.WalletPaymentMethod != null &&
                    this.WalletPaymentMethod.Equals(input.WalletPaymentMethod))
                ) && base.Equals(input) && 
                (
                    this.SplitShipment == input.SplitShipment ||
                    (this.SplitShipment != null &&
                    this.SplitShipment.Equals(input.SplitShipment))
                ) && base.Equals(input) && 
                (
                    this.PaymentFacilitator == input.PaymentFacilitator ||
                    (this.PaymentFacilitator != null &&
                    this.PaymentFacilitator.Equals(input.PaymentFacilitator))
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
                if (this.WalletPaymentMethod != null)
                    hashCode = hashCode * 59 + this.WalletPaymentMethod.GetHashCode();
                if (this.SplitShipment != null)
                    hashCode = hashCode * 59 + this.SplitShipment.GetHashCode();
                if (this.PaymentFacilitator != null)
                    hashCode = hashCode * 59 + this.PaymentFacilitator.GetHashCode();
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
