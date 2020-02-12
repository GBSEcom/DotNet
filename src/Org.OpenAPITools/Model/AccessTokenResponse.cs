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
    /// Access token generation response.
    /// </summary>
    [DataContract]
    public partial class AccessTokenResponse :  IEquatable<AccessTokenResponse>, IValidatableObject
    {
        /// <summary>
        /// The result of the requested operation. If this is anything other than &#39;SUCCESS&#39;, please refer to the 400s HTTP error codes. See ErrorResponse object for details.
        /// </summary>
        /// <value>The result of the requested operation. If this is anything other than &#39;SUCCESS&#39;, please refer to the 400s HTTP error codes. See ErrorResponse object for details.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequestStatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 1

        }

        /// <summary>
        /// The result of the requested operation. If this is anything other than &#39;SUCCESS&#39;, please refer to the 400s HTTP error codes. See ErrorResponse object for details.
        /// </summary>
        /// <value>The result of the requested operation. If this is anything other than &#39;SUCCESS&#39;, please refer to the 400s HTTP error codes. See ErrorResponse object for details.</value>
        [DataMember(Name="requestStatus", EmitDefaultValue=false)]
        public RequestStatusEnum? RequestStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenResponse" /> class.
        /// </summary>
        /// <param name="accessToken">Access token for authentication..</param>
        /// <param name="clientRequestId">Echoes back the value from the request header for tracking..</param>
        /// <param name="requestStatus">The result of the requested operation. If this is anything other than &#39;SUCCESS&#39;, please refer to the 400s HTTP error codes. See ErrorResponse object for details..</param>
        public AccessTokenResponse(string accessToken = default(string), string clientRequestId = default(string), RequestStatusEnum? requestStatus = default(RequestStatusEnum?))
        {
            this.AccessToken = accessToken;
            this.ClientRequestId = clientRequestId;
            this.RequestStatus = requestStatus;
        }
        
        /// <summary>
        /// Access token for authentication.
        /// </summary>
        /// <value>Access token for authentication.</value>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Echoes back the value from the request header for tracking.
        /// </summary>
        /// <value>Echoes back the value from the request header for tracking.</value>
        [DataMember(Name="clientRequestId", EmitDefaultValue=false)]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessTokenResponse {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
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
            return this.Equals(input as AccessTokenResponse);
        }

        /// <summary>
        /// Returns true if AccessTokenResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessTokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessTokenResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.ClientRequestId == input.ClientRequestId ||
                    (this.ClientRequestId != null &&
                    this.ClientRequestId.Equals(input.ClientRequestId))
                ) && 
                (
                    this.RequestStatus == input.RequestStatus ||
                    this.RequestStatus.Equals(input.RequestStatus)
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
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.ClientRequestId != null)
                    hashCode = hashCode * 59 + this.ClientRequestId.GetHashCode();
                hashCode = hashCode * 59 + this.RequestStatus.GetHashCode();
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
