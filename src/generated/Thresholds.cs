          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Stellar.Generated
{


// === xdr source ============================================================

//  typedef opaque Thresholds[4];

//  ===========================================================================
public class Thresholds {
  public byte[] InnerValue { get; set; } = default(byte[]);
        
  public Thresholds() { }
  public Thresholds(byte[] Thresholds)
  {
    InnerValue = Thresholds;
  }
  public static void Encode(IByteWriter stream, Thresholds  encodedThresholds) {
  int ThresholdsSize = encodedThresholds.InnerValue.Length;
  XdrEncoding.WriteFixOpaque(stream, (uint)ThresholdsSize, encodedThresholds.InnerValue);
  }
  public static Thresholds Decode(IByteReader stream) {
    Thresholds decodedThresholds = new Thresholds();
  int Thresholdssize = 4;
  decodedThresholds.InnerValue = XdrEncoding.ReadFixOpaque(stream, (uint)Thresholdssize);
    return decodedThresholds;
  }
}
}
