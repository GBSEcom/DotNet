using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Additional data specific to the car rental industry
  /// </summary>
  [DataContract]
  public class CarRental {
    /// <summary>
    /// The car rental agreement number
    /// </summary>
    /// <value>The car rental agreement number</value>
    [DataMember(Name="agreementNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agreementNumber")]
    public string AgreementNumber { get; set; }

    /// <summary>
    /// The name of the person renting the car
    /// </summary>
    /// <value>The name of the person renting the car</value>
    [DataMember(Name="renterName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renterName")]
    public string RenterName { get; set; }

    /// <summary>
    /// The name of the city where the rental ends and the car is returned
    /// </summary>
    /// <value>The name of the city where the rental ends and the car is returned</value>
    [DataMember(Name="returnCity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "returnCity")]
    public string ReturnCity { get; set; }

    /// <summary>
    /// The date the car rental ends and the car is returned
    /// </summary>
    /// <value>The date the car rental ends and the car is returned</value>
    [DataMember(Name="returnDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "returnDate")]
    public DateTime? ReturnDate { get; set; }

    /// <summary>
    /// The date the car rental begins
    /// </summary>
    /// <value>The date the car rental begins</value>
    [DataMember(Name="pickupDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickupDate")]
    public DateTime? PickupDate { get; set; }

    /// <summary>
    /// The classification of the rental car
    /// </summary>
    /// <value>The classification of the rental car</value>
    [DataMember(Name="rentalClassId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rentalClassId")]
    public string RentalClassId { get; set; }

    /// <summary>
    /// Array containing information about charges other than the rental rate.
    /// </summary>
    /// <value>Array containing information about charges other than the rental rate.</value>
    [DataMember(Name="extraCharges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extraCharges")]
    public List<CarRentalExtraCharges> ExtraCharges { get; set; }

    /// <summary>
    /// Indicates if the transaction is related to a no-show charge.
    /// </summary>
    /// <value>Indicates if the transaction is related to a no-show charge.</value>
    [DataMember(Name="noShowIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "noShowIndicator")]
    public bool? NoShowIndicator { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CarRental {\n");
      sb.Append("  AgreementNumber: ").Append(AgreementNumber).Append("\n");
      sb.Append("  RenterName: ").Append(RenterName).Append("\n");
      sb.Append("  ReturnCity: ").Append(ReturnCity).Append("\n");
      sb.Append("  ReturnDate: ").Append(ReturnDate).Append("\n");
      sb.Append("  PickupDate: ").Append(PickupDate).Append("\n");
      sb.Append("  RentalClassId: ").Append(RentalClassId).Append("\n");
      sb.Append("  ExtraCharges: ").Append(ExtraCharges).Append("\n");
      sb.Append("  NoShowIndicator: ").Append(NoShowIndicator).Append("\n");
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
