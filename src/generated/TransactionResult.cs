          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Stellar.Generated
{


// === xdr source ============================================================

//  struct TransactionResult
//  {
//      int64 feeCharged; // actual fee charged for the transaction
//  
//      union switch (TransactionResultCode code)
//      {
//      case txSUCCESS:
//      case txFAILED:
//          OperationResult results<>;
//      default:
//          void;
//      }
//      result;
//  
//      // reserved for future use
//      union switch (int v)
//      {
//      case 0:
//          void;
//      }
//      ext;
//  };

//  ===========================================================================
public class TransactionResult {
  public TransactionResult () {}
  public Int64 FeeCharged { get; set; }
  public TransactionResultResult Result { get; set; }
  public TransactionResultExt Ext { get; set; }
  public static void Encode(IByteWriter stream, TransactionResult encodedTransactionResult) {
    Int64.Encode(stream, encodedTransactionResult.FeeCharged);
    TransactionResultResult.Encode(stream, encodedTransactionResult.Result);
    TransactionResultExt.Encode(stream, encodedTransactionResult.Ext);
  }
  public static TransactionResult Decode(IByteReader stream) {
    TransactionResult decodedTransactionResult = new TransactionResult();
    decodedTransactionResult.FeeCharged = Int64.Decode(stream);
    decodedTransactionResult.Result = TransactionResultResult.Decode(stream);
    decodedTransactionResult.Ext = TransactionResultExt.Decode(stream);
    return decodedTransactionResult;
  }

  public class TransactionResultResult {
    public TransactionResultResult () {}
    public TransactionResultCode Discriminant { get; set; } = new TransactionResultCode();
    public OperationResult[] Results { get; set; } = default(OperationResult[]);
    public static void Encode(IByteWriter stream, TransactionResultResult encodedTransactionResultResult) {
    XdrEncoding.EncodeInt32((int)encodedTransactionResultResult.Discriminant.InnerValue, stream);
    switch (encodedTransactionResultResult.Discriminant.InnerValue) {
    case TransactionResultCode.TransactionResultCodeEnum.txSUCCESS:
    case TransactionResultCode.TransactionResultCodeEnum.txFAILED:
    int resultssize = encodedTransactionResultResult.Results.Length;
    XdrEncoding.EncodeInt32(resultssize, stream);
    for (int i = 0; i < resultssize; i++) {
      OperationResult.Encode(stream, encodedTransactionResultResult.Results[i]);
    }
    break;
    default:
    break;
    }
    }
    public static TransactionResultResult Decode(IByteReader stream) {
      TransactionResultResult decodedTransactionResultResult = new TransactionResultResult();
    decodedTransactionResultResult.Discriminant = TransactionResultCode.Decode(stream);
    switch (decodedTransactionResultResult.Discriminant.InnerValue) {
    case TransactionResultCode.TransactionResultCodeEnum.txSUCCESS:
    case TransactionResultCode.TransactionResultCodeEnum.txFAILED:
    int resultssize = XdrEncoding.DecodeInt32(stream);
    decodedTransactionResultResult.Results = new OperationResult[resultssize];
    for (int i = 0; i < resultssize; i++) {
      decodedTransactionResultResult.Results[i] = OperationResult.Decode(stream);
    }
    break;
    default:
    break;
    }
      return decodedTransactionResultResult;
    }

  }
  public class TransactionResultExt {
    public TransactionResultExt () {}
    public int Discriminant { get; set; } = new int();
    public static void Encode(IByteWriter stream, TransactionResultExt encodedTransactionResultExt) {
    XdrEncoding.EncodeInt32(encodedTransactionResultExt.Discriminant, stream);
    switch (encodedTransactionResultExt.Discriminant) {
    case 0:
    break;
    }
    }
    public static TransactionResultExt Decode(IByteReader stream) {
      TransactionResultExt decodedTransactionResultExt = new TransactionResultExt();
    decodedTransactionResultExt.Discriminant = XdrEncoding.DecodeInt32(stream);
    switch (decodedTransactionResultExt.Discriminant) {
    case 0:
    break;
    }
      return decodedTransactionResultExt;
    }

  }
}
}
