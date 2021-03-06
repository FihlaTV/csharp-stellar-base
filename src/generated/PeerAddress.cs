          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Stellar.Generated
{


// === xdr source ============================================================

//  struct PeerAddress
//  {
//      union switch (IPAddrType type)
//      {
//      case IPv4:
//          opaque ipv4[4];
//      case IPv6:
//          opaque ipv6[16];
//      }
//      ip;
//      uint32 port;
//      uint32 numFailures;
//  };

//  ===========================================================================
public class PeerAddress {
  public PeerAddress () {}
  public PeerAddressIp Ip { get; set; }
  public Uint32 Port { get; set; }
  public Uint32 NumFailures { get; set; }
  public static void Encode(IByteWriter stream, PeerAddress encodedPeerAddress) {
    PeerAddressIp.Encode(stream, encodedPeerAddress.Ip);
    Uint32.Encode(stream, encodedPeerAddress.Port);
    Uint32.Encode(stream, encodedPeerAddress.NumFailures);
  }
  public static PeerAddress Decode(IByteReader stream) {
    PeerAddress decodedPeerAddress = new PeerAddress();
    decodedPeerAddress.Ip = PeerAddressIp.Decode(stream);
    decodedPeerAddress.Port = Uint32.Decode(stream);
    decodedPeerAddress.NumFailures = Uint32.Decode(stream);
    return decodedPeerAddress;
  }

  public class PeerAddressIp {
    public PeerAddressIp () {}
    public IPAddrType Discriminant { get; set; } = new IPAddrType();
    public byte[] Ipv4 { get; set; } = default(byte[]);
    public byte[] Ipv6 { get; set; } = default(byte[]);
    public static void Encode(IByteWriter stream, PeerAddressIp encodedPeerAddressIp) {
    XdrEncoding.EncodeInt32((int)encodedPeerAddressIp.Discriminant.InnerValue, stream);
    switch (encodedPeerAddressIp.Discriminant.InnerValue) {
    case IPAddrType.IPAddrTypeEnum.IPv4:
    int ipv4size = encodedPeerAddressIp.Ipv4.Length;
    XdrEncoding.WriteFixOpaque(stream, (uint)ipv4size, encodedPeerAddressIp.Ipv4);
    break;
    case IPAddrType.IPAddrTypeEnum.IPv6:
    int ipv6size = encodedPeerAddressIp.Ipv6.Length;
    XdrEncoding.WriteFixOpaque(stream, (uint)ipv6size, encodedPeerAddressIp.Ipv6);
    break;
    }
    }
    public static PeerAddressIp Decode(IByteReader stream) {
      PeerAddressIp decodedPeerAddressIp = new PeerAddressIp();
    decodedPeerAddressIp.Discriminant = IPAddrType.Decode(stream);
    switch (decodedPeerAddressIp.Discriminant.InnerValue) {
    case IPAddrType.IPAddrTypeEnum.IPv4:
    int ipv4size = 4;
    decodedPeerAddressIp.Ipv4 = XdrEncoding.ReadFixOpaque(stream, (uint)ipv4size);
    break;
    case IPAddrType.IPAddrTypeEnum.IPv6:
    int ipv6size = 16;
    decodedPeerAddressIp.Ipv6 = XdrEncoding.ReadFixOpaque(stream, (uint)ipv6size);
    break;
    }
      return decodedPeerAddressIp;
    }

  }
}
}
