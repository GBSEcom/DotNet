/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.6.0.20190507.002
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
    /// The payment object for AliPay transactions. Use this to populate AliPay payment method details.
    /// </summary>
    [DataContract]
    public partial class AliPay :  IEquatable<AliPay>, IValidatableObject
    {
        /// <summary>
        /// Use this to indicate the type of machine-readable payment data for scanning.
        /// </summary>
        /// <value>Use this to indicate the type of machine-readable payment data for scanning.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentDataTypeEnum
        {
            /// <summary>
            /// Enum BARCODE for value: BARCODE
            /// </summary>
            [EnumMember(Value = "BARCODE")]
            BARCODE = 1,

            /// <summary>
            /// Enum QRCODE for value: QRCODE
            /// </summary>
            [EnumMember(Value = "QRCODE")]
            QRCODE = 2

        }

        /// <summary>
        /// Use this to indicate the type of machine-readable payment data for scanning.
        /// </summary>
        /// <value>Use this to indicate the type of machine-readable payment data for scanning.</value>
        [DataMember(Name="paymentDataType", EmitDefaultValue=false)]
        public PaymentDataTypeEnum PaymentDataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AliPay" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AliPay() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AliPay" /> class.
        /// </summary>
        /// <param name="paymentDataType">Use this to indicate the type of machine-readable payment data for scanning. (required).</param>
        /// <param name="paymentData">Use this to send payment-related information, such as customer identity ID. (required).</param>
        /// <param name="orderTitle">Use this to send an order title that shows up in the statement. (required).</param>
        /// <param name="orderDetails">Use this to send order details that show up in the statement. (required).</param>
        public AliPay(PaymentDataTypeEnum paymentDataType = default(PaymentDataTypeEnum), string paymentData = default(string), string orderTitle = default(string), string orderDetails = default(string))
        {
            this.PaymentDataType = paymentDataType;
            // to ensure "paymentData" is required (not null)
            if (paymentData == null)
            {
                throw new InvalidDataException("paymentData is a required property for AliPay and cannot be null");
            }
            else
            {
                this.PaymentData = paymentData;
            }

            // to ensure "orderTitle" is required (not null)
            if (orderTitle == null)
            {
                throw new InvalidDataException("orderTitle is a required property for AliPay and cannot be null");
            }
            else
            {
                this.OrderTitle = orderTitle;
            }

            // to ensure "orderDetails" is required (not null)
            if (orderDetails == null)
            {
                throw new InvalidDataException("orderDetails is a required property for AliPay and cannot be null");
            }
            else
            {
                this.OrderDetails = orderDetails;
            }

        }
        
        /// <summary>
        /// Use this to send payment-related information, such as customer identity ID.
        /// </summary>
        /// <value>Use this to send payment-related information, such as customer identity ID.</value>
        [DataMember(Name="paymentData", EmitDefaultValue=false)]
        public string PaymentData { get; set; }

        /// <summary>
        /// Use this to send an order title that shows up in the statement.
        /// </summary>
        /// <value>Use this to send an order title that shows up in the statement.</value>
        [DataMember(Name="orderTitle", EmitDefaultValue=false)]
        public string OrderTitle { get; set; }

        /// <summary>
        /// Use this to send order details that show up in the statement.
        /// </summary>
        /// <value>Use this to send order details that show up in the statement.</value>
        [DataMember(Name="orderDetails", EmitDefaultValue=false)]
        public string OrderDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AliPay {\n");
            sb.Append("  PaymentDataType: ").Append(PaymentDataType).Append("\n");
            sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
            sb.Append("  OrderTitle: ").Append(OrderTitle).Append("\n");
            sb.Append("  OrderDetails: ").Append(OrderDetails).Append("\n");
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
            return this.Equals(input as AliPay);
        }

        /// <summary>
        /// Returns true if AliPay instances are equal
        /// </summary>
        /// <param name="input">Instance of AliPay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AliPay input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentDataType == input.PaymentDataType ||
                    this.PaymentDataType.Equals(input.PaymentDataType)
                ) && 
                (
                    this.PaymentData == input.PaymentData ||
                    (this.PaymentData != null &&
                    this.PaymentData.Equals(input.PaymentData))
                ) && 
                (
                    this.OrderTitle == input.OrderTitle ||
                    (this.OrderTitle != null &&
                    this.OrderTitle.Equals(input.OrderTitle))
                ) && 
                (
                    this.OrderDetails == input.OrderDetails ||
                    (this.OrderDetails != null &&
                    this.OrderDetails.Equals(input.OrderDetails))
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
                hashCode = hashCode * 59 + this.PaymentDataType.GetHashCode();
                if (this.PaymentData != null)
                    hashCode = hashCode * 59 + this.PaymentData.GetHashCode();
                if (this.OrderTitle != null)
                    hashCode = hashCode * 59 + this.OrderTitle.GetHashCode();
                if (this.OrderDetails != null)
                    hashCode = hashCode * 59 + this.OrderDetails.GetHashCode();
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
            // PaymentData (string) maxLength
            if(this.PaymentData != null && this.PaymentData.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentData, length must be less than 100.", new [] { "PaymentData" });
            }

            // PaymentData (string) pattern
            Regex regexPaymentData = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexPaymentData.Match(this.PaymentData).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentData, must match a pattern of " + regexPaymentData, new [] { "PaymentData" });
            }

            // OrderTitle (string) maxLength
            if(this.OrderTitle != null && this.OrderTitle.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OrderTitle, length must be less than 100.", new [] { "OrderTitle" });
            }

            // OrderTitle (string) pattern
            Regex regexOrderTitle = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexOrderTitle.Match(this.OrderTitle).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OrderTitle, must match a pattern of " + regexOrderTitle, new [] { "OrderTitle" });
            }

            // OrderDetails (string) maxLength
            if(this.OrderDetails != null && this.OrderDetails.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OrderDetails, length must be less than 1024.", new [] { "OrderDetails" });
            }

            // OrderDetails (string) pattern
            Regex regexOrderDetails = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexOrderDetails.Match(this.OrderDetails).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OrderDetails, must match a pattern of " + regexOrderDetails, new [] { "OrderDetails" });
            }

            yield break;
        }
    }

}