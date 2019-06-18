using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Customer model for customers registered at merchant&#39;s website.
  /// </summary>
  [DataContract]
  public class Customer {
    /// <summary>
    /// Unique ID for the customer, if registered. This field is required if the parent object is present.
    /// </summary>
    /// <value>Unique ID for the customer, if registered. This field is required if the parent object is present.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The timestamp of the customers registration in the merchants platform. Format is YYYY-MM-DD.
    /// </summary>
    /// <value>The timestamp of the customers registration in the merchants platform. Format is YYYY-MM-DD.</value>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public string StartDate { get; set; }

    /// <summary>
    /// Customer's first name.
    /// </summary>
    /// <value>Customer's first name.</value>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Customer's last name.
    /// </summary>
    /// <value>Customer's last name.</value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Customer's middle name.
    /// </summary>
    /// <value>Customer's middle name.</value>
    [DataMember(Name="middleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "middleName")]
    public string MiddleName { get; set; }

    /// <summary>
    /// Customer's email address.
    /// </summary>
    /// <value>Customer's email address.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// The unique ID of the current login session. Must be unique for the customer.
    /// </summary>
    /// <value>The unique ID of the current login session. Must be unique for the customer.</value>
    [DataMember(Name="sessionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sessionId")]
    public string SessionId { get; set; }

    /// <summary>
    /// The username of this customer in the merchants system. This field should contain customer-supplied data if available instead of a generated ID. This field can contain the clients email address if it is also used for authentication purposes.
    /// </summary>
    /// <value>The username of this customer in the merchants system. This field should contain customer-supplied data if available instead of a generated ID. This field can contain the clients email address if it is also used for authentication purposes.</value>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }

    /// <summary>
    /// The customers gender. Do not set this property if the customer does not specify a gender.
    /// </summary>
    /// <value>The customers gender. Do not set this property if the customer does not specify a gender.</value>
    [DataMember(Name="gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gender")]
    public string Gender { get; set; }

    /// <summary>
    /// The customer's year of birth. Format is YYYY.
    /// </summary>
    /// <value>The customer's year of birth. Format is YYYY.</value>
    [DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateOfBirth")]
    public string DateOfBirth { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public CustomerAddress Address { get; set; }

    /// <summary>
    /// A JSON object that can carry any additional information about the customer that might be helpful for fraud detection.
    /// </summary>
    /// <value>A JSON object that can carry any additional information about the customer that might be helpful for fraud detection.</value>
    [DataMember(Name="userDefined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userDefined")]
    public Object UserDefined { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Customer {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  SessionId: ").Append(SessionId).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  UserDefined: ").Append(UserDefined).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
