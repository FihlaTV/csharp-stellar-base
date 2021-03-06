          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Stellar.Generated
{


// === xdr source ============================================================

//  struct SCPNomination
//  {
//      Hash quorumSetHash; // D
//      Value votes<>;      // X
//      Value accepted<>;   // Y
//  };

//  ===========================================================================
public class SCPNomination {
  public SCPNomination () {}
  public Hash QuorumSetHash { get; set; }
  public Value[] Votes { get; set; }
  public Value[] Accepted { get; set; }
  public static void Encode(IByteWriter stream, SCPNomination encodedSCPNomination) {
    Hash.Encode(stream, encodedSCPNomination.QuorumSetHash);
    int votessize = encodedSCPNomination.Votes.Length;
    XdrEncoding.EncodeInt32(votessize, stream);
    for (int i = 0; i < votessize; i++) {
      Value.Encode(stream, encodedSCPNomination.Votes[i]);
    }
    int acceptedsize = encodedSCPNomination.Accepted.Length;
    XdrEncoding.EncodeInt32(acceptedsize, stream);
    for (int i = 0; i < acceptedsize; i++) {
      Value.Encode(stream, encodedSCPNomination.Accepted[i]);
    }
  }
  public static SCPNomination Decode(IByteReader stream) {
    SCPNomination decodedSCPNomination = new SCPNomination();
    decodedSCPNomination.QuorumSetHash = Hash.Decode(stream);
    int votessize = XdrEncoding.DecodeInt32(stream);
    decodedSCPNomination.Votes = new Value[votessize];
    for (int i = 0; i < votessize; i++) {
      decodedSCPNomination.Votes[i] = Value.Decode(stream);
    }
    int acceptedsize = XdrEncoding.DecodeInt32(stream);
    decodedSCPNomination.Accepted = new Value[acceptedsize];
    for (int i = 0; i < acceptedsize; i++) {
      decodedSCPNomination.Accepted[i] = Value.Decode(stream);
    }
    return decodedSCPNomination;
  }
}
}
