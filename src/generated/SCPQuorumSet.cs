          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Stellar.Generated
{


// === xdr source ============================================================

//  struct SCPQuorumSet
//  {
//      uint32 threshold;
//      PublicKey validators<>;
//      SCPQuorumSet innerSets<>;
//  };

//  ===========================================================================
public class SCPQuorumSet {
  public SCPQuorumSet () {}
  public Uint32 Threshold { get; set; }
  public PublicKey[] Validators { get; set; }
  public SCPQuorumSet[] InnerSets { get; set; }
  public static void Encode(IByteWriter stream, SCPQuorumSet encodedSCPQuorumSet) {
    Uint32.Encode(stream, encodedSCPQuorumSet.Threshold);
    int validatorssize = encodedSCPQuorumSet.Validators.Length;
    XdrEncoding.EncodeInt32(validatorssize, stream);
    for (int i = 0; i < validatorssize; i++) {
      PublicKey.Encode(stream, encodedSCPQuorumSet.Validators[i]);
    }
    int innerSetssize = encodedSCPQuorumSet.InnerSets.Length;
    XdrEncoding.EncodeInt32(innerSetssize, stream);
    for (int i = 0; i < innerSetssize; i++) {
      SCPQuorumSet.Encode(stream, encodedSCPQuorumSet.InnerSets[i]);
    }
  }
  public static SCPQuorumSet Decode(IByteReader stream) {
    SCPQuorumSet decodedSCPQuorumSet = new SCPQuorumSet();
    decodedSCPQuorumSet.Threshold = Uint32.Decode(stream);
    int validatorssize = XdrEncoding.DecodeInt32(stream);
    decodedSCPQuorumSet.Validators = new PublicKey[validatorssize];
    for (int i = 0; i < validatorssize; i++) {
      decodedSCPQuorumSet.Validators[i] = PublicKey.Decode(stream);
    }
    int innerSetssize = XdrEncoding.DecodeInt32(stream);
    decodedSCPQuorumSet.InnerSets = new SCPQuorumSet[innerSetssize];
    for (int i = 0; i < innerSetssize; i++) {
      decodedSCPQuorumSet.InnerSets[i] = SCPQuorumSet.Decode(stream);
    }
    return decodedSCPQuorumSet;
  }
}
}
