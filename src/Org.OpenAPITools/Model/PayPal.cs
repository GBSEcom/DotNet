/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.6.0.20190507.002
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
    /// The payment object for PayPal transactions.
    /// </summary>
    [DataContract]
    public partial class PayPal :  IEquatable<PayPal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayPal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayPal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayPal" /> class.
        /// </summary>
        /// <param name="recipientEmail">Email address of the recipient. (required).</param>
        public PayPal(string recipientEmail = default(string))
        {
            // to ensure "recipientEmail" is required (not null)
            if (recipientEmail == null)
            {
                throw new InvalidDataException("recipientEmail is a required property for PayPal and cannot be null");
            }
            else
            {
                this.RecipientEmail = recipientEmail;
            }

        }
        
        /// <summary>
        /// Email address of the recipient.
        /// </summary>
        /// <value>Email address of the recipient.</value>
        [DataMember(Name="recipientEmail", EmitDefaultValue=false)]
        public string RecipientEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayPal {\n");
            sb.Append("  RecipientEmail: ").Append(RecipientEmail).Append("\n");
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
            return this.Equals(input as PayPal);
        }

        /// <summary>
        /// Returns true if PayPal instances are equal
        /// </summary>
        /// <param name="input">Instance of PayPal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayPal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecipientEmail == input.RecipientEmail ||
                    (this.RecipientEmail != null &&
                    this.RecipientEmail.Equals(input.RecipientEmail))
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
                if (this.RecipientEmail != null)
                    hashCode = hashCode * 59 + this.RecipientEmail.GetHashCode();
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
            // RecipientEmail (string) maxLength
            if(this.RecipientEmail != null && this.RecipientEmail.Length > 254)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecipientEmail, length must be less than 254.", new [] { "RecipientEmail" });
            }

            // RecipientEmail (string) pattern
            Regex regexRecipientEmail = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexRecipientEmail.Match(this.RecipientEmail).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecipientEmail, must match a pattern of " + regexRecipientEmail, new [] { "RecipientEmail" });
            }

            yield break;
        }
    }

}