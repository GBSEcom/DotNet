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
    /// The processor Cardholder Info Response.
    /// </summary>
    [DataContract]
    public partial class CardholderInfoResponse : IEquatable<CardholderInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardholderInfoResponse" /> class.
        /// </summary>
        /// <param name="postalCodeOrZipMatch">Response if card holder postal code matches that on file..</param>
        /// <param name="addressMatch">Response if card holder address matches that on file..</param>
        /// <param name="nameMatch">Response if card holder name matches that on file..</param>
        /// <param name="telephoneMatch">Response if card holder telephone matches that on file..</param>
        /// <param name="emailMatch">Response if card holder email matches that on file..</param>
        /// <param name="associationCardholderInfoResponse">Raw cardholder info response from AMEX with no mapping..</param>
        public CardholderInfoResponse(string postalCodeOrZipMatch = default(string), string addressMatch = default(string), string nameMatch = default(string), string telephoneMatch = default(string), string emailMatch = default(string), string associationCardholderInfoResponse = default(string))
        {
            this.PostalCodeOrZipMatch = postalCodeOrZipMatch;
            this.AddressMatch = addressMatch;
            this.NameMatch = nameMatch;
            this.TelephoneMatch = telephoneMatch;
            this.EmailMatch = emailMatch;
            this.AssociationCardholderInfoResponse = associationCardholderInfoResponse;
        }

        /// <summary>
        /// Response if card holder postal code matches that on file.
        /// </summary>
        /// <value>Response if card holder postal code matches that on file.</value>
        [DataMember(Name = "postalCodeOrZipMatch", EmitDefaultValue = false)]
        public string PostalCodeOrZipMatch { get; set; }

        /// <summary>
        /// Response if card holder address matches that on file.
        /// </summary>
        /// <value>Response if card holder address matches that on file.</value>
        [DataMember(Name = "addressMatch", EmitDefaultValue = false)]
        public string AddressMatch { get; set; }

        /// <summary>
        /// Response if card holder name matches that on file.
        /// </summary>
        /// <value>Response if card holder name matches that on file.</value>
        [DataMember(Name = "nameMatch", EmitDefaultValue = false)]
        public string NameMatch { get; set; }

        /// <summary>
        /// Response if card holder telephone matches that on file.
        /// </summary>
        /// <value>Response if card holder telephone matches that on file.</value>
        [DataMember(Name = "telephoneMatch", EmitDefaultValue = false)]
        public string TelephoneMatch { get; set; }

        /// <summary>
        /// Response if card holder email matches that on file.
        /// </summary>
        /// <value>Response if card holder email matches that on file.</value>
        [DataMember(Name = "emailMatch", EmitDefaultValue = false)]
        public string EmailMatch { get; set; }

        /// <summary>
        /// Raw cardholder info response from AMEX with no mapping.
        /// </summary>
        /// <value>Raw cardholder info response from AMEX with no mapping.</value>
        [DataMember(Name = "associationCardholderInfoResponse", EmitDefaultValue = false)]
        public string AssociationCardholderInfoResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardholderInfoResponse {\n");
            sb.Append("  PostalCodeOrZipMatch: ").Append(PostalCodeOrZipMatch).Append("\n");
            sb.Append("  AddressMatch: ").Append(AddressMatch).Append("\n");
            sb.Append("  NameMatch: ").Append(NameMatch).Append("\n");
            sb.Append("  TelephoneMatch: ").Append(TelephoneMatch).Append("\n");
            sb.Append("  EmailMatch: ").Append(EmailMatch).Append("\n");
            sb.Append("  AssociationCardholderInfoResponse: ").Append(AssociationCardholderInfoResponse).Append("\n");
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
            return this.Equals(input as CardholderInfoResponse);
        }

        /// <summary>
        /// Returns true if CardholderInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CardholderInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardholderInfoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PostalCodeOrZipMatch == input.PostalCodeOrZipMatch ||
                    (this.PostalCodeOrZipMatch != null &&
                    this.PostalCodeOrZipMatch.Equals(input.PostalCodeOrZipMatch))
                ) && 
                (
                    this.AddressMatch == input.AddressMatch ||
                    (this.AddressMatch != null &&
                    this.AddressMatch.Equals(input.AddressMatch))
                ) && 
                (
                    this.NameMatch == input.NameMatch ||
                    (this.NameMatch != null &&
                    this.NameMatch.Equals(input.NameMatch))
                ) && 
                (
                    this.TelephoneMatch == input.TelephoneMatch ||
                    (this.TelephoneMatch != null &&
                    this.TelephoneMatch.Equals(input.TelephoneMatch))
                ) && 
                (
                    this.EmailMatch == input.EmailMatch ||
                    (this.EmailMatch != null &&
                    this.EmailMatch.Equals(input.EmailMatch))
                ) && 
                (
                    this.AssociationCardholderInfoResponse == input.AssociationCardholderInfoResponse ||
                    (this.AssociationCardholderInfoResponse != null &&
                    this.AssociationCardholderInfoResponse.Equals(input.AssociationCardholderInfoResponse))
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
                if (this.PostalCodeOrZipMatch != null)
                    hashCode = hashCode * 59 + this.PostalCodeOrZipMatch.GetHashCode();
                if (this.AddressMatch != null)
                    hashCode = hashCode * 59 + this.AddressMatch.GetHashCode();
                if (this.NameMatch != null)
                    hashCode = hashCode * 59 + this.NameMatch.GetHashCode();
                if (this.TelephoneMatch != null)
                    hashCode = hashCode * 59 + this.TelephoneMatch.GetHashCode();
                if (this.EmailMatch != null)
                    hashCode = hashCode * 59 + this.EmailMatch.GetHashCode();
                if (this.AssociationCardholderInfoResponse != null)
                    hashCode = hashCode * 59 + this.AssociationCardholderInfoResponse.GetHashCode();
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
