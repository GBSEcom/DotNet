/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.14.0.20201015.001
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
    /// DisbursementTransactionTypeAllOf
    /// </summary>
    [DataContract]
    public partial class DisbursementTransactionTypeAllOf : IEquatable<DisbursementTransactionTypeAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisbursementTransactionTypeAllOf" /> class.
        /// </summary>
        /// <param name="disbursementType">The type of disbursement..</param>
        public DisbursementTransactionTypeAllOf(string disbursementType = default(string))
        {
            this.DisbursementType = disbursementType;
        }

        /// <summary>
        /// The type of disbursement.
        /// </summary>
        /// <value>The type of disbursement.</value>
        [DataMember(Name = "disbursementType", EmitDefaultValue = false)]
        public string DisbursementType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisbursementTransactionTypeAllOf {\n");
            sb.Append("  DisbursementType: ").Append(DisbursementType).Append("\n");
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
            return this.Equals(input as DisbursementTransactionTypeAllOf);
        }

        /// <summary>
        /// Returns true if DisbursementTransactionTypeAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of DisbursementTransactionTypeAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisbursementTransactionTypeAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisbursementType == input.DisbursementType ||
                    (this.DisbursementType != null &&
                    this.DisbursementType.Equals(input.DisbursementType))
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
                if (this.DisbursementType != null)
                    hashCode = hashCode * 59 + this.DisbursementType.GetHashCode();
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
