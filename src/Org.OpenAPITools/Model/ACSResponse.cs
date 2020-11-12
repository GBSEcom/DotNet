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
    /// Encapsulates response data from the ACS.
    /// </summary>
    [DataContract]
    public partial class ACSResponse : IEquatable<ACSResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ACSResponse" /> class.
        /// </summary>
        /// <param name="cRes">The ACS response to the CReq message. It can indicate the result of cardholder authentication or, in the case of an app-based model, also signal that further cardholder interaction is required to complete the authentication..</param>
        public ACSResponse(string cRes = default(string))
        {
            this.CRes = cRes;
        }

        /// <summary>
        /// The ACS response to the CReq message. It can indicate the result of cardholder authentication or, in the case of an app-based model, also signal that further cardholder interaction is required to complete the authentication.
        /// </summary>
        /// <value>The ACS response to the CReq message. It can indicate the result of cardholder authentication or, in the case of an app-based model, also signal that further cardholder interaction is required to complete the authentication.</value>
        [DataMember(Name = "cRes", EmitDefaultValue = false)]
        public string CRes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ACSResponse {\n");
            sb.Append("  CRes: ").Append(CRes).Append("\n");
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
            return this.Equals(input as ACSResponse);
        }

        /// <summary>
        /// Returns true if ACSResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ACSResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ACSResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CRes == input.CRes ||
                    (this.CRes != null &&
                    this.CRes.Equals(input.CRes))
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
                if (this.CRes != null)
                    hashCode = hashCode * 59 + this.CRes.GetHashCode();
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
