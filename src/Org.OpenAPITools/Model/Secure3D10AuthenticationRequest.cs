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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Request authentication of the payment card using the 3DS 1.0 URL redirect scheme. DEPRECATED - use Secure3DAuthenticationRequest instead
    /// </summary>
    [DataContract(Name = "Secure3D10AuthenticationRequest")]
    [JsonConverter(typeof(JsonSubtypes), "AuthenticationType")]
    public partial class Secure3D10AuthenticationRequest : AuthenticationRequest, IEquatable<Secure3D10AuthenticationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3D10AuthenticationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Secure3D10AuthenticationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3D10AuthenticationRequest" /> class.
        /// </summary>
        /// <param name="termURL">The result of the authentication will be sent to this URL. If not provided, a term URL will be dynamically generated. Note this must be a valid URL (special characters should be URL-encoded)..</param>
        /// <param name="authenticationType">Indicates what kind of authentication scheme the merchant wants to use on the card. (required) (default to &quot;Secure3D10AuthenticationRequest&quot;).</param>
        public Secure3D10AuthenticationRequest(string termURL = default(string), string authenticationType = "Secure3D10AuthenticationRequest") : base(authenticationType)
        {
            this.TermURL = termURL;
        }

        /// <summary>
        /// The result of the authentication will be sent to this URL. If not provided, a term URL will be dynamically generated. Note this must be a valid URL (special characters should be URL-encoded).
        /// </summary>
        /// <value>The result of the authentication will be sent to this URL. If not provided, a term URL will be dynamically generated. Note this must be a valid URL (special characters should be URL-encoded).</value>
        [DataMember(Name = "termURL", EmitDefaultValue = false)]
        public string TermURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Secure3D10AuthenticationRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  TermURL: ").Append(TermURL).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as Secure3D10AuthenticationRequest);
        }

        /// <summary>
        /// Returns true if Secure3D10AuthenticationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of Secure3D10AuthenticationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Secure3D10AuthenticationRequest input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.TermURL == input.TermURL ||
                    (this.TermURL != null &&
                    this.TermURL.Equals(input.TermURL))
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
                if (this.TermURL != null)
                    hashCode = hashCode * 59 + this.TermURL.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }
}
