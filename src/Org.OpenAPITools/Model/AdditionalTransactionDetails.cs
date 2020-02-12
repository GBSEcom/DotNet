/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.9.1.20191223.002
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Additional transaction details for transaction response.
    /// </summary>
    [DataContract]
    public partial class AdditionalTransactionDetails :  IEquatable<AdditionalTransactionDetails>, IValidatableObject
    {
        /// <summary>
        /// The type of debit disbursement transaction.
        /// </summary>
        /// <value>The type of debit disbursement transaction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisbursementTransTypeEnum
        {
            /// <summary>
            /// Enum FUNDING for value: FUNDING
            /// </summary>
            [EnumMember(Value = "FUNDING")]
            FUNDING = 1,

            /// <summary>
            /// Enum DISBURSEMENT for value: DISBURSEMENT
            /// </summary>
            [EnumMember(Value = "DISBURSEMENT")]
            DISBURSEMENT = 2

        }

        /// <summary>
        /// The type of debit disbursement transaction.
        /// </summary>
        /// <value>The type of debit disbursement transaction.</value>
        [DataMember(Name="disbursementTransType", EmitDefaultValue=false)]
        public DisbursementTransTypeEnum? DisbursementTransType { get; set; }
        /// <summary>
        /// The wallet provider type.
        /// </summary>
        /// <value>The wallet provider type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WalletProviderEnum
        {
            /// <summary>
            /// Enum GOOGLEPAY for value: GOOGLE_PAY
            /// </summary>
            [EnumMember(Value = "GOOGLE_PAY")]
            GOOGLEPAY = 1,

            /// <summary>
            /// Enum APPLEPAY for value: APPLE_PAY
            /// </summary>
            [EnumMember(Value = "APPLE_PAY")]
            APPLEPAY = 2,

            /// <summary>
            /// Enum SAMSUNGPAY for value: SAMSUNG_PAY
            /// </summary>
            [EnumMember(Value = "SAMSUNG_PAY")]
            SAMSUNGPAY = 3

        }

        /// <summary>
        /// The wallet provider type.
        /// </summary>
        /// <value>The wallet provider type.</value>
        [DataMember(Name="walletProvider", EmitDefaultValue=false)]
        public WalletProviderEnum? WalletProvider { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalTransactionDetails" /> class.
        /// </summary>
        /// <param name="comments">Comment for the payment..</param>
        /// <param name="invoiceNumber">Invoice number..</param>
        /// <param name="purchaseOrderNumber">Purchase order number..</param>
        /// <param name="disbursementTransType">The type of debit disbursement transaction..</param>
        /// <param name="walletProvider">The wallet provider type..</param>
        public AdditionalTransactionDetails(string comments = default(string), string invoiceNumber = default(string), string purchaseOrderNumber = default(string), DisbursementTransTypeEnum? disbursementTransType = default(DisbursementTransTypeEnum?), WalletProviderEnum? walletProvider = default(WalletProviderEnum?))
        {
            this.Comments = comments;
            this.InvoiceNumber = invoiceNumber;
            this.PurchaseOrderNumber = purchaseOrderNumber;
            this.DisbursementTransType = disbursementTransType;
            this.WalletProvider = walletProvider;
        }
        
        /// <summary>
        /// Comment for the payment.
        /// </summary>
        /// <value>Comment for the payment.</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Invoice number.
        /// </summary>
        /// <value>Invoice number.</value>
        [DataMember(Name="invoiceNumber", EmitDefaultValue=false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Purchase order number.
        /// </summary>
        /// <value>Purchase order number.</value>
        [DataMember(Name="purchaseOrderNumber", EmitDefaultValue=false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalTransactionDetails {\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  DisbursementTransType: ").Append(DisbursementTransType).Append("\n");
            sb.Append("  WalletProvider: ").Append(WalletProvider).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdditionalTransactionDetails);
        }

        /// <summary>
        /// Returns true if AdditionalTransactionDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalTransactionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalTransactionDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
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
                    this.DisbursementTransType == input.DisbursementTransType ||
                    this.DisbursementTransType.Equals(input.DisbursementTransType)
                ) && 
                (
                    this.WalletProvider == input.WalletProvider ||
                    this.WalletProvider.Equals(input.WalletProvider)
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
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                if (this.PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderNumber.GetHashCode();
                hashCode = hashCode * 59 + this.DisbursementTransType.GetHashCode();
                hashCode = hashCode * 59 + this.WalletProvider.GetHashCode();
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
            // Comments (string) maxLength
            if(this.Comments != null && this.Comments.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Comments, length must be less than 1024.", new [] { "Comments" });
            }

            // InvoiceNumber (string) maxLength
            if(this.InvoiceNumber != null && this.InvoiceNumber.Length > 48)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InvoiceNumber, length must be less than 48.", new [] { "InvoiceNumber" });
            }

            // PurchaseOrderNumber (string) maxLength
            if(this.PurchaseOrderNumber != null && this.PurchaseOrderNumber.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PurchaseOrderNumber, length must be less than 128.", new [] { "PurchaseOrderNumber" });
            }

            yield break;
        }
    }

}
