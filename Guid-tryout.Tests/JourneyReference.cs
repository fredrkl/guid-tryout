namespace Guid_tryout.Tests;
public record JourneyReference{
  public Guid ExternalValidationGuid { get; }
  public long? ValidationSequenceNumber { get; }

  public JourneyReference(Guid ExternalValidationGuid, long? ValidationSequenceNumber){
    // Validation logic
    this.ExternalValidationGuid = ExternalValidationGuid;
    this.ValidationSequenceNumber = ValidationSequenceNumber;
  }
}
