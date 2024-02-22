using boxpoker.network.Core;

namespace boxpoker.pix.Requests
{
    public class DeleteQrCodeRequest : Request
    {
        private readonly int _transactionId;

        public DeleteQrCodeRequest(int transactionId)
        {
            _transactionId = transactionId;
        }

        public override string Path => $"/pix/v1/brcode/dynamic/{_transactionId}";

        public override RequestMethod Method => RequestMethod.Delete;
    }
}