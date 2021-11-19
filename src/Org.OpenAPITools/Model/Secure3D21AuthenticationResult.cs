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
    /// Submit the result of the authentication managed outside of the gateway for a 3-D Secure 2.x scheme. For more convenient usage without implementing 3-D Secure yourself see \&quot;authenticationRequest\&quot; section. DEPRECATED - use Secure3DAuthenticationResult instead
    /// </summary>
    [DataContract(Name = "Secure3D21AuthenticationResult")]
    [JsonConverter(typeof(JsonSubtypes), "AuthenticationType")]
    public partial class Secure3D21AuthenticationResult : AuthenticationResult, IEquatable<Secure3D21AuthenticationResult>, IValidatableObject
    {
        /// <summary>
        /// The result of authentication attempt returned by the 3D Secure authentication process (PaRes).
        /// </summary>
        /// <value>The result of authentication attempt returned by the 3D Secure authentication process (PaRes).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthenticationResponseEnum
        {
            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")]
            A = 1,

            /// <summary>
            /// Enum N for value: N
            /// </summary>
            [EnumMember(Value = "N")]
            N = 2,

            /// <summary>
            /// Enum U for value: U
            /// </summary>
            [EnumMember(Value = "U")]
            U = 3,

            /// <summary>
            /// Enum Y for value: Y
            /// </summary>
            [EnumMember(Value = "Y")]
            Y = 4,

            /// <summary>
            /// Enum C for value: C
            /// </summary>
            [EnumMember(Value = "C")]
            C = 5,

            /// <summary>
            /// Enum R for value: R
            /// </summary>
            [EnumMember(Value = "R")]
            R = 6

        }


        /// <summary>
        /// The result of authentication attempt returned by the 3D Secure authentication process (PaRes).
        /// </summary>
        /// <value>The result of authentication attempt returned by the 3D Secure authentication process (PaRes).</value>
        [DataMember(Name = "authenticationResponse", EmitDefaultValue = false)]
        public AuthenticationResponseEnum? AuthenticationResponse { get; set; }
        /// <summary>
        /// The transaction status as returned by the 3D Secure authentication process.
        /// </summary>
        /// <value>The transaction status as returned by the 3D Secure authentication process.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionStatusEnum
        {
            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")]
            A = 1,

            /// <summary>
            /// Enum N for value: N
            /// </summary>
            [EnumMember(Value = "N")]
            N = 2,

            /// <summary>
            /// Enum U for value: U
            /// </summary>
            [EnumMember(Value = "U")]
            U = 3,

            /// <summary>
            /// Enum Y for value: Y
            /// </summary>
            [EnumMember(Value = "Y")]
            Y = 4,

            /// <summary>
            /// Enum C for value: C
            /// </summary>
            [EnumMember(Value = "C")]
            C = 5,

            /// <summary>
            /// Enum R for value: R
            /// </summary>
            [EnumMember(Value = "R")]
            R = 6

        }


        /// <summary>
        /// The transaction status as returned by the 3D Secure authentication process.
        /// </summary>
        /// <value>The transaction status as returned by the 3D Secure authentication process.</value>
        [DataMember(Name = "transactionStatus", EmitDefaultValue = false)]
        public TransactionStatusEnum? TransactionStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3D21AuthenticationResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Secure3D21AuthenticationResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3D21AuthenticationResult" /> class.
        /// </summary>
        /// <param name="cavv">The Cardholder Authentication Verification Value (CAVV) is a cryptographic value derived by the issuer during payment authentication that can provide evidence of the results of payment authentication during an online purchase..</param>
        /// <param name="xid">The transaction identifier (XID) is a unique tracking number set by the merchant..</param>
        /// <param name="transactionId">The response transaction UUID. Only applicable to MasterCard..</param>
        /// <param name="authenticationResponse">The result of authentication attempt returned by the 3D Secure authentication process (PaRes). (default to AuthenticationResponseEnum.Y).</param>
        /// <param name="transactionStatus">The transaction status as returned by the 3D Secure authentication process..</param>
        /// <param name="authenticationType">Specifies the version of 3DS to be used where authentication was managed outside of the gateway. (required) (default to &quot;Secure3D21AuthenticationResult&quot;).</param>
        public Secure3D21AuthenticationResult(string cavv = default(string), string xid = default(string), string transactionId = default(string), AuthenticationResponseEnum? authenticationResponse = AuthenticationResponseEnum.Y, TransactionStatusEnum? transactionStatus = default(TransactionStatusEnum?), string authenticationType = "Secure3D21AuthenticationResult") : base(authenticationType)
        {
            this.Cavv = cavv;
            this.Xid = xid;
            this.TransactionId = transactionId;
            this.AuthenticationResponse = authenticationResponse;
            this.TransactionStatus = transactionStatus;
        }

        /// <summary>
        /// The Cardholder Authentication Verification Value (CAVV) is a cryptographic value derived by the issuer during payment authentication that can provide evidence of the results of payment authentication during an online purchase.
        /// </summary>
        /// <value>The Cardholder Authentication Verification Value (CAVV) is a cryptographic value derived by the issuer during payment authentication that can provide evidence of the results of payment authentication during an online purchase.</value>
        [DataMember(Name = "cavv", EmitDefaultValue = false)]
        public string Cavv { get; set; }

        /// <summary>
        /// The transaction identifier (XID) is a unique tracking number set by the merchant.
        /// </summary>
        /// <value>The transaction identifier (XID) is a unique tracking number set by the merchant.</value>
        [DataMember(Name = "xid", EmitDefaultValue = false)]
        public string Xid { get; set; }

        /// <summary>
        /// The response transaction UUID. Only applicable to MasterCard.
        /// </summary>
        /// <value>The response transaction UUID. Only applicable to MasterCard.</value>
        [DataMember(Name = "transactionId", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Secure3D21AuthenticationResult {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Cavv: ").Append(Cavv).Append("\n");
            sb.Append("  Xid: ").Append(Xid).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  AuthenticationResponse: ").Append(AuthenticationResponse).Append("\n");
            sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
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
            return this.Equals(input as Secure3D21AuthenticationResult);
        }

        /// <summary>
        /// Returns true if Secure3D21AuthenticationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of Secure3D21AuthenticationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Secure3D21AuthenticationResult input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Cavv == input.Cavv ||
                    (this.Cavv != null &&
                    this.Cavv.Equals(input.Cavv))
                ) && base.Equals(input) && 
                (
                    this.Xid == input.Xid ||
                    (this.Xid != null &&
                    this.Xid.Equals(input.Xid))
                ) && base.Equals(input) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && base.Equals(input) && 
                (
                    this.AuthenticationResponse == input.AuthenticationResponse ||
                    this.AuthenticationResponse.Equals(input.AuthenticationResponse)
                ) && base.Equals(input) && 
                (
                    this.TransactionStatus == input.TransactionStatus ||
                    this.TransactionStatus.Equals(input.TransactionStatus)
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
                if (this.Cavv != null)
                    hashCode = hashCode * 59 + this.Cavv.GetHashCode();
                if (this.Xid != null)
                    hashCode = hashCode * 59 + this.Xid.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                hashCode = hashCode * 59 + this.AuthenticationResponse.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionStatus.GetHashCode();
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
            // Cavv (string) maxLength
            if(this.Cavv != null && this.Cavv.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cavv, length must be less than 32.", new [] { "Cavv" });
            }

            // Cavv (string) minLength
            if(this.Cavv != null && this.Cavv.Length < 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cavv, length must be greater than 20.", new [] { "Cavv" });
            }

            // Xid (string) maxLength
            if(this.Xid != null && this.Xid.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Xid, length must be less than 32.", new [] { "Xid" });
            }

            // Xid (string) minLength
            if(this.Xid != null && this.Xid.Length < 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Xid, length must be greater than 20.", new [] { "Xid" });
            }

            yield break;
        }
    }
}
