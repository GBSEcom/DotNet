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
    /// Masterpass Wallet payment method information.
    /// </summary>
    [DataContract]
    public partial class MasterpassWalletPaymentMethod : WalletPaymentMethod, IEquatable<MasterpassWalletPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MasterpassWalletPaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MasterpassWalletPaymentMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MasterpassWalletPaymentMethod" /> class.
        /// </summary>
        /// <param name="walletId">Masterpass Wallet ID. (required).</param>
        /// <param name="paymentCard">paymentCard (required).</param>
        /// <param name="walletType">Type of wallet. (required).</param>
        public MasterpassWalletPaymentMethod(string walletId = default(string), PaymentCard paymentCard = default(PaymentCard), string walletType = default(string)) : base(walletType)
        {
            // to ensure "walletId" is required (not null)
            this.WalletId = walletId ?? throw new ArgumentNullException("walletId is a required property for MasterpassWalletPaymentMethod and cannot be null");
            // to ensure "paymentCard" is required (not null)
            this.PaymentCard = paymentCard ?? throw new ArgumentNullException("paymentCard is a required property for MasterpassWalletPaymentMethod and cannot be null");
        }

        /// <summary>
        /// Masterpass Wallet ID.
        /// </summary>
        /// <value>Masterpass Wallet ID.</value>
        [DataMember(Name = "walletId", EmitDefaultValue = false)]
        public string WalletId { get; set; }

        /// <summary>
        /// Gets or Sets PaymentCard
        /// </summary>
        [DataMember(Name = "paymentCard", EmitDefaultValue = false)]
        public PaymentCard PaymentCard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MasterpassWalletPaymentMethod {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
            sb.Append("  PaymentCard: ").Append(PaymentCard).Append("\n");
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
            return this.Equals(input as MasterpassWalletPaymentMethod);
        }

        /// <summary>
        /// Returns true if MasterpassWalletPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of MasterpassWalletPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MasterpassWalletPaymentMethod input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.WalletId == input.WalletId ||
                    (this.WalletId != null &&
                    this.WalletId.Equals(input.WalletId))
                ) && base.Equals(input) && 
                (
                    this.PaymentCard == input.PaymentCard ||
                    (this.PaymentCard != null &&
                    this.PaymentCard.Equals(input.PaymentCard))
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
                if (this.WalletId != null)
                    hashCode = hashCode * 59 + this.WalletId.GetHashCode();
                if (this.PaymentCard != null)
                    hashCode = hashCode * 59 + this.PaymentCard.GetHashCode();
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
            // WalletId (string) maxLength
            if(this.WalletId != null && this.WalletId.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WalletId, length must be less than 3.", new [] { "WalletId" });
            }

            // WalletId (string) pattern
            Regex regexWalletId = new Regex(@"^\\S$|^\\S.*\\S$", RegexOptions.CultureInvariant);
            if (false == regexWalletId.Match(this.WalletId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WalletId, must match a pattern of " + regexWalletId, new [] { "WalletId" });
            }

            yield break;
        }
    }
}
