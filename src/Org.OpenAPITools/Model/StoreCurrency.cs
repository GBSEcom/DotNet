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
    /// Currency details associated with a store.
    /// </summary>
    [DataContract(Name = "StoreCurrency")]
    public partial class StoreCurrency : IEquatable<StoreCurrency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreCurrency" /> class.
        /// </summary>
        /// <param name="literalCurrencyCode">This field contains the ISO alpha currency code..</param>
        /// <param name="numericCurrencyCode">This field contains the ISO numeric currecy code..</param>
        /// <param name="decimalPlaces">This field indicates the number of decimal places required for this currency..</param>
        /// <param name="defaultCurrency">This field indicates if this currency is the default currency for queried store..</param>
        public StoreCurrency(string literalCurrencyCode = default(string), string numericCurrencyCode = default(string), int decimalPlaces = default(int), bool defaultCurrency = default(bool))
        {
            this.LiteralCurrencyCode = literalCurrencyCode;
            this.NumericCurrencyCode = numericCurrencyCode;
            this.DecimalPlaces = decimalPlaces;
            this.DefaultCurrency = defaultCurrency;
        }

        /// <summary>
        /// This field contains the ISO alpha currency code.
        /// </summary>
        /// <value>This field contains the ISO alpha currency code.</value>
        [DataMember(Name = "literalCurrencyCode", EmitDefaultValue = false)]
        public string LiteralCurrencyCode { get; set; }

        /// <summary>
        /// This field contains the ISO numeric currecy code.
        /// </summary>
        /// <value>This field contains the ISO numeric currecy code.</value>
        [DataMember(Name = "numericCurrencyCode", EmitDefaultValue = false)]
        public string NumericCurrencyCode { get; set; }

        /// <summary>
        /// This field indicates the number of decimal places required for this currency.
        /// </summary>
        /// <value>This field indicates the number of decimal places required for this currency.</value>
        [DataMember(Name = "decimalPlaces", EmitDefaultValue = false)]
        public int DecimalPlaces { get; set; }

        /// <summary>
        /// This field indicates if this currency is the default currency for queried store.
        /// </summary>
        /// <value>This field indicates if this currency is the default currency for queried store.</value>
        [DataMember(Name = "defaultCurrency", EmitDefaultValue = true)]
        public bool? DefaultCurrency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreCurrency {\n");
            sb.Append("  LiteralCurrencyCode: ").Append(LiteralCurrencyCode).Append("\n");
            sb.Append("  NumericCurrencyCode: ").Append(NumericCurrencyCode).Append("\n");
            sb.Append("  DecimalPlaces: ").Append(DecimalPlaces).Append("\n");
            sb.Append("  DefaultCurrency: ").Append(DefaultCurrency).Append("\n");
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
            return this.Equals(input as StoreCurrency);
        }

        /// <summary>
        /// Returns true if StoreCurrency instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreCurrency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreCurrency input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LiteralCurrencyCode == input.LiteralCurrencyCode ||
                    (this.LiteralCurrencyCode != null &&
                    this.LiteralCurrencyCode.Equals(input.LiteralCurrencyCode))
                ) && 
                (
                    this.NumericCurrencyCode == input.NumericCurrencyCode ||
                    (this.NumericCurrencyCode != null &&
                    this.NumericCurrencyCode.Equals(input.NumericCurrencyCode))
                ) && 
                (
                    this.DecimalPlaces == input.DecimalPlaces ||
                    this.DecimalPlaces.Equals(input.DecimalPlaces)
                ) && 
                (
                    this.DefaultCurrency == input.DefaultCurrency ||
                    this.DefaultCurrency.Equals(input.DefaultCurrency)
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
                if (this.LiteralCurrencyCode != null)
                    hashCode = hashCode * 59 + this.LiteralCurrencyCode.GetHashCode();
                if (this.NumericCurrencyCode != null)
                    hashCode = hashCode * 59 + this.NumericCurrencyCode.GetHashCode();
                hashCode = hashCode * 59 + this.DecimalPlaces.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultCurrency.GetHashCode();
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
