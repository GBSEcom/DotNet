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
    /// DCCExchangeRateRequestAllOf
    /// </summary>
    [DataContract(Name = "DCCExchangeRateRequest_allOf")]
    public partial class DCCExchangeRateRequestAllOf : IEquatable<DCCExchangeRateRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DCCExchangeRateRequestAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DCCExchangeRateRequestAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DCCExchangeRateRequestAllOf" /> class.
        /// </summary>
        /// <param name="bin">The bank identification number (BIN) of the card to be used for DCC. The BIN is the first 6-9 digits of the card number. (required).</param>
        public DCCExchangeRateRequestAllOf(string bin = default(string))
        {
            // to ensure "bin" is required (not null)
            this.Bin = bin ?? throw new ArgumentNullException("bin is a required property for DCCExchangeRateRequestAllOf and cannot be null");
        }

        /// <summary>
        /// The bank identification number (BIN) of the card to be used for DCC. The BIN is the first 6-9 digits of the card number.
        /// </summary>
        /// <value>The bank identification number (BIN) of the card to be used for DCC. The BIN is the first 6-9 digits of the card number.</value>
        [DataMember(Name = "bin", IsRequired = true, EmitDefaultValue = false)]
        public string Bin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DCCExchangeRateRequestAllOf {\n");
            sb.Append("  Bin: ").Append(Bin).Append("\n");
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
            return this.Equals(input as DCCExchangeRateRequestAllOf);
        }

        /// <summary>
        /// Returns true if DCCExchangeRateRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of DCCExchangeRateRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DCCExchangeRateRequestAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bin == input.Bin ||
                    (this.Bin != null &&
                    this.Bin.Equals(input.Bin))
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
                if (this.Bin != null)
                    hashCode = hashCode * 59 + this.Bin.GetHashCode();
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
            // Bin (string) pattern
            Regex regexBin = new Regex(@"[0-9]{6,9}", RegexOptions.CultureInvariant);
            if (false == regexBin.Match(this.Bin).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bin, must match a pattern of " + regexBin, new [] { "Bin" });
            }

            yield break;
        }
    }
}
