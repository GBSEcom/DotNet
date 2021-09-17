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
    /// ReferencedOrderPaymentSchedulesRequestAllOf
    /// </summary>
    [DataContract(Name = "ReferencedOrderPaymentSchedulesRequest_allOf")]
    public partial class ReferencedOrderPaymentSchedulesRequestAllOf : IEquatable<ReferencedOrderPaymentSchedulesRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencedOrderPaymentSchedulesRequestAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReferencedOrderPaymentSchedulesRequestAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencedOrderPaymentSchedulesRequestAllOf" /> class.
        /// </summary>
        /// <param name="referencedOrderId">Order ID used to create recurring payment from existing transaction. (required).</param>
        public ReferencedOrderPaymentSchedulesRequestAllOf(string referencedOrderId = default(string))
        {
            // to ensure "referencedOrderId" is required (not null)
            this.ReferencedOrderId = referencedOrderId ?? throw new ArgumentNullException("referencedOrderId is a required property for ReferencedOrderPaymentSchedulesRequestAllOf and cannot be null");
        }

        /// <summary>
        /// Order ID used to create recurring payment from existing transaction.
        /// </summary>
        /// <value>Order ID used to create recurring payment from existing transaction.</value>
        [DataMember(Name = "referencedOrderId", IsRequired = true, EmitDefaultValue = false)]
        public string ReferencedOrderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReferencedOrderPaymentSchedulesRequestAllOf {\n");
            sb.Append("  ReferencedOrderId: ").Append(ReferencedOrderId).Append("\n");
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
            return this.Equals(input as ReferencedOrderPaymentSchedulesRequestAllOf);
        }

        /// <summary>
        /// Returns true if ReferencedOrderPaymentSchedulesRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ReferencedOrderPaymentSchedulesRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReferencedOrderPaymentSchedulesRequestAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReferencedOrderId == input.ReferencedOrderId ||
                    (this.ReferencedOrderId != null &&
                    this.ReferencedOrderId.Equals(input.ReferencedOrderId))
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
                if (this.ReferencedOrderId != null)
                    hashCode = hashCode * 59 + this.ReferencedOrderId.GetHashCode();
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
            // ReferencedOrderId (string) pattern
            Regex regexReferencedOrderId = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexReferencedOrderId.Match(this.ReferencedOrderId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferencedOrderId, must match a pattern of " + regexReferencedOrderId, new [] { "ReferencedOrderId" });
            }

            yield break;
        }
    }
}
