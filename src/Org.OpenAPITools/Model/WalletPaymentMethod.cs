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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Various wallet payment methods the gateway supports. Abstract class, do not use this class directly, use one of its children: EncryptedApplePayWalletPaymentMethod, EncryptedGooglePayWalletPaymentMethod, EncryptedSamsungPayWalletPaymentMethod, DecryptedApplePayWalletPaymentMethod, DecryptedGooglePayWalletPaymentMethod, DecryptedSamsungPayWalletPaymentMethod, MasterpassWalletPaymentMethod
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "WalletType")]
    [JsonSubtypes.KnownSubType(typeof(EncryptedApplePayWalletPaymentMethod), "EncryptedApplePayWalletPaymentMethod")]
    [JsonSubtypes.KnownSubType(typeof(EncryptedGooglePayWalletPaymentMethod), "EncryptedGooglePayWalletPaymentMethod")]
    [JsonSubtypes.KnownSubType(typeof(EncryptedSamsungPayWalletPaymentMethod), "EncryptedSamsungPayWalletPaymentMethod")]
    [JsonSubtypes.KnownSubType(typeof(DecryptedApplePayWalletPaymentMethod), "DecryptedApplePayWalletPaymentMethod")]
    [JsonSubtypes.KnownSubType(typeof(DecryptedGooglePayWalletPaymentMethod), "DecryptedGooglePayWalletPaymentMethod")]
    [JsonSubtypes.KnownSubType(typeof(DecryptedSamsungPayWalletPaymentMethod), "DecryptedSamsungPayWalletPaymentMethod")]
    [JsonSubtypes.KnownSubType(typeof(MasterpassWalletPaymentMethod), "MasterpassWalletPaymentMethod")]
    public partial class WalletPaymentMethod : IEquatable<WalletPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletPaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WalletPaymentMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletPaymentMethod" /> class.
        /// </summary>
        /// <param name="walletType">Type of wallet. (required).</param>
        public WalletPaymentMethod(string walletType = default(string))
        {
            // to ensure "walletType" is required (not null)
            this.WalletType = walletType ?? throw new ArgumentNullException("walletType is a required property for WalletPaymentMethod and cannot be null");
        }

        /// <summary>
        /// Type of wallet.
        /// </summary>
        /// <value>Type of wallet.</value>
        [DataMember(Name = "walletType", EmitDefaultValue = false)]
        public string WalletType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WalletPaymentMethod {\n");
            sb.Append("  WalletType: ").Append(WalletType).Append("\n");
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
            return this.Equals(input as WalletPaymentMethod);
        }

        /// <summary>
        /// Returns true if WalletPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletPaymentMethod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WalletType == input.WalletType ||
                    (this.WalletType != null &&
                    this.WalletType.Equals(input.WalletType))
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
                if (this.WalletType != null)
                    hashCode = hashCode * 59 + this.WalletType.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
