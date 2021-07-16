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
    /// Level 3 data for monitoring and controlling corporate expenditures.
    /// </summary>
    [DataContract]
    public partial class PurchaseCardsLevel3 : IEquatable<PurchaseCardsLevel3>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseCardsLevel3" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PurchaseCardsLevel3() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseCardsLevel3" /> class.
        /// </summary>
        /// <param name="lineItems">Line items of monitoring and controlling corporate expenditures data. (required).</param>
        public PurchaseCardsLevel3(List<PurchaseCardsLevel3LineItems> lineItems = default(List<PurchaseCardsLevel3LineItems>))
        {
            // to ensure "lineItems" is required (not null)
            this.LineItems = lineItems ?? throw new ArgumentNullException("lineItems is a required property for PurchaseCardsLevel3 and cannot be null");
        }

        /// <summary>
        /// Line items of monitoring and controlling corporate expenditures data.
        /// </summary>
        /// <value>Line items of monitoring and controlling corporate expenditures data.</value>
        [DataMember(Name = "lineItems", EmitDefaultValue = false)]
        public List<PurchaseCardsLevel3LineItems> LineItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseCardsLevel3 {\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
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
            return this.Equals(input as PurchaseCardsLevel3);
        }

        /// <summary>
        /// Returns true if PurchaseCardsLevel3 instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseCardsLevel3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseCardsLevel3 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
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
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
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
