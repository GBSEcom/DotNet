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
    /// Detailed information about a payment URL.
    /// </summary>
    [DataContract]
    public partial class PaymentUrlDetail :  IEquatable<PaymentUrlDetail>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public PaymentUrlStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentUrlDetail" /> class.
        /// </summary>
        /// <param name="paymentUrl">URL for embedded payment link..</param>
        /// <param name="merchantTransactionId">The unique merchant transaction ID from the request, if supplied..</param>
        /// <param name="orderId">Client order ID if supplied by client, otherwise the order ID..</param>
        /// <param name="requestTime">The transaction time in seconds since epoch..</param>
        /// <param name="status">status.</param>
        public PaymentUrlDetail(string paymentUrl = default(string), string merchantTransactionId = default(string), string orderId = default(string), long requestTime = default(long), PaymentUrlStatus status = default(PaymentUrlStatus))
        {
            this.PaymentUrl = paymentUrl;
            this.MerchantTransactionId = merchantTransactionId;
            this.OrderId = orderId;
            this.RequestTime = requestTime;
            this.Status = status;
        }
        
        /// <summary>
        /// URL for embedded payment link.
        /// </summary>
        /// <value>URL for embedded payment link.</value>
        [DataMember(Name="paymentUrl", EmitDefaultValue=false)]
        public string PaymentUrl { get; set; }

        /// <summary>
        /// The unique merchant transaction ID from the request, if supplied.
        /// </summary>
        /// <value>The unique merchant transaction ID from the request, if supplied.</value>
        [DataMember(Name="merchantTransactionId", EmitDefaultValue=false)]
        public string MerchantTransactionId { get; set; }

        /// <summary>
        /// Client order ID if supplied by client, otherwise the order ID.
        /// </summary>
        /// <value>Client order ID if supplied by client, otherwise the order ID.</value>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The transaction time in seconds since epoch.
        /// </summary>
        /// <value>The transaction time in seconds since epoch.</value>
        [DataMember(Name="requestTime", EmitDefaultValue=false)]
        public long RequestTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentUrlDetail {\n");
            sb.Append("  PaymentUrl: ").Append(PaymentUrl).Append("\n");
            sb.Append("  MerchantTransactionId: ").Append(MerchantTransactionId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  RequestTime: ").Append(RequestTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as PaymentUrlDetail);
        }

        /// <summary>
        /// Returns true if PaymentUrlDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentUrlDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentUrlDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentUrl == input.PaymentUrl ||
                    (this.PaymentUrl != null &&
                    this.PaymentUrl.Equals(input.PaymentUrl))
                ) && 
                (
                    this.MerchantTransactionId == input.MerchantTransactionId ||
                    (this.MerchantTransactionId != null &&
                    this.MerchantTransactionId.Equals(input.MerchantTransactionId))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.RequestTime == input.RequestTime ||
                    this.RequestTime.Equals(input.RequestTime)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                if (this.PaymentUrl != null)
                    hashCode = hashCode * 59 + this.PaymentUrl.GetHashCode();
                if (this.MerchantTransactionId != null)
                    hashCode = hashCode * 59 + this.MerchantTransactionId.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                hashCode = hashCode * 59 + this.RequestTime.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
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
            // MerchantTransactionId (string) maxLength
            if(this.MerchantTransactionId != null && this.MerchantTransactionId.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantTransactionId, length must be less than 40.", new [] { "MerchantTransactionId" });
            }

            yield break;
        }
    }

}
