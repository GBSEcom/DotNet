/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.9.1.20191223.002
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
    /// Wallet payment method containing encrypted Apple Pay information.
    /// </summary>
    [DataContract]
    public partial class EncryptedApplePayWalletPaymentMethod : WalletPaymentMethod,  IEquatable<EncryptedApplePayWalletPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedApplePayWalletPaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EncryptedApplePayWalletPaymentMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedApplePayWalletPaymentMethod" /> class.
        /// </summary>
        /// <param name="encryptedApplePay">encryptedApplePay (required).</param>
        /// <param name="walletType">Type of wallet. (required).</param>
        public EncryptedApplePayWalletPaymentMethod(EncryptedApplePay encryptedApplePay = default(EncryptedApplePay), string walletType = default(string)) : base(walletType)
        {
            // to ensure "encryptedApplePay" is required (not null)
            if (encryptedApplePay == null)
            {
                throw new InvalidDataException("encryptedApplePay is a required property for EncryptedApplePayWalletPaymentMethod and cannot be null");
            }
            else
            {
                this.EncryptedApplePay = encryptedApplePay;
            }

        }
        
        /// <summary>
        /// Gets or Sets EncryptedApplePay
        /// </summary>
        [DataMember(Name="encryptedApplePay", EmitDefaultValue=false)]
        public EncryptedApplePay EncryptedApplePay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncryptedApplePayWalletPaymentMethod {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EncryptedApplePay: ").Append(EncryptedApplePay).Append("\n");
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
            return this.Equals(input as EncryptedApplePayWalletPaymentMethod);
        }

        /// <summary>
        /// Returns true if EncryptedApplePayWalletPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of EncryptedApplePayWalletPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EncryptedApplePayWalletPaymentMethod input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
