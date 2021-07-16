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
    /// Decrypted Apple Pay payload.
    /// </summary>
    [DataContract]
    public partial class DecryptedApplePay : IEquatable<DecryptedApplePay>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecryptedApplePay" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DecryptedApplePay() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecryptedApplePay" /> class.
        /// </summary>
        /// <param name="accountNumber">Payment card number. (required).</param>
        /// <param name="expiration">Card expiration date in MMYYYY format. (required).</param>
        /// <param name="cardholderName">Name of the cardholder..</param>
        /// <param name="brand">Card brand..</param>
        /// <param name="cryptogram">The wallet cryptogram from the decrypted data. (required).</param>
        /// <param name="eciIndicator">The ECI indicator from the decrypted data..</param>
        public DecryptedApplePay(string accountNumber = default(string), string expiration = default(string), string cardholderName = default(string), string brand = default(string), string cryptogram = default(string), string eciIndicator = default(string))
        {
            // to ensure "accountNumber" is required (not null)
            this.AccountNumber = accountNumber ?? throw new ArgumentNullException("accountNumber is a required property for DecryptedApplePay and cannot be null");
            // to ensure "expiration" is required (not null)
            this.Expiration = expiration ?? throw new ArgumentNullException("expiration is a required property for DecryptedApplePay and cannot be null");
            // to ensure "cryptogram" is required (not null)
            this.Cryptogram = cryptogram ?? throw new ArgumentNullException("cryptogram is a required property for DecryptedApplePay and cannot be null");
            this.CardholderName = cardholderName;
            this.Brand = brand;
            this.EciIndicator = eciIndicator;
        }

        /// <summary>
        /// Payment card number.
        /// </summary>
        /// <value>Payment card number.</value>
        [DataMember(Name = "accountNumber", EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Card expiration date in MMYYYY format.
        /// </summary>
        /// <value>Card expiration date in MMYYYY format.</value>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        public string Expiration { get; set; }

        /// <summary>
        /// Name of the cardholder.
        /// </summary>
        /// <value>Name of the cardholder.</value>
        [DataMember(Name = "cardholderName", EmitDefaultValue = false)]
        public string CardholderName { get; set; }

        /// <summary>
        /// Card brand.
        /// </summary>
        /// <value>Card brand.</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// The wallet cryptogram from the decrypted data.
        /// </summary>
        /// <value>The wallet cryptogram from the decrypted data.</value>
        [DataMember(Name = "cryptogram", EmitDefaultValue = false)]
        public string Cryptogram { get; set; }

        /// <summary>
        /// The ECI indicator from the decrypted data.
        /// </summary>
        /// <value>The ECI indicator from the decrypted data.</value>
        [DataMember(Name = "eciIndicator", EmitDefaultValue = false)]
        public string EciIndicator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecryptedApplePay {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  CardholderName: ").Append(CardholderName).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Cryptogram: ").Append(Cryptogram).Append("\n");
            sb.Append("  EciIndicator: ").Append(EciIndicator).Append("\n");
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
            return this.Equals(input as DecryptedApplePay);
        }

        /// <summary>
        /// Returns true if DecryptedApplePay instances are equal
        /// </summary>
        /// <param name="input">Instance of DecryptedApplePay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecryptedApplePay input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
                ) && 
                (
                    this.CardholderName == input.CardholderName ||
                    (this.CardholderName != null &&
                    this.CardholderName.Equals(input.CardholderName))
                ) && 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.Cryptogram == input.Cryptogram ||
                    (this.Cryptogram != null &&
                    this.Cryptogram.Equals(input.Cryptogram))
                ) && 
                (
                    this.EciIndicator == input.EciIndicator ||
                    (this.EciIndicator != null &&
                    this.EciIndicator.Equals(input.EciIndicator))
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
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.Expiration != null)
                    hashCode = hashCode * 59 + this.Expiration.GetHashCode();
                if (this.CardholderName != null)
                    hashCode = hashCode * 59 + this.CardholderName.GetHashCode();
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
                if (this.Cryptogram != null)
                    hashCode = hashCode * 59 + this.Cryptogram.GetHashCode();
                if (this.EciIndicator != null)
                    hashCode = hashCode * 59 + this.EciIndicator.GetHashCode();
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
            // AccountNumber (string) pattern
            Regex regexAccountNumber = new Regex(@"[0-9]{13,19}", RegexOptions.CultureInvariant);
            if (false == regexAccountNumber.Match(this.AccountNumber).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, must match a pattern of " + regexAccountNumber, new [] { "AccountNumber" });
            }

            // Expiration (string) pattern
            Regex regexExpiration = new Regex(@"[0-9]{6}", RegexOptions.CultureInvariant);
            if (false == regexExpiration.Match(this.Expiration).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Expiration, must match a pattern of " + regexExpiration, new [] { "Expiration" });
            }

            // CardholderName (string) maxLength
            if(this.CardholderName != null && this.CardholderName.Length > 96)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CardholderName, length must be less than 96.", new [] { "CardholderName" });
            }

            // CardholderName (string) pattern
            Regex regexCardholderName = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexCardholderName.Match(this.CardholderName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CardholderName, must match a pattern of " + regexCardholderName, new [] { "CardholderName" });
            }

            // Brand (string) pattern
            Regex regexBrand = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexBrand.Match(this.Brand).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Brand, must match a pattern of " + regexBrand, new [] { "Brand" });
            }

            // Cryptogram (string) pattern
            Regex regexCryptogram = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexCryptogram.Match(this.Cryptogram).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cryptogram, must match a pattern of " + regexCryptogram, new [] { "Cryptogram" });
            }

            // EciIndicator (string) pattern
            Regex regexEciIndicator = new Regex(@"[0-9]{2}", RegexOptions.CultureInvariant);
            if (false == regexEciIndicator.Match(this.EciIndicator).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EciIndicator, must match a pattern of " + regexEciIndicator, new [] { "EciIndicator" });
            }

            yield break;
        }
    }
}
