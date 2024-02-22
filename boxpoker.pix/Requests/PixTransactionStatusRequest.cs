using boxpoker.network.Core;

namespace boxpoker.pix.Requests
{
    public class PixTransactionStatusRequest : Request
    {

        public required string TransactionId;
       
        public override string Path => $"/payment/pi/status?transactionId={TransactionId}";

        public override RequestMethod Method => RequestMethod.Get;
    }
}