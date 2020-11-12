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
    /// Request to perform a dynamic pricing exchange rate inquiry.
    /// </summary>
    [DataContract]
    public partial class DynamicPricingExchangeRateRequest : ExchangeRateRequest, IEquatable<DynamicPricingExchangeRateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicPricingExchangeRateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DynamicPricingExchangeRateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicPricingExchangeRateRequest" /> class.
        /// </summary>
        /// <param name="foreignCurrency">The currency code to convert for dynamic pricing in either numeric or alphabetic ISO 4217 currency code format. (required).</param>
        /// <param name="requestType">Object name of the exchange rate request. (required).</param>
        /// <param name="baseAmount">The original amount of the merchant currency for calculation. (required).</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same app..</param>
        public DynamicPricingExchangeRateRequest(string foreignCurrency = default(string), string requestType = default(string), decimal baseAmount = default(decimal), string storeId = default(string)) : base(requestType, baseAmount, storeId)
        {
            // to ensure "foreignCurrency" is required (not null)
            this.ForeignCurrency = foreignCurrency ?? throw new ArgumentNullException("foreignCurrency is a required property for DynamicPricingExchangeRateRequest and cannot be null");
        }

        /// <summary>
        /// The currency code to convert for dynamic pricing in either numeric or alphabetic ISO 4217 currency code format.
        /// </summary>
        /// <value>The currency code to convert for dynamic pricing in either numeric or alphabetic ISO 4217 currency code format.</value>
        [DataMember(Name = "foreignCurrency", EmitDefaultValue = false)]
        public string ForeignCurrency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DynamicPricingExchangeRateRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ForeignCurrency: ").Append(ForeignCurrency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as DynamicPricingExchangeRateRequest);
        }

        /// <summary>
        /// Returns true if DynamicPricingExchangeRateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicPricingExchangeRateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicPricingExchangeRateRequest input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ForeignCurrency == input.ForeignCurrency ||
                    (this.ForeignCurrency != null &&
                    this.ForeignCurrency.Equals(input.ForeignCurrency))
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
                int hashCode = base.GetHashCode();
                if (this.ForeignCurrency != null)
                    hashCode = hashCode * 59 + this.ForeignCurrency.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            // ForeignCurrency (string) maxLength
            if(this.ForeignCurrency != null && this.ForeignCurrency.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ForeignCurrency, length must be less than 3.", new [] { "ForeignCurrency" });
            }

            // ForeignCurrency (string) pattern
            Regex regexForeignCurrency = new Regex(@"([A-Z]{3})|([0-9]{3})", RegexOptions.CultureInvariant);
            if (false == regexForeignCurrency.Match(this.ForeignCurrency).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ForeignCurrency, must match a pattern of " + regexForeignCurrency, new [] { "ForeignCurrency" });
            }

            yield break;
        }
    }
}
