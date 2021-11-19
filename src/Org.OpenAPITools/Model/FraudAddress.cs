/*
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.5.0.20211029.001
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Address fields.
    /// </summary>
    [DataContract(Name = "FraudAddress")]
    public partial class FraudAddress : IEquatable<FraudAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FraudAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudAddress" /> class.
        /// </summary>
        /// <param name="street">First line of street address. (required).</param>
        /// <param name="street2">Second line of street address..</param>
        /// <param name="stateProvince">State or province..</param>
        /// <param name="city">City..</param>
        /// <param name="country">Country. (required).</param>
        /// <param name="zipPostalCode">Postal code..</param>
        public FraudAddress(string street = default(string), string street2 = default(string), string stateProvince = default(string), string city = default(string), string country = default(string), string zipPostalCode = default(string))
        {
            // to ensure "street" is required (not null)
            this.Street = street ?? throw new ArgumentNullException("street is a required property for FraudAddress and cannot be null");
            // to ensure "country" is required (not null)
            this.Country = country ?? throw new ArgumentNullException("country is a required property for FraudAddress and cannot be null");
            this.Street2 = street2;
            this.StateProvince = stateProvince;
            this.City = city;
            this.ZipPostalCode = zipPostalCode;
        }

        /// <summary>
        /// First line of street address.
        /// </summary>
        /// <value>First line of street address.</value>
        [DataMember(Name = "street", IsRequired = true, EmitDefaultValue = false)]
        public string Street { get; set; }

        /// <summary>
        /// Second line of street address.
        /// </summary>
        /// <value>Second line of street address.</value>
        [DataMember(Name = "street2", EmitDefaultValue = false)]
        public string Street2 { get; set; }

        /// <summary>
        /// State or province.
        /// </summary>
        /// <value>State or province.</value>
        [DataMember(Name = "stateProvince", EmitDefaultValue = false)]
        public string StateProvince { get; set; }

        /// <summary>
        /// City.
        /// </summary>
        /// <value>City.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Country.
        /// </summary>
        /// <value>Country.</value>
        [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>
        /// <value>Postal code.</value>
        [DataMember(Name = "zipPostalCode", EmitDefaultValue = false)]
        public string ZipPostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FraudAddress {\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  ZipPostalCode: ").Append(ZipPostalCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FraudAddress);
        }

        /// <summary>
        /// Returns true if FraudAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.Street2 == input.Street2 ||
                    (this.Street2 != null &&
                    this.Street2.Equals(input.Street2))
                ) && 
                (
                    this.StateProvince == input.StateProvince ||
                    (this.StateProvince != null &&
                    this.StateProvince.Equals(input.StateProvince))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.ZipPostalCode == input.ZipPostalCode ||
                    (this.ZipPostalCode != null &&
                    this.ZipPostalCode.Equals(input.ZipPostalCode))
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
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.Street2 != null)
                    hashCode = hashCode * 59 + this.Street2.GetHashCode();
                if (this.StateProvince != null)
                    hashCode = hashCode * 59 + this.StateProvince.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.ZipPostalCode != null)
                    hashCode = hashCode * 59 + this.ZipPostalCode.GetHashCode();
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
            // Street (string) pattern
            Regex regexStreet = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexStreet.Match(this.Street).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Street, must match a pattern of " + regexStreet, new [] { "Street" });
            }

            // Country (string) pattern
            Regex regexCountry = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexCountry.Match(this.Country).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, must match a pattern of " + regexCountry, new [] { "Country" });
            }

            // ZipPostalCode (string) pattern
            Regex regexZipPostalCode = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexZipPostalCode.Match(this.ZipPostalCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ZipPostalCode, must match a pattern of " + regexZipPostalCode, new [] { "ZipPostalCode" });
            }

            yield break;
        }
    }
}
