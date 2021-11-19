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
    /// Secure3D21AuthenticationRequestAllOf
    /// </summary>
    [DataContract(Name = "Secure3D21AuthenticationRequest_allOf")]
    public partial class Secure3D21AuthenticationRequestAllOf : IEquatable<Secure3D21AuthenticationRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Indicates whether or not a challenge should be performed. 01 &#x3D; No preference (You have no preference whether a challenge should be performed. This is the default value) 02 &#x3D; No challenge requested (You prefer that no challenge should be performed) 03 &#x3D; Challenge requested: 3DS Requestor Preference (You prefer that a challenge should be performed) 04 &#x3D; Challenge requested: Mandate (There are local or regional mandates that mean that a challenge must be performed) The following are applicable only for 3DS 2.2 protocol. 05 &#x3D; No challenge requested (transactional risk analysis is already performed) 06 &#x3D; No challenge requested (Data share only) 07 &#x3D; No challenge requested (strong consumer authentication is already performed) 08 &#x3D; No challenge requested (utilise whitelist exemption if no challenge required) 09 &#x3D; Challenge requested (whitelist prompt requested if challenge required) 
        /// </summary>
        /// <value>Indicates whether or not a challenge should be performed. 01 &#x3D; No preference (You have no preference whether a challenge should be performed. This is the default value) 02 &#x3D; No challenge requested (You prefer that no challenge should be performed) 03 &#x3D; Challenge requested: 3DS Requestor Preference (You prefer that a challenge should be performed) 04 &#x3D; Challenge requested: Mandate (There are local or regional mandates that mean that a challenge must be performed) The following are applicable only for 3DS 2.2 protocol. 05 &#x3D; No challenge requested (transactional risk analysis is already performed) 06 &#x3D; No challenge requested (Data share only) 07 &#x3D; No challenge requested (strong consumer authentication is already performed) 08 &#x3D; No challenge requested (utilise whitelist exemption if no challenge required) 09 &#x3D; Challenge requested (whitelist prompt requested if challenge required) </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChallengeIndicatorEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01 = 1,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")]
            _02 = 2,

            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")]
            _03 = 3,

            /// <summary>
            /// Enum _04 for value: 04
            /// </summary>
            [EnumMember(Value = "04")]
            _04 = 4,

            /// <summary>
            /// Enum _05 for value: 05
            /// </summary>
            [EnumMember(Value = "05")]
            _05 = 5,

            /// <summary>
            /// Enum _06 for value: 06
            /// </summary>
            [EnumMember(Value = "06")]
            _06 = 6,

            /// <summary>
            /// Enum _07 for value: 07
            /// </summary>
            [EnumMember(Value = "07")]
            _07 = 7,

            /// <summary>
            /// Enum _08 for value: 08
            /// </summary>
            [EnumMember(Value = "08")]
            _08 = 8,

            /// <summary>
            /// Enum _09 for value: 09
            /// </summary>
            [EnumMember(Value = "09")]
            _09 = 9

        }


        /// <summary>
        /// Indicates whether or not a challenge should be performed. 01 &#x3D; No preference (You have no preference whether a challenge should be performed. This is the default value) 02 &#x3D; No challenge requested (You prefer that no challenge should be performed) 03 &#x3D; Challenge requested: 3DS Requestor Preference (You prefer that a challenge should be performed) 04 &#x3D; Challenge requested: Mandate (There are local or regional mandates that mean that a challenge must be performed) The following are applicable only for 3DS 2.2 protocol. 05 &#x3D; No challenge requested (transactional risk analysis is already performed) 06 &#x3D; No challenge requested (Data share only) 07 &#x3D; No challenge requested (strong consumer authentication is already performed) 08 &#x3D; No challenge requested (utilise whitelist exemption if no challenge required) 09 &#x3D; Challenge requested (whitelist prompt requested if challenge required) 
        /// </summary>
        /// <value>Indicates whether or not a challenge should be performed. 01 &#x3D; No preference (You have no preference whether a challenge should be performed. This is the default value) 02 &#x3D; No challenge requested (You prefer that no challenge should be performed) 03 &#x3D; Challenge requested: 3DS Requestor Preference (You prefer that a challenge should be performed) 04 &#x3D; Challenge requested: Mandate (There are local or regional mandates that mean that a challenge must be performed) The following are applicable only for 3DS 2.2 protocol. 05 &#x3D; No challenge requested (transactional risk analysis is already performed) 06 &#x3D; No challenge requested (Data share only) 07 &#x3D; No challenge requested (strong consumer authentication is already performed) 08 &#x3D; No challenge requested (utilise whitelist exemption if no challenge required) 09 &#x3D; Challenge requested (whitelist prompt requested if challenge required) </value>
        [DataMember(Name = "challengeIndicator", EmitDefaultValue = false)]
        public ChallengeIndicatorEnum? ChallengeIndicator { get; set; }
        /// <summary>
        /// Defines the size of the challenge window displayed to customers during authentication. 01 &#x3D; 250 x 400 02 &#x3D; 390 x 400 03 &#x3D; 500 x 600 04 &#x3D; 600 x 400 05 &#x3D; Full screen 
        /// </summary>
        /// <value>Defines the size of the challenge window displayed to customers during authentication. 01 &#x3D; 250 x 400 02 &#x3D; 390 x 400 03 &#x3D; 500 x 600 04 &#x3D; 600 x 400 05 &#x3D; Full screen </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChallengeWindowSizeEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01 = 1,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")]
            _02 = 2,

            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")]
            _03 = 3,

            /// <summary>
            /// Enum _04 for value: 04
            /// </summary>
            [EnumMember(Value = "04")]
            _04 = 4,

            /// <summary>
            /// Enum _05 for value: 05
            /// </summary>
            [EnumMember(Value = "05")]
            _05 = 5

        }


        /// <summary>
        /// Defines the size of the challenge window displayed to customers during authentication. 01 &#x3D; 250 x 400 02 &#x3D; 390 x 400 03 &#x3D; 500 x 600 04 &#x3D; 600 x 400 05 &#x3D; Full screen 
        /// </summary>
        /// <value>Defines the size of the challenge window displayed to customers during authentication. 01 &#x3D; 250 x 400 02 &#x3D; 390 x 400 03 &#x3D; 500 x 600 04 &#x3D; 600 x 400 05 &#x3D; Full screen </value>
        [DataMember(Name = "challengeWindowSize", EmitDefaultValue = false)]
        public ChallengeWindowSizeEnum? ChallengeWindowSize { get; set; }
        /// <summary>
        /// Provides additional information to the ACS to determine the best approach for handling an authentication request. 01 &#x3D; Payment transaction 02 &#x3D; Recurring transaction 03 &#x3D; Installment transaction 04 &#x3D; Add card 05 &#x3D; Maintain card 06 &#x3D; Card holder verification as part of EMV token ID and Value 
        /// </summary>
        /// <value>Provides additional information to the ACS to determine the best approach for handling an authentication request. 01 &#x3D; Payment transaction 02 &#x3D; Recurring transaction 03 &#x3D; Installment transaction 04 &#x3D; Add card 05 &#x3D; Maintain card 06 &#x3D; Card holder verification as part of EMV token ID and Value </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthenticationIndicatorEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01 = 1,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")]
            _02 = 2,

            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")]
            _03 = 3,

            /// <summary>
            /// Enum _04 for value: 04
            /// </summary>
            [EnumMember(Value = "04")]
            _04 = 4,

            /// <summary>
            /// Enum _05 for value: 05
            /// </summary>
            [EnumMember(Value = "05")]
            _05 = 5,

            /// <summary>
            /// Enum _06 for value: 06
            /// </summary>
            [EnumMember(Value = "06")]
            _06 = 6

        }


        /// <summary>
        /// Provides additional information to the ACS to determine the best approach for handling an authentication request. 01 &#x3D; Payment transaction 02 &#x3D; Recurring transaction 03 &#x3D; Installment transaction 04 &#x3D; Add card 05 &#x3D; Maintain card 06 &#x3D; Card holder verification as part of EMV token ID and Value 
        /// </summary>
        /// <value>Provides additional information to the ACS to determine the best approach for handling an authentication request. 01 &#x3D; Payment transaction 02 &#x3D; Recurring transaction 03 &#x3D; Installment transaction 04 &#x3D; Add card 05 &#x3D; Maintain card 06 &#x3D; Card holder verification as part of EMV token ID and Value </value>
        [DataMember(Name = "authenticationIndicator", EmitDefaultValue = false)]
        public AuthenticationIndicatorEnum? AuthenticationIndicator { get; set; }
        /// <summary>
        /// 02 &#x3D; BRW 03 &#x3D; 3RI 
        /// </summary>
        /// <value>02 &#x3D; BRW 03 &#x3D; 3RI </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Secure3DDeviceChannelEnum
        {
            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")]
            _02 = 1,

            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")]
            _03 = 2

        }


        /// <summary>
        /// 02 &#x3D; BRW 03 &#x3D; 3RI 
        /// </summary>
        /// <value>02 &#x3D; BRW 03 &#x3D; 3RI </value>
        [DataMember(Name = "secure3DDeviceChannel", EmitDefaultValue = true)]
        public Secure3DDeviceChannelEnum? Secure3DDeviceChannel { get; set; }
        /// <summary>
        /// 01 &#x3D; Recurring transaction 02 &#x3D; Instalment transaction 03 &#x3D; Add card 04 &#x3D; Maintain card information 05 &#x3D; Account verification 06 &#x3D; Split/delayed shipment 07 &#x3D; Top-up 08 &#x3D; Mail Order 09 &#x3D; Telephone Order 10 &#x3D; Whitelist status check 11 &#x3D; Other payment 
        /// </summary>
        /// <value>01 &#x3D; Recurring transaction 02 &#x3D; Instalment transaction 03 &#x3D; Add card 04 &#x3D; Maintain card information 05 &#x3D; Account verification 06 &#x3D; Split/delayed shipment 07 &#x3D; Top-up 08 &#x3D; Mail Order 09 &#x3D; Telephone Order 10 &#x3D; Whitelist status check 11 &#x3D; Other payment </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Secure3DThreeRIIndicatorEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01 = 1,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")]
            _02 = 2,

            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")]
            _03 = 3,

            /// <summary>
            /// Enum _04 for value: 04
            /// </summary>
            [EnumMember(Value = "04")]
            _04 = 4,

            /// <summary>
            /// Enum _05 for value: 05
            /// </summary>
            [EnumMember(Value = "05")]
            _05 = 5,

            /// <summary>
            /// Enum _06 for value: 06
            /// </summary>
            [EnumMember(Value = "06")]
            _06 = 6,

            /// <summary>
            /// Enum _07 for value: 07
            /// </summary>
            [EnumMember(Value = "07")]
            _07 = 7,

            /// <summary>
            /// Enum _08 for value: 08
            /// </summary>
            [EnumMember(Value = "08")]
            _08 = 8,

            /// <summary>
            /// Enum _09 for value: 09
            /// </summary>
            [EnumMember(Value = "09")]
            _09 = 9,

            /// <summary>
            /// Enum _10 for value: 10
            /// </summary>
            [EnumMember(Value = "10")]
            _10 = 10,

            /// <summary>
            /// Enum _11 for value: 11
            /// </summary>
            [EnumMember(Value = "11")]
            _11 = 11

        }


        /// <summary>
        /// 01 &#x3D; Recurring transaction 02 &#x3D; Instalment transaction 03 &#x3D; Add card 04 &#x3D; Maintain card information 05 &#x3D; Account verification 06 &#x3D; Split/delayed shipment 07 &#x3D; Top-up 08 &#x3D; Mail Order 09 &#x3D; Telephone Order 10 &#x3D; Whitelist status check 11 &#x3D; Other payment 
        /// </summary>
        /// <value>01 &#x3D; Recurring transaction 02 &#x3D; Instalment transaction 03 &#x3D; Add card 04 &#x3D; Maintain card information 05 &#x3D; Account verification 06 &#x3D; Split/delayed shipment 07 &#x3D; Top-up 08 &#x3D; Mail Order 09 &#x3D; Telephone Order 10 &#x3D; Whitelist status check 11 &#x3D; Other payment </value>
        [DataMember(Name = "secure3DThreeRIIndicator", EmitDefaultValue = true)]
        public Secure3DThreeRIIndicatorEnum? Secure3DThreeRIIndicator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3D21AuthenticationRequestAllOf" /> class.
        /// </summary>
        /// <param name="termURL">The result of the authentication will be sent to this URL. If not provided, a term URL will be dynamically generated. Note this must be a valid URL (special characters should be URL-encoded)..</param>
        /// <param name="methodNotificationURL">The 3DS method iframe and transaction ID will be sent here. Note this must be a valid URL (special characters should be URL-encoded)..</param>
        /// <param name="challengeIndicator">Indicates whether or not a challenge should be performed. 01 &#x3D; No preference (You have no preference whether a challenge should be performed. This is the default value) 02 &#x3D; No challenge requested (You prefer that no challenge should be performed) 03 &#x3D; Challenge requested: 3DS Requestor Preference (You prefer that a challenge should be performed) 04 &#x3D; Challenge requested: Mandate (There are local or regional mandates that mean that a challenge must be performed) The following are applicable only for 3DS 2.2 protocol. 05 &#x3D; No challenge requested (transactional risk analysis is already performed) 06 &#x3D; No challenge requested (Data share only) 07 &#x3D; No challenge requested (strong consumer authentication is already performed) 08 &#x3D; No challenge requested (utilise whitelist exemption if no challenge required) 09 &#x3D; Challenge requested (whitelist prompt requested if challenge required)  (default to ChallengeIndicatorEnum._01).</param>
        /// <param name="challengeWindowSize">Defines the size of the challenge window displayed to customers during authentication. 01 &#x3D; 250 x 400 02 &#x3D; 390 x 400 03 &#x3D; 500 x 600 04 &#x3D; 600 x 400 05 &#x3D; Full screen .</param>
        /// <param name="browserJavaScriptEnabled">Indicates if the browser issuing the request is capable of performing JavaScript..</param>
        /// <param name="authenticationIndicator">Provides additional information to the ACS to determine the best approach for handling an authentication request. 01 &#x3D; Payment transaction 02 &#x3D; Recurring transaction 03 &#x3D; Installment transaction 04 &#x3D; Add card 05 &#x3D; Maintain card 06 &#x3D; Card holder verification as part of EMV token ID and Value  (default to AuthenticationIndicatorEnum._01).</param>
        /// <param name="secure3DDeviceChannel">02 &#x3D; BRW 03 &#x3D; 3RI .</param>
        /// <param name="secure3DThreeRIIndicator">01 &#x3D; Recurring transaction 02 &#x3D; Instalment transaction 03 &#x3D; Add card 04 &#x3D; Maintain card information 05 &#x3D; Account verification 06 &#x3D; Split/delayed shipment 07 &#x3D; Top-up 08 &#x3D; Mail Order 09 &#x3D; Telephone Order 10 &#x3D; Whitelist status check 11 &#x3D; Other payment .</param>
        /// <param name="recurringExpiry">Date after which no further authorisations shall be performed..</param>
        /// <param name="recurringFrequency">Indicates the minimum number of days between authorisations..</param>
        public Secure3D21AuthenticationRequestAllOf(string termURL = default(string), string methodNotificationURL = default(string), ChallengeIndicatorEnum? challengeIndicator = ChallengeIndicatorEnum._01, ChallengeWindowSizeEnum? challengeWindowSize = default(ChallengeWindowSizeEnum?), bool? browserJavaScriptEnabled = default(bool?), AuthenticationIndicatorEnum? authenticationIndicator = AuthenticationIndicatorEnum._01, Secure3DDeviceChannelEnum? secure3DDeviceChannel = default(Secure3DDeviceChannelEnum?), Secure3DThreeRIIndicatorEnum? secure3DThreeRIIndicator = default(Secure3DThreeRIIndicatorEnum?), string recurringExpiry = default(string), int? recurringFrequency = default(int?))
        {
            this.TermURL = termURL;
            this.MethodNotificationURL = methodNotificationURL;
            this.ChallengeIndicator = challengeIndicator;
            this.ChallengeWindowSize = challengeWindowSize;
            this.BrowserJavaScriptEnabled = browserJavaScriptEnabled;
            this.AuthenticationIndicator = authenticationIndicator;
            this.Secure3DDeviceChannel = secure3DDeviceChannel;
            this.Secure3DThreeRIIndicator = secure3DThreeRIIndicator;
            this.RecurringExpiry = recurringExpiry;
            this.RecurringFrequency = recurringFrequency;
        }

        /// <summary>
        /// The result of the authentication will be sent to this URL. If not provided, a term URL will be dynamically generated. Note this must be a valid URL (special characters should be URL-encoded).
        /// </summary>
        /// <value>The result of the authentication will be sent to this URL. If not provided, a term URL will be dynamically generated. Note this must be a valid URL (special characters should be URL-encoded).</value>
        [DataMember(Name = "termURL", EmitDefaultValue = false)]
        public string TermURL { get; set; }

        /// <summary>
        /// The 3DS method iframe and transaction ID will be sent here. Note this must be a valid URL (special characters should be URL-encoded).
        /// </summary>
        /// <value>The 3DS method iframe and transaction ID will be sent here. Note this must be a valid URL (special characters should be URL-encoded).</value>
        [DataMember(Name = "methodNotificationURL", EmitDefaultValue = false)]
        public string MethodNotificationURL { get; set; }

        /// <summary>
        /// Indicates if the browser issuing the request is capable of performing JavaScript.
        /// </summary>
        /// <value>Indicates if the browser issuing the request is capable of performing JavaScript.</value>
        [DataMember(Name = "browserJavaScriptEnabled", EmitDefaultValue = true)]
        public bool? BrowserJavaScriptEnabled { get; set; }

        /// <summary>
        /// Date after which no further authorisations shall be performed.
        /// </summary>
        /// <value>Date after which no further authorisations shall be performed.</value>
        [DataMember(Name = "recurringExpiry", EmitDefaultValue = true)]
        public string RecurringExpiry { get; set; }

        /// <summary>
        /// Indicates the minimum number of days between authorisations.
        /// </summary>
        /// <value>Indicates the minimum number of days between authorisations.</value>
        [DataMember(Name = "recurringFrequency", EmitDefaultValue = true)]
        public int? RecurringFrequency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Secure3D21AuthenticationRequestAllOf {\n");
            sb.Append("  TermURL: ").Append(TermURL).Append("\n");
            sb.Append("  MethodNotificationURL: ").Append(MethodNotificationURL).Append("\n");
            sb.Append("  ChallengeIndicator: ").Append(ChallengeIndicator).Append("\n");
            sb.Append("  ChallengeWindowSize: ").Append(ChallengeWindowSize).Append("\n");
            sb.Append("  BrowserJavaScriptEnabled: ").Append(BrowserJavaScriptEnabled).Append("\n");
            sb.Append("  AuthenticationIndicator: ").Append(AuthenticationIndicator).Append("\n");
            sb.Append("  Secure3DDeviceChannel: ").Append(Secure3DDeviceChannel).Append("\n");
            sb.Append("  Secure3DThreeRIIndicator: ").Append(Secure3DThreeRIIndicator).Append("\n");
            sb.Append("  RecurringExpiry: ").Append(RecurringExpiry).Append("\n");
            sb.Append("  RecurringFrequency: ").Append(RecurringFrequency).Append("\n");
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
            return this.Equals(input as Secure3D21AuthenticationRequestAllOf);
        }

        /// <summary>
        /// Returns true if Secure3D21AuthenticationRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of Secure3D21AuthenticationRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Secure3D21AuthenticationRequestAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TermURL == input.TermURL ||
                    (this.TermURL != null &&
                    this.TermURL.Equals(input.TermURL))
                ) && 
                (
                    this.MethodNotificationURL == input.MethodNotificationURL ||
                    (this.MethodNotificationURL != null &&
                    this.MethodNotificationURL.Equals(input.MethodNotificationURL))
                ) && 
                (
                    this.ChallengeIndicator == input.ChallengeIndicator ||
                    this.ChallengeIndicator.Equals(input.ChallengeIndicator)
                ) && 
                (
                    this.ChallengeWindowSize == input.ChallengeWindowSize ||
                    this.ChallengeWindowSize.Equals(input.ChallengeWindowSize)
                ) && 
                (
                    this.BrowserJavaScriptEnabled == input.BrowserJavaScriptEnabled ||
                    (this.BrowserJavaScriptEnabled != null &&
                    this.BrowserJavaScriptEnabled.Equals(input.BrowserJavaScriptEnabled))
                ) && 
                (
                    this.AuthenticationIndicator == input.AuthenticationIndicator ||
                    this.AuthenticationIndicator.Equals(input.AuthenticationIndicator)
                ) && 
                (
                    this.Secure3DDeviceChannel == input.Secure3DDeviceChannel ||
                    this.Secure3DDeviceChannel.Equals(input.Secure3DDeviceChannel)
                ) && 
                (
                    this.Secure3DThreeRIIndicator == input.Secure3DThreeRIIndicator ||
                    this.Secure3DThreeRIIndicator.Equals(input.Secure3DThreeRIIndicator)
                ) && 
                (
                    this.RecurringExpiry == input.RecurringExpiry ||
                    (this.RecurringExpiry != null &&
                    this.RecurringExpiry.Equals(input.RecurringExpiry))
                ) && 
                (
                    this.RecurringFrequency == input.RecurringFrequency ||
                    (this.RecurringFrequency != null &&
                    this.RecurringFrequency.Equals(input.RecurringFrequency))
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
                if (this.TermURL != null)
                    hashCode = hashCode * 59 + this.TermURL.GetHashCode();
                if (this.MethodNotificationURL != null)
                    hashCode = hashCode * 59 + this.MethodNotificationURL.GetHashCode();
                hashCode = hashCode * 59 + this.ChallengeIndicator.GetHashCode();
                hashCode = hashCode * 59 + this.ChallengeWindowSize.GetHashCode();
                if (this.BrowserJavaScriptEnabled != null)
                    hashCode = hashCode * 59 + this.BrowserJavaScriptEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.AuthenticationIndicator.GetHashCode();
                hashCode = hashCode * 59 + this.Secure3DDeviceChannel.GetHashCode();
                hashCode = hashCode * 59 + this.Secure3DThreeRIIndicator.GetHashCode();
                if (this.RecurringExpiry != null)
                    hashCode = hashCode * 59 + this.RecurringExpiry.GetHashCode();
                if (this.RecurringFrequency != null)
                    hashCode = hashCode * 59 + this.RecurringFrequency.GetHashCode();
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
            // RecurringExpiry (string) pattern
            Regex regexRecurringExpiry = new Regex(@"^([0-9]{4})(1[0-2]|0[1-9])(3[01]|0[1-9]|[12][0-9])$", RegexOptions.CultureInvariant);
            if (false == regexRecurringExpiry.Match(this.RecurringExpiry).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecurringExpiry, must match a pattern of " + regexRecurringExpiry, new [] { "RecurringExpiry" });
            }

            // RecurringFrequency (int?) maximum
            if(this.RecurringFrequency > (int?)9999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecurringFrequency, must be a value less than or equal to 9999.", new [] { "RecurringFrequency" });
            }

            // RecurringFrequency (int?) minimum
            if(this.RecurringFrequency < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecurringFrequency, must be a value greater than or equal to 1.", new [] { "RecurringFrequency" });
            }

            yield break;
        }
    }
}
