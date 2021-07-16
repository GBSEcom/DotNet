/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.3.0.20210608.001
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
    /// Order response with error field included.
    /// </summary>
    [DataContract]
    public partial class OrderErrorResponse : IEquatable<OrderErrorResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ResponseType
        /// </summary>
        [DataMember(Name = "responseType", EmitDefaultValue = false)]
        public ResponseType? ResponseType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderErrorResponse" /> class.
        /// </summary>
        /// <param name="clientRequestId">Echoes back the value in the request header for tracking..</param>
        /// <param name="apiTraceId">Request identifier in API, can be used to request logs from the support team..</param>
        /// <param name="responseType">responseType.</param>
        /// <param name="orderId">Note - Client Order ID if supplied by client. If not supplied by client, IPG will generate. The first 12 alphanumeric digits are passed down to Fiserv Enterprise reporting tool, Clientline and Data File Manager (DFM)..</param>
        /// <param name="billing">billing.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="transactions">Required for some payment methods (for example, Klarna)..</param>
        /// <param name="additionalDetails">additionalDetails.</param>
        /// <param name="error">error.</param>
        public OrderErrorResponse(string clientRequestId = default(string), string apiTraceId = default(string), ResponseType responseType = default(ResponseType), string orderId = default(string), Billing billing = default(Billing), Shipping shipping = default(Shipping), List<TransactionResponse> transactions = default(List<TransactionResponse>), AdditionalDetails additionalDetails = default(AdditionalDetails), Error error = default(Error))
        {
            this.ClientRequestId = clientRequestId;
            this.ApiTraceId = apiTraceId;
            this.ResponseType = responseType;
            this.OrderId = orderId;
            this.Billing = billing;
            this.Shipping = shipping;
            this.Transactions = transactions;
            this.AdditionalDetails = additionalDetails;
            this.Error = error;
        }

        /// <summary>
        /// Echoes back the value in the request header for tracking.
        /// </summary>
        /// <value>Echoes back the value in the request header for tracking.</value>
        [DataMember(Name = "clientRequestId", EmitDefaultValue = false)]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Request identifier in API, can be used to request logs from the support team.
        /// </summary>
        /// <value>Request identifier in API, can be used to request logs from the support team.</value>
        [DataMember(Name = "apiTraceId", EmitDefaultValue = false)]
        public string ApiTraceId { get; set; }

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
        /// Required for some payment methods (for example, Klarna).
        /// </summary>
        /// <value>Required for some payment methods (for example, Klarna).</value>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public List<TransactionResponse> Transactions { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalDetails
        /// </summary>
        [DataMember(Name = "additionalDetails", EmitDefaultValue = false)]
        public AdditionalDetails AdditionalDetails { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public Error Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderErrorResponse {\n");
            sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  ApiTraceId: ").Append(ApiTraceId).Append("\n");
            sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Billing: ").Append(Billing).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  AdditionalDetails: ").Append(AdditionalDetails).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as OrderErrorResponse);
        }

        /// <summary>
        /// Returns true if OrderErrorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderErrorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderErrorResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientRequestId == input.ClientRequestId ||
                    (this.ClientRequestId != null &&
                    this.ClientRequestId.Equals(input.ClientRequestId))
                ) && 
                (
                    this.ApiTraceId == input.ApiTraceId ||
                    (this.ApiTraceId != null &&
                    this.ApiTraceId.Equals(input.ApiTraceId))
                ) && 
                (
                    this.ResponseType == input.ResponseType ||
                    (this.ResponseType != null &&
                    this.ResponseType.Equals(input.ResponseType))
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
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
                ) && 
                (
                    this.AdditionalDetails == input.AdditionalDetails ||
                    (this.AdditionalDetails != null &&
                    this.AdditionalDetails.Equals(input.AdditionalDetails))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.ClientRequestId != null)
                    hashCode = hashCode * 59 + this.ClientRequestId.GetHashCode();
                if (this.ApiTraceId != null)
                    hashCode = hashCode * 59 + this.ApiTraceId.GetHashCode();
                if (this.ResponseType != null)
                    hashCode = hashCode * 59 + this.ResponseType.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Billing != null)
                    hashCode = hashCode * 59 + this.Billing.GetHashCode();
                if (this.Shipping != null)
                    hashCode = hashCode * 59 + this.Shipping.GetHashCode();
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
                if (this.AdditionalDetails != null)
                    hashCode = hashCode * 59 + this.AdditionalDetails.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
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
            yield break;
        }
    }
}
