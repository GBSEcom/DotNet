using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Additional data specific to the airline industry
  /// </summary>
  [DataContract]
  public class Airline {
    /// <summary>
    /// Gets or Sets PassengerName
    /// </summary>
    [DataMember(Name="passengerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passengerName")]
    public string PassengerName { get; set; }

    /// <summary>
    /// Gets or Sets TicketNumber
    /// </summary>
    [DataMember(Name="ticketNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticketNumber")]
    public string TicketNumber { get; set; }

    /// <summary>
    /// Gets or Sets IssuingCarrier
    /// </summary>
    [DataMember(Name="issuingCarrier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuingCarrier")]
    public string IssuingCarrier { get; set; }

    /// <summary>
    /// Gets or Sets CarrierName
    /// </summary>
    [DataMember(Name="carrierName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrierName")]
    public string CarrierName { get; set; }

    /// <summary>
    /// Gets or Sets TravelAgencyIataCode
    /// </summary>
    [DataMember(Name="travelAgencyIataCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "travelAgencyIataCode")]
    public string TravelAgencyIataCode { get; set; }

    /// <summary>
    /// Gets or Sets TravelAgencyName
    /// </summary>
    [DataMember(Name="travelAgencyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "travelAgencyName")]
    public string TravelAgencyName { get; set; }

    /// <summary>
    /// Gets or Sets AirlinePlanNumber
    /// </summary>
    [DataMember(Name="airlinePlanNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airlinePlanNumber")]
    public string AirlinePlanNumber { get; set; }

    /// <summary>
    /// Gets or Sets AirlineInvoiceNumber
    /// </summary>
    [DataMember(Name="airlineInvoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airlineInvoiceNumber")]
    public string AirlineInvoiceNumber { get; set; }

    /// <summary>
    /// Gets or Sets ReservationSystem
    /// </summary>
    [DataMember(Name="reservationSystem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reservationSystem")]
    public string ReservationSystem { get; set; }

    /// <summary>
    /// Gets or Sets Restricted
    /// </summary>
    [DataMember(Name="restricted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restricted")]
    public bool? Restricted { get; set; }

    /// <summary>
    /// Gets or Sets TravelRoute
    /// </summary>
    [DataMember(Name="travelRoute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "travelRoute")]
    public List<AirlineTravelRoute> TravelRoute { get; set; }

    /// <summary>
    /// Gets or Sets RelatedTicketNumber
    /// </summary>
    [DataMember(Name="relatedTicketNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "relatedTicketNumber")]
    public string RelatedTicketNumber { get; set; }

    /// <summary>
    /// Identify the purchase of ancillary goods or services with a false value. If this element is not provided, the transaction is assumed to be a purchase of an airline ticket.
    /// </summary>
    /// <value>Identify the purchase of ancillary goods or services with a false value. If this element is not provided, the transaction is assumed to be a purchase of an airline ticket.</value>
    [DataMember(Name="ancillaryServiceCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ancillaryServiceCategory")]
    public List<AirlineAncillaryServiceCategory> AncillaryServiceCategory { get; set; }

    /// <summary>
    /// Gets or Sets TicketPurchase
    /// </summary>
    [DataMember(Name="ticketPurchase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticketPurchase")]
    public bool? TicketPurchase { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Airline {\n");
      sb.Append("  PassengerName: ").Append(PassengerName).Append("\n");
      sb.Append("  TicketNumber: ").Append(TicketNumber).Append("\n");
      sb.Append("  IssuingCarrier: ").Append(IssuingCarrier).Append("\n");
      sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
      sb.Append("  TravelAgencyIataCode: ").Append(TravelAgencyIataCode).Append("\n");
      sb.Append("  TravelAgencyName: ").Append(TravelAgencyName).Append("\n");
      sb.Append("  AirlinePlanNumber: ").Append(AirlinePlanNumber).Append("\n");
      sb.Append("  AirlineInvoiceNumber: ").Append(AirlineInvoiceNumber).Append("\n");
      sb.Append("  ReservationSystem: ").Append(ReservationSystem).Append("\n");
      sb.Append("  Restricted: ").Append(Restricted).Append("\n");
      sb.Append("  TravelRoute: ").Append(TravelRoute).Append("\n");
      sb.Append("  RelatedTicketNumber: ").Append(RelatedTicketNumber).Append("\n");
      sb.Append("  AncillaryServiceCategory: ").Append(AncillaryServiceCategory).Append("\n");
      sb.Append("  TicketPurchase: ").Append(TicketPurchase).Append("\n");
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
