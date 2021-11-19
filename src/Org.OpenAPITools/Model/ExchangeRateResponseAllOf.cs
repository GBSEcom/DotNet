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
    /// ExchangeRateResponseAllOf
    /// </summary>
    [DataContract(Name = "ExchangeRateResponse_allOf")]
    public partial class ExchangeRateResponseAllOf : IEquatable<ExchangeRateResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeRateResponseAllOf" /> class.
        /// </summary>
        /// <param name="ipgTransactionId">The response transaction ID..</param>
        /// <param name="requestTime">Time of the request. The used format is \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSXXX\&quot;..</param>
        /// <param name="exchangeRateDetails">exchangeRateDetails.</param>
        public ExchangeRateResponseAllOf(string ipgTransactionId = default(string), string requestTime = default(string), ExchangeRateDetails exchangeRateDetails = default(ExchangeRateDetails))
        {
            this.IpgTransactionId = ipgTransactionId;
            this.RequestTime = requestTime;
            this.ExchangeRateDetails = exchangeRateDetails;
        }

        /// <summary>
        /// The response transaction ID.
        /// </summary>
        /// <value>The response transaction ID.</value>
        [DataMember(Name = "ipgTransactionId", EmitDefaultValue = false)]
        public string IpgTransactionId { get; set; }

        /// <summary>
        /// Time of the request. The used format is \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSXXX\&quot;.
        /// </summary>
        /// <value>Time of the request. The used format is \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSXXX\&quot;.</value>
        [DataMember(Name = "requestTime", EmitDefaultValue = false)]
        public string RequestTime { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeRateDetails
        /// </summary>
        [DataMember(Name = "exchangeRateDetails", EmitDefaultValue = false)]
        public ExchangeRateDetails ExchangeRateDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExchangeRateResponseAllOf {\n");
            sb.Append("  IpgTransactionId: ").Append(IpgTransactionId).Append("\n");
            sb.Append("  RequestTime: ").Append(RequestTime).Append("\n");
            sb.Append("  ExchangeRateDetails: ").Append(ExchangeRateDetails).Append("\n");
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
            return this.Equals(input as ExchangeRateResponseAllOf);
        }

        /// <summary>
        /// Returns true if ExchangeRateResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeRateResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeRateResponseAllOf input)
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
                    this.RequestTime == input.RequestTime ||
                    (this.RequestTime != null &&
                    this.RequestTime.Equals(input.RequestTime))
                ) && 
                (
                    this.ExchangeRateDetails == input.ExchangeRateDetails ||
                    (this.ExchangeRateDetails != null &&
                    this.ExchangeRateDetails.Equals(input.ExchangeRateDetails))
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
                if (this.RequestTime != null)
                    hashCode = hashCode * 59 + this.RequestTime.GetHashCode();
                if (this.ExchangeRateDetails != null)
                    hashCode = hashCode * 59 + this.ExchangeRateDetails.GetHashCode();
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
