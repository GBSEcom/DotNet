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
    /// RecurringPaymentDetailsResponseAllOf
    /// </summary>
    [DataContract(Name = "RecurringPaymentDetailsResponse_allOf")]
    public partial class RecurringPaymentDetailsResponseAllOf : IEquatable<RecurringPaymentDetailsResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurringPaymentDetailsResponseAllOf" /> class.
        /// </summary>
        /// <param name="recurringPaymentDetails">recurringPaymentDetails.</param>
        public RecurringPaymentDetailsResponseAllOf(RecurringPaymentDetails recurringPaymentDetails = default(RecurringPaymentDetails))
        {
            this.RecurringPaymentDetails = recurringPaymentDetails;
        }

        /// <summary>
        /// Gets or Sets RecurringPaymentDetails
        /// </summary>
        [DataMember(Name = "recurringPaymentDetails", EmitDefaultValue = false)]
        public RecurringPaymentDetails RecurringPaymentDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecurringPaymentDetailsResponseAllOf {\n");
            sb.Append("  RecurringPaymentDetails: ").Append(RecurringPaymentDetails).Append("\n");
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
            return this.Equals(input as RecurringPaymentDetailsResponseAllOf);
        }

        /// <summary>
        /// Returns true if RecurringPaymentDetailsResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of RecurringPaymentDetailsResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecurringPaymentDetailsResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecurringPaymentDetails == input.RecurringPaymentDetails ||
                    (this.RecurringPaymentDetails != null &&
                    this.RecurringPaymentDetails.Equals(input.RecurringPaymentDetails))
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
                if (this.RecurringPaymentDetails != null)
                    hashCode = hashCode * 59 + this.RecurringPaymentDetails.GetHashCode();
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
