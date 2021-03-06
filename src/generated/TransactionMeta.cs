          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Stellar.Generated
{


// === xdr source ============================================================

//  union TransactionMeta switch (int v)
//  {
//  case 0:
//      OperationMeta operations<>;
//  };

//  ===========================================================================
public class TransactionMeta {
  public TransactionMeta () {}
  public int Discriminant { get; set; } = new int();
  public OperationMeta[] Operations { get; set; } = default(OperationMeta[]);
  public static void Encode(IByteWriter stream, TransactionMeta encodedTransactionMeta) {
  XdrEncoding.EncodeInt32(encodedTransactionMeta.Discriminant, stream);
  switch (encodedTransactionMeta.Discriminant) {
  case 0:
  int operationssize = encodedTransactionMeta.Operations.Length;
  XdrEncoding.EncodeInt32(operationssize, stream);
  for (int i = 0; i < operationssize; i++) {
    OperationMeta.Encode(stream, encodedTransactionMeta.Operations[i]);
  }
  break;
  }
  }
  public static TransactionMeta Decode(IByteReader stream) {
    TransactionMeta decodedTransactionMeta = new TransactionMeta();
  decodedTransactionMeta.Discriminant = XdrEncoding.DecodeInt32(stream);
  switch (decodedTransactionMeta.Discriminant) {
  case 0:
  int operationssize = XdrEncoding.DecodeInt32(stream);
  decodedTransactionMeta.Operations = new OperationMeta[operationssize];
  for (int i = 0; i < operationssize; i++) {
    decodedTransactionMeta.Operations[i] = OperationMeta.Decode(stream);
  }
  break;
  }
    return decodedTransactionMeta;
  }
}
}
