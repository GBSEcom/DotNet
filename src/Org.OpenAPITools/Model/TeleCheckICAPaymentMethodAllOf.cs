/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.2.0.20210406.001
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
    /// TeleCheckICAPaymentMethodAllOf
    /// </summary>
    [DataContract]
    public partial class TeleCheckICAPaymentMethodAllOf : IEquatable<TeleCheckICAPaymentMethodAllOf>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets RecurringType
        /// </summary>
        [DataMember(Name = "recurringType", EmitDefaultValue = false)]
        public AchRecurringType? RecurringType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeleCheckICAPaymentMethodAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeleCheckICAPaymentMethodAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeleCheckICAPaymentMethodAllOf" /> class.
        /// </summary>
        /// <param name="customerIpAddress">Customer IP address from the terminal where the order was placed (as captured by merchant). (required).</param>
        /// <param name="imeiCode">International mobile equipment identity code..</param>
        /// <param name="recurringType">recurringType.</param>
        public TeleCheckICAPaymentMethodAllOf(string customerIpAddress = default(string), string imeiCode = default(string), AchRecurringType recurringType = default(AchRecurringType))
        {
            // to ensure "customerIpAddress" is required (not null)
            this.CustomerIpAddress = customerIpAddress ?? throw new ArgumentNullException("customerIpAddress is a required property for TeleCheckICAPaymentMethodAllOf and cannot be null");
            this.ImeiCode = imeiCode;
            this.RecurringType = recurringType;
        }

        /// <summary>
        /// Customer IP address from the terminal where the order was placed (as captured by merchant).
        /// </summary>
        /// <value>Customer IP address from the terminal where the order was placed (as captured by merchant).</value>
        [DataMember(Name = "customerIpAddress", EmitDefaultValue = false)]
        public string CustomerIpAddress { get; set; }

        /// <summary>
        /// International mobile equipment identity code.
        /// </summary>
        /// <value>International mobile equipment identity code.</value>
        [DataMember(Name = "imeiCode", EmitDefaultValue = false)]
        public string ImeiCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeleCheckICAPaymentMethodAllOf {\n");
            sb.Append("  CustomerIpAddress: ").Append(CustomerIpAddress).Append("\n");
            sb.Append("  ImeiCode: ").Append(ImeiCode).Append("\n");
            sb.Append("  RecurringType: ").Append(RecurringType).Append("\n");
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
            return this.Equals(input as TeleCheckICAPaymentMethodAllOf);
        }

        /// <summary>
        /// Returns true if TeleCheckICAPaymentMethodAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of TeleCheckICAPaymentMethodAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeleCheckICAPaymentMethodAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerIpAddress == input.CustomerIpAddress ||
                    (this.CustomerIpAddress != null &&
                    this.CustomerIpAddress.Equals(input.CustomerIpAddress))
                ) && 
                (
                    this.ImeiCode == input.ImeiCode ||
                    (this.ImeiCode != null &&
                    this.ImeiCode.Equals(input.ImeiCode))
                ) && 
                (
                    this.RecurringType == input.RecurringType ||
                    (this.RecurringType != null &&
                    this.RecurringType.Equals(input.RecurringType))
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
                if (this.CustomerIpAddress != null)
                    hashCode = hashCode * 59 + this.CustomerIpAddress.GetHashCode();
                if (this.ImeiCode != null)
                    hashCode = hashCode * 59 + this.ImeiCode.GetHashCode();
                if (this.RecurringType != null)
                    hashCode = hashCode * 59 + this.RecurringType.GetHashCode();
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
            // CustomerIpAddress (string) maxLength
            if(this.CustomerIpAddress != null && this.CustomerIpAddress.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerIpAddress, length must be less than 15.", new [] { "CustomerIpAddress" });
            }

            // CustomerIpAddress (string) pattern
            Regex regexCustomerIpAddress = new Regex(@"^[0-9\\.]+$", RegexOptions.CultureInvariant);
            if (false == regexCustomerIpAddress.Match(this.CustomerIpAddress).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerIpAddress, must match a pattern of " + regexCustomerIpAddress, new [] { "CustomerIpAddress" });
            }

            // ImeiCode (string) maxLength
            if(this.ImeiCode != null && this.ImeiCode.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImeiCode, length must be less than 25.", new [] { "ImeiCode" });
            }

            // ImeiCode (string) pattern
            Regex regexImeiCode = new Regex(@"(?=.*[^\\s])^[^|]+$", RegexOptions.CultureInvariant);
            if (false == regexImeiCode.Match(this.ImeiCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImeiCode, must match a pattern of " + regexImeiCode, new [] { "ImeiCode" });
            }

            yield break;
        }
    }
}