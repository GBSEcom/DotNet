/*
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.4.0.20210824.002
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
    /// PaymentTokenizationResponse
    /// </summary>
    [DataContract(Name = "PaymentTokenizationResponse")]
    public partial class PaymentTokenizationResponse : IEquatable<PaymentTokenizationResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ResponseType
        /// </summary>
        [DataMember(Name = "responseType", EmitDefaultValue = false)]
        public ResponseType? ResponseType { get; set; }
        /// <summary>
        /// The status of the request.
        /// </summary>
        /// <value>The status of the request.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequestStatusEnum
        {
            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED = 1,

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 2,

            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 3,

            /// <summary>
            /// Enum APPROVED for value: APPROVED
            /// </summary>
            [EnumMember(Value = "APPROVED")]
            APPROVED = 4,

            /// <summary>
            /// Enum WAITING for value: WAITING
            /// </summary>
            [EnumMember(Value = "WAITING")]
            WAITING = 5,

            /// <summary>
            /// Enum VALIDATIONFAILED for value: VALIDATION_FAILED
            /// </summary>
            [EnumMember(Value = "VALIDATION_FAILED")]
            VALIDATIONFAILED = 6,

            /// <summary>
            /// Enum DECLINED for value: DECLINED
            /// </summary>
            [EnumMember(Value = "DECLINED")]
            DECLINED = 7

        }


        /// <summary>
        /// The status of the request.
        /// </summary>
        /// <value>The status of the request.</value>
        [DataMember(Name = "requestStatus", EmitDefaultValue = false)]
        public RequestStatusEnum? RequestStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenizationResponse" /> class.
        /// </summary>
        /// <param name="clientRequestId">Echoes back the value in the request header for tracking..</param>
        /// <param name="apiTraceId">Request identifier in API, can be used to request logs from the support team..</param>
        /// <param name="responseType">responseType.</param>
        /// <param name="requestStatus">The status of the request..</param>
        /// <param name="requestTime">Time of the request..</param>
        /// <param name="brand">Card brand..</param>
        /// <param name="country">Country of the card issued..</param>
        /// <param name="paymentToken">paymentToken.</param>
        /// <param name="paymentCard">paymentCard.</param>
        /// <param name="processor">processor.</param>
        /// <param name="orderId">Note - Client Order ID if supplied by client. If not supplied by client, IPG will generate. The first 12 alphanumeric digits are passed down to Fiserv Enterprise reporting tool, Clientline and Data File Manager (DFM)..</param>
        /// <param name="ipgTransactionId">The response transaction ID..</param>
        /// <param name="merchantTransactionId">The unique merchant transaction ID from the request header, if supplied..</param>
        /// <param name="additionalResponseData">additionalResponseData.</param>
        public PaymentTokenizationResponse(string clientRequestId = default(string), string apiTraceId = default(string), ResponseType? responseType = default(ResponseType?), RequestStatusEnum? requestStatus = default(RequestStatusEnum?), long requestTime = default(long), string brand = default(string), string country = default(string), PaymentTokenDetails paymentToken = default(PaymentTokenDetails), PaymentCard paymentCard = default(PaymentCard), ProcessorData processor = default(ProcessorData), string orderId = default(string), string ipgTransactionId = default(string), string merchantTransactionId = default(string), AdditionalResponseData additionalResponseData = default(AdditionalResponseData))
        {
            this.ClientRequestId = clientRequestId;
            this.ApiTraceId = apiTraceId;
            this.ResponseType = responseType;
            this.RequestStatus = requestStatus;
            this.RequestTime = requestTime;
            this.Brand = brand;
            this.Country = country;
            this.PaymentToken = paymentToken;
            this.PaymentCard = paymentCard;
            this.Processor = processor;
            this.OrderId = orderId;
            this.IpgTransactionId = ipgTransactionId;
            this.MerchantTransactionId = merchantTransactionId;
            this.AdditionalResponseData = additionalResponseData;
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
        /// Time of the request.
        /// </summary>
        /// <value>Time of the request.</value>
        [DataMember(Name = "requestTime", EmitDefaultValue = false)]
        public long RequestTime { get; set; }

        /// <summary>
        /// Card brand.
        /// </summary>
        /// <value>Card brand.</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// Country of the card issued.
        /// </summary>
        /// <value>Country of the card issued.</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets PaymentToken
        /// </summary>
        [DataMember(Name = "paymentToken", EmitDefaultValue = false)]
        public PaymentTokenDetails PaymentToken { get; set; }

        /// <summary>
        /// Gets or Sets PaymentCard
        /// </summary>
        [DataMember(Name = "paymentCard", EmitDefaultValue = false)]
        public PaymentCard PaymentCard { get; set; }

        /// <summary>
        /// Gets or Sets Processor
        /// </summary>
        [DataMember(Name = "processor", EmitDefaultValue = false)]
        public ProcessorData Processor { get; set; }

        /// <summary>
        /// Note - Client Order ID if supplied by client. If not supplied by client, IPG will generate. The first 12 alphanumeric digits are passed down to Fiserv Enterprise reporting tool, Clientline and Data File Manager (DFM).
        /// </summary>
        /// <value>Note - Client Order ID if supplied by client. If not supplied by client, IPG will generate. The first 12 alphanumeric digits are passed down to Fiserv Enterprise reporting tool, Clientline and Data File Manager (DFM).</value>
        [DataMember(Name = "orderId", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The response transaction ID.
        /// </summary>
        /// <value>The response transaction ID.</value>
        [DataMember(Name = "ipgTransactionId", EmitDefaultValue = false)]
        public string IpgTransactionId { get; set; }

        /// <summary>
        /// The unique merchant transaction ID from the request header, if supplied.
        /// </summary>
        /// <value>The unique merchant transaction ID from the request header, if supplied.</value>
        [DataMember(Name = "merchantTransactionId", EmitDefaultValue = false)]
        public string MerchantTransactionId { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalResponseData
        /// </summary>
        [DataMember(Name = "additionalResponseData", EmitDefaultValue = false)]
        public AdditionalResponseData AdditionalResponseData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentTokenizationResponse {\n");
            sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  ApiTraceId: ").Append(ApiTraceId).Append("\n");
            sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
            sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
            sb.Append("  RequestTime: ").Append(RequestTime).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  PaymentToken: ").Append(PaymentToken).Append("\n");
            sb.Append("  PaymentCard: ").Append(PaymentCard).Append("\n");
            sb.Append("  Processor: ").Append(Processor).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  IpgTransactionId: ").Append(IpgTransactionId).Append("\n");
            sb.Append("  MerchantTransactionId: ").Append(MerchantTransactionId).Append("\n");
            sb.Append("  AdditionalResponseData: ").Append(AdditionalResponseData).Append("\n");
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
            return this.Equals(input as PaymentTokenizationResponse);
        }

        /// <summary>
        /// Returns true if PaymentTokenizationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTokenizationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTokenizationResponse input)
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
                    this.ResponseType.Equals(input.ResponseType)
                ) && 
                (
                    this.RequestStatus == input.RequestStatus ||
                    this.RequestStatus.Equals(input.RequestStatus)
                ) && 
                (
                    this.RequestTime == input.RequestTime ||
                    this.RequestTime.Equals(input.RequestTime)
                ) && 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.PaymentToken == input.PaymentToken ||
                    (this.PaymentToken != null &&
                    this.PaymentToken.Equals(input.PaymentToken))
                ) && 
                (
                    this.PaymentCard == input.PaymentCard ||
                    (this.PaymentCard != null &&
                    this.PaymentCard.Equals(input.PaymentCard))
                ) && 
                (
                    this.Processor == input.Processor ||
                    (this.Processor != null &&
                    this.Processor.Equals(input.Processor))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.IpgTransactionId == input.IpgTransactionId ||
                    (this.IpgTransactionId != null &&
                    this.IpgTransactionId.Equals(input.IpgTransactionId))
                ) && 
                (
                    this.MerchantTransactionId == input.MerchantTransactionId ||
                    (this.MerchantTransactionId != null &&
                    this.MerchantTransactionId.Equals(input.MerchantTransactionId))
                ) && 
                (
                    this.AdditionalResponseData == input.AdditionalResponseData ||
                    (this.AdditionalResponseData != null &&
                    this.AdditionalResponseData.Equals(input.AdditionalResponseData))
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
                hashCode = hashCode * 59 + this.ResponseType.GetHashCode();
                hashCode = hashCode * 59 + this.RequestStatus.GetHashCode();
                hashCode = hashCode * 59 + this.RequestTime.GetHashCode();
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.PaymentToken != null)
                    hashCode = hashCode * 59 + this.PaymentToken.GetHashCode();
                if (this.PaymentCard != null)
                    hashCode = hashCode * 59 + this.PaymentCard.GetHashCode();
                if (this.Processor != null)
                    hashCode = hashCode * 59 + this.Processor.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.IpgTransactionId != null)
                    hashCode = hashCode * 59 + this.IpgTransactionId.GetHashCode();
                if (this.MerchantTransactionId != null)
                    hashCode = hashCode * 59 + this.MerchantTransactionId.GetHashCode();
                if (this.AdditionalResponseData != null)
                    hashCode = hashCode * 59 + this.AdditionalResponseData.GetHashCode();
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
            // IpgTransactionId (string) maxLength
            if(this.IpgTransactionId != null && this.IpgTransactionId.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IpgTransactionId, length must be less than 14.", new [] { "IpgTransactionId" });
            }

            // MerchantTransactionId (string) maxLength
            if(this.MerchantTransactionId != null && this.MerchantTransactionId.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantTransactionId, length must be less than 40.", new [] { "MerchantTransactionId" });
            }

            yield break;
        }
    }
}
