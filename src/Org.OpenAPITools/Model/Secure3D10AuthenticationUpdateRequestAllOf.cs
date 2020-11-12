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
    /// Secure3D10AuthenticationUpdateRequestAllOf
    /// </summary>
    [DataContract]
    public partial class Secure3D10AuthenticationUpdateRequestAllOf : IEquatable<Secure3D10AuthenticationUpdateRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3D10AuthenticationUpdateRequestAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Secure3D10AuthenticationUpdateRequestAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3D10AuthenticationUpdateRequestAllOf" /> class.
        /// </summary>
        /// <param name="payerAuthenticationResponse">A formatted message providing results of the issuer’s cardholder authentication. (required).</param>
        /// <param name="merchantData">Formatted string encoding transaction time, order ID, and return URL data. (required).</param>
        /// <param name="securityCode">Card security code if required by merchant..</param>
        public Secure3D10AuthenticationUpdateRequestAllOf(string payerAuthenticationResponse = default(string), string merchantData = default(string), string securityCode = default(string))
        {
            // to ensure "payerAuthenticationResponse" is required (not null)
            this.PayerAuthenticationResponse = payerAuthenticationResponse ?? throw new ArgumentNullException("payerAuthenticationResponse is a required property for Secure3D10AuthenticationUpdateRequestAllOf and cannot be null");
            // to ensure "merchantData" is required (not null)
            this.MerchantData = merchantData ?? throw new ArgumentNullException("merchantData is a required property for Secure3D10AuthenticationUpdateRequestAllOf and cannot be null");
            this.SecurityCode = securityCode;
        }

        /// <summary>
        /// A formatted message providing results of the issuer’s cardholder authentication.
        /// </summary>
        /// <value>A formatted message providing results of the issuer’s cardholder authentication.</value>
        [DataMember(Name = "payerAuthenticationResponse", EmitDefaultValue = false)]
        public string PayerAuthenticationResponse { get; set; }

        /// <summary>
        /// Formatted string encoding transaction time, order ID, and return URL data.
        /// </summary>
        /// <value>Formatted string encoding transaction time, order ID, and return URL data.</value>
        [DataMember(Name = "merchantData", EmitDefaultValue = false)]
        public string MerchantData { get; set; }

        /// <summary>
        /// Card security code if required by merchant.
        /// </summary>
        /// <value>Card security code if required by merchant.</value>
        [DataMember(Name = "securityCode", EmitDefaultValue = false)]
        public string SecurityCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Secure3D10AuthenticationUpdateRequestAllOf {\n");
            sb.Append("  PayerAuthenticationResponse: ").Append(PayerAuthenticationResponse).Append("\n");
            sb.Append("  MerchantData: ").Append(MerchantData).Append("\n");
            sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
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
            return this.Equals(input as Secure3D10AuthenticationUpdateRequestAllOf);
        }

        /// <summary>
        /// Returns true if Secure3D10AuthenticationUpdateRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of Secure3D10AuthenticationUpdateRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Secure3D10AuthenticationUpdateRequestAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PayerAuthenticationResponse == input.PayerAuthenticationResponse ||
                    (this.PayerAuthenticationResponse != null &&
                    this.PayerAuthenticationResponse.Equals(input.PayerAuthenticationResponse))
                ) && 
                (
                    this.MerchantData == input.MerchantData ||
                    (this.MerchantData != null &&
                    this.MerchantData.Equals(input.MerchantData))
                ) && 
                (
                    this.SecurityCode == input.SecurityCode ||
                    (this.SecurityCode != null &&
                    this.SecurityCode.Equals(input.SecurityCode))
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
                if (this.PayerAuthenticationResponse != null)
                    hashCode = hashCode * 59 + this.PayerAuthenticationResponse.GetHashCode();
                if (this.MerchantData != null)
                    hashCode = hashCode * 59 + this.MerchantData.GetHashCode();
                if (this.SecurityCode != null)
                    hashCode = hashCode * 59 + this.SecurityCode.GetHashCode();
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
            // PayerAuthenticationResponse (string) pattern
            Regex regexPayerAuthenticationResponse = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexPayerAuthenticationResponse.Match(this.PayerAuthenticationResponse).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PayerAuthenticationResponse, must match a pattern of " + regexPayerAuthenticationResponse, new [] { "PayerAuthenticationResponse" });
            }

            // MerchantData (string) pattern
            Regex regexMerchantData = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexMerchantData.Match(this.MerchantData).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantData, must match a pattern of " + regexMerchantData, new [] { "MerchantData" });
            }

            yield break;
        }
    }
}
