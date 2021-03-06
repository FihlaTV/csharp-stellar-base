          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Stellar.Generated
{


// === xdr source ============================================================

//  struct CreateAccountOp
//  {
//      AccountID destination; // account to create
//      int64 startingBalance; // amount they end up with
//  };

//  ===========================================================================
public class CreateAccountOp {
  public CreateAccountOp () {}
  public AccountID Destination { get; set; }
  public Int64 StartingBalance { get; set; }
  public static void Encode(IByteWriter stream, CreateAccountOp encodedCreateAccountOp) {
    AccountID.Encode(stream, encodedCreateAccountOp.Destination);
    Int64.Encode(stream, encodedCreateAccountOp.StartingBalance);
  }
  public static CreateAccountOp Decode(IByteReader stream) {
    CreateAccountOp decodedCreateAccountOp = new CreateAccountOp();
    decodedCreateAccountOp.Destination = AccountID.Decode(stream);
    decodedCreateAccountOp.StartingBalance = Int64.Decode(stream);
    return decodedCreateAccountOp;
  }
}
}
