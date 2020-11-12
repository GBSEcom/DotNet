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
    /// The group MCC (Merchant Category Code) 6012
    /// </summary>
    [DataContract]
    public partial class Mcc6012 : IEquatable<Mcc6012>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mcc6012" /> class.
        /// </summary>
        /// <param name="dateOfBirth">The date of birth of the cardholder (YYYYMMDD)..</param>
        /// <param name="accountFirst6">The first six digits of the primary account number..</param>
        /// <param name="accountLast4">The last four digits of the primary account number..</param>
        /// <param name="accountNum">The account number where the primary account number is not a card..</param>
        /// <param name="postCode">The postal code of the cardholder..</param>
        /// <param name="surname">Surname or last name of the card holder..</param>
        public Mcc6012(string dateOfBirth = default(string), string accountFirst6 = default(string), string accountLast4 = default(string), string accountNum = default(string), string postCode = default(string), string surname = default(string))
        {
            this.DateOfBirth = dateOfBirth;
            this.AccountFirst6 = accountFirst6;
            this.AccountLast4 = accountLast4;
            this.AccountNum = accountNum;
            this.PostCode = postCode;
            this.Surname = surname;
        }

        /// <summary>
        /// The date of birth of the cardholder (YYYYMMDD).
        /// </summary>
        /// <value>The date of birth of the cardholder (YYYYMMDD).</value>
        [DataMember(Name = "dateOfBirth", EmitDefaultValue = false)]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// The first six digits of the primary account number.
        /// </summary>
        /// <value>The first six digits of the primary account number.</value>
        [DataMember(Name = "accountFirst6", EmitDefaultValue = false)]
        public string AccountFirst6 { get; set; }

        /// <summary>
        /// The last four digits of the primary account number.
        /// </summary>
        /// <value>The last four digits of the primary account number.</value>
        [DataMember(Name = "accountLast4", EmitDefaultValue = false)]
        public string AccountLast4 { get; set; }

        /// <summary>
        /// The account number where the primary account number is not a card.
        /// </summary>
        /// <value>The account number where the primary account number is not a card.</value>
        [DataMember(Name = "accountNum", EmitDefaultValue = false)]
        public string AccountNum { get; set; }

        /// <summary>
        /// The postal code of the cardholder.
        /// </summary>
        /// <value>The postal code of the cardholder.</value>
        [DataMember(Name = "postCode", EmitDefaultValue = false)]
        public string PostCode { get; set; }

        /// <summary>
        /// Surname or last name of the card holder.
        /// </summary>
        /// <value>Surname or last name of the card holder.</value>
        [DataMember(Name = "surname", EmitDefaultValue = false)]
        public string Surname { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Mcc6012 {\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  AccountFirst6: ").Append(AccountFirst6).Append("\n");
            sb.Append("  AccountLast4: ").Append(AccountLast4).Append("\n");
            sb.Append("  AccountNum: ").Append(AccountNum).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
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
            return this.Equals(input as Mcc6012);
        }

        /// <summary>
        /// Returns true if Mcc6012 instances are equal
        /// </summary>
        /// <param name="input">Instance of Mcc6012 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Mcc6012 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.AccountFirst6 == input.AccountFirst6 ||
                    (this.AccountFirst6 != null &&
                    this.AccountFirst6.Equals(input.AccountFirst6))
                ) && 
                (
                    this.AccountLast4 == input.AccountLast4 ||
                    (this.AccountLast4 != null &&
                    this.AccountLast4.Equals(input.AccountLast4))
                ) && 
                (
                    this.AccountNum == input.AccountNum ||
                    (this.AccountNum != null &&
                    this.AccountNum.Equals(input.AccountNum))
                ) && 
                (
                    this.PostCode == input.PostCode ||
                    (this.PostCode != null &&
                    this.PostCode.Equals(input.PostCode))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
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
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.AccountFirst6 != null)
                    hashCode = hashCode * 59 + this.AccountFirst6.GetHashCode();
                if (this.AccountLast4 != null)
                    hashCode = hashCode * 59 + this.AccountLast4.GetHashCode();
                if (this.AccountNum != null)
                    hashCode = hashCode * 59 + this.AccountNum.GetHashCode();
                if (this.PostCode != null)
                    hashCode = hashCode * 59 + this.PostCode.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
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
            // DateOfBirth (string) maxLength
            if(this.DateOfBirth != null && this.DateOfBirth.Length > 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DateOfBirth, length must be less than 8.", new [] { "DateOfBirth" });
            }

            // AccountFirst6 (string) maxLength
            if(this.AccountFirst6 != null && this.AccountFirst6.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountFirst6, length must be less than 6.", new [] { "AccountFirst6" });
            }

            // AccountLast4 (string) maxLength
            if(this.AccountLast4 != null && this.AccountLast4.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountLast4, length must be less than 4.", new [] { "AccountLast4" });
            }

            // AccountNum (string) maxLength
            if(this.AccountNum != null && this.AccountNum.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNum, length must be less than 50.", new [] { "AccountNum" });
            }

            // PostCode (string) maxLength
            if(this.PostCode != null && this.PostCode.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostCode, length must be less than 50.", new [] { "PostCode" });
            }

            // Surname (string) maxLength
            if(this.Surname != null && this.Surname.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Surname, length must be less than 100.", new [] { "Surname" });
            }

            yield break;
        }
    }
}
