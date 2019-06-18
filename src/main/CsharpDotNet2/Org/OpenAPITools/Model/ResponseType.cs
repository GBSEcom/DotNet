using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Org.OpenAPITools.Model {

    [JsonConverter(typeof(StringEnumConverter))]

    public enum ResponseType
    {

        ///   <summary>
        /// Enum Default for "Default"
        /// </summary>
        [EnumMember(Value = "Default")]
        Default,

        /// <summary>
        /// Enum BadRequest for "BadRequest"
        /// </summary>
        [EnumMember(Value = "BadRequest")]
        BadRequest,

        /// <summary>
        /// Enum Unauthenticated for "Unauthenticated"
        /// </summary>
        [EnumMember(Value = "Unauthenticated")]
        Unauthenticated,

        /// <summary>
        /// Enum Unauthorized for "Unauthorized"
        /// </summary>
        [EnumMember(Value = "Unauthorized")]
        Unauthorized,

        /// <summary>
        /// Enum NotFound for "NotFound"
        /// </summary>
        [EnumMember(Value = "NotFound")]
        NotFound,

        /// <summary>
        /// Enum GatewayDeclined for "GatewayDeclined"
        /// </summary>
        [EnumMember(Value = "GatewayDeclined")]
        GatewayDeclined,

        /// <summary>
        /// Enum EndpointDeclined for "EndpointDeclined"
        /// </summary>
        [EnumMember(Value = "EndpointDeclined")]
        EndpointDeclined,

        /// <summary>
        /// Enum ServerError for "ServerError"
        /// </summary>
        [EnumMember(Value = "ServerError")]
        ServerError,

        /// <summary>
        /// Enum EndpointCommunicationError for "EndpointCommunicationError"
        /// </summary>
        [EnumMember(Value = "EndpointCommunicationError")]
        EndpointCommunicationError,

        /// <summary>
        /// Enum UnsupportedMediaType for "UnsupportedMediaType"
        /// </summary>
        [EnumMember(Value = "UnsupportedMediaType")]
        UnsupportedMediaType
    }
}
