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

public record Person
{
  public string Firstname {get;}
  public string Lastname {get;}
  public Person(string Firstname, string Lastname)
  {
    if(Firstname.Length < 5){
      throw new ArgumentException("To short firstname", nameof(Firstname));
    }

    this.Firstname = Firstname;
    this.Lastname = Lastname;
  }
}
