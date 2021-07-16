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
    /// Billing details for telecheck transactions.
    /// </summary>
    [DataContract]
    public partial class TeleCheckAchPaymentMethodAchBillTo : IEquatable<TeleCheckAchPaymentMethodAchBillTo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeleCheckAchPaymentMethodAchBillTo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeleCheckAchPaymentMethodAchBillTo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeleCheckAchPaymentMethodAchBillTo" /> class.
        /// </summary>
        /// <param name="firstName">Customer billing first name..</param>
        /// <param name="lastName">Customer billing last name. (required).</param>
        /// <param name="addressOne">Customer billing address, first line. (required).</param>
        /// <param name="addressTwo">Customer billing address, second line..</param>
        /// <param name="city">Customer billing city. (required).</param>
        /// <param name="state">Customer billing state. (required).</param>
        /// <param name="zip">Customer billing zip code. (required).</param>
        /// <param name="phone">Customer billing phone number. (required).</param>
        /// <param name="email">Customer billing email. Required if performing an ICA transaction..</param>
        /// <param name="countryCode">ISO country code. Required if performing an ICA transaction..</param>
        public TeleCheckAchPaymentMethodAchBillTo(string firstName = default(string), string lastName = default(string), string addressOne = default(string), string addressTwo = default(string), string city = default(string), string state = default(string), string zip = default(string), string phone = default(string), string email = default(string), string countryCode = default(string))
        {
            // to ensure "lastName" is required (not null)
            this.LastName = lastName ?? throw new ArgumentNullException("lastName is a required property for TeleCheckAchPaymentMethodAchBillTo and cannot be null");
            // to ensure "addressOne" is required (not null)
            this.AddressOne = addressOne ?? throw new ArgumentNullException("addressOne is a required property for TeleCheckAchPaymentMethodAchBillTo and cannot be null");
            // to ensure "city" is required (not null)
            this.City = city ?? throw new ArgumentNullException("city is a required property for TeleCheckAchPaymentMethodAchBillTo and cannot be null");
            // to ensure "state" is required (not null)
            this.State = state ?? throw new ArgumentNullException("state is a required property for TeleCheckAchPaymentMethodAchBillTo and cannot be null");
            // to ensure "zip" is required (not null)
            this.Zip = zip ?? throw new ArgumentNullException("zip is a required property for TeleCheckAchPaymentMethodAchBillTo and cannot be null");
            // to ensure "phone" is required (not null)
            this.Phone = phone ?? throw new ArgumentNullException("phone is a required property for TeleCheckAchPaymentMethodAchBillTo and cannot be null");
            this.FirstName = firstName;
            this.AddressTwo = addressTwo;
            this.Email = email;
            this.CountryCode = countryCode;
        }

        /// <summary>
        /// Customer billing first name.
        /// </summary>
        /// <value>Customer billing first name.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Customer billing last name.
        /// </summary>
        /// <value>Customer billing last name.</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Customer billing address, first line.
        /// </summary>
        /// <value>Customer billing address, first line.</value>
        [DataMember(Name = "addressOne", EmitDefaultValue = false)]
        public string AddressOne { get; set; }

        /// <summary>
        /// Customer billing address, second line.
        /// </summary>
        /// <value>Customer billing address, second line.</value>
        [DataMember(Name = "addressTwo", EmitDefaultValue = false)]
        public string AddressTwo { get; set; }

        /// <summary>
        /// Customer billing city.
        /// </summary>
        /// <value>Customer billing city.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Customer billing state.
        /// </summary>
        /// <value>Customer billing state.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Customer billing zip code.
        /// </summary>
        /// <value>Customer billing zip code.</value>
        [DataMember(Name = "zip", EmitDefaultValue = false)]
        public string Zip { get; set; }

        /// <summary>
        /// Customer billing phone number.
        /// </summary>
        /// <value>Customer billing phone number.</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Customer billing email. Required if performing an ICA transaction.
        /// </summary>
        /// <value>Customer billing email. Required if performing an ICA transaction.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// ISO country code. Required if performing an ICA transaction.
        /// </summary>
        /// <value>ISO country code. Required if performing an ICA transaction.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeleCheckAchPaymentMethodAchBillTo {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  AddressOne: ").Append(AddressOne).Append("\n");
            sb.Append("  AddressTwo: ").Append(AddressTwo).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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
            return this.Equals(input as TeleCheckAchPaymentMethodAchBillTo);
        }

        /// <summary>
        /// Returns true if TeleCheckAchPaymentMethodAchBillTo instances are equal
        /// </summary>
        /// <param name="input">Instance of TeleCheckAchPaymentMethodAchBillTo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeleCheckAchPaymentMethodAchBillTo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.AddressOne == input.AddressOne ||
                    (this.AddressOne != null &&
                    this.AddressOne.Equals(input.AddressOne))
                ) && 
                (
                    this.AddressTwo == input.AddressTwo ||
                    (this.AddressTwo != null &&
                    this.AddressTwo.Equals(input.AddressTwo))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.AddressOne != null)
                    hashCode = hashCode * 59 + this.AddressOne.GetHashCode();
                if (this.AddressTwo != null)
                    hashCode = hashCode * 59 + this.AddressTwo.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Zip != null)
                    hashCode = hashCode * 59 + this.Zip.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
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
            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 30.", new [] { "FirstName" });
            }

            // FirstName (string) pattern
            Regex regexFirstName = new Regex(@"(?=.*[^\\s])^[^|]+$", RegexOptions.CultureInvariant);
            if (false == regexFirstName.Match(this.FirstName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, must match a pattern of " + regexFirstName, new [] { "FirstName" });
            }

            // LastName (string) maxLength
            if(this.LastName != null && this.LastName.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be less than 30.", new [] { "LastName" });
            }

            // LastName (string) pattern
            Regex regexLastName = new Regex(@"(?=.*[^\\s])^[^|]+$", RegexOptions.CultureInvariant);
            if (false == regexLastName.Match(this.LastName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, must match a pattern of " + regexLastName, new [] { "LastName" });
            }

            // AddressOne (string) maxLength
            if(this.AddressOne != null && this.AddressOne.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressOne, length must be less than 50.", new [] { "AddressOne" });
            }

            // AddressOne (string) pattern
            Regex regexAddressOne = new Regex(@"(?=.*[^\\s])^[^|]+$", RegexOptions.CultureInvariant);
            if (false == regexAddressOne.Match(this.AddressOne).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressOne, must match a pattern of " + regexAddressOne, new [] { "AddressOne" });
            }

            // AddressTwo (string) maxLength
            if(this.AddressTwo != null && this.AddressTwo.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressTwo, length must be less than 30.", new [] { "AddressTwo" });
            }

            // AddressTwo (string) pattern
            Regex regexAddressTwo = new Regex(@"(?=.*[^\\s])^[^|]+$", RegexOptions.CultureInvariant);
            if (false == regexAddressTwo.Match(this.AddressTwo).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressTwo, must match a pattern of " + regexAddressTwo, new [] { "AddressTwo" });
            }

            // City (string) maxLength
            if(this.City != null && this.City.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 30.", new [] { "City" });
            }

            // City (string) pattern
            Regex regexCity = new Regex(@"(?=.*[^\\s])^[^|]+$", RegexOptions.CultureInvariant);
            if (false == regexCity.Match(this.City).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, must match a pattern of " + regexCity, new [] { "City" });
            }

            // State (string) maxLength
            if(this.State != null && this.State.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for State, length must be less than 2.", new [] { "State" });
            }

            // State (string) pattern
            Regex regexState = new Regex(@"^[A-Z]{2}$", RegexOptions.CultureInvariant);
            if (false == regexState.Match(this.State).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for State, must match a pattern of " + regexState, new [] { "State" });
            }

            // Zip (string) maxLength
            if(this.Zip != null && this.Zip.Length > 11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Zip, length must be less than 11.", new [] { "Zip" });
            }

            // Zip (string) pattern
            Regex regexZip = new Regex(@"(?=.*[^\\s])^[^|]+$", RegexOptions.CultureInvariant);
            if (false == regexZip.Match(this.Zip).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Zip, must match a pattern of " + regexZip, new [] { "Zip" });
            }

            // Phone (string) maxLength
            if(this.Phone != null && this.Phone.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Phone, length must be less than 10.", new [] { "Phone" });
            }

            // Phone (string) pattern
            Regex regexPhone = new Regex(@"^[0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexPhone.Match(this.Phone).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Phone, must match a pattern of " + regexPhone, new [] { "Phone" });
            }

            // Email (string) maxLength
            if(this.Email != null && this.Email.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 100.", new [] { "Email" });
            }

            // Email (string) pattern
            Regex regexEmail = new Regex(@"(?=.*[^\\s])^[^|]+$", RegexOptions.CultureInvariant);
            if (false == regexEmail.Match(this.Email).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, must match a pattern of " + regexEmail, new [] { "Email" });
            }

            // CountryCode (string) maxLength
            if(this.CountryCode != null && this.CountryCode.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be less than 2.", new [] { "CountryCode" });
            }

            // CountryCode (string) pattern
            Regex regexCountryCode = new Regex(@"^[A-Z]{2}$", RegexOptions.CultureInvariant);
            if (false == regexCountryCode.Match(this.CountryCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, must match a pattern of " + regexCountryCode, new [] { "CountryCode" });
            }

            yield break;
        }
    }
}
