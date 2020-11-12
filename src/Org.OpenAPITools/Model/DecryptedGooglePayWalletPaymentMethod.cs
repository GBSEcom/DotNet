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
    /// Wallet payment method containing decrypted Google Pay information.
    /// </summary>
    [DataContract]
    public partial class DecryptedGooglePayWalletPaymentMethod : WalletPaymentMethod, IEquatable<DecryptedGooglePayWalletPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecryptedGooglePayWalletPaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DecryptedGooglePayWalletPaymentMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecryptedGooglePayWalletPaymentMethod" /> class.
        /// </summary>
        /// <param name="decryptedGooglePay">decryptedGooglePay (required).</param>
        /// <param name="walletType">Type of wallet. (required).</param>
        public DecryptedGooglePayWalletPaymentMethod(DecryptedGooglePay decryptedGooglePay = default(DecryptedGooglePay), string walletType = default(string)) : base(walletType)
        {
            // to ensure "decryptedGooglePay" is required (not null)
            this.DecryptedGooglePay = decryptedGooglePay ?? throw new ArgumentNullException("decryptedGooglePay is a required property for DecryptedGooglePayWalletPaymentMethod and cannot be null");
        }

        /// <summary>
        /// Gets or Sets DecryptedGooglePay
        /// </summary>
        [DataMember(Name = "decryptedGooglePay", EmitDefaultValue = false)]
        public DecryptedGooglePay DecryptedGooglePay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecryptedGooglePayWalletPaymentMethod {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  DecryptedGooglePay: ").Append(DecryptedGooglePay).Append("\n");
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
            return this.Equals(input as DecryptedGooglePayWalletPaymentMethod);
        }

        /// <summary>
        /// Returns true if DecryptedGooglePayWalletPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of DecryptedGooglePayWalletPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecryptedGooglePayWalletPaymentMethod input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.DecryptedGooglePay == input.DecryptedGooglePay ||
                    (this.DecryptedGooglePay != null &&
                    this.DecryptedGooglePay.Equals(input.DecryptedGooglePay))
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
                if (this.DecryptedGooglePay != null)
                    hashCode = hashCode * 59 + this.DecryptedGooglePay.GetHashCode();
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
