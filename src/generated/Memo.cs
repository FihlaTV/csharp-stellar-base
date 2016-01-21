          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Stellar.Generated
{


// === xdr source ============================================================

//  union Memo switch (MemoType type)
//  {
//  case MEMO_NONE:
//      void;
//  case MEMO_TEXT:
//      string text<28>;
//  case MEMO_ID:
//      uint64 id;
//  case MEMO_HASH:
//      Hash hash; // the hash of what to pull from the content server
//  case MEMO_RETURN:
//      Hash retHash; // the hash of the tx you are rejecting
//  };

//  ===========================================================================
public class Memo {
  public Memo () {}
  public MemoType Discriminant { get; set; } = new MemoType();
  public string Text { get; set; } = default(string);
  public Uint64 Id { get; set; } = default(Uint64);
  public Hash Hash { get; set; } = default(Hash);
  public Hash RetHash { get; set; } = default(Hash);
  public static void Encode(IByteWriter stream, Memo encodedMemo) {
  XdrEncoding.EncodeInt32((int)encodedMemo.Discriminant.InnerValue, stream);
  switch (encodedMemo.Discriminant.InnerValue) {
  case MemoType.MemoTypeEnum.MEMO_NONE:
  break;
  case MemoType.MemoTypeEnum.MEMO_TEXT:
  XdrEncoding.WriteString(stream, encodedMemo.Text);
  break;
  case MemoType.MemoTypeEnum.MEMO_ID:
  Uint64.Encode(stream, encodedMemo.Id);
  break;
  case MemoType.MemoTypeEnum.MEMO_HASH:
  Hash.Encode(stream, encodedMemo.Hash);
  break;
  case MemoType.MemoTypeEnum.MEMO_RETURN:
  Hash.Encode(stream, encodedMemo.RetHash);
  break;
  }
  }
  public static Memo Decode(IByteReader stream) {
    Memo decodedMemo = new Memo();
  decodedMemo.Discriminant = MemoType.Decode(stream);
  switch (decodedMemo.Discriminant.InnerValue) {
  case MemoType.MemoTypeEnum.MEMO_NONE:
  break;
  case MemoType.MemoTypeEnum.MEMO_TEXT:
  decodedMemo.Text = XdrEncoding.ReadString(stream);
  break;
  case MemoType.MemoTypeEnum.MEMO_ID:
  decodedMemo.Id = Uint64.Decode(stream);
  break;
  case MemoType.MemoTypeEnum.MEMO_HASH:
  decodedMemo.Hash = Hash.Decode(stream);
  break;
  case MemoType.MemoTypeEnum.MEMO_RETURN:
  decodedMemo.RetHash = Hash.Decode(stream);
  break;
  }
    return decodedMemo;
  }
}
}
