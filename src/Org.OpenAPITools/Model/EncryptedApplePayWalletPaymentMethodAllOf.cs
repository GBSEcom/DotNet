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
    /// EncryptedApplePayWalletPaymentMethodAllOf
    /// </summary>
    [DataContract]
    public partial class EncryptedApplePayWalletPaymentMethodAllOf : IEquatable<EncryptedApplePayWalletPaymentMethodAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedApplePayWalletPaymentMethodAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EncryptedApplePayWalletPaymentMethodAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedApplePayWalletPaymentMethodAllOf" /> class.
        /// </summary>
        /// <param name="encryptedApplePay">encryptedApplePay (required).</param>
        public EncryptedApplePayWalletPaymentMethodAllOf(EncryptedApplePay encryptedApplePay = default(EncryptedApplePay))
        {
            // to ensure "encryptedApplePay" is required (not null)
            this.EncryptedApplePay = encryptedApplePay ?? throw new ArgumentNullException("encryptedApplePay is a required property for EncryptedApplePayWalletPaymentMethodAllOf and cannot be null");
        }

        /// <summary>
        /// Gets or Sets EncryptedApplePay
        /// </summary>
        [DataMember(Name = "encryptedApplePay", EmitDefaultValue = false)]
        public EncryptedApplePay EncryptedApplePay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncryptedApplePayWalletPaymentMethodAllOf {\n");
            sb.Append("  EncryptedApplePay: ").Append(EncryptedApplePay).Append("\n");
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
            return this.Equals(input as EncryptedApplePayWalletPaymentMethodAllOf);
        }

        /// <summary>
        /// Returns true if EncryptedApplePayWalletPaymentMethodAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of EncryptedApplePayWalletPaymentMethodAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EncryptedApplePayWalletPaymentMethodAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EncryptedApplePay == input.EncryptedApplePay ||
                    (this.EncryptedApplePay != null &&
                    this.EncryptedApplePay.Equals(input.EncryptedApplePay))
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
                if (this.EncryptedApplePay != null)
                    hashCode = hashCode * 59 + this.EncryptedApplePay.GetHashCode();
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
