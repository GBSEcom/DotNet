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
    /// Secure3dAuthenticationVerificationRequestAllOf
    /// </summary>
    [DataContract]
    public partial class Secure3dAuthenticationVerificationRequestAllOf :  IEquatable<Secure3dAuthenticationVerificationRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3dAuthenticationVerificationRequestAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Secure3dAuthenticationVerificationRequestAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3dAuthenticationVerificationRequestAllOf" /> class.
        /// </summary>
        /// <param name="payerAuthenticationResponse">A formatted message providing results of the issuer’s cardholder authentication. (required).</param>
        /// <param name="merchantData">Formatted string encoding transaction time, order ID, and return URL data. (required).</param>
        public Secure3dAuthenticationVerificationRequestAllOf(string payerAuthenticationResponse = default(string), string merchantData = default(string))
        {
            // to ensure "payerAuthenticationResponse" is required (not null)
            if (payerAuthenticationResponse == null)
            {
                throw new InvalidDataException("payerAuthenticationResponse is a required property for Secure3dAuthenticationVerificationRequestAllOf and cannot be null");
            }
            else
            {
                this.PayerAuthenticationResponse = payerAuthenticationResponse;
            }

            // to ensure "merchantData" is required (not null)
            if (merchantData == null)
            {
                throw new InvalidDataException("merchantData is a required property for Secure3dAuthenticationVerificationRequestAllOf and cannot be null");
            }
            else
            {
                this.MerchantData = merchantData;
            }

        }
        
        /// <summary>
        /// A formatted message providing results of the issuer’s cardholder authentication.
        /// </summary>
        /// <value>A formatted message providing results of the issuer’s cardholder authentication.</value>
        [DataMember(Name="payerAuthenticationResponse", EmitDefaultValue=false)]
        public string PayerAuthenticationResponse { get; set; }

        /// <summary>
        /// Formatted string encoding transaction time, order ID, and return URL data.
        /// </summary>
        /// <value>Formatted string encoding transaction time, order ID, and return URL data.</value>
        [DataMember(Name="merchantData", EmitDefaultValue=false)]
        public string MerchantData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Secure3dAuthenticationVerificationRequestAllOf {\n");
            sb.Append("  PayerAuthenticationResponse: ").Append(PayerAuthenticationResponse).Append("\n");
            sb.Append("  MerchantData: ").Append(MerchantData).Append("\n");
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
            return this.Equals(input as Secure3dAuthenticationVerificationRequestAllOf);
        }

        /// <summary>
        /// Returns true if Secure3dAuthenticationVerificationRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of Secure3dAuthenticationVerificationRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Secure3dAuthenticationVerificationRequestAllOf input)
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
