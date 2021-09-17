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
    /// PaymentTokenUpdateResponseAllOf
    /// </summary>
    [DataContract(Name = "PaymentTokenUpdateResponse_allOf")]
    public partial class PaymentTokenUpdateResponseAllOf : IEquatable<PaymentTokenUpdateResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// The status of the request.
        /// </summary>
        /// <value>The status of the request.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequestStatusEnum
        {
            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 1,

            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 2,

            /// <summary>
            /// Enum PARTIALSUCCESS for value: PARTIAL_SUCCESS
            /// </summary>
            [EnumMember(Value = "PARTIAL_SUCCESS")]
            PARTIALSUCCESS = 3

        }


        /// <summary>
        /// The status of the request.
        /// </summary>
        /// <value>The status of the request.</value>
        [DataMember(Name = "requestStatus", EmitDefaultValue = false)]
        public RequestStatusEnum? RequestStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenUpdateResponseAllOf" /> class.
        /// </summary>
        /// <param name="requestStatus">The status of the request..</param>
        /// <param name="requestTime">Time of the request..</param>
        /// <param name="errors">errors.</param>
        public PaymentTokenUpdateResponseAllOf(RequestStatusEnum? requestStatus = default(RequestStatusEnum?), long requestTime = default(long), List<Error> errors = default(List<Error>))
        {
            this.RequestStatus = requestStatus;
            this.RequestTime = requestTime;
            this.Errors = errors;
        }

        /// <summary>
        /// Time of the request.
        /// </summary>
        /// <value>Time of the request.</value>
        [DataMember(Name = "requestTime", EmitDefaultValue = false)]
        public long RequestTime { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<Error> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentTokenUpdateResponseAllOf {\n");
            sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
            sb.Append("  RequestTime: ").Append(RequestTime).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as PaymentTokenUpdateResponseAllOf);
        }

        /// <summary>
        /// Returns true if PaymentTokenUpdateResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTokenUpdateResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTokenUpdateResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestStatus == input.RequestStatus ||
                    this.RequestStatus.Equals(input.RequestStatus)
                ) && 
                (
                    this.RequestTime == input.RequestTime ||
                    this.RequestTime.Equals(input.RequestTime)
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
                hashCode = hashCode * 59 + this.RequestStatus.GetHashCode();
                hashCode = hashCode * 59 + this.RequestTime.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
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