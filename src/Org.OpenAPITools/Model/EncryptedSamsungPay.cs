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
    /// Encrypted Samsung Pay payload.
    /// </summary>
    [DataContract]
    public partial class EncryptedSamsungPay :  IEquatable<EncryptedSamsungPay>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedSamsungPay" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EncryptedSamsungPay() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedSamsungPay" /> class.
        /// </summary>
        /// <param name="data">The encrypted wallet payload. (required).</param>
        /// <param name="version">Identifies under which encryption/signing scheme this message has been created. In this way, the protocol can evolve over time if needed. For Google Payments transactions, this should be set to ECv1..</param>
        public EncryptedSamsungPay(string data = default(string), string version = default(string))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for EncryptedSamsungPay and cannot be null");
            }
            else
            {
                this.Data = data;
            }

            this.Version = version;
        }
        
        /// <summary>
        /// The encrypted wallet payload.
        /// </summary>
        /// <value>The encrypted wallet payload.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Identifies under which encryption/signing scheme this message has been created. In this way, the protocol can evolve over time if needed. For Google Payments transactions, this should be set to ECv1.
        /// </summary>
        /// <value>Identifies under which encryption/signing scheme this message has been created. In this way, the protocol can evolve over time if needed. For Google Payments transactions, this should be set to ECv1.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncryptedSamsungPay {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as EncryptedSamsungPay);
        }

        /// <summary>
        /// Returns true if EncryptedSamsungPay instances are equal
        /// </summary>
        /// <param name="input">Instance of EncryptedSamsungPay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EncryptedSamsungPay input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
            // Data (string) pattern
            Regex regexData = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexData.Match(this.Data).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Data, must match a pattern of " + regexData, new [] { "Data" });
            }

            // Version (string) pattern
            Regex regexVersion = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexVersion.Match(this.Version).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Version, must match a pattern of " + regexVersion, new [] { "Version" });
            }

            yield break;
        }
    }

}
